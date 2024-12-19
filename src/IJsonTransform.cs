namespace Ferris.Json
{
    public interface IJsonTransform
    {
        public string ToJson(object obj);
        public T ToObject<T>(string json);
    }
}
