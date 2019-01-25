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
        private const int MAX_BANKNOTES_COUNT = 6;

        private List<int> _banknotesDenominations = new List<int>();

        public event EventHandler<EventArgs> BankNoteAdded;

        public ATM_Interface()
        {
            InitializeComponent();

            ReadBanknotesDenominations();
        }

        private void ReadBanknotesDenominations()
        {
            using (var reader = new StreamReader("Banknotes.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    _banknotesDenominations.Add(Convert.ToInt32(line));
                }

                for (int i = 0; i < MAX_BANKNOTES_COUNT && i < _banknotesDenominations.Count; i++)
                {
                    /*var button = new Button();

                    button.Name = "BankNote_" + _banknotesDenominations[i].ToString();
                    button.Text = _banknotesDenominations[i].ToString();

                    flowLayoutPanel1.Controls.Add(button);*/

                    flowLayoutPanel_Banknotes.Controls[i].Text = _banknotesDenominations[i].ToString();
                }
            }
        }

        private void button_Banknote1_Click(object sender, EventArgs e)
        {
            BankNoteAdded?.Invoke(this, EventArgs.Empty);//Передаем в событие номинал банкноты
        }

        private void button_Banknote2_Click(object sender, EventArgs e)
        {

        }

        private void button_Banknote3_Click(object sender, EventArgs e)
        {

        }

        private void button_Banknote4_Click(object sender, EventArgs e)
        {

        }

        private void button_Banknote5_Click(object sender, EventArgs e)
        {

        }

        private void button_Banknote6_Click(object sender, EventArgs e)
        {

        }
    }
}
