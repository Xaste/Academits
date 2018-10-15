using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureUIExercise
{
    public class TemperatureModel
    {
        public Dictionary<string, Func<double, double>[]> Temperatures { get; } = new Dictionary<string, Func<double, double>[]>()
        {
            ["Celsius"] = new Func<double, double>[2] { x => x, x => x },
            ["Kelvin"] = new Func<double, double>[2] { x => x + 273, x => x - 273 },
            ["Fahrenheit"] = new Func<double, double>[2] { x => x * 9 / 5 + 32, x => (x - 32) * 5 / 9 }

        };

        public double ValueTemperature { get; set; } = 0;
    }
}
