using System;
using System.Windows.Input;

namespace WpfConvertWithMVVM.Model.Commands.Base
{
    //Create base command and implements icommand
    abstract class BaseCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);
    }
}
