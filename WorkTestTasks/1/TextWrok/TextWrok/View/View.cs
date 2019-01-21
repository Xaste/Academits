using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextWrok
{
    public partial class View : Form, IView
    {
        //private string _inputFileName = null;

        //private string _outputFileName = null;

        public View()
        {
            InitializeComponent();
        }

        public string InputFileName => InputFileNameTextBox.Text;

        public string OutputFileName => OutputFileNameTextBox.Text;

        public bool IsPunctuationDelete => CheckBoxIsDeletePunctuation.Checked == true;

        public int MinWordLength => (int)WordMinLengthNumericUpDown.Value;

        //public event EventHandler<EventArgs> InputFileSelect;

        //public event EventHandler<EventArgs> OutputFileSelect;

        public event EventHandler<EventArgs> ConvertText;

        private void ButtonFileOpen_Click(object sender, EventArgs e)//TODO Не должен задавать значение в модель, только в текст бокс, а он уже в модель
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SetInputFileTextBox(openFileDialog.FileName);

                    //InputFileNameTextBox.Text = openFileDialog.FileName;
                }
            }

            /*if (_inputFileName != null)
            {
                SetInputFileTextBox(_inputFileName);

                //InputFileSelect?.Invoke(this, EventArgs.Empty);
            }*/
        }

        private void SetInputFileTextBox(string text)
        {
            InputFileNameTextBox.Text = text;
        }

        private void SetOutputTextBox(string text)
        {
            OutputFileNameTextBox.Text = text;
        }

        public void ShowMessage(string message, string caption)
        {
            MessageBox.Show(message, caption);
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            /*InputFileSelect?.Invoke(this, EventArgs.Empty);
            OutputFileSelect?.Invoke(this, EventArgs.Empty);*/

            ConvertText?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonOutputFileOpen_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SetOutputTextBox(saveFileDialog.FileName);                    
                }
            }

            //SetOutputTextBox(_outputFileName);

            //OutputFileSelect?.Invoke(this, EventArgs.Empty);
        }

        /*private void InputFileNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            InputFileSelect?.Invoke(this, EventArgs.Empty);
        }*/

        /*private void InputFileNameTextBox_TextChanged(object sender, EventArgs e)//Looks like to delete
        {
            InputFileSelect?.Invoke(this, EventArgs.Empty);
        }

        private void OutputFileNameTextBox_TextChanged(object sender, EventArgs e)//Looks like to delete
        {
            OutputFileSelect?.Invoke(this, EventArgs.Empty);
        }*/
    }
}
