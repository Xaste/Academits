using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureUIExercise
{
    public class Presenter
    {
        private TemperatureModel _model = new TemperatureModel();
        private IView _view;

        public Presenter(IView view)
        {
            _view = view;
            _view.CelsiusSetted += new EventHandler<EventArgs>(OnSetCelsius);
            _view.FarenheitSetted += new EventHandler<EventArgs>(OnSetFarenheit);
            _view.KelvinSetted += new EventHandler<EventArgs>(OnSetKelvin);
            _view.InputDegreeSetted += new EventHandler<EventArgs>(OnSetDegree);
            _view.Convert += new EventHandler<EventArgs>(OnConvert);
            RefreshView();
        }

        private void OnSetCelsius(object sender, EventArgs e)
        {
            _model.TemperatureType = TemperatureModel.TemperatureTypes.Celsius;
            RefreshView();
        }

        private void OnSetFarenheit(object sender, EventArgs e)
        {
            _model.TemperatureType = TemperatureModel.TemperatureTypes.Farenheit;
            RefreshView();

        }

        private void OnSetKelvin(object sender, EventArgs e)
        {
            _model.TemperatureType = TemperatureModel.TemperatureTypes.Kelvin;
            RefreshView();
        }

        private void OnSetDegree(object sender, EventArgs e)
        {
            if (_model.TemperatureType is TemperatureModel.TemperatureTypes.Celsius)
            {
                _model.ValueCelsius = _view.InputDegree;
            }
            else if (_model.TemperatureType is TemperatureModel.TemperatureTypes.Kelvin)
            {
                _model.ValueKelvin = _view.InputDegree;
            }
            else
            {
                _model.ValueFarenheit = _view.InputDegree;
            }
        }

        public void OnConvert(object sender, EventArgs e)
        {
            if (_model.TemperatureType == TemperatureModel.TemperatureTypes.Celsius)
            {
                _view.SetFirstLabel("Келвин");
                _view.SetSecondLabel("Фаренгейт");

                _view.SetFirstResult(_model.ValueKelvin);
                _view.SetSecondResult(_model.ValueFarenheit);
            }
            else if(_model.TemperatureType == TemperatureModel.TemperatureTypes.Kelvin)
            {
                _view.SetFirstLabel("Цельсий");
                _view.SetSecondLabel("Фаренгейт");

                _view.SetFirstResult(_model.ValueCelsius);
                _view.SetSecondResult(_model.ValueFarenheit);
            }
            else
            {
                _view.SetFirstLabel("Цельсий");
                _view.SetSecondLabel("Келвин");

                _view.SetFirstResult(_model.ValueCelsius);
                _view.SetSecondResult(_model.ValueKelvin);
            }

        }

        private void RefreshView()
        {
            _view.SetTemperatureType(_model.TemperatureType);

            if (Equals(_model.TemperatureType, TemperatureModel.TemperatureTypes.Celsius))
            {
                _view.SetInputDegree(_model.ValueCelsius);
            }
            else if (Equals(_model.TemperatureType, TemperatureModel.TemperatureTypes.Farenheit))
            {
                _view.SetInputDegree(_model.ValueFarenheit);
            }
            else
            {
                _view.SetInputDegree(_model.ValueKelvin);
            }
        }
    }
}
