using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Pizza.Pizza_types
{
    class ChicagoStyleCheesePizza : Pizza
    {
        /*public ChicagoStyleCheesePizza()
        {
            _name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            _sause = "Pulm Tomato Sauce";

            _toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }*/
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
