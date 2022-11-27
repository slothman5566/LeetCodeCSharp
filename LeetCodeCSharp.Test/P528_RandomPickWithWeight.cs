using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P528_RandomPickWithWeight;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P528_RandomPickWithWeight
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new Solution(new int[] { 1,3,6});
            sol.PickIndex();

        }
    }
}
