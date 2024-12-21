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
    }
}
