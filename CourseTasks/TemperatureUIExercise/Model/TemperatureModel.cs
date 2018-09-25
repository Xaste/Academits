using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureUIExercise
{
    public class TemperatureModel
    {
        private double _valueCelsius = 0;

        private readonly Dictionary<string, Func<double, double>[]> _temperatures = new Dictionary<string, Func<double, double>[]>()
        {
            ["Celsius"] = new Func<double, double>[2] { x => x, x => x },
            ["Kelvin"] = new Func<double, double>[2] { x => x + 273, x => x - 273 },
            ["Farenheit"] = new Func<double, double>[2] { x => x * 9 / 5 + 32, x => (x - 32) * 5 / 9 }

        };

        public Dictionary<string, Func<double, double>[]> Temperatures => _temperatures;

        public double ValueTemperature { get => _valueCelsius; set => _valueCelsius = value; }
    }
}
