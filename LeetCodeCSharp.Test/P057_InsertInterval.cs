using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P057_InsertInterval;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P057_InsertInterval
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var intervals = new int[2][];
            intervals[0] = new int[] { 1, 3 };
            intervals[1] = new int[] { 6, 9 };
            var newinterval= new int[] { 2, 5 };

            var result = new int[2][];
            result[0] = new int[] { 1, 5 };
            result[1] = new int[] { 6, 9 };
            var ans = _Solution.Insert(intervals, newinterval);
            for(var i=0; i < result.Length; i++)
            {
                CollectionAssert.AreEqual(result[i], ans[i]);
            }
          
        }

        [TestMethod]
        public void TestMethod2()
        {
            var intervals = new int[5][];
            intervals[0] = new int[] { 1, 2 };
            intervals[1] = new int[] { 3, 5 };
            intervals[2] = new int[] { 6, 7 };
            intervals[3] = new int[] { 8, 10 };
            intervals[4] = new int[] { 12, 16 };
            var newinterval = new int[] { 4, 8 };

            var result = new int[3][];
            result[0] = new int[] { 1, 2 };
            result[1] = new int[] { 3, 10 };
            result[2] = new int[] { 12, 16 };
            var ans = _Solution.Insert(intervals, newinterval);
            for (var i = 0; i < result.Length; i++)
            {
                CollectionAssert.AreEqual(result[i], ans[i]);
            }

        }

        [TestMethod]
        public void TestMethod3()
        {
            var intervals = new int[1][];
            intervals[0] = new int[] { 1, 5 };
         
            var newinterval = new int[] { 2, 3 };

            var result = new int[1][];
            result[0] = new int[] { 1, 5 };
          
            var ans = _Solution.Insert(intervals, newinterval);
            for (var i = 0; i < result.Length; i++)
            {
                CollectionAssert.AreEqual(result[i], ans[i]);
            }

        }

        [TestMethod]
        public void TestMethod4()
        {
            var intervals = new int[1][];
            intervals[0] = new int[] { 1, 5 };

            var newinterval = new int[] { 6, 8 };

            var result = new int[2][];
            result[0] = new int[] { 1, 5 };
            result[1] = new int[] { 6, 8 };
            var ans = _Solution.Insert(intervals, newinterval);
            for (var i = 0; i < result.Length; i++)
            {
                CollectionAssert.AreEqual(result[i], ans[i]);
            }

        }


    }
}
