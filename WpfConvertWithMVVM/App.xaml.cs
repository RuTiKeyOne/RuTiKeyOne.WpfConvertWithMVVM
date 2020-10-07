using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfConvertWithMVVM.Model.Dialogs;
using WpfConvertWithMVVM.View;
using WpfConvertWithMVVM.ViewModel;

namespace WpfConvertWithMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal DisplayRootRegistry displayRootRegistry = new DisplayRootRegistry();

        MainViewModel MainWindowViewModel;

        public App()
        {
            displayRootRegistry.RegisterWindowType<MainViewModel, MainWindow>();
            displayRootRegistry.RegisterWindowType<MessageViewModel, MessageWindow>();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindowViewModel = new MainViewModel();

            await displayRootRegistry.ShowModalPresentation(MainWindowViewModel);

            Shutdown();
        }
    }
}
