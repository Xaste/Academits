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
    interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IVeggies[] CreateVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClams();
    }
}
