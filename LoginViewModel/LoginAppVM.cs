using LoginModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace LoginViewModel
{
    public class LoginAppVM: ViewModelBase
    {



        #region Properties
        private string email;
        private object password;

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

        public object Password
        {
            get { return password; }
            set
            {
                if (password == value) return;
                password = value;
                onPropertyChanged("Password");
            }
        }

        #endregion


        public LoginAppVM()
        {
            //Popup codePopup = new Popup();
            //codePopup.VerticalAlignment 
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
        #endregion


        #region CommandExecute


        private void RegisterNewUser(object PasswordBox)
        {
            Task.Run(() => {
                var Parameters = Helpers.GenerateParameters(Email, PasswordBox);
                DataAccess.Instance.RegisterNewUser(Parameters);
            });

            CleanTextBox(PasswordBox);

        }


        #endregion



        private void CleanTextBox(object PasswordBox)
        {
            Email=string.Empty;
            ((PasswordBox)PasswordBox).Password=string.Empty;
        }



    }
}