using System.Web.Script.Serialization;

namespace MessageRoutingHub.Common
{
    public static class JsonHelper<T>
    {
        public static string ToJson(T obj)
        {
            var jsonSerialiser = new JavaScriptSerializer();
            var json = jsonSerialiser.Serialize(obj);            

            return json;
        }

        public static T FromJson(string obj)
        {
            var jsonSerialiser = new JavaScriptSerializer();
            return jsonSerialiser.Deserialize<T>(obj);
        }
    }
}