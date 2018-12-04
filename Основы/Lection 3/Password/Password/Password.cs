using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Password
    {
        static void Main(string[] args)
        {
            string password = "Password";

            Console.Write("Введите пароль: ");
            string userInput = Console.ReadLine();

            if (password == userInput)
            {
                Console.WriteLine("Введен верный пароль.");
            }
            else if (userInput.Length > password.Length)
            {
                Console.WriteLine("Введенный вами парооль длиннее чем заданный.");
            }
            else if (userInput.Length < password.Length)
            {
                Console.WriteLine("Введенный вами парооль короче чем заданный.");
            }
            else
            {
                Console.WriteLine("Введенный вами пароль не верен.");
            }
            Console.ReadLine();
        }
    }
}
