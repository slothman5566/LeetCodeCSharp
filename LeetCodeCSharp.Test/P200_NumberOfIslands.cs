using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P200_NumberOfIslands;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P200_NumberOfIslands
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            char[][] grid = new char[4][];
            grid[0] = new char[5] { '1', '1', '0', '0', '0' };
            grid[1] = new char[5] { '1', '1', '0', '0', '0' };
            grid[2] = new char[5] { '0', '0', '1', '0', '0' };
            grid[3] = new char[5] { '0', '0', '0', '1', '1' };
            Assert.AreEqual(3, _Solution.NumIslandsByUF(grid));
            Assert.AreEqual(3, _Solution.NumIslands(grid));
          
        }

        [TestMethod]
        public void TestMethod2()
        {
            char[][] grid = new char[4][];
            grid[0] = new char[5] { '1', '1', '1', '1', '0' };
            grid[1] = new char[5] { '1', '1', '0', '1', '0' };
            grid[2] = new char[5] { '1', '1', '0', '0', '0' };
            grid[3] = new char[5] { '0', '0', '0', '0', '0' };
            Assert.AreEqual(1, _Solution.NumIslandsByUF(grid));
            Assert.AreEqual(1, _Solution.NumIslands(grid));

        }
    }
}
