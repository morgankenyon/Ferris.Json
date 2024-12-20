using System.Reflection;

namespace Ferris.Json
{
    public static class JsonTransformer
    {
        public static string ToJson(object obj)
        {
            var properties = obj.GetType().GetProperties();

            var jsonProperties = new List<string>(properties.Length);
            foreach (var property in properties) {
                var propertyValue = property.GetValue(obj);
                if (property.PropertyType == typeof(System.Int32))
                {
                    jsonProperties.Add($"\"{property.Name}\":{propertyValue}");
                }
                else if (property.PropertyType == typeof(System.Boolean))
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
