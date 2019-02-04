using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMWork.View
{
    public partial class WithDrawInfo : Form
    {
        public Button WithDrawButton => buttonWithDraw;

        public WithDrawInfo()
        {
            InitializeComponent();
        }

        private void buttonWithDraw_Click(object sender, EventArgs e)
        {
            if (checkedListBox.CheckedItems.Count < 1)
            {
                MessageBox.Show("Выберите хотя бы 1 купюру", "Ошибка");
                return;
            }

            Close();
        }

        public void AddItemsToCheckBox(string[] str)
        {
            checkedListBox.Items.AddRange(str);
        }

        public string[] GetCheckedItems()
        {
            var result = new string[checkedListBox.CheckedItems.Count];
            for (int i = 0; i < checkedListBox.CheckedItems.Count; i++)
            {
                result[i] = (string)checkedListBox.CheckedItems[i];
            }

            return result;
        }
    }
}
