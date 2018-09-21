using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureUIExercise
{
    public partial class FormView : Form, IView
    {
        public FormView()
        {
            InitializeComponent();
            this.firstTemeratureLabel.Hide();
            this.secondTemeratureLabel.Hide();
        }

        public double InputDegree => (double)inputDegree.Value;

        public event EventHandler<EventArgs> FarenheitSetted;
        public event EventHandler<EventArgs> CelsiusSetted;
        public event EventHandler<EventArgs> KelvinSetted;
        public event EventHandler<EventArgs> InputDegreeSetted;
        public event EventHandler<EventArgs> Convert;

        private void button1_Click(object sender, EventArgs e)
        {
            firstTemeratureLabel.Show();
            secondTemeratureLabel.Show();

            Convert?.Invoke(this, EventArgs.Empty);
        }

        private void InputDegreeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (inputDegreeComboBox.SelectedIndex)
            {
                case (int)TemperatureModel.TemperatureTypes.Celsius:
                    CelsiusSetted?.Invoke(this, EventArgs.Empty);
                    break;
                case (int)TemperatureModel.TemperatureTypes.Kelvin:
                    KelvinSetted?.Invoke(this, EventArgs.Empty);
                    break;
                default:
                    FarenheitSetted?.Invoke(this, EventArgs.Empty);
                    break;
            }
        }

        public void SetTemperatureType(TemperatureModel.TemperatureTypes value)
        {
            inputDegreeComboBox.SelectedIndex = (int)value;
        }

        public void SetInputDegree(double value)
        {
            inputDegree.Value = (decimal)value;
        }

        private void InputDegree_ValueChanged(object sender, EventArgs e)
        {
            InputDegreeSetted?.Invoke(this, EventArgs.Empty);
        }

        public void SetFirstLabel(string value)
        {
            firstTemeratureLabel.Text = value;
        }

        public void SetSecondLabel(string value)
        {
            secondTemeratureLabel.Text = value;
        }

        public void SetFirstResult(double value)
        {
            firstResult.Value = (decimal)value;
        }

        public void SetSecondResult(double value)
        {
            SecondResult.Value = (decimal)value;
        }
    }
}
