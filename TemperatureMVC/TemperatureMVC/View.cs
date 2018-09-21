using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureMVC
{
    public partial class View : Form
    {
        Controller controller = new Controller();

        public View()
        {
            InitializeComponent();
        }
    }
}
