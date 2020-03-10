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

        public double Sims(double A, double B, double M)
        {
            double h = (B - A) / (M - 1);//шаг
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


/*double gr__a = Convert.ToDouble(gr__A.Text);//взяли данные из формы(нижняя граница)
double gr__b = Convert.ToDouble(gr__A.Text);//взяли данные из формы(верхняя граница)
double m = Convert.ToDouble(M.Text);//возможно кол во итераций????


double h = (gr__b - gr__a) / (m - 1);//шаг
double x = gr__a;
double I = function(gr__a) + function(gr__b);
int n = 0;

while (n < m - 2)
{

x = x + h;

if (n % 2 == 0) I = I + 4 * function(x);
else I = I + 2 * function(x);
n++;

}

double Res = I * (h / 3);
res.Text = Convert.ToString(Res);*/
