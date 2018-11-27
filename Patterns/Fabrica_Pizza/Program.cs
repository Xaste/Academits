using Fabrica_Pizza.Pizza_types;
using Fabrica_Pizza.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.Name}");

            Console.WriteLine();

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.Name}");
        }
    }
}
