using LoginModel;
using System.Windows.Controls;
using System.Windows.Input;


namespace LoginViewModel
{
    public class LoginAppVM: ViewModelBase
    {



        #region Properties
        private string email;
        private string password;

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
                    signUp = new RelayCommand(param => this.RegisterNewUser(param)); 
                }
                return signUp;
            }
        }
        #endregion


        #region CommandExecute


        private void RegisterNewUser(object param)
        {
            var a = (PasswordBox)param;
            


            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@email", email);
            Parameters.Add("@Password", password);
            DataAccess.Instance.RegisterNewUser(Parameters);

        }


        #endregion


    }
}