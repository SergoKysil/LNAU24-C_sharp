using LNAU24.Models;
using LNAU24.Base;
using System.Drawing;
using FluentValidation;
using System.Collections.ObjectModel;

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


        public ObservableCollection<User> _userList;
        public ObservableCollection<User> UsersList
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
