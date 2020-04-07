
using LNAU24.Base;
using LNAU24.Models;
using LNAU24.Validator;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace LNAU24.ViewModels.NewsViewModels
{
    public class AddNewsViewModel : BaseNewsViewModel
    {


        #region Public Commands
        /// <summary>
        /// The command to add new news
        /// </summary>
        public ICommand SaveNewsCommand { get; private set; }

        /// <summary>
        /// The command to add images to news
        /// </summary>
        public ICommand AddImageCommand { get; private set; }


        public ICommand RemoveImageCommand { get; private set; }

        /// <summary>
        /// The command to add some files to news
        /// </summary>
        /// 
        public ICommand AddFileCommand { get; private set; }

        /// <summary>
        /// The command to close this window
        /// </summary>
        public ICommand CloseWindowCommand { get; private set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public AddNewsViewModel()
        {
            _newsValidator = new NewsValidator();
            _news = new News();



            SaveNewsCommand = new RelayCommand(SaveNews);
            AddImageCommand = new RelayCommand(AddImage);
            AddFileCommand = new RelayCommand(AddFile);
            CloseWindowCommand = new RelayCommand<Window>(CloseWindow);
            RemoveImageCommand = new RelayCommand<string>(RemoveImage);

        }

        #endregion

        #region Methods to commands
        /// <summary>
        /// The function that works when a SaveNewsCommand is called
        /// </summary>
        private void SaveNews()
        {
            var validateResults = _newsValidator.Validate(_news);
            if (validateResults.IsValid)
            {
                //TODO: Logic to save will be here
                System.Windows.MessageBox.Show("Successful save");
            }
            else
            {
                //If not valid
                System.Windows.MessageBox.Show(validateResults.Errors[0].ErrorMessage, "Додавання новини", MessageBoxButton.OK);
            }

        }

        /// <summary>
        /// The functions that works when a AddImageCommand is called
        /// </summary>
        private void AddImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png;*.jpeg;*.jfif)|*.bmp;*.jpg;*.gif;*.png;*.jpeg;*.jfif";
                openFileDialog.FilterIndex = 2;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach(var item in openFileDialog.FileNames)
                    {
                        _news.Images.Add(item);
                    }
                }
            }
        }

        private void RemoveImage(string image)
        {
            if (image != null)
            {
                _news.Images.Remove(image);
            }
        }

        /// <summary>
        /// The functions that works when a AddFileCommand is called
        /// </summary>
        private void AddFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Documents Files(*.doc;*.docx;*.xls;*.xlsx;*.ppt;.txt;*.zip;*.rar)|*.doc;*.docx;*.xls;*.xlsx;*.ppt;.txt;*.zip;*.rar";
                openFileDialog.FilterIndex = 2;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        /// <summary>
        /// The functions that works when a CloseWindowCommand is called
        /// </summary>
        private void CloseWindow(Window window)
        {
           
            if(window != null)
            {
                window.Close();
            }
        }

        #endregion




    }
}
