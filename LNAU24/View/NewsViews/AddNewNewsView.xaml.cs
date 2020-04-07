using LNAU24.ViewModels.NewsViewModels;
using System.Windows;
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


        private void title_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
