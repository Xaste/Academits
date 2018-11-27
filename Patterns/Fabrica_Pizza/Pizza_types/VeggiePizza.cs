using Fabrica_Pizza.Ingridients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Pizza.Pizza_types
{
    class VeggiePizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Prepare {Name}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Veggies = _ingredientFactory.CreateVeggies();
        }
    }
}
