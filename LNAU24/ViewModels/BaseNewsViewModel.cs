using LNAU24.Base;
using LNAU24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNAU24.ViewModels
{
    public class BaseNewsViewModel : BaseViewModel
    {
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

        #endregion
    }
}
