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
            throw new NotImplementedException();
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
                if (token == Token.None || token == Token.Unknown)
                {
                    //LOG something
                    return tokens;
                }
                tokens.Add((token, placeholder, data));
                offset += placeholder;
            }

            return tokens;
        }

        internal static (Token token, int placeholder, string? data) GetNextTokenAndData(
            string json,
            int offset)
        {
            var token = GetNextToken(json, offset);

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

            return (token, 1, null);
        }

        private static (string data, int length) ExtractNextString(Token token, string json, int offset)
        {
            //offsets to exclude colon and double quotes when
            //extracting strings and calculating parse position
            var (stringOffset, parsingOffset) = 
                token == Token.PropertyName
                ? (1, 2)
                : (2, 4);
            var endOfString = json.IndexOf('"', stringOffset + offset) - stringOffset - offset;
            var data = json.Substring(stringOffset + offset, endOfString);
            return (data, endOfString + parsingOffset);
        }

        internal static (string data, int length) ExtractTokenData(Token token, string json, int offset)
        {
            var subString = json.Substring(offset);
            if (token == Token.PropertyName)
            {
                //TODO: doesn't take escaped double strings into account
                return ExtractNextString(token, json, offset);
            }
            else if (token == Token.PropertyValue)
            {
                if (subString[1] == '"')
                {
                    return ExtractNextString(token, json, offset);
                }
                else
                {
                    //there could be no comma here if it's the last property in an object
                    var endingComma = json.IndexOf(',', offset) - 1 - offset;
                    var data = json.Substring(1 + offset, endingComma);
                    return (data, endingComma + 2);
                }
            }
            return ("", 0);
        }

        internal static Token GetNextToken(string json, int offset)
        {
            if (offset >= json.Length)
            {
                return Token.EndOfInput;
            }

            var substring = json.Substring(offset);
            if (string.IsNullOrWhiteSpace(substring))
            {
                return Token.EndOfInput;
            }
            else if (substring[0] == '{')
            {
                return Token.OpenBracket;
            }
            else if (substring[0] == '}')
            {
                return Token.CloseBracket;
            }
            else if (substring[0] == '"')
            {
                return Token.PropertyName;
            }
            else if (substring[0] == ':')
            {
                return Token.PropertyValue;
            }
            return Token.Unknown;
        }
    }
}
