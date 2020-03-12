using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integral
{
    public class IntegralMath: IMath
    {
        //private double func(double x)
        //{
        //    return 2 * x - Math.Log(2 * x) + 234;
        //}

        public double Trap(double a, double b, double h, Func<double, double> func)
        {
            double sum_x = 0;
            int n = (int)((b - a) / h);

            for (int i = 1; i < n; i++)
            {
                sum_x += func(a + i * h); 
            }

            sum_x += (func(a) + func(b)) / 2;
            sum_x *= h;

            return sum_x;
        }

        public double Sims(double A, double B, int M, Func<double, double> func)
        {
            if (M <= 0)
            {
                throw new ArgumentException();

            }
            double h = (B - A) / (M - 1); //шаг
            double x = A;
            double I = func(A) + func(B);
            int n = 0;

            while (n < M-2)
            {

                x = x + h;

                if (n % 2 == 0) I = I + 4 * func(x);
                else I = I + 2 * func(x);
                n++;

            }

            return I * (h / 3);
        }
    }
}
