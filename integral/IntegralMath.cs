using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integral
{
    public class IntegralMath: IMath
    {

        // Метод Трапеции 

        public double Trap(double a, double b, double h, Func<double, double> func)
        {
            if (h < 0.0)
            {
                throw new ArgumentException();

            }

            if (h > 1.0)
            {
                throw new ArgumentException();
            }


            double sum_x = 0.0;
            int n = (int)(Math.Abs(b - a) / h);

            for (int i = 1; i < n; i++)
            {
                sum_x += func(a + i * h); 
            }

            sum_x += (func(a) + func(b)) / 2.0;
            sum_x *= h;

            return sum_x;
        }


        // Метод Симпсона
        
        public double Sims(double A, double B, int M, Func<double, double> func)
        {
            if (M <= 0)
            {
                throw new ArgumentException();
            }

            if (M > 10000000)
            {
                throw new ArgumentException();
            }

            double h = Math.Abs(B - A) / M; //шаг
            double x = A;
            double I = func(A) + func(B);
            int n = 0;

            while (n < M-1)
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
