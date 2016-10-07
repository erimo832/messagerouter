using MessageRouting.Shared.Model;
using MessageRoutingHub.Common;
using MessageRoutingHub.Model;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;

namespace MessageRoutingHub.Service
{
    
    public class MessageRoutingBus : Hub
    {
        #region properties

        public static ObjectCache Cache = MemoryCache.Default;

        public IList<ClientConnection> ClientList
        {
            get
            {
                if (Cache[CacheItems.Clients.ToString()] == null)
                    return new List<ClientConnection>();

                return (List<ClientConnection>)Cache[CacheItems.Clients.ToString()];
            }
            set
            {
                Cache.Set(CacheItems.Clients.ToString(), value, DateTimeOffset.MaxValue);
            }
        }

        #endregion

        #region connection

        public override Task OnDisconnected(bool stopCalled)
        {
            if (ClientList.Any(x => x.ConnectionId == Context.ConnectionId))
            {
                var dummy = ClientList.First(x => x.ConnectionId == Context.ConnectionId);
                
                ClientList.Remove(ClientList.First(x => x.ConnectionId == Context.ConnectionId));
            }
            
            return base.OnDisconnected(stopCalled);
        }

        #endregion

        #region subscription

        /// <summary>
        /// Subscribe to events
        /// </summary>
        /// <param name="name"></param>
        public void Subscribe(string name, string[] topics)
        {
            var obj = ClientList;

            if (obj.All(x => x.ConnectionId != Context.ConnectionId))
            {
                //Add connection
                obj.Add(new ClientConnection
                {
                    ConnectionId = Context.ConnectionId,
                    Name = name,
                    SubscriptionTopics = topics
                });

                //Update cache
                ClientList = obj;                
            }

            PushConnectionEstablished(new[] { Context.ConnectionId }, string.Format("Subscription registered for {0}", name));
        }

        
        private void PushConnectionEstablished(string[] connectionIds, string message)
        {
            foreach (var connectionId in connectionIds)
            {
                Task.Run(() => Clients.Client(connectionId).ConnectionEstablished(message));
            }
        }
        
        private void PushMessageToClients(string[] connectionIds, Message msg)
        {
            var json = JsonHelper<Message>.ToJson(msg);

            foreach (var connectionId in connectionIds)
            {
                Task.Run(() => Clients.Client(connectionId).NewMessage(json));
            }
        }

        #endregion
        
        #region publication

        public void Publish(Message msg)
        {
            try
            {
                //Get subscribers
                var subs = TopicRouter.GetSubscribers(msg, ClientList);

                if (subs.Count > 0)
                    PushMessageToClients(subs.Select(x => x.ConnectionId).ToArray(), msg);
            }
            catch { /* avoid unhandled exceptions */ }
        } 

        #endregion
    }
}