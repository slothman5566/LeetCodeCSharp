using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using LeetCodeCSharp.P199_BinaryTreeRightSideView;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P199_BinaryTreeRightSideView
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3, 4 }, _Solution.RightSideView(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 1, 2, 3, null, 5, null, 4 })).ToArray());
        }

        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3, 5 }, 
                _Solution.RightSideView(TreeNode.BuildTreeNode(
                    new System.Collections.Generic.List<int?>() { 1, 2, 3, 4,5 })).ToArray());
        }
    }
}
