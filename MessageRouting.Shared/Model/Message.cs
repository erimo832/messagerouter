
namespace MessageRouting.Shared.Model
{
    public class Message
    {
        public string Topic { get; set; }
        //public string Level { get; set; }  // refactor into a text message object
        //public string Text { get; set; } // refactor into a text message object
        public string JsonObject { get; set; }
    }
}
