using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Привет, {name}!");
            Console.ReadLine();
        }
    }
}
