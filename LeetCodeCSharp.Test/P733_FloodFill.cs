using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P733_FloodFill;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P733_FloodFill
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var array = new int[3][];
            array[0] = new int[] { 1,1,1};
            array[1] = new int[] { 1,1,0};
            array[2] = new int[] { 1,0,1};
            _Solution.FloodFill(array, 1, 1, 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var array = new int[2][];
            array[0] = new int[] { 0, 0, 0 };
            array[1] = new int[] { 0, 0, 0 };
           
            _Solution.FloodFill(array, 0, 0, 0);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var array = new int[2][];
            array[0] = new int[] { 0, 0, 0 };
            array[1] = new int[] { 0, 1, 0 };

            _Solution.FloodFill(array, 0, 0, 2);
        }

    }
}
