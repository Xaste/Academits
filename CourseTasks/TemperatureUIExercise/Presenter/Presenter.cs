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
            RefreshView();
        }

        private void OnSetCelsius(object sender, EventArgs e)
        {
            _model.ValueCelsius = _view.InputDegree;
            RefreshView();
        }

        private void OnSetFarenheit(object sender, EventArgs e)
        {
            _model.ValueFarenheit = _view.InputDegree;
            RefreshView();

        }

        private void RefreshView()
        {
            _view.SetTemperatureType(_model.TemperatureType);
            //_view.SetCelsius(_model.ValueCelsius);
            //_view.SetFarenheit(_model.ValueFarenheit);
        }
    }
}
