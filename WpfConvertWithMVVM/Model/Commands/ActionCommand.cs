using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WpfConvertWithMVVM.Model.Commands.Base;

namespace WpfConvertWithMVVM.Model.Commands
{
    class ActionCommand : BaseCommand
    {
        private readonly Action<object> _Execute;
        private readonly Func<object, bool> _CanExecute;

        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;

        public override void Execute(object parameter) => _Execute(parameter);

        public ActionCommand(Action<object> execute, Func<object, bool> canexecute = null)
        {
            _Execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _CanExecute = canexecute;
        }
    }
}
