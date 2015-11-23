
namespace MessageRouting.Shared.Model
{
    public class Message
    {
        public string Topic { get; set; }
        public string Level { get; set; } //can maybe have differnt styles on this
        public string Text { get; set; }
    }
}
