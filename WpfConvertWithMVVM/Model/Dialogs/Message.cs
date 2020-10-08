using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using WpfConvertWithMVVM.Model.API;
using WpfConvertWithMVVM.ViewModel;

namespace WpfConvertWithMVVM.Model.Dialogs
{
    class Message
    {
        internal void ShowMessage(string message)
        {
            var DisplayRootRegistryFalse = (Application.Current as App).displayRootRegistry;
            var DataFalse = new MessageViewModel(message);
            DisplayRootRegistryFalse.ShowPresentation(DataFalse);
        }

    }
}
