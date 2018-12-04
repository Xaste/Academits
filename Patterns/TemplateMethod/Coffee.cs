using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Coffee : CaffeineBeverage
    {
        /*public override void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        public void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public void AddSugarAndMilk()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }*/
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
    }
}
