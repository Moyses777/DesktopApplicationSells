using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaAppDesktop.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_cashier_Click(object sender, EventArgs e)
        {
            new Cashier().ShowDialog();
        }

        private void Dashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) btn_cashier_Click(null, null);
            if (e.KeyCode == Keys.F2) btn_employees_Click(null, null);
            if (e.KeyCode == Keys.F3) btn_credit_Click(null, null);
            if (e.KeyCode == Keys.F4) btn_categories_Click(null, null);
            if (e.KeyCode == Keys.F5) charging();
            if (e.KeyCode == Keys.F6) btn_sells_Click(null, null);
        }

        private async void charging()
        {
            Loading loader = new Loading();
            loader.Show();
            Task loading = new Task(() => Thread.Sleep(5000));
            loading.Start();
            await loading;
            loader.Close();
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            new EmployeesRegister().ShowDialog();
        }

        private void btn_credit_Click(object sender, EventArgs e)
        {
            new CreditSells().ShowDialog();
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            new Categories().ShowDialog();
        }

        private void btn_sells_Click(object sender, EventArgs e)
        {
            new Sells().ShowDialog();
        }
    }
}
