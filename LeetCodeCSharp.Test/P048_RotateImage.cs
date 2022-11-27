using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P048_RotateImage;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P048_RotateImage
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var matrix = ArrayHelper.ConvertStringToIntArrayOfArrays("[1,2,3],[4,5,6],[7,8,9]");
           _Solution.Rotate(matrix);
            var ans= ArrayHelper.ConvertStringToIntArrayOfArrays("[7,4,1],[8,5,2],[9,6,3]");
            for(var i=0;i<ans.Length; i++)
            {
                CollectionAssert.AreEqual(ans[i], matrix[i]);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            var matrix = ArrayHelper.ConvertStringToIntArrayOfArrays("[1,2,3],[4,5,6],[7,8,9]");
            _Solution.Rotate(matrix);
            var ans = ArrayHelper.ConvertStringToIntArrayOfArrays("[7,4,1],[8,5,2],[9,6,3]");
            for (var i = 0; i < ans.Length; i++)
            {
                CollectionAssert.AreEqual(ans[i], matrix[i]);
            }
        }
    }
}
