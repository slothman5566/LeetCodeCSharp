using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P039_CombinationSum;
using System.Linq;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P039_CombinationSum
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var result = _Solution.CombinationSum(new int[] { 2, 3, 6, 7 }, 7);
            var ans = ArrayHelper.ConvertStringToIntArrayOfArrays("[2,2,3],[7]");
            for(var i=0;i<ans.Length; i++)
            {
                CollectionAssert.AreEqual(ans[i], result[i].ToArray());
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _Solution.CombinationSum(new int[] { 2, 3, 5 }, 8);
            var ans = ArrayHelper.ConvertStringToIntArrayOfArrays("[2,2,2,2],[2,3,3],[3,5]");
            for (var i = 0; i < ans.Length; i++)
            {
                CollectionAssert.AreEqual(ans[i], result[i].ToArray());
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = _Solution.CombinationSum(new int[] { 2 }, 1);
            Assert.AreEqual(0, result.Count);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var result = _Solution.CombinationSum(new int[] { 2 ,3}, 1);
            Assert.AreEqual(0, result.Count);
        }
    }
}
