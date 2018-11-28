using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single
{
    class Program
    {
        static void Main(string[] args)
        {
            //var boiler1 = ChocolateBoiler.GetInstance();
            //var boiler2 = ChocolateBoiler.GetInstance();

            var boiler1 = ChocolateBoiler.Source;

            boiler1.Fill();

            var boiler2 = ChocolateBoiler.Source;

            boiler1.Fill();
            boiler1.Boil();

            boiler2.Drain();
        }
    }
}
