using System;
using System.Windows;

namespace Ezhu.AutoUpdater
{
    class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                //Ezhu.AutoUpdater.App app = new Ezhu.AutoUpdater.App();
                //UI.DownFileProcess downUI = new UI.DownFileProcess("", "", "","","","");
                //app.Run(downUI);


                //MessageBox.Show("无参数");
                //UI.DownFileProcess downUI = new UI.DownFileProcess();

                //Ezhu.AutoUpdater.App app = new Ezhu.AutoUpdater.App();
                //app.Run(downUI);
                return;
            }
            else if (args[0] == "update")
            {
                try
                {
                    //MessageBox.Show("外部更新");
                    string callExeName = args[1];
                    string updateFileDir = args[2];
                    string appDir = args[3];
                    string appName = args[4];
                    string appVersion = args[5];
                    string desc = args[6];

                    //Check If Have New Vision
                    Ezhu.AutoUpdater.App app = new Ezhu.AutoUpdater.App();
                    UI.DownFileProcess downUI = new UI.DownFileProcess(callExeName, updateFileDir, appDir, appName, appVersion, desc) { WindowStartupLocation = WindowStartupLocation.CenterScreen };
                    app.Run(downUI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
