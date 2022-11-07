using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P134_GasStation;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P134_GasStation
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, _Solution.CanCompleteCircuit(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(-1, _Solution.CanCompleteCircuit(new int[] {2,3,4 }, new int[] { 3,4,3 }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(4, _Solution.CanCompleteCircuit(new int[] { 5, 1, 2, 3, 4 }, new int[] { 4, 4, 1, 5, 1 }));
        }
    }
}
