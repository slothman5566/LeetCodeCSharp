using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P074_SearchA2DMatrix;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P074_SearchA2DMatrix
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(_Solution.SearchMatrix(ArrayHelper.ConvertStringToIntArrayOfArrays("[1,3,5,7],[10,11,16,20],[23,30,34,60]"), 3));

        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(_Solution.SearchMatrix(ArrayHelper.ConvertStringToIntArrayOfArrays("[1,3,5,7],[10,11,16,20],[23,30,34,60]"), 13));

        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(_Solution.SearchMatrix(ArrayHelper.ConvertStringToIntArrayOfArrays("[1]"), 1));

        }

        

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(_Solution.SearchMatrix(ArrayHelper.ConvertStringToIntArrayOfArrays("[1,3,5,7],[10,11,16,20],[23,30,34,50]"), 2));

        }
    }
}
