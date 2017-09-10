using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Example
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Startup += new StartupEventHandler(App_Startup);
        }
        void App_Startup(object sender, StartupEventArgs e)
        {
            Ezhu.AutoUpdater.Updater.CheckUpdateStatus();
        }
        
    }
}
