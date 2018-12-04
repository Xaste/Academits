using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactExercise
{
    class ContactExercise
    {
        static void Main(string[] args)
        {
            Contact first = new Contact();
            Contact second = new Contact();
            Contact third = new Contact("Ivan", "The Terrible", "None");

            first.Name = "Ivan";
            first.Surname = "Ivanov";
            first.PhoneNumber = "333-33-33";

            second.Name = "Petr";
            second.Surname = "Petrov";
            second.PhoneNumber = "555-55-55";

            Console.WriteLine($"{first.Name} {first.Surname}. тел {first.PhoneNumber}");
            Console.WriteLine($"{second.Name} {second.Surname}. тел {second.PhoneNumber}");
            Console.WriteLine($"{third.Name} {third.Surname}. тел {third.PhoneNumber}");
        }
    }

    class Contact
    {
        public string Name
        {
            get;
            set;
        }
        public string Surname
        {
            get;
            set;
        }

        public string PhoneNumber
        {
            get;
            set;
        }

        public Contact()
        {

        }

        public Contact(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }
    }
}
