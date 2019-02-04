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
            InputFileNameTextBox.Text = "D:\\123_in.txt";
            OutputFileNameTextBox.Text = "D:\\123_out.txt";
        }

        public string InputFilePath => InputFileNameTextBox.Text;

        public string OutputFilePath => OutputFileNameTextBox.Text;

        public bool IsPunctuationDelete => CheckBoxIsDeletePunctuation.Checked;

        public int MinWordLength => (int)WordMinLengthNumericUpDown.Value;

        public event EventHandler<EventArgs> ConvertText;

        private void ButtonInputFileOpen_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Path.GetFullPath(Environment.CurrentDirectory);
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
                saveFileDialog.InitialDirectory = Path.GetFullPath(Environment.CurrentDirectory);
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
            if (OutputFilePath == String.Empty)
            {
                ShowMessage("Не указан путь к файлу для сохранения!", "Ошибка!");
                return;
            }

            if (!Path.IsPathRooted(OutputFilePath))
            {
                ShowMessage($"Неверный путь файла \"{OutputFilePath}\"", "Ошибка!");
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
            catch (IOException e)
            {
                ShowMessage(e.Message, "Ошибка!");
            }
            catch (UnauthorizedAccessException e)
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
            if (InputFilePath == String.Empty)
            {
                ShowMessage("Не указан путь к исходному файлу!", "Ошибка!");
                return null;
            }
            if (!Path.IsPathRooted(InputFilePath))
            {
                ShowMessage($"Неверный путь файла \"{InputFilePath}\"", "Ошибка!");
                return null;
            }

            try
            {
                string resultText = null;
                /*using (var reader = new StreamReader(InputFilePath, Encoding.Default))
                {
                    var line = reader.
                    resultText = reader.ReadToEnd();
                }

                return resultText;*/

                using (var fs = File.Open(InputFilePath, FileMode.Open, FileAccess.Read))
                {
                    using (var bs = new BufferedStream(fs, 1))
                    {
                        using (StreamReader sr = new StreamReader(bs))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                Console.WriteLine();
                            }
                        }
                    }
                }
                return resultText;
            }
            catch (IOException e)
            {
                ShowMessage(e.Message, "Ошибка!");
                return null;
            }
            catch (UnauthorizedAccessException e)
            {
                ShowMessage(e.Message, "Ошибка!");
                return null;
            }
        }
    }
}
