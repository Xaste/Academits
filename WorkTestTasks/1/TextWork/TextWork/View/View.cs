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
using TextWork.Presenter;

namespace TextWork.View
{
    public partial class View : Form, IView
    {
        public View()
        {
            InitializeComponent();
        }

        public string InputFilePath => InputFileNameTextBox.Text;

        public string OutputFilePath => OutputFileNameTextBox.Text;

        public bool IsPunctuationDelete => CheckBoxIsDeletePunctuation.Checked;

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
                saveFileDialog.InitialDirectory = $"{Path.GetPathRoot(Environment.SystemDirectory)}";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SetOutputTextBox(saveFileDialog.FileName);
                }
            }
        }

        public void ShowResultText(string text)
        {
            if (OutputFilePath == null)
            {
                throw new ArgumentNullException("OutputFile path is null");
            }


            if (!Path.IsPathRooted(OutputFilePath))
            {
                ShowMessage("Неверный путь файла!", "Ошибка!");
                return;
            }

            try
            {
                using (var writer = new StreamWriter(OutputFilePath))
                {
                    writer.Write(text);
                }

                ShowMessage("Конвертация текста выполненена.", "Готово!");
            }
            catch (Exception e)
            {
                ShowMessage(e.Message, "Ошибка!");
            }
        }

        public string GetText()
        {
            if (InputFilePath == null)
            {
                throw new ArgumentNullException("InputFile path is null");
            }

            if (!Path.IsPathRooted(InputFilePath))
            {
                ShowMessage("Неверный путь файла!", "Ошибка!");
                return null;
            }

            try
            {
                string resultText;
                using (var reader = new StreamReader(InputFilePath, Encoding.Default))
                {
                    resultText = reader.ReadToEnd();
                }

                return resultText;
            }
            catch (Exception e)
            {
                ShowMessage(e.Message, "Ошибка!");
                return null;
            }
        }
    }
}
