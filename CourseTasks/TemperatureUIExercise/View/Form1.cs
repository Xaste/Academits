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
        }

        public double InputDegree => (double)inputDegree.Value;

        public event EventHandler<EventArgs> FarenheitSetted;
        public event EventHandler<EventArgs> CelsiusSetted;
        public event EventHandler<EventArgs> KelvinSetted;
        public event EventHandler<EventArgs> InputDegreeSetted;
        public event EventHandler<EventArgs> Convert;

        private void button1_Click(object sender, EventArgs e)
        {
            Convert(this, EventArgs.Empty);
        }

        private void inputDegreeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inputDegreeComboBox.SelectedIndex == (int)TemperatureModel.TemperatureTypes.Celsius)
            {
                if (CelsiusSetted != null)
                {
                    CelsiusSetted(this, EventArgs.Empty);
                }
            }
            else if (inputDegreeComboBox.SelectedIndex == (int)TemperatureModel.TemperatureTypes.Kelvin)
            {
                if (KelvinSetted != null)
                {
                    KelvinSetted(this, EventArgs.Empty);
                }
            }
            else
            {
                if (FarenheitSetted != null)
                {
                    FarenheitSetted(this, EventArgs.Empty);
                }
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

        private void inputDegree_ValueChanged(object sender, EventArgs e)
        {
            InputDegreeSetted(this, EventArgs.Empty);
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
