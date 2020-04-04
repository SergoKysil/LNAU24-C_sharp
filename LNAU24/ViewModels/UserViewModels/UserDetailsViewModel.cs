using LNAU24.Base;
using LNAU24.Models;
using LNAU24.Validator;
using System.Windows.Input;

namespace LNAU24.ViewModels.UserViewModels
{
    public class UserDetailsViewModel : BaseUserViewModel
    {

        #region Public Commands
        /// <summary>
        /// The command to edit user details
        /// </summary>
        public ICommand EditUserDetailsCommand { get; private set; }


        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public UserDetailsViewModel()
        {
            _user = new User();
            _userValidator = new UserValidator();

            //TODO: Add functions to commands more
            EditUserDetailsCommand = new RelayCommand(EditDetails);

        }
        #endregion


        #region EditDetails
        /// <summary>
        /// THis function was use where EditUserDetailsCommand called
        /// </summary>
        private void EditDetails()
        {
            //TODO: Open new window for edit or edit on this window
        }
        #endregion



    }
}
