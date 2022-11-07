using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P056_MergeIntervals;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P056_MergeIntervals
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var result = _Solution.Merge(ArrayHelper.ConvertStringToIntArrayOfArrays("[1,3],[2,6],[8,10],[15,18]"));
            var ans = ArrayHelper.ConvertStringToIntArrayOfArrays("[1,6],[8,10],[15,18]");

            for(var i=0; i < ans.Length; i++)
            {
                CollectionAssert.AreEqual(ans[i], result[i]);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            var result = _Solution.Merge(ArrayHelper.ConvertStringToIntArrayOfArrays("[1,4],[4,5]"));
            var ans = ArrayHelper.ConvertStringToIntArrayOfArrays("[1,5]");

            for (var i = 0; i < ans.Length; i++)
            {
                CollectionAssert.AreEqual(ans[i], result[i]);
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = _Solution.Merge(ArrayHelper.ConvertStringToIntArrayOfArrays("[2,3],[4,5],[6,7],[8,9],[1,10]"));
            var ans = ArrayHelper.ConvertStringToIntArrayOfArrays("[1,10]");

            for (var i = 0; i < ans.Length; i++)
            {
                CollectionAssert.AreEqual(ans[i], result[i]);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = _Solution.Merge(ArrayHelper.ConvertStringToIntArrayOfArrays("[2,3],[2,2],[3,3],[1,3],[5,7],[2,2],[4,6]"));
            var ans = ArrayHelper.ConvertStringToIntArrayOfArrays("[1,3],[4,7]");

            for (var i = 0; i < ans.Length; i++)
            {
                CollectionAssert.AreEqual(ans[i], result[i]);
            }
        }
    }
}
