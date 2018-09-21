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
        private TemperatureTypes _temperatureType = TemperatureTypes.Celsius;

        public enum TemperatureTypes
        {
            Celsius,
            Kelvin,
            Farenheit
        }

        public TemperatureTypes TemperatureType
        {
            get { return _temperatureType; }
            set { _temperatureType = value; }
        }

        public double ValueCelsius
        {
            get { return _valueCelsius; }
            set
            {
                _valueCelsius = value;
                _valueFarenheit = _valueCelsius * 9 / 5 + 32;
                _valueKelvin = _valueCelsius + 273.15;
            }
        }

        public double ValueFarenheit
        {
            get { return _valueFarenheit; }
            set
            {
                _valueFarenheit = value;
                _valueCelsius = (_valueFarenheit - 32) * 5 / 9;
                _valueKelvin = _valueCelsius + 273.15;
            }
        }

        public double ValueKelvin
        {
            get { return _valueKelvin; }
            set
            {
                _valueKelvin = value;
                _valueCelsius = _valueKelvin - 273.15;
                _valueFarenheit = _valueCelsius * 9 / 5 + 32;
            }
        }
    }
}
