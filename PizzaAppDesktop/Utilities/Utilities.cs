using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PizzaAppDesktop.Utilities
{
    public static class Utilities
    {
        public static void setErrorProvider(this ErrorProvider error, TextBox input, string message, bool isError)
        {
            if (isError) error.SetError(input, message);
            else error.SetError(input, "");
        }
    }
}
