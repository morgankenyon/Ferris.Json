using System.Reflection;

namespace Ferris.Json
{
    public static class JsonTransformer
    {
        public static string Serialize(object obj)
        {
            var properties = obj.GetType().GetProperties();

            var combinedProperties = MapProperties(properties, obj);

            return combinedProperties;
        }

        internal static string MapProperties(PropertyInfo[] properties, object obj)
        {
            var jsonProperties = new List<string>(properties.Length);
            foreach (var property in properties)
            {
                var propertyValue = property.GetValue(obj);
                var type = property.PropertyType;
                var childProperties = type.GetProperties();
                if (propertyValue == null)
                {
                    jsonProperties.Add($"\"{property.Name}\":null");
                }
                else if (type == typeof(System.String)
                    || type == typeof(System.Char))
                {
                    jsonProperties.Add($"\"{property.Name}\":\"{propertyValue}\"");
                }
                else if (type.BaseType == typeof(object)
                    && childProperties.Length > 0)
                {
                    var childJson = MapProperties(childProperties, propertyValue);
                    jsonProperties.Add($"\"{property.Name}\":{childJson}");
                }
                else if (type == typeof(System.Int16)
                    || type == typeof(System.UInt16)
                    || type == typeof(System.Int32)
                    || type == typeof(System.UInt32)
                    || type == typeof(System.Int64)
                    || type == typeof(System.UInt64)
                    || type == typeof(System.Int128)
                    || type == typeof(System.UInt128)
                    || type == typeof(System.Single)
                    || type == typeof(System.Double)
                    || type == typeof(System.Byte)
                    || type == typeof(System.SByte)
                    || type == typeof(System.Decimal)
                    || type == typeof(System.IntPtr)
                    || type == typeof(System.UIntPtr)
                    )
                {
                    jsonProperties.Add($"\"{property.Name}\":{propertyValue}");
                }
                else if (type == typeof(System.Boolean))
                {
                    jsonProperties.Add($"\"{property.Name}\":{propertyValue!.ToString()!.ToLower()}");
                }
                else if (type == typeof(System.DateTime))
                {
                    var dateTime = (DateTime)propertyValue;
                    var dateString = dateTime.ToString("s", System.Globalization.CultureInfo.InvariantCulture);
                    jsonProperties.Add($"\"{property.Name}\":\"{dateString}\"");
                }
                else
                {
                    jsonProperties.Add($"\"{property.Name}\":\"{propertyValue}\"");
                }
            }

            var combinedProperties = $"{{{string.Join(",", jsonProperties)}}}";

            return combinedProperties;
        }

        public static T Deserialize<T>(string json)
        {
            Type type = typeof(T);

            var spanData = Deserialize(type, json);

            var result = spanData.Value;

            //might have to found a better way to do this
            var convertedValue = Convert.ChangeType(result, type);
            return (T)convertedValue;
        }

        private static SpanData Deserialize(Type type, ReadOnlySpan<char> jsonSpan)
        {
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var propertiesDict = properties.ToDictionary(p => p.Name, p => p);
            var instance = Activator.CreateInstance(type);

            while (true)
            {
                var (token, tokenLength, data) = GetNextTokenAndData(jsonSpan);

                if (token == Token.EndOfInput)
                {
                    break;
                }
                else if (token == Token.PropertyName && data != null)
                {
                    jsonSpan = jsonSpan.Slice(tokenLength);
                    //also need to cover the case where it's a object instead of a value
                    //and nulls and booleans
                    var propertyName = data;

                    (token, tokenLength, data) = GetNextTokenAndData(jsonSpan);

                    if (token == Token.PropertyValue
                        && data != null
                        && propertiesDict.TryGetValue(propertyName, out var propertyInfo))
                    {
                        MapValue(propertyInfo, instance, data);
                    }
                    else if (token == Token.OpenBracket
                        && propertiesDict.TryGetValue(propertyName, out var objectInfo))
                    {
                        if (jsonSpan[0] == ':')
                        {
                            jsonSpan = jsonSpan.Slice(1);
                        }
                        var spanData = Deserialize(objectInfo.PropertyType, jsonSpan);
                        var obj = spanData.Value;
                        jsonSpan = spanData.JsonSpan;

                        if (objectInfo.PropertyType.IsInstanceOfType(obj)
                            && spanData.Value != null)
                        {
                            objectInfo.SetValue(instance, spanData.Value!);
                        }

                        //When going into nested objects, the jsonSpan fundamentally changes
                        //since the (token, tokenLength, data) was calculated. So continuing
                        //on the loop doesn't end well when trying to take a slice
                        continue;
                    }

                }
                else if (token == Token.CloseBracket)
                {
                    jsonSpan = jsonSpan.Slice(tokenLength);
                    break;
                }

                jsonSpan = jsonSpan.Slice(tokenLength);
            }

            return new SpanData(jsonSpan, instance);
        }

