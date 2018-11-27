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
    class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new Mozzarella();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = { new BlackOlives(), new Spinach(), new EggPlant() };
            return veggies;
        }
    }
}
