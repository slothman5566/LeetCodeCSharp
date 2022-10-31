using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P542_01Matrix;
using System.Collections.Generic;
using System.Linq;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P542_01Matrix
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var mat = new int[3][];
            mat[0] = new int[] { 0, 0, 0 };
            mat[1] = new int[] { 0, 1, 0 };
            mat[2] = new int[] { 0, 0, 0 };

            var result= new int[3][];
            result[0] = new int[] { 0, 0, 0 };
            result[1] = new int[] { 0, 1, 0 };
            result[2] = new int[] { 0, 0, 0 };
            var ans = _Solution.UpdateMatrix(mat);
            for(var i=0; i < result.Length; i++)
            {
                CollectionAssert.AreEqual(result[i], ans[i]);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            var mat = new int[3][];
            mat[0] = new int[] { 0, 0, 0 };
            mat[1] = new int[] { 0, 1, 0 };
            mat[2] = new int[] { 1, 1, 1 };

            var result = new int[3][];
            result[0] = new int[] { 0, 0, 0 };
            result[1] = new int[] { 0, 1, 0 };
            result[2] = new int[] { 1, 2, 1 };
            var ans = _Solution.UpdateMatrix(mat);
            for (var i = 0; i < result.Length; i++)
            {
                CollectionAssert.AreEqual(result[i], ans[i]);
            }
        }
        [TestMethod]
        public void TestMethod3()
        {
            var mat = new int[2][];
            mat[0] = new int[] { 0 };
            mat[1] = new int[] { 1 };
      
            var result = new int[2][];
            result[0] = new int[] { 0};
            result[1] = new int[] { 1 };
         
            var ans = _Solution.UpdateMatrix(mat);
            for (var i = 0; i < result.Length; i++)
            {
                CollectionAssert.AreEqual(result[i], ans[i]);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {

            var mat = new int[10][];
            mat[0] = new int[] { 1, 0, 1, 1, 0, 0, 1, 0, 0, 1 };
            mat[1] = new int[] { 0, 1, 1, 0, 1, 0, 1, 0, 1, 1 };
            mat[2] = new int[] { 0, 0, 1, 0, 1, 0, 0, 1, 0, 0 };
            mat[3] = new int[] { 1, 0, 1, 0, 1, 1, 1, 1, 1, 1 };
            mat[4] = new int[] { 0, 1, 0, 1, 1, 0, 0, 0, 0, 1 };
            mat[5] = new int[] { 0, 0, 1, 0, 1, 1, 1, 0, 1, 0 };
            mat[6] = new int[] { 0, 1, 0, 1, 0, 1, 0, 0, 1, 1 };
            mat[7] = new int[] { 1, 0, 0, 0, 1, 1, 1, 1, 0, 1 };
            mat[8] = new int[] { 1, 1, 1, 1, 1, 1, 1, 0, 1, 0 };
            mat[9] = new int[] { 1, 1, 1, 1, 0, 1, 0, 0, 1, 1 };
            var result = new int[10][];
            result[0] = new int[] { 1, 0, 1, 1, 0, 0, 1, 0, 0, 1 };
            result[1] = new int[] { 0, 1, 1, 0, 1, 0, 1, 0, 1, 1 };
            result[2] = new int[] { 0, 0, 1, 0, 1, 0, 0, 1, 0, 0 };
            result[3] = new int[] { 1, 0, 1, 0, 1, 1, 1, 1, 1, 1 };
            result[4] = new int[] { 0, 1, 0, 1, 1, 0, 0, 0, 0, 1 };
            result[5] = new int[] { 0, 0, 1, 0, 1, 1, 1, 0, 1, 0 };
            result[6] = new int[] { 0, 1, 0, 1, 0, 1, 0, 0, 1, 1 };
            result[7] = new int[] { 1, 0, 0, 0, 1, 2, 1, 1, 0, 1 };
            result[8] = new int[] { 2, 1, 1, 1, 1, 2, 1, 0, 1, 0 };
            result[9] = new int[] { 3, 2, 2, 1, 0, 1, 0, 0, 1, 1 };

            var ans = _Solution.UpdateMatrix(mat);
            for (var i = 0; i < result.Length; i++)
            {
                CollectionAssert.AreEqual(result[i], ans[i]);
            }
        }

        [TestMethod]
        public void TestMethod5()
        {

            var mat = new int[10][];
            mat[0] = new int[] { 1, 1, 0, 1, 1, 1, 1, 1, 1, 1 };
            mat[1] = new int[] { 1, 1, 0, 1, 1, 1, 1, 1, 1, 1 };
            mat[2] = new int[] { 1, 1, 1, 1, 0, 0, 0, 1, 1, 0 };
            mat[3] = new int[] { 1, 1, 1, 1, 1, 1, 0, 0, 1, 0 };
            mat[4] = new int[] { 1, 0, 0, 1, 1, 1, 0, 1, 0, 1 };
            mat[5] = new int[] { 0, 0, 1, 0, 0, 1, 1, 0, 0, 1 };
            mat[6] = new int[] { 0, 1, 0, 1, 1, 1, 1, 1, 1, 1 };
            mat[7] = new int[] { 1, 0, 0, 1, 1, 0, 0, 0, 0, 0 };
            mat[8] = new int[] { 0, 0, 1, 1, 1, 1, 0, 1, 1, 1 };
            mat[9] = new int[] { 1, 1, 0, 0, 1, 0, 1, 0, 1, 1 };
            var result = new int[10][];
            result[0] = new int[] { 2, 1, 0, 1, 2, 2, 2, 3, 3, 2 };
            result[1] = new int[] { 2, 1, 0, 1, 1, 1, 1, 2, 2, 1 };
            result[2] = new int[] { 3, 2, 1, 1, 0, 0, 0, 1, 1, 0 };
            result[3] = new int[] { 2, 1, 1, 2, 1, 1, 0, 0, 1, 0 };
            result[4] = new int[] { 1, 0, 0, 1, 1, 1, 0, 1, 0, 1 };
            result[5] = new int[] { 0, 0, 1, 0, 0, 1, 1, 0, 0, 1 };
            result[6] = new int[] { 0, 1, 0, 1, 1, 1, 1, 1, 1, 1 };
            result[7] = new int[] { 1, 0, 0, 1, 1, 0, 0, 0, 0, 0 };
            result[8] = new int[] { 0, 0, 1, 1, 2, 1, 0, 1, 1, 1};
            result[9] = new int[] { 1, 1, 0, 0, 1, 0, 1, 0, 1, 2 };

            var ans = _Solution.UpdateMatrix(mat);
            for (var i = 0; i < result.Length; i++)
            {
                CollectionAssert.AreEqual(result[i], ans[i]);
            }
        }

    }
}
