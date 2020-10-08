using System.Windows;
using WpfConvertWithMVVM.ViewModel;

namespace WpfConvertWithMVVM.Model.Dialogs
{
    //The class implements the creation and display of a notification for the user, which contains some kind of message.
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
