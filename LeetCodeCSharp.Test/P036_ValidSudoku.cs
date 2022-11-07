using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P036_ValidSudoku;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P036_ValidSudoku
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var input = ArrayHelper.ConvertStringToCharArrayOfArrays(
              " ['5', '3', '.', '.', '7', '.', '.', '.', '.'],['6', '.', '.', '1', '9', '5', '.', '.', '.'],['.', '9', '8', '.', '.', '.', '.', '6', '.'],['8', '.', '.', '.', '6', '.', '.', '.', '3'],['4', '.', '.', '8', '.', '3', '.', '.', '1'],['7', '.', '.', '.', '2', '.', '.', '.', '6'],['.', '6', '.', '.', '.', '.', '2', '8', '.'],['.', '.', '.', '4', '1', '9', '.', '.', '5'],['.', '.', '.', '.', '8', '.', '.', '7', '9']"
                );
            Assert.IsTrue(_Solution.IsValidSudoku(input));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = ArrayHelper.ConvertStringToCharArrayOfArrays(
              "['8','3','.','.','7','.','.','.','.'],['6', '.', '.', '1', '9', '5', '.', '.', '.'],['.', '9', '8', '.', '.', '.', '.', '6', '.'],['8', '.', '.', '.', '6', '.', '.', '.', '3'],['4', '.', '.', '8', '.', '3', '.', '.', '1'],['7', '.', '.', '.', '2', '.', '.', '.', '6'],['.', '6', '.', '.', '.', '.', '2', '8', '.'],['.', '.', '.', '4', '1', '9', '.', '.', '5'],['.', '.', '.', '.', '8', '.', '.', '7', '9']"
                );
            Assert.IsFalse(_Solution.IsValidSudoku(input));
        }
    }
}
