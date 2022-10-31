using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P994_RottingOranges;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P994_RottingOranges
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
           Assert.AreEqual(4, _Solution.OrangesRotting(ArrayHelper.ConvertStringToIntArrayOfArrays("[2,1,1],[1,1,0],[0,1,1]")));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, _Solution.OrangesRotting(ArrayHelper.ConvertStringToIntArrayOfArrays("[0,2]")));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(-1, _Solution.OrangesRotting(ArrayHelper.ConvertStringToIntArrayOfArrays("[0,1]")));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(2, _Solution.OrangesRotting(ArrayHelper.ConvertStringToIntArrayOfArrays("[2,1,1],[0,0,0],[0,0,0]")));
        }
    }
}
