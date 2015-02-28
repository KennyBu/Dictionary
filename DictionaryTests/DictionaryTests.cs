using System.Linq;
using DictionaryConsole;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DictionaryTests
{
    [TestClass]
    public class DictionaryTests
    {
        [TestMethod]
        public void DictionarySearchTestWithLinq()
        {
            var dictionary = new[]
            {
                "Star",
                "Burst",
            };

            const string searchWord = "StartBurst";

            var searcher = new DictionarySearcher(dictionary);
            var results = searcher.Search(searchWord, Enums.SearchType.Linq);

            Assert.IsTrue(results.Count() == 2);
            Assert.IsTrue(results.Contains("Star"));
            Assert.IsTrue(results.Contains("Burst"));
        }

        [TestMethod]
        public void DictionarySearchTestWithLinqFail()
        {
            var dictionary = new[]
            {
                "Star",
                "Burst",
            };

            const string searchWord = "NotFound";

            var searcher = new DictionarySearcher(dictionary);
            var results = searcher.Search(searchWord, Enums.SearchType.Linq);

            Assert.IsTrue(results.Count() == 0);
        }

        [TestMethod]
        public void DictionarySearchTestWithoutLinq()
        {
            var dictionary = new[]
            {
                "Star",
                "Burst",
            };

            const string searchWord = "StartBurst";

            var searcher = new DictionarySearcher(dictionary);
            var results = searcher.Search(searchWord, Enums.SearchType.NoLinq);

            Assert.IsTrue(results.Count() == 2);
            Assert.IsTrue(results.Contains("Star"));
            Assert.IsTrue(results.Contains("Burst"));
        }

        [TestMethod]
        public void DictionarySearchTestWithoutLinqFail()
        {
            var dictionary = new[]
            {
                "Star",
                "Burst",
            };

            const string searchWord = "NotFound";

            var searcher = new DictionarySearcher(dictionary);
            var results = searcher.Search(searchWord, Enums.SearchType.NoLinq);

            Assert.IsTrue(results.Count() == 0);
        }
    }
}