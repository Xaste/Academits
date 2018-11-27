using Fabrica_Pizza.Ingridients.Cheese;
using Fabrica_Pizza.Ingridients.Clams;
using Fabrica_Pizza.Ingridients.Dough;
using Fabrica_Pizza.Ingridients.Pepperoni;
using Fabrica_Pizza.Ingridients.Sauce;
using Fabrica_Pizza.Ingridients.Veggies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Pizza.Pizza_types
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        public IDough Dough { get; set; }
        public ISauce Sauce { get; set; }
        public IVeggies[] Veggies { get; set; }
        public ICheese Cheese { get; set; }
        public IPepperoni Pepperoni { get; set; }
        public IClams Clam { get; set; }

        public abstract void Prepare();


        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStroe box");
        }

        /*public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }*/

        public override string ToString()
        {
            return "pizza";
        }
    }
}
