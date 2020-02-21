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


        
       

       

        private void Exit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Title_prog_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
