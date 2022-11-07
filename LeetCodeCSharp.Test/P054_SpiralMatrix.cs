using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P054_SpiralMatrix;
using System.Linq;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P054_SpiralMatrix
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
          CollectionAssert.AreEqual(new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 },  _Solution.SpiralOrder(ArrayHelper.ConvertStringToIntArrayOfArrays("[1,2,3],[4,5,6],[7,8,9]")).ToArray());
        }

        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }, _Solution.SpiralOrder(ArrayHelper.ConvertStringToIntArrayOfArrays("[1,2,3,4],[5,6,7,8],[9,10,11,12]")).ToArray());
        }

        [TestMethod]
        public void TestMethod3()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10 }, _Solution.SpiralOrder(ArrayHelper.ConvertStringToIntArrayOfArrays("[1,2,3,4],[5,6,7,8],[9,10,11,12],[13,14,15,16]")).ToArray());
        }
    }
}
