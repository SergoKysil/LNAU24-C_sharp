using LNAU24.Base;
using LNAU24.Models;
using LNAU24.Validator;
using System;
using System.Threading.Tasks;
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

        
        #region Default Constructor
        public UserSingUpViewModel()
        {
            _user = new User();
            _userValidator = new UserValidator();

            SingUpUserConfirmed = new RelayCommand(ConfirmedSingUp);

        }
        #endregion
        private void ConfirmedSingUp()
        {
            var validateResults = _userValidator.Validate(_user);

            if (validateResults.IsValid)
            {
                MessageBox.Show("Підтвердіть реєстрацію за вказаним вами E-mail", "Підтвердження реєстрації", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show(validateResults.Errors[0].ErrorMessage, "Підтвердження реєстрації", MessageBoxButton.OK);

            }
        }

       
    }
}
