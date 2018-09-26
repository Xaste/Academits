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

        public double InputDegree1 => (double)temperatureDegree1.Value;
        public double InputDegree2 => (double)temperatureDegree2.Value;

        public string Temperature1 => (string)temperatureTypeComboBox1.SelectedItem;
        public string Temperature2 => (string)temperatureTypeComboBox2.SelectedItem;
 
        public event EventHandler<EventArgs> FirstTemperatureSet;
        public event EventHandler<EventArgs> SecondTemperatureSet;

        public event EventHandler<EventArgs> FirstDegreeSet;
        public event EventHandler<EventArgs> SecondDegreeSet;

        private void temperatureTypeComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            FirstTemperatureSet?.Invoke(this, EventArgs.Empty);
        }

        private void temperatureTypeComboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            SecondTemperatureSet?.Invoke(this, EventArgs.Empty);
        }

        public void SetTemperatureDegree1(double value)
        {
            temperatureDegree1.Value = (decimal)value;
        }

        public void SetTemperatureDegree2(double value)
        {
            temperatureDegree2.Value = (decimal)value;
        }

        public void AddTemperaturesInCombobox(Dictionary<string, Func<double, double>[]> value)
        {
            foreach (var item in value)
            {
                temperatureTypeComboBox1.Items.Add(item.Key);
                temperatureTypeComboBox2.Items.Add(item.Key);
            }
        }

        /*private void TemperatureDegree1_ValueChanged(object sender, EventArgs e)
        {
            FirstDegreeSetted(this, EventArgs.Empty);//TODO
        }*/

        /*private void temperatureDegree2_ValueChanged(object sender, EventArgs e)
        {
            SecondDegreeSetted(this, EventArgs.Empty);
        }*/

        public void FillTemperatures(int index1, int index2)
        {
            temperatureTypeComboBox1.SelectedIndex = index1;
            temperatureTypeComboBox2.SelectedIndex = index2;
        }

        private void temperatureDegree1_KeyUp(object sender, KeyEventArgs e)
        {
            FirstDegreeSetted(this, EventArgs.Empty);
        }

        private void temperatureDegree2_KeyUp(object sender, KeyEventArgs e)
        {
            SecondDegreeSetted(this, EventArgs.Empty);
        }
    }
}
