using FluentValidation;
using LNAU24.Base;
using LNAU24.Models;
using System.Collections.ObjectModel;
using System.Drawing;

namespace LNAU24.ViewModels.NewsViewModels
{
    public class BaseNewsViewModel : BaseViewModel
    {

        public IValidator _newsValidator;


        #region News

        public News _news;

        public string Title
        {
            get => _news.Title;
            set
            {
                _news.Title = value;
                NotifyPropertyChanged(nameof(Title));
            }
        }

        public string Body 
        { 
            get => _news.Body;
            set
            {
                _news.Body = value;
                NotifyPropertyChanged(nameof(Body));
            }
        }

        public int Views
        {
            get => _news.Views;
            set
            {
                _news.Views = value;
                NotifyPropertyChanged(nameof(Views));
            }
        }


        public string Author
        {
            get => _news.Author;
            set
            {
                _news.Author = value;
                NotifyPropertyChanged(nameof(Author));
            }
        }

        public ObservableCollection<string> Images
        {
            get => _news.Images;
            set
            {
                _news.Images = value;
                NotifyPropertyChanged(nameof(Images));
            }
        }

        public ObservableCollection<News> _newsList;
        public ObservableCollection<News> NewsList
        {
            get => _newsList;
            set
            {
                _newsList = value;
                NotifyPropertyChanged(nameof(NewsList));
            }
        }

        #endregion
    }
}
