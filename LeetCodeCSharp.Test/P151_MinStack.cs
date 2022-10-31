using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P151_MinStack;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P151_MinStack
    {
        [TestMethod]
        public void TestMethod1()
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Assert.AreEqual(-3, minStack.GetMin()); // return -3
            minStack.Pop();
            Assert.AreEqual(0, minStack.Top());    // return 0
            Assert.AreEqual(-2, minStack.GetMin()); // return -2
        }
    }
}
