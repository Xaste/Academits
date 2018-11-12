using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExercise
{
    class JsonExercise
    {
        static void Main(string[] args)
        {
            string input;
            using (var reader = new StreamReader("TextFile1.txt"))
            {
                input = reader.ReadLine();
            }

            var countries = JsonConvert.DeserializeObject<List<Country>>(input);

            var globalPopulation = 0;

            var currencyList = new HashSet<string>();

            foreach (var item in countries)
            {
                globalPopulation += item.Population;

                foreach (var currency in item.Currencies)
                {
                    if (!currencyList.Contains(currency.Name))
                    {
                        currencyList.Add(currency.Name);
                    }
                }
            }

            Console.WriteLine($"Население в файле: {globalPopulation}");

            Console.WriteLine();

            Console.WriteLine("Валюты:");

            foreach (var currency in currencyList)
            {
                Console.WriteLine(currency);
            }
        }
    }
}
