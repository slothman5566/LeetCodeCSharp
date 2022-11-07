using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P049_GroupAnagrams;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P049_GroupAnagrams
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
           var result= _Solution.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
           
        }
    }
}
