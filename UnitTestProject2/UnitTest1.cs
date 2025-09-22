using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using var18;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        // ==================== Тесты для Task2 ====================
        [TestMethod]
        public void Task2_return_true1()
        {
            int B = 5;
            int C = 10;
            int p = 48;
            int product = task02.product_of_numbers(B, C);
            Assert.AreEqual(p, product);
        }
        [TestMethod]
        public void Task2_return_true2()
        {
            int B1 = 6;
            int C1 = 12;
            int p = 80;
            int product = task02.product_of_numbers(B1, C1);
            Assert.AreEqual(p, product);
        }
        [TestMethod]
        public void Task2_return_false1()
        {
            int B2 = -5;
            int C2 = -1;
            int expected = 1;
            int result = task02.product_of_numbers(B2, C2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Task2_return_false2()
        {
            int B3 = -4;
            int C3 = 0;
            int expected = 1;
            int result = task02.product_of_numbers(B3, C3);
            Assert.AreEqual(expected, result);
        }
    }
}
