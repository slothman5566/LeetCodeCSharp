using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P981_TimeBasedKeyValueStore;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P981_TimeBasedKeyValueStore
    {
        [TestMethod]
        public void TestMethod1()
        {
            TimeMap timeMap = new TimeMap();
            timeMap.Set("foo", "bar", 1);  // store the key "foo" and value "bar" along with timestamp = 1.
            Assert.AreEqual("bar", timeMap.Get("foo", 1));         // return "bar"
            Assert.AreEqual("bar", timeMap.Get("foo", 3));         // return "bar", since there is no value corresponding to foo at timestamp 3 and timestamp 2, then the only value is at timestamp 1 is "bar".
            timeMap.Set("foo", "bar2", 4); // store the key "foo" and value "bar2" along with timestamp = 4.
            Assert.AreEqual("bar2", timeMap.Get("foo", 4));         // return "bar2"
            Assert.AreEqual("bar2", timeMap.Get("foo", 5));
        }

    }
}
