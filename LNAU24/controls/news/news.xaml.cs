using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace LNAU24.controls
{

    public partial class news : UserControl
    {

      
        public news()
        {
            InitializeComponent();
        }

        int get_ratio(Image image)
        {
            double render = image.Width / image.Height;
            if (render < 1)
                return 1;
            else
                return 0;
        }

        void set_image_width_and_height_normal(Image image)
        {
            if (get_ratio(image) == 1)
                image.Width = 202;
            else
                image.Width = 408; image.Height = 270;
        }

        void set_image_width_and_height_maximiaze(Image image)
        {
            if (get_ratio(image) == 1)
            {
                image.Height = news1.Height;
                image.Width = news1.Width * 0.211;
            }
            else
            {
                image.Height = news2.Height;
                image.Width = news2.Width * 0.38;
            }
        }





        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage1 =  new BitmapImage(new Uri("/Resources/image/Tempnews/ing3.jpg", UriKind.Relative));
            img1.Source = bitmapImage1;
            this.img1.Height = bitmapImage1.PixelHeight;
            this.img1.Width = bitmapImage1.PixelWidth;
            set_image_width_and_height_normal(img1);
            title_news1.Text = "ASSHOLE";
            text_news1.Text = "20 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню0 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню0 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню0 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню0 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню0 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню0 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню0 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню0 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню0 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню0 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню0 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню0 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню0 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню0 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню0 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню подвигу учасників Революції Гідності";
            BitmapImage bitmapImage2 = new BitmapImage(new Uri("/Resources/image/Tempnews/photo.jpg", UriKind.Relative));
            img2.Source = bitmapImage2;
            this.img2.Height = bitmapImage2.Height;
            this.img2.Width = bitmapImage2.Width;
            set_image_width_and_height_normal(img2);
            title_news2.Text = "zrbqcm pfujkjdjr";
            text_news2.Text = "20 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню подвигу учасників Революції Гідності та пам'яті Героїв Небесної Сотні.20 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню подвигу учасників Революції Гідності та пам'яті Героїв Небесної Сотні. 20 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню подвигу учасників Революції Гідності та пам'яті Героїв Небесної Сотні. 20 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню подвигу учасників Революції Гідності та пам'яті Героїв Небесної Сотні. 20 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню подвигу учасників Революції Гідності та пам'яті Героїв Небесної Сотні. 20 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню подвигу учасників Революції Гідності та пам'яті Героїв Небесної Сотні. 20 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню подвигу учасників Революції Гідності та пам'яті Героїв Небесної Сотні. 20 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню подвигу учасників Революції Гідності та пам'яті Героїв Небесної Сотні. 20 лютого 2020 року біля пам'ятника Степану Бандері відбулося віче та поминальна панахида, присвячені вшануванню подвигу учасників Революції Гідності та пам'яті Героїв Небесної Сотні.  До всіх присутніх звернувся ректор Львівського національного аграрного університету Володимир Снітинський: «Ми зібралися сьогодні біля пам'ятника Степану Бандері, який для усіх українських борців за волю став символом незламності духу, його чин та ідея виховали покоління українців, які не бояться диких орд зі сходу, бо для них Україна – понад усе». ";
            normal_news();
        }
       
      
        public void maximazed_news()
        {
            this.Width = SystemParameters.PrimaryScreenWidth - 50;
            this.Height = SystemParameters.PrimaryScreenHeight - 50;
            news1.Width = SystemParameters.PrimaryScreenWidth - 50;
            news1.Height = SystemParameters.PrimaryScreenHeight/2 - 50;
            set_image_width_and_height_maximiaze(img1);
            content1.Width = SystemParameters.PrimaryScreenWidth - img1.Width - 125;           
            news2.Height = SystemParameters.PrimaryScreenHeight/2 - 70;
            news2.Width = SystemParameters.PrimaryScreenWidth - 50;
            set_image_width_and_height_maximiaze(img2);
            content2.Width = SystemParameters.PrimaryScreenWidth - img2.Width - 125;
            content2.Height = SystemParameters.PrimaryScreenWidth/2 - 50;
           
        }

        public void normal_news()
        {
            this.Width = 1015;
            this.Height = 600;
            news1.Width = 955;
            news1.Height = 270;
            news2.Width = 955;
            news2.Height = 270;           
            set_image_width_and_height_normal(img1);
            set_image_width_and_height_normal(img2);
            content1.Width = news1.Width - img1.Width - 10;
            content2.Width = news2.Width - img2.Width - 10;
        }

       

        private void Grid_LayoutUpdated(object sender, EventArgs e)
        {
           
        }
    }
}
