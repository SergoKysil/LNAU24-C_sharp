using FluentValidation;
using LNAU24.Base;
using LNAU24.Models;
using System.Collections.Generic;
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
                NotifyPropertyChanged("Title");
            }
        }

        public string Body 
        { 
            get => _news.Body;
            set
            {
                _news.Body = value;
                NotifyPropertyChanged("Body");
            }
        }

        public int Views
        {
            get => _news.Views;
            set
            {
                _news.Views = value;
                NotifyPropertyChanged("Views");
            }
        }


        public string Author
        {
            get => _news.Author;
            set
            {
                _news.Author = value;
                NotifyPropertyChanged("Author");
            }
        }

        public List<Image> Images
        {
            get => _news.Images;
            set
            {
                _news.Images = value;
                NotifyPropertyChanged("Images");
            }
        }

        public List<News> _newsList;
        public List<News> NewsList
        {
            get => _newsList;
            set
            {
                _newsList = value;
                NotifyPropertyChanged("NewsList");
            }
        }

        #endregion
    }
}
