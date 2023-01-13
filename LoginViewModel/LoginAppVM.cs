﻿using LoginModel;
using LoginViewModel.Utils;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace LoginViewModel
{
    public class LoginAppVM : ViewModelBase
    {



        #region Properties
        private string email;
        private string password;
        private PasswordBox loginpasswordBox;
        private bool popupVisibilitySuccess;
        private bool popupVisibilityError;
        private string errorMessage;
        private string successMessage;



        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                if (errorMessage == value) return;
                errorMessage = value;
                onPropertyChanged("ErrorMessage");
            }
        }

        public string SuccessMessage
        {
            get { return successMessage; }
            set
            {
                if (successMessage == value) return;
                successMessage = value;
                onPropertyChanged("SuccessMessage");
            }
        }



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


        public bool PopupVisibilitySuccess
        {
            get { return popupVisibilitySuccess; }
            set
            {
                if (popupVisibilitySuccess == value) return;
                popupVisibilitySuccess = value;
                onPropertyChanged("PopupVisibilitySuccess");
            }
        }


        public bool PopupVisibilityError
        {
            get { return popupVisibilityError; }
            set
            {
                if(popupVisibilityError == value) return;
                popupVisibilityError = value;
                onPropertyChanged("PopupVisibilityError");
            }
        }



        #endregion



        public Validations Util { get; set; }


        public LoginAppVM()
        {
            //Util = new Validations(this.Email);
        }


        #region Commands

        private ICommand signUp;
        private ICommand signIn;

        #endregion


        #region CommandExecute

        public ICommand SignUp
        {
            get
            {
                if (signUp == null)
                {
                    signUp = new RelayCommand(PasswordBox => this.RegisterNewUser2(PasswordBox));
                }
                return signUp;
            }
        }

        public ICommand SignIn
        {
            get
            {
                if (signIn == null)
                {
                    signIn = new RelayCommand(param => this.PopupExecute(param));
                }
                return signIn;
            }
        }

        DispatcherTimer timer = new DispatcherTimer();

        private void PopupExecute(object param)
        {


            
        }






        #endregion


        #region CommandExecute

        private void RegisterNewUser2(object PasswordBox)
        {
            Task.Run(() =>
            {


                Util = new Validations(Email, (PasswordBox)PasswordBox, this);


                if (!Util.IsEmailValid())
                {
                    ShowPopUpError("Email Inválido");
                    return;
                }


                if (!Util.ValidatePassword())
                {
                    var Parameters = Helpers.GenerateParameters(Email, PasswordBox);
                    DataAccess.Instance.RegisterNewUser(Parameters);
                    ShowPopUpSuccess("Registro Existoso!");
                }

                return;

            })
            .ContinueWith(t =>
            {
                this.CleanTextBox(PasswordBox);
            });



        }




        private void RegisterNewUser(object PasswordBox)
        {
            Task.Run(() =>
            {


                Util = new Validations(Email,(PasswordBox)PasswordBox,this);


                if (!Util.IsEmailValid())
                {
                    ShowPopUpError("Email Inválido");
                    return;
                }


                if (!Util.ValidatePassword())
                {
                    var Parameters = Helpers.GenerateParameters(Email, PasswordBox);
                    DataAccess.Instance.RegisterNewUser(Parameters);
                    ShowPopUpSuccess("Registro Existoso!");
                }

                return;
                    
            })
            .ContinueWith(t =>
            {
                this.CleanTextBox(PasswordBox);
            });



        }

        #endregion


        private bool Is



        private void CleanTextBox(object PasswordBox)
        {
            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                Email = string.Empty;
                ((PasswordBox)PasswordBox).Password = string.Empty;

            }));   
        }

        public void ShowPopUpError(string message)
        {
            ErrorMessage = message;

            PopupVisibilityError = true;

            timer.Interval = TimeSpan.FromSeconds(1.5);
            timer.Tick += new EventHandler(ErrorTimer_Tick);
            timer.Start();
        }


        public void ShowPopUpSuccess(string message)
        {
            SuccessMessage = message;// "Registro Existoso!";

            PopupVisibilitySuccess = true;

            timer.Interval = TimeSpan.FromSeconds(1.5);
            timer.Tick += new EventHandler(SuccessTimer_Tick);
            timer.Start();
        }




        public void ErrorTimer_Tick(object? sender, EventArgs e)
        {
            PopupVisibilityError = false;
            timer.Stop();
        }

        public void SuccessTimer_Tick(object? sender, EventArgs e)
        {
            PopupVisibilitySuccess = false;
            timer.Stop();
        }















    }
}