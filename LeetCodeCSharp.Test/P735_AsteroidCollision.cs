using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P735_AsteroidCollision;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P735_AsteroidCollision
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
         var result=   _Solution.AsteroidCollision(new int[] { 5, 10, -5 });
            var ans = new int[] { 5, 10 };
            CollectionAssert.AreEqual(result, ans);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _Solution.AsteroidCollision(new int[] { 5, -5 });
            var ans = new int[] {  };
            CollectionAssert.AreEqual(result, ans);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = _Solution.AsteroidCollision(new int[] { 10,2, -5 });
            var ans = new int[] {10 };
            CollectionAssert.AreEqual(result, ans);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = _Solution.AsteroidCollision(new int[] { 10, 2, 5 });
            var ans = new int[] { 10,2,5 };
            CollectionAssert.AreEqual(result, ans);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var result = _Solution.AsteroidCollision(new int[] { -2, -2, -2, 1 });
            var ans = new int[] { -2, -2, -2, 1 };
            CollectionAssert.AreEqual(result, ans);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var result = _Solution.AsteroidCollision(new int[] { -2, -2, -1, 2 });
            var ans = new int[] { -2, -2, -1, 2 };
            CollectionAssert.AreEqual(result, ans);
        }
    }
}
