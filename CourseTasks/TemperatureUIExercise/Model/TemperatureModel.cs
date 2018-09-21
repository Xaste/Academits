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
        private TemperatureTypes _temperatureType = TemperatureTypes.Kelvin;

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
            }
        }

        public double ValueFarenheit
        {
            get { return _valueFarenheit; }
            set
            {
                _valueFarenheit = value;
                _valueCelsius = (_valueFarenheit - 32) * 5 / 9;
            }
        }
    }
}
