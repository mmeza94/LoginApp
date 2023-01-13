using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace LoginViewModel.Utils
{
    public class Validations
    {

        string Email { get; set; }
        PasswordBox passwordbox { get; set; }

        LoginAppVM loginAppVM { get; set; }

        string LoginPassword { get => passwordbox.Password; }

        public Validations(string Email, PasswordBox passwordbox, LoginAppVM loginAppVM)
        {

            this.Email = Email;
            this.passwordbox = passwordbox;
            this.loginAppVM = loginAppVM;
        }


        public bool IsEmailValid()
        {
            return Email.Contains(".com") && Email.Contains("@");
        }


        public bool ValidatePassword()
        {
            

            if (!IsPasswordLengthValid())
                return true;
            if (!IsPasswordNumberFormatValid())
                return true;
            if (!IsPasswordFormatValid())
                return true;
            return false;
        }


        public bool IsPasswordLengthValid()
        {
            if (LoginPassword.Length < 8)
            {
                loginAppVM.ShowPopUpError("Password demasiado corto");
                return false;
            }
            return true;
        }

        public bool IsPasswordNumberFormatValid()
        {
            if (!Regex.IsMatch(LoginPassword, @"[1-9]"))
            {
                loginAppVM.ShowPopUpError("Debe contener un número");
                return false;
            }
            return true;
        }

        public bool IsPasswordFormatValid()
        {
            if (!Regex.IsMatch(LoginPassword, @"[A-Z]"))
            {
                loginAppVM.ShowPopUpError("Debe contener una mayúscula");
                return false;
            }
            return true;
        }




        


    }
}
