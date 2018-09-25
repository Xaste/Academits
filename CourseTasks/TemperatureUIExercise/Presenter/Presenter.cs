using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureUIExercise
{
    public class Presenter
    {
        private readonly TemperatureModel _model = new TemperatureModel();
        private readonly IView _view;

        public Presenter(IView view)
        {
            _view = view;
            _view.AddTemperaturesInCombobox(_model.Temperatures);
            

            _view.FirstTemperatureSet += new EventHandler<EventArgs>(OnFirstTemperatureSetted);
            _view.SecondTemperatureSet += new EventHandler<EventArgs>(OnSecondTemperatureSetted);

            _view.FirstDegreeSet += new EventHandler<EventArgs>(OnFirstDegreeSetted);
            _view.SecondDegreeSet += new EventHandler<EventArgs>(OnSecondDegreeSetted);

            FillTemperatures();
        }

        private void FillTemperatures()
        {
            if (_model.Temperatures.Count > 2)
            {
                _view.FillTemperatures(0, 1);
            }
            else if (_model.Temperatures.Count == 1)
            {
                _view.FillTemperatures(0, 0);
            }
            else
            {
                throw new ArgumentException("Нет температур");
            }
        }

        private void OnFirstTemperatureSetted(object sender, EventArgs e)
        {
            _view.SetTemperatureDegree1(_model.Temperatures[_view.Temperature1][0](_model.ValueTemperature));
        }

        private void OnSecondTemperatureSetted(object sender, EventArgs e)
        {
            _view.SetTemperatureDegree2(_model.Temperatures[_view.Temperature2][0](_model.ValueTemperature));
        }

        private void OnFirstDegreeSetted(object sender, EventArgs e)
        {
            _model.ValueTemperature = _model.Temperatures[_view.Temperature1][1](_view.InputDegree1);
            OnSecondTemperatureSetted(this, EventArgs.Empty);
        }

        private void OnSecondDegreeSetted(object sender, EventArgs e)
        {
            _model.ValueTemperature = _model.Temperatures[_view.Temperature2][1](_view.InputDegree2);
            OnFirstTemperatureSetted(this, EventArgs.Empty);
        }
    }
}
