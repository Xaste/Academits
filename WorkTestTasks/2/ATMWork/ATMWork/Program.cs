using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMWork.Presenter;
using ATMWork.View;

namespace ATMWork
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new AtmInterface();
            var presenter = new ATMWork.Presenter.Presenter(view);
            Application.Run(view);
        }
    }
}
