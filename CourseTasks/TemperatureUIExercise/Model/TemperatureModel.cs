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
        private double _valueFarenheit = 32;
        private double _valueKelvin = 273.15;

        public enum TemperatureTypes
        {
            Celsius,
            Kelvin,
            Farenheit
        }

        public TemperatureTypes TemperatureType { get; set; } = TemperatureTypes.Celsius;

        public double ValueCelsius
        {
            get => _valueCelsius;
            set
            {
                _valueCelsius = value;
                _valueFarenheit = _valueCelsius * 9 / 5 + 32;
                _valueKelvin = _valueCelsius + 273.15;
            }
        }

        public double ValueFarenheit
        {
            get => _valueFarenheit;
            set
            {
                _valueFarenheit = value;
                _valueCelsius = (_valueFarenheit - 32) * 5 / 9;
                _valueKelvin = _valueCelsius + 273.15;
            }
        }

        public double ValueKelvin
        {
            get => _valueKelvin;
            set
            {
                _valueKelvin = value;
                _valueCelsius = _valueKelvin - 273.15;
                _valueFarenheit = _valueCelsius * 9 / 5 + 32;
            }
        }
    }
}
