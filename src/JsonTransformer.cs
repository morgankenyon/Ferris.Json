using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
                            var listItemType = item.GetType();
                            if (listItemType == typeof(System.String)
                                || listItemType == typeof(System.Char))
                            {
                                generatedListJson.Add($"\"{item.ToString()}\"");
                            }
                            else if (listItemType.BaseType == typeof(object))
                            {
                                var listItemProperties = item.GetType().GetProperties();
                                var listItemJson = MapProperties(listItemProperties, item);
                                generatedListJson.Add(listItemJson);
                            }
                            else
                            {
                                generatedListJson.Add(item.ToString());
                            }
                        }
                    }
                    else
                    {
                        //need something here
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
                    //|| propertyType == typeof(System.Int128)
                    //|| propertyType == typeof(System.UInt128)
                    || propertyType == typeof(System.Byte)
                    || propertyType == typeof(System.SByte)
                    || propertyType == typeof(System.Decimal)
                    || propertyType == typeof(System.IntPtr)
                    || propertyType == typeof(System.UIntPtr)
                    )
                {
                    jsonProperties.Add($"\"{propertyInfo.Name}\":{propertyValue}");
                }
                else if (propertyType == typeof(System.Single))
                {
                    var floatValue = (float)propertyValue;
                    jsonProperties.Add($"\"{propertyInfo.Name}\":{floatValue.ToString("R", CultureInfo.InvariantCulture)}");
                }
                else if (propertyType == typeof(System.Double))
                {
                    var doubleValue = (double)propertyValue;
                    jsonProperties.Add($"\"{propertyInfo.Name}\":{doubleValue.ToString("R", CultureInfo.InvariantCulture)}");
                }
                else if (propertyType == typeof(System.Boolean))
                {
                    jsonProperties.Add($"\"{propertyInfo.Name}\":{propertyValue.ToString().ToLower()}");
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

            var spanData = Deserialize(type, json.AsSpan());

            var result = spanData.Value;

            //might have to found a better way to do this
            var convertedValue = Convert.ChangeType(result, type);
            return (T)convertedValue;
        }

        private static bool IsLineEndingToken(Token token) =>
            token.IsComma() || token.IsCloseBrace();

        private static bool IsValidPropertyNameToken(TokenInfo propertyNameInfo)
        {
            return propertyNameInfo != null
                && propertyNameInfo.Token.IsPropertyName()
                && propertyNameInfo.Data != null;
        }

        private static bool IsValidColonToken(TokenInfo colonInfo)
        {
            return colonInfo != null
                && colonInfo.Token.IsColon();
        }

        private static bool IsValidPropertyValueToken(TokenInfo propertyValueInfo)
        {
            return propertyValueInfo != null
                && propertyValueInfo.Token.IsPropertyValue()
                && propertyValueInfo.HasValue;
        }

        private static bool AreTokensSetupForPropertyValue(TokenInfo propertyNameInfo, TokenInfo colonInfo)
        {
            return IsValidPropertyNameToken(propertyNameInfo)
                && IsValidColonToken(colonInfo);
        }

        private static bool AreTokensSetupForValue(
            Token previousToken,
            TokenInfo propertyNameInfo,
            TokenInfo colonInfo,
            TokenInfo propertyValueInfo)
        {
            return previousToken.IsPropertyValue()
                && IsValidPropertyNameToken(propertyNameInfo)
                && IsValidColonToken(colonInfo)
                && IsValidPropertyValueToken(propertyValueInfo);
        }

        private static SpanData Deserialize(Type type, ReadOnlySpan<char> jsonSpan)
        {
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var propertiesDict = properties.ToDictionary(p => p.Name, p => p);
            var instance = Activator.CreateInstance(type);

            if (instance == null)
            {
                //need some general error case here
                return new SpanData(jsonSpan, null);
            }
            var previousToken = Token.None;
            TokenInfo openBraceInfo = null;
            TokenInfo propertyNameInfo = null;
            TokenInfo colonInfo = null;
            TokenInfo propertyValueInfo = null;
            while (true)
            {
                var tokenInfo = GetNextTokenAndData(previousToken, jsonSpan);
                var token = tokenInfo.Token;
                var tokenLength = tokenInfo.Length;

                if (token.IsEndOfInput())
                {
                    break;
                }

                //Case for completing a name + value pair
                if (IsLineEndingToken(token)
                    && AreTokensSetupForValue(previousToken, propertyNameInfo, colonInfo, propertyValueInfo)
                    && propertiesDict.TryGetValue((string)propertyNameInfo.Data, out var propertyInfo))
                {
                    Libs.MapValue(propertyInfo, instance, propertyValueInfo);
                }
                else
                {
                    //some error message
                }

                //Case for nested json object
                if (token.IsOpenBrace() && previousToken.IsColon())
                {
                    if (AreTokensSetupForPropertyValue(propertyNameInfo, colonInfo)
                        && propertiesDict.TryGetValue((string)propertyNameInfo.Data, out var objectInfo))
                    {
                        var spanData = Deserialize(objectInfo.PropertyType, jsonSpan);

                        propertyValueInfo = new TokenInfo(Token.PropertyValue, 0, spanData.Value);
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
                //Case for json array
                else if (token.IsOpenBracket() && previousToken.IsColon())
                {
                    if (AreTokensSetupForPropertyValue(propertyNameInfo, colonInfo)
                        && propertiesDict.TryGetValue((string)propertyNameInfo.Data, out var arrayInfo))
                    {
                        var arrayType = arrayInfo.PropertyType;
                        //if it's a list
                        if (arrayType.IsGenericType && arrayType.GetGenericTypeDefinition() == typeof(List<>))
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

                            propertyValueInfo = new TokenInfo(Token.PropertyValue, 0, listInstance);
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

                            propertyValueInfo = new TokenInfo(Token.PropertyValue, 0, array);
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
                    if (openBraceInfo != null)
                    {
                        openBraceInfo = null;
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
                    if (token.IsPropertyName())
                    {
                        propertyNameInfo = tokenInfo;
                    }
                    else if (token.IsColon())
                    {
                        colonInfo = tokenInfo;
                    }
                    else if (token.IsPropertyValue())
                    {
                        propertyValueInfo = tokenInfo;
                    }
                    else if (token.IsOpenBrace())
                    {
                        if (openBraceInfo != null)
                        {
                            //log error case
                        }
                        else
                        {
                            openBraceInfo = tokenInfo;
                        }
                    }
                }

                if (!token.IsWhitespace())
                {
                    previousToken = token;
                }
                jsonSpan = jsonSpan.Slice(tokenLength);
            }

            return new SpanData(jsonSpan, instance);
        }

        internal static List<TokenInfo> TokenizeString(
            string json)
        {
            List<TokenInfo> tokens = new List<TokenInfo>();
            ReadOnlySpan<char> jsonSpan = json.AsSpan();

            var previousValidToken = Token.Unknown;
            while (true)
            {
                var tokenInfo = GetNextTokenAndData(previousValidToken, jsonSpan);
                tokens.Add(tokenInfo);
                if (tokenInfo.Token.IsNone()
                    || tokenInfo.Token.IsUnknown()
                    || tokenInfo.Token.IsEndOfInput())
                {
                    //LOG something
                    return tokens;
                }
                jsonSpan = jsonSpan.Slice(tokenInfo.Length);
                if (!tokenInfo.Token.IsWhitespace())
                {
                    previousValidToken = tokenInfo.Token;
                }
            }

            return tokens;
        }

        internal static TokenInfo GetNextTokenAndData(
            Token previousToken,
            ReadOnlySpan<char> jsonSpan)
        {
            var token = GetNextToken(previousToken, jsonSpan);

            if (token == Token.PropertyName
                || token == Token.PropertyValue)
            {
                var tokenInfo = ExtractTokenData(token, jsonSpan);
                return tokenInfo;
            }
            else if (token == Token.Whitespace)
            {
                var length = FindWhitespaceLength(jsonSpan);
                return new TokenInfo(token, length);
            }
            else if (token == Token.Unknown
                || token == Token.None)
            {
                return new TokenInfo(token, 1);
            }

            return new TokenInfo(token, 1);
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
            var valueSpanCount = valueSpan.Length;
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

        internal static TokenInfo ExtractTokenData(Token token, ReadOnlySpan<char> jsonSpan)
        {
            if (token == Token.PropertyName)
            {
                //TODO: doesn't take escaped double strings into account
                var (data, length) = ExtractPropertyName(jsonSpan);
                return new TokenInfo(token, length, data);
            }
            else if (token == Token.PropertyValue)
            {
                if (jsonSpan[0] == '"')
                {
                    var (data, length) = ExtractQuotedPropertyValue(jsonSpan);
                    return new TokenInfo(token, length, data);
                }
                else
                {
                    var (data, length) = ExtractUnquotedPropertyValue(jsonSpan);
                    return new TokenInfo(token, length, data);
                }
            }
            return new TokenInfo(token, 0);
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
