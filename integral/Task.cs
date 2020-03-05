using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integral
{
    class Task: IMath
    {
        private double func(double x)
        {
            return 2.0 * x - Math.Log(2.0 * x) + 234;
        }

        public double Trap(double a, double b, double h)
        {
            double sum_x = 0.0;
            int n = (int)((b - a) / h);

            for (int i = 0; i < n; i++)
            {
                sum_x += func(a + i * h); 
            }

            return h / 2.0 * (func(a) + 2.0 * sum_x + func(b));
        }

        //public double Sims(double A, double B, double H)
        //{

        //}
    }
}
