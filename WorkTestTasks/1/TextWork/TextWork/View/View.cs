﻿using System;
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

        public Stream GetInputTextStream()
        {
            if (InputFilePath == null)
            {
                throw new ArgumentNullException("InputFile path is null");
            }
            if (InputFilePath == string.Empty)
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
                return File.Open(InputFilePath, FileMode.Open, FileAccess.Read);
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

        public Stream GetOutputTextStream()
        {
            if (OutputFilePath == null)
            {
                throw new ArgumentNullException("OutputFilePath path is null");
            }
            if (OutputFilePath == string.Empty)
            {
                ShowMessage("Не указан путь к файлу для сохранения!", "Ошибка!");
                return null;
            }
            if (!Path.IsPathRooted(OutputFilePath))
            {
                ShowMessage($"Неверный путь файла \"{OutputFilePath}\"", "Ошибка!");
                return null;
            }

            try
            {
                return File.Open(OutputFilePath, FileMode.Create, FileAccess.Write);
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
