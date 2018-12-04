using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class TemperatureConversion
    {
        static void Main(string[] args)
        {
            Console.Write("Введите температуру в градусах Цельсия: ");
            double temperatureCelsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{temperatureCelsius:f2} в градусах Кельвинах: {ConvertCelsiusToKelvin(temperatureCelsius):f2}");
            Console.WriteLine($"{temperatureCelsius:f2} в градусах Фаренгейтата: {ConvertCelsiusToFahrenheit(temperatureCelsius):f2}");
        }

        public static double ConvertCelsiusToKelvin(double temperatureCelsius)
        {
            const double kelvinRatio = 273.15;
            return temperatureCelsius + kelvinRatio;
        }

        public static double ConvertCelsiusToFahrenheit(double temperatureCelsius)
        {
            const double coefficient1 = (double)9 / 5;
            const double coefficient2 = 32;
            return coefficient1 * temperatureCelsius + coefficient2;
        }
    }
}
