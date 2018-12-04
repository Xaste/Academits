using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public abstract void AddCondiments();

        public abstract void Brew();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
