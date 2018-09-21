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
            _view.CelsiusSetted += OnSetCelsius;
            _view.FarenheitSetted += OnSetFarenheit;
            _view.KelvinSetted += OnSetKelvin;
            _view.InputDegreeSetted += OnSetDegree;
            _view.Convert += OnConvert;
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
            switch (_model.TemperatureType)
            {
                case TemperatureModel.TemperatureTypes.Celsius:
                    _model.ValueCelsius = _view.InputDegree;
                    break;
                case TemperatureModel.TemperatureTypes.Kelvin:
                    _model.ValueKelvin = _view.InputDegree;
                    break;
                case TemperatureModel.TemperatureTypes.Farenheit:
                    _model.ValueFarenheit = _view.InputDegree;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void OnConvert(object sender, EventArgs e)
        {
            switch (_model.TemperatureType)
            {
                case TemperatureModel.TemperatureTypes.Celsius:
                    _view.SetFirstLabel("Келвин");
                    _view.SetSecondLabel("Фаренгейт");

                    _view.SetFirstResult(_model.ValueKelvin);
                    _view.SetSecondResult(_model.ValueFarenheit);
                    break;
                case TemperatureModel.TemperatureTypes.Kelvin:
                    _view.SetFirstLabel("Цельсий");
                    _view.SetSecondLabel("Фаренгейт");

                    _view.SetFirstResult(_model.ValueCelsius);
                    _view.SetSecondResult(_model.ValueFarenheit);
                    break;
                case TemperatureModel.TemperatureTypes.Farenheit:
                    _view.SetFirstLabel("Цельсий");
                    _view.SetSecondLabel("Келвин");

                    _view.SetFirstResult(_model.ValueCelsius);
                    _view.SetSecondResult(_model.ValueKelvin);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void RefreshView()
        {
            _view.SetTemperatureType(_model.TemperatureType);

            switch (_model.TemperatureType)
            {
                case TemperatureModel.TemperatureTypes.Celsius:
                    _view.SetInputDegree(_model.ValueCelsius);
                    break;
                case TemperatureModel.TemperatureTypes.Farenheit:
                    _view.SetInputDegree(_model.ValueFarenheit);
                    break;
                case TemperatureModel.TemperatureTypes.Kelvin:
                    _view.SetInputDegree(_model.ValueKelvin);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
