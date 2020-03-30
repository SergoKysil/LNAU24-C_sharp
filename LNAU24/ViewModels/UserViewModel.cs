using LNAU24.Models;
using LNAU24.ViewModels.Base;
using System.Collections.Generic;
using System.Drawing;

namespace LNAU24.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        #region User

        public User _user;

        public string UserName
        {
            get => _user.UserName;
            set
            {
                _user.UserName = value;
                NotifyPropertyChanged("UserName");
            }
        }

        public string UserSurname
        {
            get => _user.UserSurname;
            set
            {
                _user.UserSurname = value;
                NotifyPropertyChanged("UserSurname");
            }
        }

        public string UserEmail
        {
            get => _user.UserEmail;
            set
            {
                _user.UserEmail = value;
                NotifyPropertyChanged("UserEmail");
            }
        }

        public Image UserImage
        {
            get => _user.UserImage;
            set
            {
                _user.UserImage = value;
                NotifyPropertyChanged("UserImage");
            }
        }

        public bool UserStatusIn
        {
            get => _user.StatusIn;
            set
            {
                _user.StatusIn = value;
                NotifyPropertyChanged("StatusIn");
            }
        }


        public List<User> _userList;
        public List<User> UsersList
        {
            get => _userList;
            set
            {
                _userList = value;
                NotifyPropertyChanged("UsersList");
            }
        }
        #endregion


    }
}
