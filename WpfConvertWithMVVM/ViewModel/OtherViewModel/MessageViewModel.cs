using GalaSoft.MvvmLight.CommandWpf;
using System.Windows;
using WpfConvertWithMVVM.Model.Commands.Base;
using WpfConvertWithMVVM.ViewModel.Base;

namespace WpfConvertWithMVVM.ViewModel
{
    public class MessageViewModel : BaseViewModel, ICloseWindow
    {
        private string message;
        public string Message
        {
            get => message;
            set
            {
                message = value;
                OnPropertyChanged(Message);
            }
        }

        #region ctors
        public MessageViewModel()
        {

        }
        public MessageViewModel(string message)
        {
            Message = message;
            this.CloseWindowCommand = new RelayCommand<Window>(this.CloseWindow);
        }
        #endregion

        #region Close window command
        public RelayCommand<Window> CloseWindowCommand { get; private set; }
        public void CloseWindow(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }
        #endregion
    }
}
