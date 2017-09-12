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
                //args = "update RXhhbXBsZQ== RTpcZ2l0c2VydmVyXEF1dG9VcGRhdGVyXEV4YW1wbGVcYmluXERlYnVnXFVwZGF0ZVxhZTVmYjg2My1lMDcxLTRiZDEtYWEyYy0zYTVkNDhiN2QyM2I= RTpcZ2l0c2VydmVyXEF1dG9VcGRhdGVyXEV4YW1wbGVcYmluXERlYnVnXA== 6L+c56iL5qGM6Z2i5bel5YW3 MS4wLjAuMTA= ICAgIDHjgIHkv67lpI0uLi4uLi4uLi4uDQogICAgMuOAgeS/ruWkjS4uLi4uLi4uLi4NCiAgICAz44CB5L+u5aSNLi4uLi4uLi4uLg0KICAgIDTjgIHkv67lpI0uLi4uLi4uLi4uDQogICAgNOOAgeS/ruWkjS4uLi4uLi4uLi4NCiAgICA044CB5L+u5aSNLi4uLi4uLi4uLg0KICAgIDTjgIHkv67lpI0uLi4uLi4uLi4uDQogICAgNOOAgeS/ruWkjS4uLi4uLi4uLi4NCiAgICA044CB5L+u5aSNLi4uLi4uLi4uLg0KICAgIDTjgIHkv67lpI0uLi4uLi4uLi4uDQogICAgNOOAgeS/ruWkjS4uLi4uLi4uLi4NCiAgICA044CB5L+u5aSNLi4uLi4uLi4uLg0KICA=".Split(' ');
                //string callExeName = args[1];
                //string updateFileDir = args[2];
                //string appDir = args[3];
                //string appName = args[4];
                //string appVersion = args[5];
                //string desc = args[6];

                ////Check If Have New Vision
                //Ezhu.AutoUpdater.App app = new Ezhu.AutoUpdater.App();
                //UI.DownFileProcess downUI = new UI.DownFileProcess(callExeName, updateFileDir, appDir, appName, appVersion, desc) { WindowStartupLocation = WindowStartupLocation.CenterScreen };
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
