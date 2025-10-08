using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;
using ClassLibrary2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_zad1()
        {
            int a = 1;
            int b = -1;
            int c =-2;
            int expected = 1;
            int actual = onlyone.Onlyone(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_zad1()
        {
            int a = -1;
            int b = -1;
            int c = -2;
            int expected = -1;
            int actual = onlyone.Onlyone(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_zad2()
        {
            int k = 1234567;
            int n = 5;
            int expected = 3;
            int actual = count.Count(k, n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod1_zad2()
        {
            int k = 123456;
            int n = 5;
            int expected = 2;
            int actual = count.Count(k, n);
            Assert.AreEqual(expected, actual);
        }
    }
}
