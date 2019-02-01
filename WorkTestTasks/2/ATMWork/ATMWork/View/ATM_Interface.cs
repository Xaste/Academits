using ATMWork.View;
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

namespace ATMWork.View
{
    public partial class AtmInterface : Form, IView
    {
        public int WithDrawSum => (int)numericUpDown_WithDrawSum.Value;

        public int PreferNominal => Convert.ToInt32(comboBox_WithDrawBankNotes.Text);

        private const int MaxBankNotesTypes = 6;

        private readonly List<int> _banknotesDenominations = new List<int>();

        public event EventHandler<AtmEventArgs> BankNoteAdded;
        public event EventHandler<EventArgs> WithDraw;

        public AtmInterface()
        {
            InitializeComponent();

            comboBox_WithDrawBankNotes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void UpdateAtmLoading(Dictionary<int, int> atmLoad, int maxCapacity)
        {
            for (var i = 0; i < flowLayoutPanel_BanknotesCapacity.Controls.Count; i++)
            {
                if (i < atmLoad.Count)
                {
                    flowLayoutPanel_BanknotesCapacity.Controls[i].Text = $"{atmLoad[_banknotesDenominations[i]]}/{maxCapacity}";
                }
                else
                {
                    flowLayoutPanel_BanknotesCapacity.Controls[i].Text = String.Empty;
                    flowLayoutPanel_BanknotesCapacity.Controls[i].Enabled = false;
                }

            }
        }

        public void SetReadyAtm(IList<int> col)
        {
            for (var i = 0; i < MaxBankNotesTypes; i++)
            {
                if (i < col.Count)
                {
                    _banknotesDenominations.Add(col[i]);
                    flowLayoutPanel_Banknotes.Controls[i].Text = col[i].ToString();
                    comboBox_WithDrawBankNotes.Items.Add(col[i].ToString());
                }
                else
                {
                    flowLayoutPanel_Banknotes.Controls[i].Text = String.Empty;
                    flowLayoutPanel_Banknotes.Controls[i].Enabled = false;
                }

            }

            comboBox_WithDrawBankNotes.SelectedIndex = 0;
        }

        public void ShowBalance(int balance)
        {
            textBox_Balance.Text = balance.ToString();
        }

        private void Button_WithDraw_Click(object sender, EventArgs e)
        {
            WithDraw?.Invoke(this, EventArgs.Empty);
        }

        public void ShowMessage(string message, string caption)
        {
            MessageBox.Show(message, caption);
        }

        private void Button_Banknote1_Click(object sender, EventArgs e)
        {
            BankNoteAdded?.Invoke(this, new AtmEventArgs(Convert.ToInt32(button_Banknote1.Text)));
        }

        private void Button_Banknote2_Click(object sender, EventArgs e)
        {
            BankNoteAdded?.Invoke(this, new AtmEventArgs(Convert.ToInt32(button_Banknote2.Text)));
        }

        private void Button_Banknote3_Click(object sender, EventArgs e)
        {
            BankNoteAdded?.Invoke(this, new AtmEventArgs(Convert.ToInt32(button_Banknote3.Text)));
        }

        private void Button_Banknote4_Click(object sender, EventArgs e)
        {
            BankNoteAdded?.Invoke(this, new AtmEventArgs(Convert.ToInt32(button_Banknote4.Text)));
        }

        private void Button_Banknote5_Click(object sender, EventArgs e)
        {
            BankNoteAdded?.Invoke(this, new AtmEventArgs(Convert.ToInt32(button_Banknote5.Text)));
        }

        private void Button_Banknote6_Click(object sender, EventArgs e)
        {
            BankNoteAdded?.Invoke(this, new AtmEventArgs(Convert.ToInt32(button_Banknote6.Text)));
        }
    }
}
