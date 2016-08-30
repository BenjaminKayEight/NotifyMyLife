using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Drawing;
using NotifyMyLife2.Models;
using System.ComponentModel;

namespace NotifyMyLife2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private bool CLOSE=false;
        private NotifyIcon TrayIcon = new NotifyIcon();
        private Notification[] active = { };
        public MainWindow() {
            System.Windows.Forms.Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            InitializeComponent();
            InitializeTrayIcon();
            this.ShowInTaskbar = false;
           
            this.Hide();

        }
        private void InitializeTrayIcon() {
            TrayIcon.Visible = true;
            TrayIcon.BalloonTipIcon = ToolTipIcon.Info;
            TrayIcon.BalloonTipText = "I noticed you double clicked me!";
            TrayIcon.BalloonTipTitle = "Developed by Benjamin Kidd";
            TrayIcon.Text = "NotifyMyLife" + "\nActive Notifications: " + active.Length;

            TrayIcon.Icon = Properties.Resources.NotifyMyLife2;
            //optional doubleclick
            TrayIcon.DoubleClick += TrayIcon_DoubleClick;
            TrayIcon.ContextMenuStrip = new MenuContext().Initialize(this);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            

    
            
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e) {
            TrayIcon.ShowBalloonTip(10000);
        }

        private void OnApplicationExit(object sender, EventArgs e) {
            CLOSE = true;
            this.Close();
            TrayIcon.Visible = false;
            
        }
        protected override void OnStateChanged(EventArgs e) {
            if(WindowState == System.Windows.WindowState.Minimized) {
                this.Hide();
            }
        }
        protected override void OnClosing(CancelEventArgs e) {
            if (!CLOSE) {
                base.OnClosing(e);
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
