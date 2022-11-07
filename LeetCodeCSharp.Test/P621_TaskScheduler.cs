using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P621_TaskScheduler;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P621_TaskScheduler
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
          Assert.AreEqual(8,  _Solution.LeastInterval(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(6, _Solution.LeastInterval(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 0));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(16, _Solution.LeastInterval(new char[] { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'C', 'D', 'E', 'F', 'G' }, 2));
        }
    }
}
