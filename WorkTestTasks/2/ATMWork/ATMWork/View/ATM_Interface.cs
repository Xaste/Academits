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

namespace ATMWork
{
    public partial class ATM_Interface : Form, IView
    {
        public int WithDrawSum => (int)numericUpDown_WithDrawSum.Value;

        public int PreferNominal => Convert.ToInt32(comboBox_WithDrawBankNotes.Text);

        private const int MAX_BANKNOTES_TYPES = 6;

        private List<int> _banknotesDenominations = new List<int>();

        public event EventHandler<ATMEventArgs> BankNoteAdded;
        public event EventHandler<EventArgs> WithDraw;

        public ATM_Interface()
        {
            InitializeComponent();

            comboBox_WithDrawBankNotes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void UpdateATMLoading(Dictionary<int, int> loadout, int maxCapacity)
        {
            for (int i = 0; i < flowLayoutPanel_BanknotesCapacity.Controls.Count; i++)
            {
                flowLayoutPanel_BanknotesCapacity.Controls[i].Text = $"{loadout[_banknotesDenominations[i]]}/{maxCapacity}";
            }
        }

        public void SetReadyATM(IList<int> col)
        {
            for (int i = 0; i < MAX_BANKNOTES_TYPES && i < col.Count; i++)
            {
                _banknotesDenominations.Add(col[i]);
                flowLayoutPanel_Banknotes.Controls[i].Text = col[i].ToString();
                comboBox_WithDrawBankNotes.Items.Add(col[i].ToString());
            }

            comboBox_WithDrawBankNotes.SelectedIndex = 0;
        }

        public void SetBalance(int balance)
        {
            textBox_Balance.Text = balance.ToString();
        }

        private void button_WithDraw_Click(object sender, EventArgs e)
        {
            WithDraw?.Invoke(this, EventArgs.Empty);
        }

        public void ShowMessage(string message, string caption)
        {
            MessageBox.Show(message, caption);
        }

        private void button_Banknote1_Click(object sender, EventArgs e)
        {
            BankNoteAdded?.Invoke(this, new ATMEventArgs(Convert.ToInt32(button_Banknote1.Text)));
        }

        private void button_Banknote2_Click(object sender, EventArgs e)
        {
            BankNoteAdded?.Invoke(this, new ATMEventArgs(Convert.ToInt32(button_Banknote2.Text)));
        }

        private void button_Banknote3_Click(object sender, EventArgs e)
        {
            BankNoteAdded?.Invoke(this, new ATMEventArgs(Convert.ToInt32(button_Banknote3.Text)));
        }

        private void button_Banknote4_Click(object sender, EventArgs e)
        {
            BankNoteAdded?.Invoke(this, new ATMEventArgs(Convert.ToInt32(button_Banknote4.Text)));
        }

        private void button_Banknote5_Click(object sender, EventArgs e)
        {
            BankNoteAdded?.Invoke(this, new ATMEventArgs(Convert.ToInt32(button_Banknote5.Text)));
        }

        private void button_Banknote6_Click(object sender, EventArgs e)
        {
            BankNoteAdded?.Invoke(this, new ATMEventArgs(Convert.ToInt32(button_Banknote6.Text)));
        }
    }
}
