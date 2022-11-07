using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using LeetCodeCSharp.P017_LetterCombinationsOfAPhoneNumber;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P017_LetterCombinationsOfAPhoneNumber
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
          var result=  _Solution.LetterCombinations("23");
            CollectionAssert.AreEqual(new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }, result.ToArray());
        }
    }
}
