using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using LeetCodeCSharp.P417_PacificAtlanticWaterFlow;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P417_PacificAtlanticWaterFlow
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var result = _Solution.PacificAtlantic(ArrayHelper.ConvertStringToIntArrayOfArrays("[1,2,2,3,5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5],[5,1,1,2,4]")).ToArray();
            var ans = ArrayHelper.ConvertStringToIntArrayOfArrays("[0,4],[1,3],[1,4],[2,2],[3,0],[3,1],[4,0]");
            
            for(var i=0; i < ans.Length; i++)
            {
                CollectionAssert.AreEqual(ans[i], result[i].ToArray());
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _Solution.PacificAtlantic(ArrayHelper.ConvertStringToIntArrayOfArrays("[1]")).ToArray();
            var ans = ArrayHelper.ConvertStringToIntArrayOfArrays("[0,0]");

            for (var i = 0; i < ans.Length; i++)
            {
                CollectionAssert.AreEqual(ans[i], result[i].ToArray());
            }
        }
    }
}
