using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using ConvertApiDotNet;
using WpfConvertWithMVVM.Model.Dialogs;

namespace WpfConvertWithMVVM.Model.API
{
    class ApiWork
    {
        public async void ConvertFile(string fileName, string whereToSave, string expansion)
        {
            await Task.Run(() =>
            {
                try{
                    var ConvertApi = new ConvertApi("zU0PbViExUse1d6W");
                    ConvertApi.ConvertFile($@"{fileName}", $@"{whereToSave}\ConvertedFile{expansion}");
                }
                catch(Exception ex)
                {
                   //I have problem from STA and create new window
                }
            });

        }
    }
}
