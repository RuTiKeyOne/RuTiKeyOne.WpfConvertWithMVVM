using Microsoft.WindowsAPICodePack.Dialogs;

namespace WpfConvertWithMVVM.Model.Dialogs
{
    //The class implements opening a dialog box and getting a folder.
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
            return "No folder selected";
        }
    }
}
