using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabrica_Pizza.Pizza_types;

namespace Fabrica_Pizza.Stores
{
    class CaliforniaPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            /*if (type.Equals("cheese"))
            {
                return new CaliforniaStyleCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                return new CaliforniaStylePepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                return new CaliforniaStyleClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                return new CaliforniaStyleVeggiePizza();
            }*/
            return null;
        }
    }
}
