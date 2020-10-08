using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using ConvertApiDotNet;
using NUnit.Framework;
using WpfConvertWithMVVM.Model.Dialogs;

namespace WpfConvertWithMVVM.Model.API
{
    class ApiWork
    {
        public delegate void DelegateComplete(bool result);
        public event DelegateComplete EventCompleteConvert;
        public bool IsConvertFile { get; private set; }

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
