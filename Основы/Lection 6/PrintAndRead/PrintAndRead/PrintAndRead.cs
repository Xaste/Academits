using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAndRead
{
    class PrintAndRead
    {
        static void Main(string[] args)
        {
            string invitationMessage = "Введите число: ";
            int result = PrintRead(invitationMessage);
            Console.WriteLine($"Было введено {result}");

            int result2 = PrintRead("Введите еще одно число: ");
            Console.WriteLine($"Было введено {result2}");
        }

        public static int PrintRead(string invitationMessage)
        {
            Console.Write(invitationMessage);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
