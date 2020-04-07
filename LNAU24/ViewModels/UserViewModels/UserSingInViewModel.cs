using LNAU24.Base;
using LNAU24.Models;
using LNAU24.Validator;
using LNAU24.Views.UserViews;
using System.Windows;
using System.Windows.Input;

namespace LNAU24.ViewModels.UserViewModels
{
    public class UserSingInViewModel : BaseUserViewModel
    {
        #region Public Commands
        /// <summary>
        /// The command to SingIn
        /// </summary>
        public ICommand SingInUserConfirmedCommand { get; private set; }

        /// <summary>
        /// The command if user forgot password
        /// </summary>
        public ICommand ForgotPasswordCommand { get; private set; }


        /// <summary>
        /// The command to open view to create user
        /// </summary>
        public ICommand CreateAccountCommand { get; private set; }

        /// <summary>
        /// THe command to close UserSingIn window
        /// </summary>
        public ICommand CloseWindowCommand { get; private set; }

        #endregion


        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public UserSingInViewModel()
        {
            _user = new User();
            _userValidator = new UserValidator();


            //Add function to commands
            SingInUserConfirmedCommand = new RelayCommand(SingInUserConfirmed);
            ForgotPasswordCommand = new RelayCommand(ForgotPassword);
            CreateAccountCommand = new RelayCommand(CreateAccount);
            CloseWindowCommand = new RelayCommand<Window>(CloseWindow);
        }
        #endregion


        #region SingIn
        /// <summary>
        /// The function that works when a SingInUserConfirmedCommand is called
        /// </summary>
        private void SingInUserConfirmed()
        {
            var validateResults = _userValidator.Validate(_user);

            if (validateResults.IsValid)
            {
                //TODO: Logic to sing in write here
            }
            else
            {
                //TODO: Some logic if login was failed
            }
        }

        #endregion


        #region Forgot Password
        /// <summary>
        /// The function that works when a ForgotPasswordCommand is called
        /// </summary>
        private void ForgotPassword()
        {
            //TODO Write some logic if click on forgot password
        }

        #endregion


        #region Create Account
        /// <summary>
        /// The function that works when a CreateAccountCommand is called
        /// </summary>
        private void CreateAccount()
        {
            UserSingUp w = new UserSingUp();
            w.ShowDialog();
        }

        #endregion

        #region Close Window
        /// <summary>
        /// The function that works where CloseWindowCommand is called
        /// </summary>
        /// <param name="window"></param>
        private void CloseWindow(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }
        #endregion


        #region Remember me
        //TODO: Thin how do this with secure

        #endregion
    }
}
