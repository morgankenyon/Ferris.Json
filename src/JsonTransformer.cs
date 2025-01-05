using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Ferris.Json
{
    /// <summary>
    /// A json serialization/deserialization library.
    /// </summary>
    public static class JsonTransformer
    {
        /// <summary>
        /// Serialize a C# object into a json string
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize(object obj)
        {
            var properties = obj.GetType().GetProperties();

            var combinedProperties = MapProperties(properties, obj);

            return combinedProperties;
        }

        internal static string MapProperties(PropertyInfo[] propertyInfos, object obj)
        {
            var jsonProperties = new List<string>(propertyInfos.Length);
            foreach (var propertyInfo in propertyInfos)
            {
                var propertyValue = propertyInfo.GetValue(obj);
                var propertyType = propertyInfo.PropertyType;
                //var childPropertyInfos = propertyType.GetProperties();
                if (propertyValue == null)
                {
                    jsonProperties.Add($"\"{propertyInfo.Name}\":null");
                }
                else if (propertyType == typeof(System.String)
                    || propertyType == typeof(System.Char))
                {
                    jsonProperties.Add($"\"{propertyInfo.Name}\":\"{propertyValue}\"");
                }
                else if (typeof(System.Collections.IEnumerable).IsAssignableFrom(propertyType))
                {
                    var generatedListJson = new List<string>();
                    var listValue = propertyInfo.GetValue(obj);

                    if (listValue is System.Collections.IEnumerable enumerable)
                    {
                        foreach (var item in enumerable)
                        {
                            var listItemProperties = item.GetType().GetProperties();
                            var listItemJson = MapProperties(listItemProperties, item);
                            generatedListJson.Add(listItemJson);
                        }
                    }
                    var joinedChildren = string.Join(",", generatedListJson);
                    jsonProperties.Add($"\"{propertyInfo.Name}\":[{joinedChildren}]");
                }
                else if (propertyType.BaseType == typeof(object)
                    && propertyType.GetProperties().Length > 0)
                {
                    //calls GetProperties() twice, potential performance regression
                    var childPropertyInfos = propertyType.GetProperties();
                    var childJson = MapProperties(childPropertyInfos, propertyValue);
                    jsonProperties.Add($"\"{propertyInfo.Name}\":{childJson}");
                }
                else if (propertyType == typeof(System.Int16)
                    || propertyType == typeof(System.UInt16)
                    || propertyType == typeof(System.Int32)
                    || propertyType == typeof(System.UInt32)
                    || propertyType == typeof(System.Int64)
                    || propertyType == typeof(System.UInt64)
                    || propertyType == typeof(System.Int128)
                    || propertyType == typeof(System.UInt128)
                    || propertyType == typeof(System.Single)
                    || propertyType == typeof(System.Double)
                    || propertyType == typeof(System.Byte)
                    || propertyType == typeof(System.SByte)
                    || propertyType == typeof(System.Decimal)
                    || propertyType == typeof(System.IntPtr)
                    || propertyType == typeof(System.UIntPtr)
                    )
                {
                    jsonProperties.Add($"\"{propertyInfo.Name}\":{propertyValue}");
                }
                else if (propertyType == typeof(System.Boolean))
                {
                    jsonProperties.Add($"\"{propertyInfo.Name}\":{propertyValue!.ToString()!.ToLower()}");
                }
                else if (propertyType == typeof(System.DateTime))
                {
                    var dateTime = (DateTime)propertyValue;
                    var dateString = dateTime.ToString("s", System.Globalization.CultureInfo.InvariantCulture);
                    jsonProperties.Add($"\"{propertyInfo.Name}\":\"{dateString}\"");
                }
                else
                {
                    jsonProperties.Add($"\"{propertyInfo.Name}\":\"{propertyValue}\"");
                }
            }

            var combinedProperties = $"{{{string.Join(",", jsonProperties)}}}";

            return combinedProperties;
        }

        /// <summary>
        /// Deserialize the json string into a C# object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string json)
        {
            Type type = typeof(T);

            var spanData = Deserialize(type, json);

            var result = spanData.Value;

            //might have to found a better way to do this
            var convertedValue = Convert.ChangeType(result, type);
            return (T)convertedValue;
        }

        private static bool IsLineEndingToken(Token token) =>
            token.IsComma() || token.IsCloseBrace();

        private static bool IsGenericCollection(Type type)
        {
            return type.GetInterfaces()
                .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICollection<>));
        }

        private static bool IsGenericIEnumerable(Type type)
        {
            return type.GetInterfaces()
                .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEnumerable<>));
        }

        private static SpanData Deserialize(Type type, ReadOnlySpan<char> jsonSpan)
        {
            var propertyStack = new Stack<(Token token, object? data)>();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var propertiesDict = properties.ToDictionary(p => p.Name, p => p);
            var instance = Activator.CreateInstance(type);

            if (instance == null)
            {
                //need some general error case here
                return new SpanData(jsonSpan, null);
            }
            var previousToken = Token.None;
            while (true)
            {
                var (token, tokenLength, data) = GetNextTokenAndData(previousToken, jsonSpan);

                if (token.IsEndOfInput())
                {
                    break;
                }

                if (IsLineEndingToken(token) && previousToken.IsPropertyValue())
                {
                    var (_, propertyData) = propertyStack.Pop();
                    var (colonToken, _) = propertyStack.Pop();
                    var (propertyNameToken, propertyName) = propertyStack.Pop();

                    if (colonToken == Token.Colon
                        && propertyNameToken == Token.PropertyName
                        && propertyData != null
                        && propertyName != null
                        && propertiesDict.TryGetValue((string)propertyName, out var propertyInfo))
                    {
                        Libs.MapValue(propertyInfo, instance, propertyData);
                    }
                }

                if (token.IsOpenBrace() && previousToken.IsColon())
                {
                    //since stack is IEnumerable, maybe iterate versus popping and readding?
                    var (colonToken, colonData) = propertyStack.Pop();
                    var (propertyNameToken, propertyName) = propertyStack.Pop();

                    if (colonToken.IsColon()
                        && propertyNameToken.IsPropertyName()
                        && propertyName != null
                        && propertiesDict.TryGetValue((string)propertyName, out var objectInfo))
                    {
                        var spanData = Deserialize(objectInfo.PropertyType, jsonSpan);

                        //push thing back on the stack for mapping value function
                        //to work correctly
                        propertyStack.Push((propertyNameToken, propertyName));
                        propertyStack.Push((colonToken, colonData));
                        propertyStack.Push((Token.PropertyValue, spanData.Value));
                        previousToken = Token.PropertyValue;
                        jsonSpan = spanData.JsonSpan;

                        //calling this function recursively messes up the tokenLength
                        //calculation, popping out here instead
                        continue;
                    }
                    else
                    {
                        //need some type of error message
                    }
                }
                else if (token.IsOpenBracket() && previousToken.IsColon())
                {
                    var (colonToken, colonData) = propertyStack.Pop();
                    var (propertyNameToken, propertyName) = propertyStack.Pop();

                    if (colonToken.IsColon()
                        && propertyNameToken.IsPropertyName()
                        && propertyName != null
                        && propertiesDict.TryGetValue((string)propertyName, out var arrayInfo))
                    {
                        var arrayType = arrayInfo.PropertyType;
                        //if linkedlist
                        if (arrayType.IsGenericType && arrayType.GetGenericTypeDefinition() == typeof(LinkedList<>))
                        {
                            var elementType = arrayType.GetGenericArguments()[0];
                            var nextListToken = Token.None;
                            //make new list
                            dynamic linkedListInstance = Activator.CreateInstance(arrayType);
                            var addLastMethod = linkedListInstance.GetType().GetMethod("AddLast", new[] { elementType });
                            do
                            {
                                //convert all elements to C# objects
                                jsonSpan = jsonSpan.Slice(1);
                                var spanData = Deserialize(elementType, jsonSpan);
                                jsonSpan = spanData.JsonSpan;
                                nextListToken = GetNextToken(Token.None, jsonSpan);
                                object? value = spanData.Value;
                                //linkedListInstance.AddLast(value);
                                addLastMethod.Invoke(linkedListInstance, new[] { value });
                            } while (nextListToken.IsComma());

                            if (nextListToken.IsCloseBracket())
                            {
                                jsonSpan = jsonSpan.Slice(1);
                            }

                            propertyStack.Push((propertyNameToken, propertyName));
                            propertyStack.Push((colonToken, colonData));
                            propertyStack.Push((Token.PropertyValue, linkedListInstance));
                            previousToken = Token.PropertyValue;
                            continue;
                        }
                        //if it's a list
                        else if (arrayType.IsGenericType && arrayType.GetGenericTypeDefinition() == typeof(List<>))
                        {
                            var elementType = arrayType.GetGenericArguments()[0];
                            var nextListToken = Token.None;
                            //make new list
                            var listInstance = (System.Collections.IList)Activator.CreateInstance(arrayType);
                            do
                            {
                                //convert all elements to C# objects
                                jsonSpan = jsonSpan.Slice(1);
                                var spanData = Deserialize(elementType, jsonSpan);
                                jsonSpan = spanData.JsonSpan;
                                nextListToken = GetNextToken(Token.None, jsonSpan);
                                listInstance.Add(spanData.Value);
                            } while (nextListToken.IsComma());

                            if (nextListToken.IsCloseBracket())
                            {
                                jsonSpan = jsonSpan.Slice(1);
                            }
                            propertyStack.Push((propertyNameToken, propertyName));
                            propertyStack.Push((colonToken, colonData));
                            propertyStack.Push((Token.PropertyValue, listInstance));
                            previousToken = Token.PropertyValue;
                            continue;
                        }
                        else if (arrayType.IsArray)
                        {
                            var elementType = arrayType.GetElementType();
                            Type listType = typeof(List<>).MakeGenericType(elementType);
                            var elementList = (System.Collections.IList)Activator.CreateInstance(listType);

                            var nextListToken = Token.None;
                            do
                            {
                                jsonSpan = jsonSpan.Slice(1);
                                var spanData = Deserialize(elementType, jsonSpan);
                                jsonSpan = spanData.JsonSpan;
                                nextListToken = GetNextToken(Token.None, jsonSpan);
                                elementList.Add(spanData.Value);
                            } while (nextListToken.IsComma());

                            if (nextListToken.IsCloseBracket())
                            {
                                jsonSpan = jsonSpan.Slice(1);
                            }
                            Array array = Array.CreateInstance(elementType, elementList.Count);
                            elementList.CopyTo(array, 0);
                            propertyStack.Push((propertyNameToken, propertyName));
                            propertyStack.Push((colonToken, colonData));
                            propertyStack.Push((Token.PropertyValue, array));
                            previousToken = Token.PropertyValue;
                            continue;


                        }
                        else
                        {
                            var elementType = arrayType.GetElementType();
                        }
                    }
                }
                else if (token.IsCloseBrace())
                {
                    if (propertyStack.TryPeek(out var openBraceProperty) 
                        && openBraceProperty.token.IsOpenBrace())
                    {
                        propertyStack.Pop();
                    }
                    else
                    {
                        //log error case about invalid json
                    }
                    jsonSpan = jsonSpan.Slice(tokenLength);
                    break;
                }
                else if (!token.IsComma() && !token.IsWhitespace())
                {
                    propertyStack.Push((token, data));
                }

                if (!token.IsWhitespace())
                {
                    previousToken = token;
                }
                jsonSpan = jsonSpan.Slice(tokenLength);
            }

            return new SpanData(jsonSpan, instance);
        }

        internal static List<(Token token, int placeholder, string? data)> TokenizeString(
            string json)
        {
            List<(Token, int, string?)> tokens = new List<(Token, int, string?)>();
            ReadOnlySpan<char> jsonSpan = json;

            var previousValidToken = Token.Unknown;
            while (true)
            {
                var (token, placeholder, data) = GetNextTokenAndData(previousValidToken, jsonSpan);
                tokens.Add((token, placeholder, data));
                if (token == Token.None
                    || token == Token.Unknown
                    || token == Token.EndOfInput)
                {
                    //LOG something
                    return tokens;
                }
                jsonSpan = jsonSpan.Slice(placeholder);
                if (token != Token.Whitespace)
                {
                    previousValidToken = token;
                }
            }

            return tokens;
        }

        internal static (Token token, int placeholder, string? data) GetNextTokenAndData(
            Token previousToken,
            ReadOnlySpan<char> jsonSpan)
        {
            var token = GetNextToken(previousToken, jsonSpan);

            if (token == Token.PropertyName
                || token == Token.PropertyValue)
            {
                var (data, length) = ExtractTokenData(token, jsonSpan);
                return (token, length, data);
            }
            else if (token == Token.Whitespace)
            {
                var length = FindWhitespaceLength(jsonSpan);
                return (token, length, null);
            }
            else if (token == Token.Unknown
                || token == Token.None)
            {
                return (token, 1, null);
            }

            return (token, 1, null);
        }

        private static int FindWhitespaceLength(ReadOnlySpan<char> jsonSpan)
        {
            var originalLength = jsonSpan.Length;
            var nextToken = Token.Whitespace;
            while (nextToken == Token.Whitespace)
            {
                jsonSpan = jsonSpan.Slice(1);
                nextToken = GetNextToken(nextToken, jsonSpan);
            }

            return originalLength - jsonSpan.Length;
        }

        private static (string name, int length) ExtractPropertyName(ReadOnlySpan<char> jsonSpan)
        {
            var (nameOffset, parsingOffset) = (1, 2);
            var nameSpan = jsonSpan.Slice(nameOffset);

            var endOfName = nameSpan.IndexOf('"');
            var data = nameSpan.Slice(0, endOfName);
            return (data.ToString(), endOfName + parsingOffset);
        }

        private static (string data, int length) ExtractQuotedPropertyValue(ReadOnlySpan<char> jsonSpan)
        {
            //value offset is 2, colon and one double quotes
            //parsing offset is 4, colon + two double qoutes
            var (valueOffset, parsingOffset) = (1, 2);
            var valueSpan = jsonSpan.Slice(valueOffset);

            //does not handle escaped double quotes
            var endOfValue = valueSpan.IndexOf('"');
            var data = valueSpan.Slice(0, endOfValue);
            return (data.ToString(), endOfValue + parsingOffset);
        }

        private static (string data, int length) ExtractUnquotedPropertyValue(
            ReadOnlySpan<char> jsonSpan)
        {
            //also doesn't handle whitespace
            //need to handle invalid json at some point
            var endingComma = jsonSpan.IndexOf(',');
            var endingBrace = jsonSpan.IndexOf('}');
            var endingChar = -1;
            if (endingComma < 0)
                endingChar = endingBrace;
            else if (endingBrace < 0)
                endingChar = endingComma;
            else
                endingChar = Math.Min(endingComma, endingBrace);

            var data = jsonSpan.Slice(0, endingChar);
            //don't pull in ending token
            return (data.ToString(), endingChar);
        }

        internal static (string data, int length) ExtractTokenData(Token token, ReadOnlySpan<char> jsonSpan)
        {
            if (token == Token.PropertyName)
            {
                //TODO: doesn't take escaped double strings into account
                return ExtractPropertyName(jsonSpan);
            }
            else if (token == Token.PropertyValue)
            {
                if (jsonSpan[0] == '"')
                {
                    return ExtractQuotedPropertyValue(jsonSpan);
                }
                else
                {
                    return ExtractUnquotedPropertyValue(jsonSpan);
                }
            }
            return ("", 0);
        }

        internal static Token GetNextToken(Token previousToken, ReadOnlySpan<char> jsonSpan)
        {
            if (jsonSpan.Length == 0)
            {
                return Token.EndOfInput;
            }

            //check if remaining string is whitespace or not
            //var substring = json.Substring(offset);
            //if (string.IsNullOrWhiteSpace(substring))
            //{
            //    return (Token.EndOfInput, 0);
            //}
            if (jsonSpan[0] == '{')
            {
                return Token.OpenBrace;
            }
            else if (jsonSpan[0] == '}')
            {
                return Token.CloseBrace;
            }
            else if (jsonSpan[0] == '"')
            {
                if (previousToken == Token.Colon)
                {
                    return Token.PropertyValue;
                }
                else
                {
                    return Token.PropertyName;
                }
            }
            else if (jsonSpan[0] == ':')
            {
                return Token.Colon;
            }
            else if (jsonSpan[0] == ',')
            {
                return Token.Comma;
            }
            else if (jsonSpan[0] == '[')
            {
                return Token.OpenBracket;
            }
            else if (jsonSpan[0] == ']')
            {
                return Token.CloseBracket;
            }
            else if (jsonSpan[0] == ' ')
            {
                return Token.Whitespace;
            }
            else if (previousToken == Token.Colon)
            {
                return Token.PropertyValue;
            }
            return Token.Unknown;
        }
    }
}
