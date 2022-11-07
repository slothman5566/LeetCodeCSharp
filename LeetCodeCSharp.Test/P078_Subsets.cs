using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using LeetCodeCSharp.P078_Subsets;
namespace LeetCodeCSharp.Test
{

    [TestClass]
    public class P078_Subsets
    
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var result = _Solution.Subsets(new int[] { 1, 2, 3 });
            var ans = ArrayHelper.ConvertStringToIntArrayOfArrays("[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]");

            result = result.OrderBy(x => x.Sum()*x.Count()).ToList();
            ans = ans.OrderBy(x => x.Sum() * x.Count()).ToArray();
            for (var i=0; i < ans.Length; i++)
            {
                CollectionAssert.AreEquivalent(result[i].ToArray(), ans[i]);
            }
          
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _Solution.SubsetsByDFS(new int[] { 1, 2, 3 });
            var ans = ArrayHelper.ConvertStringToIntArrayOfArrays("[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]");

            result = result.OrderBy(x => x.Sum() * x.Count()).ToList();
            ans = ans.OrderBy(x => x.Sum() * x.Count()).ToArray();
            for (var i = 0; i < ans.Length; i++)
            {
                CollectionAssert.AreEquivalent(result[i].ToArray(), ans[i]);
            }

        }
    }
}
