﻿using System;
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

namespace LNAU24.controls
{
    /// <summary>
    /// Логика взаимодействия для sing_up.xaml
    /// </summary>
    public partial class sing_up : Window
    {
        public sing_up()
        {
            InitializeComponent();
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
