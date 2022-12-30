using LoginModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace LoginViewModel
{
    public class LoginAppVM : ViewModelBase
    {



        #region Properties
        private string email;
        private string password;
        private PasswordBox loginpasswordBox;

        public string Email
        {
            get { return email; }
            set
            {
                if (email == value) return;
                email = value;
                onPropertyChanged("Email");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (password == value) return;
                password = value;
                onPropertyChanged("Password");
            }
        }

        public PasswordBox LoginPasswordBox
        {
            get { return loginpasswordBox; }
            set
            {
                if (loginpasswordBox == value) return;
                loginpasswordBox = value;
                onPropertyChanged("LoginPasswordBox");
            }
        }

        #endregion


        public LoginAppVM()
        {
            //Popup codePopup = new Popup();
            //codePopup.VerticalAlignment = VerticalAlignment.Center;
            //TextBlock popupText = new TextBlock();
            //popupText.Text = "Popup Text alskdjalskdjalskdjalskdjalskjdalskdjalskdj";
            //popupText.Background = Brushes.LightBlue;
            //popupText.Foreground = Brushes.Blue;
            //codePopup.Child = popupText;
            //codePopup.IsOpen = true;
        }


        #region Commands

        private ICommand signUp;

        #endregion


        #region CommandExecute

        public ICommand SignUp
        {
            get
            {
                if (signUp == null)
                {
                    signUp = new RelayCommand(PasswordBox => this.RegisterNewUser(PasswordBox));
                }
                return signUp;
            }
        }

        


        #region CommandExecute


        private void RegisterNewUser(object PasswordBox)
        {
            Task.Run(() =>
            {
                var Parameters = Helpers.GenerateParameters(Email, PasswordBox);
                DataAccess.Instance.RegisterNewUser(Parameters);
            })
            .ContinueWith(t =>
            {
                this.CleanTextBox(PasswordBox);
            });



        }


        #endregion



        #region CanExecute

        private bool ValidatePassword(object passwordBox)
        {
            LoginPasswordBox = ((PasswordBox)passwordBox);

           // if (IsPasswordLengthValid(LoginPasswordBox.Password))
                return false;
            //if (IsPasswordFormatValid(LoginPasswordBox))
            //    return false;
            return true;
        }
        #endregion


        #endregion






        private void CleanTextBox(object PasswordBox)
        {

            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                Email = string.Empty;
                ((PasswordBox)PasswordBox).Password = string.Empty;

            }));

            
        }

        private bool IsPasswordLengthValid(string currentPassword)
        {


            if (currentPassword.Length < 8)
                MessageBox.Show("Password muy corto");
                 return false;
            return true;
        }


        private bool IsPasswordFormatValid(object currentPassword)
        {
            //if(currentPassword.Contains(@"[1-9]"))
            //    return false;
            return true;
        }

    }
}