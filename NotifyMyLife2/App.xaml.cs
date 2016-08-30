using NotifyMyLife2.Models;
using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace NotifyMyLife2 {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application {
        private System.Threading.Timer timer;
        
        private NotifyIcon TrayIcon = new NotifyIcon();
        private Notification[] active = { };
        private MainWindow main;



        protected override void OnStartup(StartupEventArgs e) {
            main = new MainWindow();
            System.Windows.Forms.Application.ApplicationExit += new EventHandler(OnApplicationExit);
            InitializeTrayIcon();
             
            
        }
    private void InitializeNotificationTimers() {

    }
    private void InitializeTrayIcon() {
            TrayIcon.Visible = true;
            TrayIcon.BalloonTipIcon = ToolTipIcon.Info;
            TrayIcon.BalloonTipText = "I noticed you double clicked me!";
            TrayIcon.BalloonTipTitle = "Developed by Benjamin Kidd";
            TrayIcon.Text = "NotifyMyLife" + "\nActive Notifications: " + active.Length;

            TrayIcon.Icon = NotifyMyLife2.Properties.Resources.NotifyMyLife2;
            //optional doubleclick
            TrayIcon.DoubleClick += TrayIcon_DoubleClick;
            TrayIcon.ContextMenuStrip = new MenuContext().Initialize(main);

        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e) {
            TrayIcon.ShowBalloonTip(10000);
        }

        public void OnApplicationExit(object sender, EventArgs e) {
            main.CLOSE = true;
            TrayIcon.Visible = false;
            main.Close();
            
        }
    }
}
