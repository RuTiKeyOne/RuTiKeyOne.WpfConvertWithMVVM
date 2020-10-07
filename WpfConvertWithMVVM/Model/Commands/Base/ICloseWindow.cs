using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WpfConvertWithMVVM.Model.Commands.Base
{
    interface ICloseWindow
    {
        void CloseWindow(Window window);
    } 
}
