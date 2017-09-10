注：

压缩解压用到开源库SharpZipLib，官网: http://www.icsharpcode.net/OpenSource/SharpZipLib/Download.aspx
服务器上升级包的目录层次应该如下(假如要升级的运用程序为Test.exe):
　　Test(与exe的名字相同)

　　----update.xml

　　----update.zip

　　update.zip包用如下方式生成：

　　新建一个目录APP,将所用升级的文件拷贝到APP目录下，然后压缩APP文件夹为update.zip文件

升级服务器的路径配置写到Constants.cs类中。
使用方法如下，在要升级的运用程序项目的Main函数中，加上一行语句:
Ezhu.AutoUpdater.Updater.CheckUpdateStatus();
　　到此，一款简单的自动升级组件就完成了!
