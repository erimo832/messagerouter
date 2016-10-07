using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MessageRoutingHub.Service;
using MessageRoutingHub.Common.Extensions;

namespace MessageRoutingTest
{
    [TestClass]
    public class TopicParserTests
    {

        #region ConvertToStack tests
        [TestMethod]
        public void ConvertToStackTest1()
        {
            var topic = "1.2.3";
            var delimiter = '.';
            
            var result = TopicRouter.ConvertToStack(topic, delimiter);

            Assert.AreEqual(result.Pop(), "1");
            Assert.AreEqual(result.Pop(), "2");
            Assert.AreEqual(result.Pop(), "3");
        }
        
        [TestMethod]
        public void ConvertToStackTest2()
        {
            var topic = "1/2/3";
            var delimiter = '/';

            var result = TopicRouter.ConvertToStack(topic, delimiter);

            Assert.AreEqual(result.Pop(), "1");
            Assert.AreEqual(result.Pop(), "2");
            Assert.AreEqual(result.Pop(), "3");
        }

        [TestMethod]
        public void ConvertToStackNoMatchLeadingDelimiterTest1()
        {
            var topic = "/1/2/3";
            var delimiter = '/';

            var result = TopicRouter.ConvertToStack(topic, delimiter);

            Assert.AreEqual(result.Pop(), "");
            Assert.AreEqual(result.Pop(), "1");
            Assert.AreEqual(result.Pop(), "2");
            Assert.AreEqual(result.Pop(), "3");
        }
        #endregion

        #region Match topic tests

        [TestMethod]
        public void TopicMatchTest1()
        {
            var delimiter = '.';

            var pubTopic = TopicRouter.ConvertToStack("duga.sde.datastorage.1.hde13", delimiter);
            var subTopic = TopicRouter.ConvertToStack("duga.sde.datastorage.1.hde13", delimiter);

            var result = TopicRouter.MatchTopic(pubTopic, subTopic, false);

            Assert.AreEqual(result, true);
        }
        
        [TestMethod]
        public void TopicMatchTest2()
        {
            var delimiter = '.';

            var pubTopic = TopicRouter.ConvertToStack("duga.sde.datastorage.1.hde13", delimiter);
            var subTopic = TopicRouter.ConvertToStack("*.sde.datastorage.1.hde13", delimiter);

            var result = TopicRouter.MatchTopic(pubTopic, subTopic, false);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TopicMatchTest3()
        {
            var delimiter = '.';

            var pubTopic = TopicRouter.ConvertToStack("duga.sde.datastorage.1.hde13", delimiter);
            var subTopic = TopicRouter.ConvertToStack("duga.*.*.1.hde13", delimiter);

            var result = TopicRouter.MatchTopic(pubTopic, subTopic, false);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TopicMatchTest4()
        {
            var delimiter = '.';

            var pubTopic = TopicRouter.ConvertToStack("duga.sde.datastorage.1.hde13", delimiter);
            var subTopic = TopicRouter.ConvertToStack("duga.sde.datastorage.1.*", delimiter);

            var result = TopicRouter.MatchTopic(pubTopic, subTopic, false);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TopicMatchTest5()
        {
            var delimiter = '.';

            var pubTopic = TopicRouter.ConvertToStack("duga.sde.datastorage.1.hde13", delimiter);
            var subTopic = TopicRouter.ConvertToStack("duga.sde.datastorage.*", delimiter);

            var result = TopicRouter.MatchTopic(pubTopic, subTopic, false);

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void TopicMatchTest6()
        {
            var delimiter = '.';

            var pubTopic = TopicRouter.ConvertToStack("duga.sde.datastorage.1.hde13", delimiter);
            var subTopic = TopicRouter.ConvertToStack("duga.sde.datastorage.1.hde13.", delimiter);

            var result = TopicRouter.MatchTopic(pubTopic, subTopic, false);

            Assert.AreEqual(result, false);
        }


        [TestMethod]
        public void TopicMatchTest7()
        {
            var delimiter = '.';

            var pubTopic = TopicRouter.ConvertToStack("duga.sde.datastorage.1.hde13", delimiter);
            var subTopic = TopicRouter.ConvertToStack("#", delimiter);

            var result = TopicRouter.MatchTopic(pubTopic, subTopic, false);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TopicMatchTest8()
        {
            var delimiter = '.';

            var pubTopic = TopicRouter.ConvertToStack("duga.sde.datastorage.1.hde13", delimiter);
            var subTopic = TopicRouter.ConvertToStack("duga.#", delimiter);

            var result = TopicRouter.MatchTopic(pubTopic, subTopic, false);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TopicMatchTest9()
        {
            var delimiter = '.';

            var pubTopic = TopicRouter.ConvertToStack("duga.sde.datastorage.1.hde13", delimiter);
            var subTopic = TopicRouter.ConvertToStack("duga.#.sde.datastorage.1.hde13", delimiter);

            var result = TopicRouter.MatchTopic(pubTopic, subTopic, false);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TopicMatchTest10()
        {
            var delimiter = '.';

            var pubTopic = TopicRouter.ConvertToStack("duga.sde.datastorage.1.hde13", delimiter);
            var subTopic = TopicRouter.ConvertToStack("duga.#.2.hde13", delimiter);

            var result = TopicRouter.MatchTopic(pubTopic, subTopic, false);

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void TopicMatchTest11()
        {
            var delimiter = '.';

            var pubTopic = TopicRouter.ConvertToStack("duga", delimiter);
            var subTopic = TopicRouter.ConvertToStack("duga.#", delimiter);

            var result = TopicRouter.MatchTopic(pubTopic, subTopic, false);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TopicMatchMultiple1()
        {
            var delimiter = '.';

            var pubTopic = TopicRouter.ConvertToStack("abc.efg", delimiter);
            var subTopic1 = TopicRouter.ConvertToStack("abc.hij", delimiter);
            var subTopic2 = TopicRouter.ConvertToStack("efg.#", delimiter);

            var result = TopicRouter.MatchTopic(pubTopic.Clone(), subTopic1, false);
            Assert.AreEqual(result, false);

            var result2 = TopicRouter.MatchTopic(pubTopic.Clone(), subTopic2, false);
            Assert.AreEqual(result2, false);
        }

        #endregion
    }
}
