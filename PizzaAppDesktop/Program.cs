using PizzaAppDesktop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaAppDesktop
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0)
            {
                Application.Run(new Dashboard());
                return;
            }
            Login login = new Login();
            login.ShowDialog();

            if (login.DialogResult == DialogResult.OK) Application.Run(new Dashboard());
        }
    }
}
