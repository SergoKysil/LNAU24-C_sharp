using LNAU24.View.NewsViews;
using LNAU24.View.UserViews;
using LNAU24.Views.NewsViews;
using System.Windows;
using System.Windows.Input;


namespace LNAU24.View.Main
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

        readonly ListNewsView magazine = new ListNewsView();
        
       

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
            UserSingIn sing_In = new UserSingIn
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
                
            } 
            else
            {
                this.WindowState = WindowState.Maximized;                
                grid_content_resize_max();
                
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
            AddNewNewsView add_news = new AddNewNewsView();
            add_news.Show();

        }
    }
}
