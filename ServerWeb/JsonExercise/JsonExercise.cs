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
            using (StreamReader reader = new StreamReader("TextFile1.txt"))
            {
                input = reader.ReadLine();
            }

            var countries = JsonConvert.DeserializeObject<List<Country>>(input);

            int globalPopulation = 0;

            int globalCurrency = 0;

            foreach (var item in countries)
            {
                globalPopulation += item.Population;
                globalCurrency += item.Currencies.Count;
            }

            Console.WriteLine($"Население в файле: {globalPopulation}");

            Console.WriteLine($"Валют: {globalCurrency}");
        }
    }
}
