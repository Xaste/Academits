using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHomeWork
{
    class LinqHomeWork
    {
        public static IEnumerable<double> GetSqrt()
        {
            var i = 1;
            while (true)
            {
                yield return Math.Sqrt(i);
                ++i;
            }
        }

        static void Main(string[] args)
        {
            var person1 = new Person { Name = "Ilya", Age = 20 };
            var person2 = new Person { Name = "Max", Age = 15 };
            var person3 = new Person { Name = "Olga", Age = 17 };
            var person4 = new Person { Name = "Alex", Age = 20 };
            var person5 = new Person { Name = "Ilya", Age = 23 };
            var person6 = new Person { Name = "Petr", Age = 27 };
            var person7 = new Person { Name = "Anna", Age = 25 };
            var person8 = new Person { Name = "Ivan", Age = 40 };


            var list = new List<Person>() { person1, person2, person3, person4, person5, person6, person7, person8 };

            var uniqeNames = list
                .Select(x => x.Name)
                .Distinct()
                .ToList();

            Console.WriteLine("A) Уникальные имена:");
            foreach (var item in uniqeNames)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Б) Уникальные имена в формате:");
            Console.WriteLine("Имена: " + string.Join(", ", uniqeNames));

            Console.WriteLine();

            var ageAverage = list
                .Where(x => x.Age < 18)
                .Average(x => x.Age);

            Console.WriteLine($"В) Средний возраст до 18 лет: {ageAverage}");

            Console.WriteLine();

            var namesByAgeAverage = list
                .GroupBy(p => p.Name)
                .ToDictionary(p => p.Key, p => p.Average(x => x.Age));

            var personsBetwen20To45 = list
                .Where(x => x.Age >= 20 && x.Age <= 45)
                .OrderByDescending(x => x.Age);

            foreach (var p in personsBetwen20To45)
            {
                Console.WriteLine(p.Name);
            }

            //Второе задание

            Console.WriteLine("Введите число: ");
            var count = Convert.ToInt32(Console.ReadLine());

            foreach (var d in GetSqrt().Take(count))
            {
                Console.WriteLine(d);
            }
        }
    }
}
