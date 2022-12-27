using LoginModel;
using System.Windows.Controls;
using System.Windows.Input;


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
            var Parameters = Helpers.GenerateParameters(Email, PasswordBox);
            DataAccess.Instance.RegisterNewUser(Parameters);
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