using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WpfConvertWithMVVM.Model.Dialogs
{
    class OpenDialogAndGetFile
    {
        public string GetFile(string format)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = format;
            switch (Dialog.ShowDialog())
            {
                case true:
                    return Dialog.FileName;
                    break;
            };
            return "No file selected";
        }
    }
}
