using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using LeetCodeCSharp.P310_MinimumHeightTrees;

namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P310_MinimumHeightTrees
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[] { 1 }, _Solution.FindMinHeightTrees(4, ArrayHelper.ConvertStringToIntArrayOfArrays("[1,0],[1,2],[1,3]")).ToArray());
        }

        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new int[] { 3,4 }, _Solution.FindMinHeightTrees(6, ArrayHelper.ConvertStringToIntArrayOfArrays("[3,0],[3,1],[3,2],[3,4],[5,4]")).ToArray());
        }
    }
}
