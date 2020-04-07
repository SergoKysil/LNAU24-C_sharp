using LNAU24.Base;
using LNAU24.Models;
using LNAU24.Validator;
using System.Windows;
using System.Windows.Input;

namespace LNAU24.ViewModels.UserViewModels
{
    public class UserSingUpViewModel : BaseUserViewModel
    {
        #region Public Commands
        /// <summary>
        /// The command to confirm registration
        /// </summary>
        public ICommand SingUpUserConfirmed { get; private set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public UserSingUpViewModel()
        {
            _user = new User();
            _userValidator = new UserValidator();

            SingUpUserConfirmed = new RelayCommand(ConfirmedSingUp);

        }
        #endregion


        #region Confirmed Registration
        /// <summary>
        /// There will be some logic to confirmed
        /// </summary>
        private void ConfirmedSingUp()
        {
            var validateResults = _userValidator.Validate(_user);

            if (validateResults.IsValid)
            {
                // TODO: If the validate was successful some action will be here
                MessageBox.Show("Підтвердіть реєстрацію за вказаним вами E-mail", "Підтвердження реєстрації", MessageBoxButton.OK);
            }
            else
            {
                //If validate error
                MessageBox.Show(validateResults.Errors[0].ErrorMessage, "Підтвердження реєстрації", MessageBoxButton.OK);

            }
        }
        #endregion




    }
}
