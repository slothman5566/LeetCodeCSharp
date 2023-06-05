using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P0412_FizzBuzz;
using System.Linq;

namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P0412_FizzBuzz
    {
        protected readonly Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
           var result= _Solution.FizzBuzz(3);
            CollectionAssert.AreEquivalent(result.ToArray(), new string[] { "1", "2", "Fizz" });
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _Solution.FizzBuzz(5);
            CollectionAssert.AreEquivalent(result.ToArray(), new string[] { "1", "2", "Fizz", "4", "Buzz" });
        }
    }
}
