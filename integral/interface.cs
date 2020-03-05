using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integral
{
    interface IMath
    {
        double Trap(double a, double b, double h);
        //double Sims(double a, double b, double h);
    }
}
