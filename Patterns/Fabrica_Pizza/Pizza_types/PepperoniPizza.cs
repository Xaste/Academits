using Fabrica_Pizza.Ingridients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Pizza.Pizza_types
{
    class PepperoniPizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientFactory.CreateDough();
            Cheese = _ingredientFactory.CreateCheese();
            Pepperoni = _ingredientFactory.CreatePepperoni();
            Veggies = _ingredientFactory.CreateVeggies();
        }
    }
}
