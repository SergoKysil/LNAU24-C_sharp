using MaterialDesignThemes.Wpf;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;

namespace LNAU24.controls.news
{
    
    public partial class add_news : Window
    {
        public add_news()
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
                    
                    Image image = new Image();
                    image.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(openFileDialog.FileName, UriKind.Absolute));
                    image.Margin = new Thickness(0,0,6,0);
                    image.Height = 85;
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

            System.Windows.Controls.Button button = new System.Windows.Controls.Button();
            button.VerticalAlignment = VerticalAlignment.Top;
            button.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
            button.Name = "Remove_btn";
            button.Background = System.Windows.Media.Brushes.DarkGray;
            button.BorderBrush = null;
            button.Width = 20;
            button.Height = 20;
            button.Content = icon;
            button.Padding = new Thickness(0);
            button.Margin = new Thickness(0,0,6,0);
            button.Cursor = System.Windows.Input.Cursors.Hand;
            return button;
        }

        private System.Windows.Forms.Control controlToRemove = null;
        private void file_add_Click(object sender, RoutedEventArgs e)
        {      
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Documents Files(*.doc;*.docx;*.xls;*.xlsx;*.ppt;.txt;*.zip;*.rar)|*.doc;*.docx;*.xls;*.xlsx;*.ppt;.txt;*.zip;*.rar";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                { 
                    Grid grid = new Grid();
                   
                    Image image = new Image();
                    image.Source = IconFromFile(openFileDialog.FileName);
                    image.Margin = new Thickness(0, 0, 6, 0);
                    image.Height = 65;
                    System.Windows.Controls.Label name_file = new System.Windows.Controls.Label();
                    name_file.Content = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                   
                    StackPanel stackPanel = new StackPanel();
                    stackPanel.Orientation = System.Windows.Controls.Orientation.Vertical;
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
