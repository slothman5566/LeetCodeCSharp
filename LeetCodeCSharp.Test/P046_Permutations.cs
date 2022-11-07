using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P046_Permutations;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P046_Permutations
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
          var result=  _Solution.Permute(new int[] { 1, 2, 3 });
        }
    }
}
