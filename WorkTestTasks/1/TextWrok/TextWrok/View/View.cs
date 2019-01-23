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
        public View()
        {
            InitializeComponent();

            SetInputFileTextBox("D:\\123_in.txt");
            SetOutputTextBox("D:\\123_out.txt");
        }

        public string InputFileName => InputFileNameTextBox.Text;

        public string OutputFileName => OutputFileNameTextBox.Text;

        public bool IsPunctuationDelete => CheckBoxIsDeletePunctuation.Checked == true;

        public int MinWordLength => (int)WordMinLengthNumericUpDown.Value;

        public event EventHandler<EventArgs> ConvertText;

        private void ButtonFileOpen_Click(object sender, EventArgs e)
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
                }
            }
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
        }

        public void ShowResultText(string text)
        {
            if (OutputFileName == null)
            {
                throw new ArgumentNullException("OutputFile path is null");
            }
            using (var writer = new StreamWriter(OutputFileName))
            {
                writer.Write(text);
            }
        }

        public string GetText()
        {
            if (InputFileName == null)
            {
                throw new ArgumentNullException("InputFile path is null");
            }

            string resultText = null;

            try
            {
                using (var reader = new StreamReader(InputFileName))
                {
                    resultText = reader.ReadToEnd();
                }
            }
            catch (Exception)
            {
                Console.WriteLine();
                //throw;
            }

            return resultText;
        }
    }
}
