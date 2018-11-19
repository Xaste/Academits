using Duck.FlyBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();

            model.PerformFly();

            model.SetFlyBehavior(new FlyRocketPowered());

            model.PerformFly();
        }
    }
}
