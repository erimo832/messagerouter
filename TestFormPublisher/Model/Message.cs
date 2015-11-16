using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFormPublisher
{
    public class Message
    {
        public string Topic { get; set; }
        public string Level { get; set; } //can maybe have differnt styles on this
        public string Text { get; set; }
    }
}
