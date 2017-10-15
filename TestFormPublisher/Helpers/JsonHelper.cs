namespace TestFormPublisher.Helpers
{
    public static class JsonHelper<T>
    {
        public static string ToJson(T obj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }
    }
}
