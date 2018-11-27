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

namespace Fabrica_Pizza.Ingridients
{
    class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }
}
