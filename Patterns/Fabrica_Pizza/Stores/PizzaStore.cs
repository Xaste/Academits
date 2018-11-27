using Fabrica_Pizza.Pizza_types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Pizza.Stores
{
    public abstract class PizzaStore
    {
        //SimplePizzaFactory factory;

        /*public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }*/

        public Pizza OrderPizza(string type)
        {
            //Pizza pizza;

            var pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

         abstract public Pizza CreatePizza(string type);
    }
}
