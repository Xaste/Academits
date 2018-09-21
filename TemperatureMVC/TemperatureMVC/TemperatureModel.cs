﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureMVC
{
    class TemperatureModel
    {
        private double _valueFahrenheit = 32;
        private double _valueCelsius = 0;

        public double valueFahrenheit
        {
            get { return _valueFahrenheit; }
            set
            {
                _valueFahrenheit = value;
                _valueCelsius = (_valueFahrenheit - 32) * 5 / 9;
            }
        }

        public double valueCelsius
        {
            get { return _valueCelsius; }
            set
            {
                _valueCelsius = value;
                _valueFahrenheit = _valueCelsius * 9 / 5 + 32;
            }
        }
    }
}
