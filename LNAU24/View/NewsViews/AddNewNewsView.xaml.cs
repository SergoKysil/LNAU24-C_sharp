using LNAU24.ViewModels.NewsViewModels;
using MaterialDesignThemes.Wpf;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;

namespace LNAU24.Views.NewsViews
{
    
    public partial class AddNewNewsView : Window
    {
        public AddNewNewsView()
        {
            InitializeComponent();
            DataContext = new AddNewsViewModel();
        }

  







        [System.Runtime.InteropServices.DllImport("gdi32")]
        static extern int DeleteObject(IntPtr o);
        public static System.Windows.Media.Imaging.BitmapSource loadBitmap(System.Drawing.Bitmap source)
        {
            IntPtr ip = source.GetHbitmap();
            System.Windows.Media.Imaging.BitmapSource bs;
            try
            {
                bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(ip,
                IntPtr.Zero, Int32Rect.Empty,
                System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
            }
            finally
            {
                DeleteObject(ip);
            }

            return bs;
        }

         public System.Windows.Media.ImageSource IconFromFile(string fileName)
        {
            var icon = System.Drawing.Icon.ExtractAssociatedIcon(fileName);
            var bmp = icon.ToBitmap();
            return loadBitmap(bmp);
        }



        public static System.Windows.Controls.Button Get_button()
        {
            var icon = new PackIcon
            {
                Kind = PackIconKind.Close,
                Foreground = System.Windows.Media.Brushes.White
            };

            System.Windows.Controls.Button button = new System.Windows.Controls.Button
            {
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Right,
                Name = "Remove_btn",
                Background = System.Windows.Media.Brushes.DarkGray,
                BorderBrush = null,
                Width = 20,
                Height = 20,
                Content = icon,
                Padding = new Thickness(0),
                Margin = new Thickness(0, 0, 6, 0),
                Cursor = System.Windows.Input.Cursors.Hand
            };
            return button;
        }


       

    }
}
