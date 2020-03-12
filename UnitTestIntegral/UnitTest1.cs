using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using integral;
namespace UnitTestIntegral
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTrap_xXx()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0;
            double b = 20;
            double h = 0.0001;
            double correct_res = 2666.66;

            //act
            IMath math = new IntegralMath();
            double res = math.Trap(a, b, h, func);

            //arrange
            Assert.AreEqual(correct_res, res, 0.01);

        }

        [TestMethod]
        public void TestTrap_yYy()
        {
            //assert 
            Func<double, double> func = y => y * 2;
            double a = 0;
            double b = 20;
            double h = 0.0001;
            double correct_res = 400.0;

            //act
            IMath math = new IntegralMath();
            double res = math.Trap(a, b, h, func);

            //arrange
            Assert.AreEqual(correct_res, res, 0.00001);

        }

        // Simpson's method

        [TestMethod]
        public void TestSimpson_xXx()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0;
            double b = 20;
            int m = 10000;
            double correct_res = 2666.66;

            //act
            IMath math = new IntegralMath();
            double res = math.Sims(a, b, m, func);

            //arrange
            Assert.AreEqual(correct_res, res, 0.01);

        }

        [TestMethod]
        public void TestSimpson_2x()
        {
            //assert 
            Func<double, double> func = x => 2 * x;
            double a = 0;
            double b = 20;
            int m = 10000;
            double correct_res = 400;

            //act
            IMath math = new IntegralMath();
            double res = math.Sims(a, b, m, func);

            //arrange
            Assert.AreEqual(correct_res, res, 0.0001);

        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentException))]
        public void TestSimpson_xXxBAD()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0;
            double b = 20;
            int m = -1900;
            double correct_res = 2666.66;

            //act
            IMath math = new IntegralMath();
            double res = math.Sims(a, b, m, func);

            //arrange
            //Assert.AreEqual(correct_res, res, 0.01);

        }
    }
}
