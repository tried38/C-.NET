using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pr20;
using var18;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // ==================== Тесты для Task1 ====================
        [TestMethod]
        public void Task1_return_true1()
        {
            int num1 = 124;
            bool result = task01.isnumberthreedigit(num1);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Task1_return_true2()
        {
            int num1 = 246;
            bool result = task01.isnumberthreedigit(num1);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Task1_return_false()
        {
            int num1 = 125;
            bool result = task01.isnumberthreedigit(num1);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Task1_return_false2()
        {
            int num1 = -126;
            bool result = task01.isnumberthreedigit(num1);
            Assert.IsTrue(result);
        }
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
        // ==================== Тесты для Task4 ====================

        [TestMethod]
        public void Task4_return_true1()
        {
            double a = 3.0;
            double otvet = 9;
            double tr_ot = task04.TriangleP(a);
            Assert.AreEqual(otvet, tr_ot);
        }
        [TestMethod]
        public void Task4_return_true2()
        {
            double a2 = 5.0;
            double otvet2 = 15;
            double tr_ot2 = task04.TriangleP(a2);
            Assert.AreEqual(otvet2, tr_ot2);
        }
        [TestMethod]
        public void Task4_return_false1()
        {
            double a3 = -4.0;
            double otvet3 = 1;
            double tr_ot3 = task04.TriangleP(a3);
            Assert.AreEqual(otvet3, tr_ot3);
        }
        [TestMethod]
        public void Task4_return_false2()
        {
            double a4 = 0;
            double otvet4 = 1;
            double tr_ot4 = task04.TriangleP(a4);
            Assert.AreEqual(otvet4, tr_ot4);
        }
        // ==================== Тесты для Task5 ====================
        [TestMethod]
        public void Task5_return_true1()
        {
            int D1 = 42;
            int d1 = 52;
            int true_otv1 = task05.DecToOct(D1);
            Assert.AreEqual(d1,true_otv1);
        }
        [TestMethod]
        public void Task5_return_true2()
        {
            int D2 = 127;
            int d2 = 177;
            int true_otv2 = task05.DecToOct(D2);
            Assert.AreEqual(d2, true_otv2);
        }
        [TestMethod]
        public void Task5_return_false1()
        {
            int D3 = 200;
            int d3 = 252;
            int true_otv3 = task05.DecToOct(D3);
            Assert.AreEqual(d3, true_otv3);
        }
        [TestMethod]
        public void Task5_return_false2()
        {
            int D4 = 300;
            int d4 = 456;
            int true_otv4 = task05.DecToOct(D4);
            Assert.AreEqual(d4, true_otv4);
        }
    }
}
