using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WpfConvertWithMVVM.ViewModel;

namespace WpfConvertWithMVVM.Model.Commands
{
    class UpdateViewCommand : ICommand
    {
        private MainViewModel ViewModel;
        public UpdateViewCommand(MainViewModel viewmodel)
        {
            this.ViewModel = viewmodel;
        }
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
    }
}
