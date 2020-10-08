using Microsoft.Win32;

namespace WpfConvertWithMVVM.Model.Dialogs
{
    //The class implements opening a dialog box and getting a file.
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
