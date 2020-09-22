using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using WpfConvertWithMVVM.Model.Commands;
using WpfConvertWithMVVM.Model.Dialogs;
using WpfConvertWithMVVM.ViewModel.Base;

namespace WpfConvertWithMVVM.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        #region Update View
        private BaseViewModel _SelectedViewModel = new StartViewModel();

        public BaseViewModel SelectedViewModel
        {
            get { return _SelectedViewModel; }
            set {
                _SelectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
        public ICommand UpdateViewCommand { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            OpenFileDialog = new ActionCommand(OnOpenFileDialogExecute, CanOpenFileDialogExecute);
            UpdateViewCommand = new UpdateViewCommand(this);
            this.CloseMain = new RelayCommand<Window>(this.CloseWindow);
        }
        #endregion

        public string _FileName{
            get => FileName;
            set
            {
                SetProperty(ref FileName, value);

            }
        }
        private string FileName;
        public ICommand OpenFileDialog { get; set; }
        public bool CanOpenFileDialogExecute(object parameter) => true;
        public void OnOpenFileDialogExecute(object parameter)
        {
            OpenDialogAndGetFile OpenObj = new OpenDialogAndGetFile();
            _FileName = OpenObj.GetFile((string)parameter);
        }

        public RelayCommand<Window> CloseMain { get; private set; }
        public void CloseWindow(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }
    }
}
