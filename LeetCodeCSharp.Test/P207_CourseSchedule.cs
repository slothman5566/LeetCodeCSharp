using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P207_CourseSchedule;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P207_CourseSchedule
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[1][];
            input[0] = new int[] { 1, 0 };
            Assert.IsTrue(_Solution.CanFinish(2, input));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new int[2][];
            input[0] = new int[] { 1, 0 };
            input[1] = new int[] { 0,1 };
            Assert.IsFalse(_Solution.CanFinish(2, input));
        }

    }
}
