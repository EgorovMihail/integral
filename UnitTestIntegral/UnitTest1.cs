using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using integral;
namespace UnitTestIntegral
{
    [TestClass]
    public class UnitTest1
    {
        // Trap method
        //проверка на точность метода траеций
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

        //проверка на точность метода траеций
        [TestMethod]
        public void TestTrap_2x()
        {
            //assert 
            Func<double, double> func = x => x * 2;
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
        //проверка на точность метода симпсона

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

        //проверка на точность метода симпсона

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

        //ввод отрцательного кол-во итераций
        [TestMethod]

        [ExpectedException(typeof(ArgumentException))]
        public void TestSimpson_iter_bad()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0;
            double b = 20;
            int m = -1900;
            
            //act
            IMath math = new IntegralMath();
            double res = math.Sims(a, b, m, func);
        }

        //ввод отрицательного шага
        [TestMethod]

        [ExpectedException(typeof(ArgumentException))]
        public void TestTrap_step_bad()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0;
            double b = 20;
            double h = -0.002;
            
            //act
            IMath math = new IntegralMath();
            double res = math.Trap(a, b, h, func);

        }

        //ввод большого кол во итераций
        [TestMethod]

        [ExpectedException(typeof(ArgumentException))]
        public void TestSims_big_iter()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0;
            double b = 20;
            int  m = 100000000;

            //act
            IMath math = new IntegralMath();
            double res = math.Sims(a, b, m, func);

        }

        //ввод большого точности 
        [TestMethod]

        [ExpectedException(typeof(ArgumentException))]
        public void TestTrap_big_step()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0;
            double b = 20;
            double h = 1;

            //act
            IMath math = new IntegralMath();
            double res = math.Trap(a, b, h, func);
        }
    }
}
