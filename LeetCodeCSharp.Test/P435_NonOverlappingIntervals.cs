using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P435_NonOverlappingIntervals;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P435_NonOverlappingIntervals
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {

          Assert.AreEqual(1,  _Solution.EraseOverlapIntervals(ArrayHelper.ConvertStringToIntArrayOfArrays("[1,2],[2,3],[3,4],[1,3]")));
        }

        [TestMethod]
        public void TestMethod2()
        {

            Assert.AreEqual(2, _Solution.EraseOverlapIntervals(ArrayHelper.ConvertStringToIntArrayOfArrays("[1,2],[1,2],[1,2]")));
        }


        [TestMethod]
        public void TestMethod3()
        {

            Assert.AreEqual(2, _Solution.EraseOverlapIntervals(ArrayHelper.ConvertStringToIntArrayOfArrays("[1,100],[11,22],[1,11],[2,12]")));
        }

        
    }
}
