using System;
using System.Windows;
using System.Windows.Input;

namespace LNAU24.Base
{
   /// <summary>
   /// Class to execute with parameters
   /// </summary>
   /// <typeparam name="T"></typeparam>
    public class RelayCommand<T> : ICommand
    {
        #region Private Members
        private readonly Predicate<T> _canExecute;
        private readonly Action<T> _execute;
        #endregion

        #region Constructors
        public RelayCommand(Action<T> execute)
           : this(execute, null)
        {
            _execute = execute;
        }

        public RelayCommand(Action<T> execute, Predicate<T> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException("execute");
            _canExecute = canExecute;
        }

        #endregion

        #region Command Methods

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute((T)parameter);
        }

        public void Execute(object parameter)
        {
            _execute((T)parameter);
        }

        #endregion

        #region Public Events
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        #endregion
    }

    /// <summary>
    /// Class for buttons execute
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Private Members
        /// <summary>
        /// The action for run
        /// </summary>
        private readonly Action mAction;

        #endregion


        #region Public Events
        /// <summary>
        /// The event thats fired when the <see cref="CanExecute(object)"/> value changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };


        #endregion


        #region Constructor 
        /// <summary>
        /// Default constructor
        /// </summary>
        public RelayCommand(Action action)
        {
            mAction = action;
        }
        #endregion


        #region Command Methods
        /// <summary>
        /// A relay command can always execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }
        /// <summary>
        /// Executes the commands Action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            mAction();
        }
        #endregion





    }
}
