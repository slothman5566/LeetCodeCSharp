using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using LeetCodeCSharp.P438_FindAllAnagramsInAString;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P438_FindAllAnagramsInAString
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[] { 0, 6 }, _Solution.FindAnagrams("cbaebabacd", "abc").ToArray());
        }

        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new int[] { 0, 1,2 }, _Solution.FindAnagrams("abab", "ab").ToArray());
        }
    }
}
