using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LNAU24.Base
{
    /// <summary>
    /// A base view model to change property
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        /// <summary>
        /// The action for run
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        
        
        /// <summary>
        /// The event that is fired when the <see cref="NotifyPropertyChanged(string)"/> value changed
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
