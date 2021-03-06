﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfConvertWithMVVM.Model.Dialogs;
using WpfConvertWithMVVM.Model.Internet;
using WpfConvertWithMVVM.View;
using WpfConvertWithMVVM.ViewModel;

namespace WpfConvertWithMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    //Creation of an initial window and checking the Internet connection.
    public partial class App : Application
    {
        internal DisplayRootRegistry displayRootRegistry = new DisplayRootRegistry();

        MainViewModel MainWindowViewModel;

        bool DoYouHaveInternetConnection;

        Internet InternetConnection = new Internet();

        //Initial window
        public App()
        {
            displayRootRegistry.RegisterWindowType<MainViewModel, MainWindow>();
            displayRootRegistry.RegisterWindowType<MessageViewModel, MessageWindow>();
        }

        //Check the internet connection
        protected override async void OnStartup(StartupEventArgs e)
        {
            if (DoYouHaveInternetConnection = InternetConnection.CheckConnection())
            {
                base.OnStartup(e);

                MainWindowViewModel = new MainViewModel();


                await displayRootRegistry.ShowModalPresentation(MainWindowViewModel);

                Shutdown();
            }
            else
            {
                Message MessageObj = new Message();
                MessageObj.ShowMessage("You don't have internet connection");
            }
        }
    }
}
