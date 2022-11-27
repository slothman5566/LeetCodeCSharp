using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using LeetCodeCSharp.P113_PathSumII;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P113_PathSumII
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var root = TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, null, 5, 1 });
            var result = _Solution.PathSum(root, 22);
            var ans = new int[2][];
            ans[0] = new int[] { 5, 4, 11, 2 };
            ans[1] = new int[] { 5,8,4,5 };
            for(var i=0;i<ans.Length; i++)
            {

                CollectionAssert.AreEqual(ans[i], result[i].ToArray());
            }
        }
    }
}
