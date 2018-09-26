using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureUIExercise
{
    public interface IView
    {
        double InputDegree1 { get; }

        double InputDegree2 { get; }

        string Temperature1 { get; }

        string Temperature2 { get; }

        void SetTemperatureDegree1(double value);

        void SetTemperatureDegree2(double value);

        void AddTemperaturesInCombobox(Dictionary<string, Func<double, double>[]> value);

        void FillTemperatures(int index1, int index2);

        event EventHandler<EventArgs> FirstTemperatureSet;
        event EventHandler<EventArgs> SecondTemperatureSet;
        event EventHandler<EventArgs> FirstDegreeSet;
        event EventHandler<EventArgs> SecondDegreeSet;
    }
}
