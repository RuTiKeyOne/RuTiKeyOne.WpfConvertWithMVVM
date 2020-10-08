using System;
using System.Threading.Tasks;
using ConvertApiDotNet;
using WpfConvertWithMVVM.Model.Dialogs;

namespace WpfConvertWithMVVM.Model.API
{
    //The class implements work with Convert Api, all work with files happens here
    class ApiWork
    {
        public delegate void DelegateComplete(bool result);
        public event DelegateComplete EventCompleteConvert;
        public bool IsConvertFile { get; private set; }

        //The main work with files happens here
        public async void ConvertFile(string fileName, string whereToSave, string expansion)
        {
            EventCompleteConvert += SetnAndShowMessage;

            await Task.Run(() =>
            {
                try{
                    var ConvertApi = new ConvertApi("zU0PbViExUse1d6W");
                    ConvertApi.ConvertFile($@"{fileName}", $@"{whereToSave}\ConvertedFile{expansion}");
                    IsConvertFile = true;

                }
                catch(Exception ex)
                {
                    IsConvertFile = false;
                }
                
            });
            EventCompleteConvert?.Invoke(IsConvertFile);

        }

        //Create a notification user
        public void SetnAndShowMessage(bool result)
        {
            Message MessageObj = new Message();
            if (result)
            {
                MessageObj.ShowMessage("Conversion completed successfully");

            }
            else
            {
                MessageObj.ShowMessage("Conversion failed");
            }        
        }
    }
}
