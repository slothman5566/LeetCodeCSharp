using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P973_KClosestPointsToOrigin;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P973_KClosestPointsToOrigin
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var points = new int[2][];
            points[0] = new int[] { 1,3};
            points[1] = new int[] { -2,2 };

            var reuslt = new int[1][];

            reuslt[0] = new int[] { -2, 2 };
            var ans = _Solution.KClosest(points, 1);
            for(var i=0;i<reuslt.Length; i++)
            {
                CollectionAssert.AreEqual(reuslt[i], ans[i]);
            }

        }

        [TestMethod]
        public void TestMethod2()
        {
            var points = new int[3][];
            points[0] = new int[] { 3, 3 };
            points[1] = new int[] { 5, -1 };
            points[2] = new int[] { -2, 4 };
            var reuslt = new int[2][];

            reuslt[0] = new int[] { 3, 3 };
            reuslt[1] = new int[] { -2, 4 };
            var ans = _Solution.KClosest(points, 2);
            for (var i = 0; i < reuslt.Length; i++)
            {
                CollectionAssert.AreEqual(reuslt[i], ans[i]);
            }

        }

        [TestMethod]
        public void TestMethod3()
        {
            var points = new int[3][];
            points[0] = new int[] { 3, 3 };
            points[1] = new int[] { 5, -1 };
            points[2] = new int[] { -2, 4 };
            var reuslt = new int[3][];

            reuslt[0] = new int[] { 3, 3 };
            reuslt[1] = new int[] { -2, 4 };
            reuslt[2] = new int[] { 5, -1 };
            var ans = _Solution.KClosest(points, 3);
            for (var i = 0; i < reuslt.Length; i++)
            {
                CollectionAssert.AreEqual(reuslt[i], ans[i]);
            }

        }

        [TestMethod]
        public void TestMethod4()
        {
            var points = new int[4][];
            points[0] = new int[] {6,10 };
            points[1] = new int[] { -3, 3 };
            points[2] = new int[] { -2, 5 };
            points[3] = new int[] { 0, 2 };
            var reuslt = new int[3][];

            reuslt[0] = new int[] { 0, 2 };
            reuslt[1] = new int[] { -3, 3 };
            reuslt[2] = new int[] { -2, 5 };
            var ans = _Solution.KClosest(points, 3);
            for (var i = 0; i < reuslt.Length; i++)
            {
                CollectionAssert.AreEqual(reuslt[i], ans[i]);
            }

        }
    }
}
