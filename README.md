# AutoUpdater
wpf自动在线更新程序


注：
此软件参考csdn上别人的示例 改进后的版本
压缩解压用到开源库SharpZipLib，官网: http://www.icsharpcode.net/OpenSource/SharpZipLib/Download.aspx
服务器上升级包的目录层次应该如下(假如要升级的运用程序为Test.exe):
　　Test(与exe的名字相同)

　　----update.xml

　　----update.zip

　　update.zip包用如下方式生成：

　  然后压缩程序文件为update.zip文件,里面不需要设置目录直接就是 exe dll等的列表

升级服务器的路径配置写到Constants.cs类中。
使用方法如下，在要升级的运用程序项目的Main函数中，加上一行语句:
Ezhu.AutoUpdater.Updater.CheckUpdateStatus();

