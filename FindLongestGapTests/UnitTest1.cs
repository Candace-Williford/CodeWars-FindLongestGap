using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars_FindLongestGap.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FixedTests()
        {
            Assert.AreEqual(2, Kata.Gap(9), "Not working for 9");
            Assert.AreEqual(4, Kata.Gap(529), "Not working for 529");
            Assert.AreEqual(1, Kata.Gap(20), "Not working for 20");
            Assert.AreEqual(0, Kata.Gap(15), "Not working for 15");
        }
    }
}
