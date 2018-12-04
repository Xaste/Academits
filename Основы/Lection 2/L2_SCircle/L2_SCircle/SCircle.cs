using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_SCircle
{
    class SCircle
    {
        static void Main(string[] args)
        {
            double r = 17;
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Площадь круга с радиусом " + r + " равна " + s);
        }
    }
}
