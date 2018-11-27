using Fabrica_Pizza.Ingridients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Pizza.Pizza_types
{
    class ClamPizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientFactory.CreateDough();
            Cheese = _ingredientFactory.CreateCheese();
            Clam = _ingredientFactory.CreateClams();
        }
    }
}
