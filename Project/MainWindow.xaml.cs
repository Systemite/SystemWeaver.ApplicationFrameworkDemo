using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Systemite.SystemWeaver.Controls.UserControls.Data;
using SystemWeaver.ApplicationFrameworkDemo.UserControls;

namespace SystemWeaver.ApplicationFrameworkDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var loginFilePath = Path.Combine(appDataPath, "login.xml");
            appControl.LoginInfoManager = new FileLoginInfoManager(loginFilePath);

            appControl.AddTab("Content", CreateContentControl, true);
        }

        private Control CreateContentControl()
        {
            return new ContentUserControl();
        }
    }
}
