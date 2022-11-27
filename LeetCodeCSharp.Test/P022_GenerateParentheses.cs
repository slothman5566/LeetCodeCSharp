using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using LeetCodeCSharp.P022_GenerateParentheses;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P022_GenerateParentheses
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var result = _Solution.GenerateParenthesis(3);
            var ans = new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" };
            CollectionAssert.AreEqual(ans, result.ToArray());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _Solution.GenerateParenthesis(1);
            var ans = new string[] { "()" };
            CollectionAssert.AreEqual(ans, result.ToArray());
        }
    }
}
