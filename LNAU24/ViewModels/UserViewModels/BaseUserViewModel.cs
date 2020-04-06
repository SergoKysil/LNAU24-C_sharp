using LNAU24.Models;
using LNAU24.Base;
using System.Drawing;
using FluentValidation;
using System.Collections.Generic;

namespace LNAU24.ViewModels.UserViewModels
{
    public class BaseUserViewModel : BaseViewModel
    {


        public IValidator _userValidator;


        #region User

        public User _user;

        public string UserName
        {
            get => _user.UserName;
            set
            {
                _user.UserName = value;
                NotifyPropertyChanged(nameof(UserName));
            }
        }

        public string UserSurname
        {
            get => _user.UserSurname;
            set
            {
                _user.UserSurname = value;
                NotifyPropertyChanged(nameof(UserSurname));
            }
        }

        public string UserEmail
        {
            get => _user.UserEmail;
            set
            {
                _user.UserEmail = value;
                NotifyPropertyChanged(nameof(UserEmail));
            }
        }

        public Image UserImage
        {
            get => _user.UserImage;
            set
            {
                _user.UserImage = value;
                NotifyPropertyChanged(nameof(UserImage));
            }
        }

        public bool UserStatusIn
        {
            get => _user.StatusIn;
            set
            {
                _user.StatusIn = value;
                NotifyPropertyChanged(nameof(UserStatusIn));
            }
        }


        public List<User> _userList;
        public List<User> UsersList
        {
            get => _userList;
            set
            {
                _userList = value;
                NotifyPropertyChanged(nameof(UsersList));
            }
        }
        #endregion


    }
}
