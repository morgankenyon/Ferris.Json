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
            while (true)
            {
                var (token, placeholder, data) = GetNextTokenAndData(json);
                if (token == Token.None || token == Token.Unknown)
                {
                    //LOG something
                    return tokens;
                }

                tokens.Add((token, placeholder, data));
            }

            return tokens;
        }

        internal static (Token token, int placeholder, string? data) GetNextTokenAndData(
            string json)
        {
            var token = GetNextToken(json);

            if (token == Token.PropertyName
                || token == Token.PropertyValue)
            {
                var (data, length) = ExtractTokenData(token, json);
                return (token, length, data);
            }
            else if (token == Token.Unknown
                || token == Token.None)
            {
                return (token, 0, null);
            }

            return (token, 1, null);
        }

        private static (string data, int length) ExtractNextString(Token token, string json)
        {
            //offsets to exclude colon and double quotes when
            //extracting strings and calculating parse position
            var (stringOffset, parsingOffset) = 
                token == Token.PropertyName
                ? (1, 2)
                : (2, 4);
            var endOfString = json.IndexOf('"', stringOffset) - stringOffset;
            var data = json.Substring(stringOffset, endOfString);
            return (data, endOfString + parsingOffset);
        }

        internal static (string data, int length) ExtractTokenData(Token token, string json)
        {
            if (token == Token.PropertyName)
            {
                //TODO: doesn't take escaped double strings into account
                return ExtractNextString(token, json);
            }
            else if (token == Token.PropertyValue)
            {
                if (json[1] == '"')
                {
                    return ExtractNextString(token, json);
                }
                else
                {
                    var endingComma = json.IndexOf(',') - 1;
                    var data = json.Substring(1, endingComma);
                    return (data, endingComma + 2);
                }
            }
            return ("", 0);
        }

        internal static Token GetNextToken(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return Token.None;
            }
            else if (json[0] == '{')
            {
                return Token.OpenBracket;
            }
            else if (json[0] == '}')
            {
                return Token.CloseBracket;
            }
            else if (json[0] == '"')
            {
                return Token.PropertyName;
            }
            else if (json[0] == ':')
            {
                return Token.PropertyValue;
            }
            return Token.Unknown;
        }
    }
}
