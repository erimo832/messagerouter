using MessageRoutingHub.Service;
using System.Collections.Generic;
using System.Linq;

namespace MessageRoutingHub.Model
{
    public class ClientConnection
    {
        public string Name { get; set; }
        public string ConnectionId { get; set; }

        public string[] SubscriptionTopics { get; set; }

        //private string[] _topics;
        //public string[] SubscriptionTopics 
        //{ 
        //    get
        //    {
        //        return _topics;
        //    }
        //    set 
        //    {
        //        _topics = value;

        //        //Create topic trees
        //        TopicStack = new List<Stack<string>>();
                
        //        _topics.ToList()
        //            .ForEach(x => TopicStack.Add(TopicRouter.ConvertToStack(x, '.')));
                
        //    }
        //}

             
        public IList<Stack<string>> TopicStack 
        {
            get 
            {
                var res =  new List<Stack<string>>();

                SubscriptionTopics.ToList().ForEach(x => res.Add(TopicRouter.ConvertToStack(x, '.')));

                return res;
            }
        }
    }

    public enum CacheItems
    {
        Clients
    }
}