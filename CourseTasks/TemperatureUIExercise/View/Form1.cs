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

        public double InputDegree => throw new NotImplementedException();

        public event EventHandler<EventArgs> FarenheitSetted;
        public event EventHandler<EventArgs> CelsiusSetted;

        public void SetCelsius(double value)
        {
            throw new NotImplementedException();
        }

        public void SetFarenheit(double value)
        {
            throw new NotImplementedException();
        }

        public void SetTemperatureType(int value)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //inputDegreeComboBox.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondTemperaturetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstTemperaturetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputDegreeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void SetTemperatureType(TemperatureModel.TemperatureTypes value)
        {
            inputDegreeComboBox.SelectedIndex = (int)value;
        }
    }
}
