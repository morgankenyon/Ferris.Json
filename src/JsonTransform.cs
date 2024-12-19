namespace Ferris.Json
{
    public class JsonTransform : IJsonTransform
    {
        public string ToJson(object obj)
        {
            var properties = obj.GetType().GetProperties();

            var jsonProperties = new List<string>(properties.Length);
            foreach (var property in properties) {
                var propertyValue = property.GetValue(obj);
                jsonProperties.Add($"\"{property.Name}\":\"{propertyValue}\"");
            }

            var combinedProperties = $"{{{string.Join(",", jsonProperties)}}}";

            return combinedProperties;
        }

        public T ToObject<T>(string json)
        {
            throw new NotImplementedException();
        }
    }
}
