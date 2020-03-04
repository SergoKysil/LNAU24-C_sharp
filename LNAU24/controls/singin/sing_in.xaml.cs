using LNAU24.controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LNAU24
{
    /// <summary>
    /// Логика взаимодействия для sing_in.xaml
    /// </summary>
    public partial class sing_in : Window
    {
        public sing_in()
        {
            InitializeComponent();
        }

        

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btn_Create_account_Click(object sender, RoutedEventArgs e)
        {
            Close();
            sing_up reg = new sing_up();
            reg.Show();
        }
    }
}
