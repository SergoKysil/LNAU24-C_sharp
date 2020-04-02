using LNAU24.ViewModels.UserViewModels;
using System.Windows;
using System.Windows.Input;

namespace LNAU24.Views.UserViews
{
    /// <summary>
    /// Логика взаимодействия для UserSingUp.xaml
    /// </summary>
    public partial class UserSingUp : Window
    {
        public UserSingUp()
        {
            InitializeComponent();
            this.DataContext = new UserSingUpViewModel();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
