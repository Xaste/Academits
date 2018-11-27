using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabrica_Pizza.Ingridients;
using Fabrica_Pizza.Pizza_types;

namespace Fabrica_Pizza.Stores
{
    class ChicagoPizzaStore : PizzaStore
    {
        Pizza pizza = null;
        IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "Chicago Style Cheese Pizza";
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.Name = "Chicago Style Pepperoni Pizza";
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "Chicago Style Clam Pizza";
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "Chicago Style Veggie Pizza";
            }
            return pizza;

        }
    }
}
