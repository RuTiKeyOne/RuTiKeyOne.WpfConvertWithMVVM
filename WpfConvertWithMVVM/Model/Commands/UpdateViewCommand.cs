using System;
using System.Windows.Input;
using WpfConvertWithMVVM.ViewModel;

namespace WpfConvertWithMVVM.Model.Commands
{
    //The class implements the Content Control update
    class UpdateViewCommand : ICommand
    {
        private MainViewModel ViewModel;

        #region ctor
        public UpdateViewCommand(MainViewModel viewmodel)
        {
            this.ViewModel = viewmodel;
        }
        #endregion

        #region UpdateViewCommand
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            switch (parameter)
            {
                case "OfficeToPdf":
                    ViewModel.SelectedViewModel = new OfficeToPdfViewModel();
                    break;
                case "ImagesToPdf":
                    ViewModel.SelectedViewModel = new ImagesToPdfViewModel();
                    break;
                case "EbookToPdf":
                    ViewModel.SelectedViewModel = new EbookToPdfViewModel();
                    break;
                case "PdfToText":
                    ViewModel.SelectedViewModel = new PdfToTextViewModel();
                    break;
            }
        }
        #endregion
    }
}
