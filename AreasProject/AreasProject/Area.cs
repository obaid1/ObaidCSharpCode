using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasProject
{
    class Area
    {
        public double AreaC(double r)
        {
            double val = Math.PI * r * r;
            return val = Math.Round(val, 2);
        }

        public double Perimeter(double r)
        {
            double val1 = 2 * Math.PI * r;
            return val1 = Math.Round(val1, 2);
        }
    }
}
