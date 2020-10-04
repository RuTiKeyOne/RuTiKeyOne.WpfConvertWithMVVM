using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using WpfConvertWithMVVM.Model.Api_Work;
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
            OpenFolderDialog = new ActionCommand(OnOpenFolderDialog, CanOpenFolderDialog);
            ConvertCommand = new ActionCommand(OnConvertCommand, CanConvertCommand);
            UpdateViewCommand = new UpdateViewCommand(this);
            this.CloseMain = new RelayCommand<Window>(this.CloseWindow);
        }
        #endregion

        public string FileName {
            get => fileName;
            set
            {
                SetProperty(ref fileName, value);

            }
        }
        private string fileName;

        #region OpenFileDialogCommand
        public ICommand OpenFileDialog { get; set; }
        public bool CanOpenFileDialogExecute(object parameter) => true;
        public void OnOpenFileDialogExecute(object parameter)
        {
            OpenDialogAndGetFile OpenObj = new OpenDialogAndGetFile();
            FileName = OpenObj.GetFile((string)parameter);
        }
        #endregion

        public string FolderName {
            get => folderName;
            set
            {
                SetProperty(ref folderName, value);
            }
        }
        private string folderName;

        public ICommand OpenFolderDialog { get; set; }

        private bool CanOpenFolderDialog(object parameter) => true;
        public void OnOpenFolderDialog(object parameter)
        {
            OpenFolderDialog SetFolderObj = new OpenFolderDialog();
            FolderName = SetFolderObj.SetFolder();
        }


        public RelayCommand<Window> CloseMain { get; private set; }
        public void CloseWindow(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }

        public ICommand ConvertCommand { get; set; }

        private bool CanConvertCommand(object sender) => FileName != null && FolderName != null && FileName != "No file selected" && FolderName != "No folder selected";
        public void OnConvertCommand(object sender)
        {
            ApiWork WorkObj = new ApiWork();
            WorkObj.ConvertFile(FileName, FolderName, (string)sender);
        }
    }
}
