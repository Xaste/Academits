using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Tea : CaffeineBeverage
    {
        /*public override void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag()
            PourInCup();
            AddLemon();
        }

        public void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }

        public void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }*/


        public override void AddCondiments()
        {
            Console.WriteLine("Add Lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}
