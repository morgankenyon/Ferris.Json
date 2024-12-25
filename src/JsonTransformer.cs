using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Ferris.Json
{
    public static class JsonTransformer
    {
        public static string ToJson(object obj)
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
                else
                {
                    jsonProperties.Add($"\"{property.Name}\":\"{propertyValue}\"");
                }
            }

            var combinedProperties = $"{{{string.Join(",", jsonProperties)}}}";

            return combinedProperties;
        }

        public static T ToObject<T>(string json)
        {
            Type type = typeof(T);

            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var propertiesDict = properties.ToDictionary(p => p.Name, p => p);
            //properties.Where(p => p.MemberType == )
            T instance = Activator.CreateInstance<T>();
            //foreach (PropertyInfo property in properties)
            //{

            //}

            var offset = 0;

            while (true)
            {
                var (token, placeholder, data) = GetNextTokenAndData(json, offset);

                if (token == Token.EndOfInput)
                {
                    break;
                }
                else if (token == Token.PropertyName && data != null)
                {
                    //also need to cover the case where it's a object instead of a value
                    //and nulls and booleans
                    var propertyName = data;
                    offset += placeholder;
                    (token, placeholder, data) = GetNextTokenAndData(json, offset);

                    if (propertiesDict.TryGetValue(propertyName, out var propertyInfo))
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
                    }
                }
                offset += placeholder;
            }

            return instance;
        }

        internal static List<Token> Tokenize(string json)
        {
            return new List<Token>();
        }

        internal static List<(Token token, int placeholder, string? data)> TokenizeString(string json)
        {
            List<(Token, int, string?)> tokens = new List<(Token, int, string?)>();
            var offset = 0;
            while (true)
            {
                var (token, placeholder, data) = GetNextTokenAndData(json, offset);

                tokens.Add((token, placeholder, data));
                if (token == Token.None
                    || token == Token.Unknown
                    || token == Token.EndOfInput)
                {
                    //LOG something
                    return tokens;
                }
                offset += placeholder;
            }

            return tokens;
        }

        internal static (Token token, int placeholder, string? data) GetNextTokenAndData(
            string json,
            int offset)
        {
            var (token, tokenOffset) = GetNextToken(json, offset);

            if (token == Token.PropertyName
                || token == Token.PropertyValue)
            {
                var (data, length) = ExtractTokenData(token, json, offset);
                return (token, length, data);
            }
            else if (token == Token.Unknown
                || token == Token.None)
            {
                return (token, 1, null);
            }

            return (token, 1 + tokenOffset, null);
        }

        private static (string name, int length) ExtractPropertyName(
            string json,
            int offset)
        {
            var (nameOffset, parsingOffset) = (1, 2);
            var localOffset = nameOffset + offset;
            var endOfName = json.IndexOf('"', localOffset) - localOffset;
            var data = json.Substring(localOffset, endOfName);
            return (data, endOfName + parsingOffset);
        }

        private static (string data, int length) ExtractPropertyStringValue(
            string json,
            int offset)
        {
            var (valueOffset, parsingOffset) = (2, 4);
            var localOffset = valueOffset + offset;
            //does not handle escaped double quotes
            var endOfValue = json.IndexOf('"', localOffset) - localOffset;
            var data = json.Substring(localOffset, endOfValue);
            return (data, endOfValue + parsingOffset);
        }

        private static (string data, int length) ExtractPropertyNumberValue(
            string json,
            int offset)
        {
            var localOffset = 1 + offset;
            var skipChars = 2; //one for colon, one for comma
            //there could be no comma here if it's the last property in an object
            var endingChar = json.IndexOf(',', localOffset) - localOffset;
            if (endingChar < 0)
            {
                endingChar = json.IndexOf('}', localOffset) - localOffset;
                skipChars--; //if no comma, detract one
            }
            var data = json.Substring(localOffset, endingChar);
            return (data, endingChar + skipChars);
        }

        internal static (string data, int length) ExtractTokenData(Token token, string json, int offset)
        {
            if (token == Token.PropertyName)
            {
                //TODO: doesn't take escaped double strings into account
                return ExtractPropertyName(json, offset);
            }
            else if (token == Token.PropertyValue)
            {
                if (json[1 + offset] == '"')
                {
                    return ExtractPropertyStringValue(json, offset);
                }
                else
                {
                    return ExtractPropertyNumberValue(json, offset);
                }
            }
            return ("", 0);
        }

        internal static (Token token, int tokenOffset) GetNextToken(string json, int offset)
        {
            if (offset >= json.Length)
            {
                return (Token.EndOfInput, 0);
            }

            var substring = json.Substring(offset);
            if (string.IsNullOrWhiteSpace(substring))
            {
                return (Token.EndOfInput, 0);
            }
            else if (json[offset] == '{')
            {
                return (Token.OpenBracket, 0);
            }
            else if (json[offset] == '}')
            {
                return (Token.CloseBracket, 0);
            }
            else if (json[offset] == '"')
            {
                return (Token.PropertyName, 0);
            }
            else if (json[offset] == ':')
            {
                if (json[offset + 1] == '{')
                {
                    return (Token.OpenBracket, 1);
                }
                return (Token.PropertyValue, 0);
            }
            return (Token.Unknown, 0);
        }
    }
}
