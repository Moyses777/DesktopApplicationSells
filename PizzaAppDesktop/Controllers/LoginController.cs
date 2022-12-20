using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAppDesktop.Controllers
{
    public static class LoginController
    {
        public static bool ValidateAndLogIn(string username, string password)
        {
            return username == "Moises" && password == "123456";
        }
    }
}
