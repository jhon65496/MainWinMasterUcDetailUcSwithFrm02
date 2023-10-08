using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MainWinMasterUcDetailUcSwithFrm02.ViewModels;

namespace MainWinMasterUcDetailUcSwithFrm02
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            
            MainWindow mainmindow = new MainWindow();
            mainmindow.DataContext = mainWindowViewModel;
        }

    }
}
