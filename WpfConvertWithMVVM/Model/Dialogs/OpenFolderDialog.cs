using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfConvertWithMVVM.Model.Dialogs
{
    class OpenFolderDialog
    {
        public string SetFolder()
        {
            CommonOpenFileDialog CommonDialog = new CommonOpenFileDialog();
            CommonDialog.IsFolderPicker = true;
            switch(CommonDialog.ShowDialog()){
                case CommonFileDialogResult.Ok:
                    return CommonDialog.FileName;
            }
            throw new Exception();
        }
    }
}
