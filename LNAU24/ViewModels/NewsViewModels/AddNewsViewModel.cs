
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
        #region Fields
        /// <summary>
        /// This field was use to open file dialog with filters
        /// </summary>
        string Filter = null;
        #endregion

        #region Public Commands
        /// <summary>
        /// The command to add new news
        /// </summary>
        public ICommand SaveNewsCommand { get; private set; }

        /// <summary>
        /// The command to add images to news
        /// </summary>
        public ICommand AddImageCommand { get; private set; }

        /// <summary>
        /// The command to add some files to news
        /// </summary>
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
            Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png;*.jpeg;*.jfif)|*.bmp;*.jpg;*.gif;*.png;*.jpeg;*.jfif";
            OpenFilesDialog(Filter);
        }

        /// <summary>
        /// The functions that works when a AddFileCommand is called
        /// </summary>
        private void AddFile()
        {
            Filter = "Documents Files(*.doc;*.docx;*.xls;*.xlsx;*.ppt;.txt;*.zip;*.rar)|*.doc;*.docx;*.xls;*.xlsx;*.ppt;.txt;*.zip;*.rar";
            OpenFilesDialog(Filter);
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
            //TODO: logic to close this* window
        }

        #endregion


        #region Methods 

        private void OpenFilesDialog(string filter)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = filter;//;
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    //TODO: Some logic to add image
                    
                    //this logic was bad
                    //Grid grid = new Grid();

                    //Image image = new Image
                    //{
                    //    Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(openFileDialog.FileName, UriKind.Absolute)),
                    //    Margin = new Thickness(0, 0, 6, 0),
                    //    Height = 85
                    //};
                    //grid.Children.Add(image);
                    //grid.Children.Add(Get_button());
                    //Body_attached_files.Children.Add(grid);
                }
            }
            
        }
        #endregion


    }
}