        private static void MapValue(PropertyInfo propertyInfo, object instance, string data)
        {
            var propertyType = propertyInfo.PropertyType;
            if (propertyType == typeof(string))
            {
                propertyInfo.SetValue(instance, data);
            }
            else if (propertyType == typeof(int))
            {
                if (int.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(uint))
            {
                if (uint.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(float))
            {
                if (float.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(double))
            {
                if (double.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(bool))
            {
                if (bool.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(byte))
            {
                if (byte.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(sbyte))
            {
                if (sbyte.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(char))
            {
                if (char.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(decimal))
            {
                if (decimal.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(long))
            {
                if (long.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(ulong))
            {
                if (ulong.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(Int128))
            {
                if (Int128.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(UInt128))
            {
                if (UInt128.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(short))
            {
                if (short.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(ushort))
            {
                if (ushort.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            else if (propertyType == typeof(DateTime))
            {
                if (DateTime.TryParse(data, out var result))
                {
                    propertyInfo.SetValue(instance, result);
                }
                else
                {
                    //add error message
                }
            }
            //add else statement
        }

        internal static List<(Token token, int placeholder, string? data)> TokenizeString(string json)
        {
            List<(Token, int, string?)> tokens = new List<(Token, int, string?)>();
            ReadOnlySpan<char> jsonSpan = json;

            while (true)
            {
                var (token, placeholder, data) = GetNextTokenAndData(jsonSpan);

                tokens.Add((token, placeholder, data));
                if (token == Token.None
                    || token == Token.Unknown
                    || token == Token.EndOfInput)
                {
                    //LOG something
                    return tokens;
                }
                jsonSpan = jsonSpan.Slice(placeholder);
            }

            return tokens;
        }

        internal static (Token token, int placeholder, string? data) GetNextTokenAndData(
            ReadOnlySpan<char> jsonSpan)
        {
            var (token, tokenOffset) = GetNextToken(jsonSpan);

            if (token == Token.PropertyName
                || token == Token.PropertyValue)
            {
                var (data, length) = ExtractTokenData(token, jsonSpan);
                return (token, length, data);
            }
            else if (token == Token.Unknown
                || token == Token.None)
            {
                return (token, 1, null);
            }

            return (token, 1 + tokenOffset, null);
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
            var (valueOffset, parsingOffset) = (2, 4);
            var valueSpan = jsonSpan.Slice(valueOffset);

            //does not handle escaped double quotes
            var endOfValue = valueSpan.IndexOf('"');
            var data = valueSpan.Slice(0, endOfValue);
            return (data.ToString(), endOfValue + parsingOffset);
        }

        private static (string data, int length) ExtractUnquotedPropertyValue(
            ReadOnlySpan<char> jsonSpan)
        {
            var valueSpan = jsonSpan.Slice(1);
            var skipChars = 2; //one for colon, one for comma
            //there could be no comma here if it's the last property in an object
            var endingChar = valueSpan.IndexOf(',');
            if (endingChar < 0)
            {
                endingChar = valueSpan.IndexOf('}');
                skipChars--; //if no comma, detract one
            }
            var data = valueSpan.Slice(0, endingChar);
            return (data.ToString(), endingChar + skipChars);
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
                if (jsonSpan[1] == '"')
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

        internal static (Token token, int tokenOffset) GetNextToken(ReadOnlySpan<char> jsonSpan)
        {
            if (jsonSpan.Length == 0)
            {
                return (Token.EndOfInput, 0);
            }

            //check if remaining string is whitespace or not
            //var substring = json.Substring(offset);
            //if (string.IsNullOrWhiteSpace(substring))
            //{
            //    return (Token.EndOfInput, 0);
            //}
            if (jsonSpan[0] == '{')
            {
                return (Token.OpenBracket, 0);
            }
            else if (jsonSpan[0] == '}')
            {
                return (Token.CloseBracket, 0);
            }
            else if (jsonSpan[0] == '"')
            {
                return (Token.PropertyName, 0);
            }
            else if (jsonSpan[0] == ':')
            {
                if (jsonSpan[0 + 1] == '{')
                {
                    return (Token.OpenBracket, 1);
                }
                return (Token.PropertyValue, 0);
            }
            return (Token.Unknown, 0);
        }
    }
}
