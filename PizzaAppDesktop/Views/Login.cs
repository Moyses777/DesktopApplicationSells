using PizzaAppDesktop.Controllers;
using PizzaAppDesktop.Utilities;
using PizzaAppDesktop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaAppDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            user_error.setErrorProvider(user_input, "Se agrego mal el usuario!", user_input.TextLength == 0);
            password_error.setErrorProvider(password_input, "Se agrego mal la contraseña", password_input.TextLength == 0);
            if (user_input.TextLength != 0 && password_input.TextLength != 0)
            {
                if(LoginController.ValidateAndLogIn(user_input.Text, password_input.Text))
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode) btn_validate_Click(null, null);
        }
    }
}
