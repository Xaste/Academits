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

        public string InputFile => InputFileNameTextBox.Text;

        public string OutputFile => OutputFileNameTextBox.Text;

        public bool IsPunctuationDelete => CheckBoxIsDeletePunctuation.Checked == true;

        public int MinWordLength => (int)WordMinLengthNumericUpDown.Value;

        public event EventHandler<EventArgs> ConvertText;

        private void ButtonFileOpen_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = $"{Path.GetPathRoot(Environment.SystemDirectory)}";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
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
            if (OutputFile == null)
            {
                throw new ArgumentNullException("OutputFile path is null");
            }

            try
            {
                using (var writer = new StreamWriter(OutputFile))
                {
                    writer.Write(text);
                }

                ShowMessage("Конвертация текста выполненена.", "Готово!");
            }
            catch (Exception e)
            {
                ShowMessage(e.Message, "Ошибка!");
                return;
                //throw;
            }
            /*catch (FileNotFoundException e)
            {
                ShowMessage(e.Message, "Ошибка!");
                return;
            }
            catch (UnauthorizedAccessException e)
            {
                ShowMessage(e.Message, "Ошибка!");
                return;
            }
            catch (ArgumentException e)
            {
                ShowMessage(e.Message, "Ошибка!");
                return;
            }
            catch (Exception)
            {
                throw;
            }*/
        }

        public string GetText()
        {
            if (InputFile == null)
            {
                throw new ArgumentNullException("InputFile path is null");
            }

            try
            {
                string resultText;
                using (var reader = new StreamReader(InputFile, Encoding.Default))
                {
                    resultText = reader.ReadToEnd();
                }

                return resultText;
            }
            catch (FileNotFoundException e)
            {
                ShowMessage(e.Message, "Ошибка!");
                return null;
            }
            catch (UnauthorizedAccessException e)
            {
                ShowMessage(e.Message, "Ошибка!");
                return null;
            }
            catch (ArgumentException e)
            {
                ShowMessage(e.Message, "Ошибка!");
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
