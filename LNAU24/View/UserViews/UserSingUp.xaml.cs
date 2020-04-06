using LNAU24.ViewModels.UserViewModels;
using System.Windows;

namespace LNAU24.Views.UserViews
{

    public partial class UserSingUp : Window
    {
        public UserSingUp()
        {
            InitializeComponent();
            this.DataContext = new UserSingUpViewModel();
        }


        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
