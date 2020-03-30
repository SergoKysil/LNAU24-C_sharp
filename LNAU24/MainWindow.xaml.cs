﻿using LNAU24.controls;
using LNAU24.controls.news;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace LNAU24
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            

            
        }
        
        void btn_menu_open_Click(object sender, RoutedEventArgs e)
        {
            btn_Close_menu.Visibility = Visibility.Visible;
            btn_Open_menu.Visibility = Visibility.Collapsed;           
        }

        void btn_menu_close_Click(object sender, RoutedEventArgs e)
        {
            btn_Close_menu.Visibility = Visibility.Collapsed;
            btn_Open_menu.Visibility = Visibility.Visible;        
        }

        readonly News magazine = new News();
        
       

       void Home_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if(grid_Content.Children == null)
                grid_Content.Children.Add(magazine);
            else
            {
                grid_Content.Children.Clear();
                grid_Content.Children.Add(magazine);
            }
        }

        private void Exit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Title_prog_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListViewItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            sing_in sing_In = new sing_in
            {
                Owner = this
            };
            sing_In.Show();

        }

        public void Fullscren_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;               
                grid_content_resize_norm();
                magazine.normal_news();
            } 
            else
            {
                this.WindowState = WindowState.Maximized;                
                grid_content_resize_max();
                magazine.maximazed_news();
            }

        }

        private void Minimized_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        void grid_content_resize_max()
        {
            grid_Content.Width = SystemParameters.PrimaryScreenWidth - 50;
            grid_Content.Height = SystemParameters.PrimaryScreenHeight - 50;
        }
        
        void grid_content_resize_norm()
        {
            grid_Content.Width = 1015;
            grid_Content.Height = 600;
        }

        private void ListViewItem_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            add_news add_news = new add_news();
            add_news.Show();

        }
    }
}
