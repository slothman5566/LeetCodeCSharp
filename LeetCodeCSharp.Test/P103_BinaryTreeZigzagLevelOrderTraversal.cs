using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using LeetCodeCSharp.P103_BinaryTreeZigzagLevelOrderTraversal;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P103_BinaryTreeZigzagLevelOrderTraversal
    {

        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var node = TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 3, 9, 20, null, null, 15, 7 });

            var result=_Solution.ZigzagLevelOrder(node);

            var ans = ArrayHelper.ConvertStringToIntArrayOfArrays("[3],[20,9],[15,7]");
           for(var i=0; i < ans.Length; i++)
            {
                CollectionAssert.AreEqual(ans[i], result[i].ToArray());
            }
        }
    }
}
