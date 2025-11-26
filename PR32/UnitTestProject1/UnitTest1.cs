using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Zadanie1_1()
        {
            int x = 123;
            bool z = true;
            bool actual = Class1.Odd(x);
            Assert.AreEqual(z, actual);
        }
        [TestMethod]
        public void Zadanie1_2()
        {
            int x = 456;
            bool z = false;
            bool actual = Class1.Odd(x);
            Assert.AreEqual(z, actual);
        }
        [TestMethod]
        public void Zadanie1_3()
        {
            int x = 789;
            bool z = true;
            bool actual = Class1.Odd(x);
            Assert.AreEqual(z, actual);
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Zadanie2_1()
        {
            int four = 1234;
            int product = 14;
            int actual = Class2.product(four);
            Assert.AreEqual(product, actual);
        }
        [TestMethod]
        public void Zadanie2_2()
        {
            int four = 5678;
            int product = 86;
            int actual = Class2.product(four);
            Assert.AreEqual(product, actual);
        }
        [TestMethod]
        public void Zadanie2_3()
        {
            int four = 9123;
            int product = 15;
            int actual = Class2.product(four);
            Assert.AreEqual(product, actual);
        }
    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Zadanie3_1()
        {
            double D = 123;
            double res = 123 * (Math.PI / 180.0);
            double actual = Class3.DegToRad(D);
            Assert.AreEqual(res, actual, 0.000000000000001);
        }
        [TestMethod]
        public void Zadanie3_2()
        {
            double D = 234;
            double res = 234 * (Math.PI / 180.0);
            double actual = Class3.DegToRad(D);
            Assert.AreEqual(res, actual );
        }
        [TestMethod]
        public void Zadanie3_3()
        {
            double D = 222;
            double res = 222 * (Math.PI / 180.0);
            double actual = Class3.DegToRad(D);
            Assert.AreEqual(res, actual);
        }
    }
}
