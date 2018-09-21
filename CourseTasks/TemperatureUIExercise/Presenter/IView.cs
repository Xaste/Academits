using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureUIExercise
{
    public interface IView
    {
        void SetFarenheit(double value);

        void SetCelsius(double value);

        void SetTemperatureType(TemperatureModel.TemperatureTypes value);

        double InputDegree { get; }

        event EventHandler<EventArgs> FarenheitSetted;

        event EventHandler<EventArgs> CelsiusSetted;
    }
}
