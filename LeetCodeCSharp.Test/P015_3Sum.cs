using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P015_3Sum;
using System.Linq;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P015_3Sum
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var ans = _Solution.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
            var result = new int[2][];
            result[0] = new int[] { -1,-1,2};
            result[1] = new int[] { -1, 0,1 };
            for(var i=0;i<result.Length; i++)
            {
                CollectionAssert.AreEqual(result[i], ans[i].ToArray());
            }

        }
    }
}
