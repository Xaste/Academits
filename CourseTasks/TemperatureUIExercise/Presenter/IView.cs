using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureUIExercise
{
    public interface IView
    {
        void SetInputDegree(double value);

        void SetTemperatureType(TemperatureModel.TemperatureTypes value);

        void SetFirstLabel(string value);

        void SetSecondLabel(string value);

        void SetFirstResult(double value);

        void SetSecondResult(double value);

        double InputDegree { get; }

        event EventHandler<EventArgs> FarenheitSetted;

        event EventHandler<EventArgs> CelsiusSetted;

        event EventHandler<EventArgs> KelvinSetted;

        event EventHandler<EventArgs> InputDegreeSetted;

        event EventHandler<EventArgs> Convert;
    }
}
