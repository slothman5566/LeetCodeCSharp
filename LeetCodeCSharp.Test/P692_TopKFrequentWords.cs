using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using LeetCodeCSharp.P692_TopKFrequentWords;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P692_TopKFrequentWords
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var result = _Solution.TopKFrequent(new string[] { "i", "love", "leetcode", "i", "love", "coding" }, 2);
            CollectionAssert.AreEqual(new string[] { "i", "love" }, result.ToArray());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _Solution.TopKFrequent(new string[] { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" }, 4);
            CollectionAssert.AreEqual(new string[] { "the", "is", "sunny", "day" }, result.ToArray());
        }
    }
}
