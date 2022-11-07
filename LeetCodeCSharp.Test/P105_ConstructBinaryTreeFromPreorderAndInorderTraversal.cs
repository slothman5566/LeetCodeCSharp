using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P105_ConstructBinaryTreeFromPreorderAndInorderTraversal;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P105_ConstructBinaryTreeFromPreorderAndInorderTraversal
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
         var result=   _Solution.BuildTree(new int[] { 3, 9, 20, 15, 7 }, new int[] { 9, 3, 15, 20, 7 });

        }
    }
}
