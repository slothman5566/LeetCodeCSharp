using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P150_EvaluateReversePolishNotation;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P150_EvaluateReversePolishNotation
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
           Assert.AreEqual(9, _Solution.EvalRPN(new string[] { "2", "1", "+", "3", "*" }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(6, _Solution.EvalRPN(new string[] { "4", "13", "5", "/", "+" }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(22, _Solution.EvalRPN(new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }));
        }
    }
}
