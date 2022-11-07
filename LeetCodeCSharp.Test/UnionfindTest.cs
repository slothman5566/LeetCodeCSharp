using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class UnionfindTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var arrays = ArrayHelper.ConvertStringToIntArrayOfArrays("[1, 2], [3, 4], [5, 2], [4, 6], [2, 6], [8, 7], [9, 7], [1, 6], [2, 4]");
            var uf = new UnionFind(10);
            foreach(var array in arrays)
            {
                uf.Union(array[0], array[1]);
            }

        }
    }
}
