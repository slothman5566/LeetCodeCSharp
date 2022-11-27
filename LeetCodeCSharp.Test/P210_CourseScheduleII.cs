using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P210_CourseScheduleII;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P210_CourseScheduleII
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[] { 0, 1 }, _Solution.FindOrder(2, ArrayHelper.ConvertStringToIntArrayOfArrays("[1,0]")));
        }


        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new int[] { 0,2,1,3 }, _Solution.FindOrder(4, ArrayHelper.ConvertStringToIntArrayOfArrays("[1,0],[2,0],[3,1],[3,2]")));
        }
    }
}
