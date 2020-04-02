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
            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void title_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

 


        private void image_add_Click(object sender, RoutedEventArgs e)
        {
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png;*.jpeg;*.jfif)|*.bmp;*.jpg;*.gif;*.png;*.jpeg;*.jfif";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Grid grid = new Grid();

                    Image image = new Image
                    {
                        Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(openFileDialog.FileName, UriKind.Absolute)),
                        Margin = new Thickness(0, 0, 6, 0),
                        Height = 85
                    };
                    grid.Children.Add(image);
                    grid.Children.Add(Get_button());
                    Body_attached_files.Children.Add(grid);
                }
            }
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


        private void file_add_Click (object sender, RoutedEventArgs e)
        {      
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Documents Files(*.doc;*.docx;*.xls;*.xlsx;*.ppt;.txt;*.zip;*.rar)|*.doc;*.docx;*.xls;*.xlsx;*.ppt;.txt;*.zip;*.rar";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                { 
                    Grid grid = new Grid();

                    Image image = new Image
                    {
                        Source = IconFromFile(openFileDialog.FileName),
                        Margin = new Thickness(0, 0, 6, 0),
                        Height = 65
                    };
                    System.Windows.Controls.Label name_file = new System.Windows.Controls.Label
                    {
                        Content = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName)
                    };

                    StackPanel stackPanel = new StackPanel
                    {
                        Orientation = System.Windows.Controls.Orientation.Vertical
                    };
                    stackPanel.Children.Add(image);
                    stackPanel.Children.Add(name_file);

                    grid.Children.Add(stackPanel);
                    grid.Children.Add(Get_button());
                    Body_attached_files.Children.Add(grid); grid.Width = 20; grid.Height = 20; grid.Background = System.Windows.Media.Brushes.Red;
                    grid.Children.Clear();
                    grid.Background = System.Windows.Media.Brushes.Red;
                   
                    

                }
            }
               

        }




        private void Save_news_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
