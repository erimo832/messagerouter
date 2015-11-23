using MessageRouting.Shared.Model;
using MessageRoutingHub.Model;
using System.Collections.Generic;

namespace MessageRoutingHub.Service
{
    public static class TopicRouter
    {
        public static List<ClientConnection> GetSubscribers(Message msg, IList<ClientConnection> clients)
        {
            var delimiter = '.';
            var result = new List<ClientConnection>();

            var topicStack = TopicRouter.ConvertToStack(msg.Topic, delimiter);

            foreach (var client in clients)
            {
                foreach (var subStack in client.TopicStack)
                {
                    if(MatchTopic(topicStack, subStack, false))
                    {
                        //Add client to subscription list
                        result.Add(client);
                        break;
                    }
                }
            }

            // duga.sde.hde13cb.010.datastorage.1.error.exception.resource already defined
            // duga.sde.hde13cb.010.datastorage.1.error

            // duga.#.error
            // duga.sde.*.*.datastorage.*.error

            //String.CompareOrdinal()
            
            return result;
        }

        public static bool MatchTopic(Stack<string> topic, Stack<string> subTopic, bool isMatchAny)
        {
            var topicCnt = topic.Count;
            var subCnt = subTopic.Count;

            //check if match found
            if (subCnt == 0 && (topicCnt == 0 || isMatchAny))            
                return true;

            if (topicCnt == 0 && (subCnt == 1 && subTopic.Peek() == "#"))
                return true;


            //Any empty list means match was not found
            if (subCnt == 0 || topicCnt == 0) 
                return false;

            
            //Same value
            if (subTopic.Peek() == topic.Peek())
            {
                topic.Pop();
                subTopic.Pop();

                //isMatchAny-flag set to false because of a match
                return MatchTopic(topic, subTopic, false);
            }

            //Remove from both stacks if * 
            if (subTopic.Peek() == "*")
            {
                topic.Pop();
                subTopic.Pop();

                return MatchTopic(topic, subTopic, false);
            }

            //Only remove subtopic, comparision next recursion
            if (subTopic.Peek() == "#")
            {
                subTopic.Pop();

                return MatchTopic(topic, subTopic, true);
            }

            //if matchAny jus pop topic, en keep recursion
            if (isMatchAny)
            {
                topic.Pop();

                //keep #-flag alive
                return MatchTopic(topic, subTopic, true);
            }

            //No match found
            return false;
        }


        public static Stack<string> ConvertToStack(string topic, char delimiter)
        {
            var stack = new Stack<string>();
            var split = topic.Split(delimiter);

            for (int i = split.Length -1; i >= 0; i--)
            {
                stack.Push(split[i]);
            }

            return stack;
        }
    }
}