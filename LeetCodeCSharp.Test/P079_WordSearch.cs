using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P079_WordSearch;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P079_WordSearch
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
          var array=  ArrayHelper.ConvertStringToCharArrayOfArrays("['A','B','C','E'],['S','F','C','S'],['A','D','E','E']");
            Assert.IsTrue(_Solution.Exist(array, "ABCCED"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var array = ArrayHelper.ConvertStringToCharArrayOfArrays("['A','B','C','E'],['S','F','C','S'],['A','D','E','E']");
            Assert.IsFalse(_Solution.Exist(array, "ACC"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            var array = ArrayHelper.ConvertStringToCharArrayOfArrays("['A','B','C','E'],['S','F','C','S'],['A','D','E','E']");
            Assert.IsTrue(_Solution.Exist(array, "SEE"));
        }
    }
}
