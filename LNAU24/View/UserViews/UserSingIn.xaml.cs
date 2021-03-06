﻿using LNAU24.ViewModels.UserViewModels;
using LNAU24.Views.UserViews;
using System.Windows;
using System.Windows.Input;

namespace LNAU24.View.UserViews
{
    /// <summary>
    /// Логика взаимодействия для sing_in.xaml
    /// </summary>
    public partial class UserSingIn : Window
    {
        public UserSingIn()
        {
            InitializeComponent();
            DataContext = new UserSingInViewModel();
        }



        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
