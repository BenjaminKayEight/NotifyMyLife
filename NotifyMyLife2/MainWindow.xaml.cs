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

namespace NotifyMyLife2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private NotifyIcon TrayIcon = new NotifyIcon();
        private Notification[] active = { };
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            this.WindowState = System.Windows.WindowState.Minimized;
            TrayIcon.BalloonTipIcon = ToolTipIcon.Info;
            TrayIcon.BalloonTipText = "I noticed you double clicked me!";
            TrayIcon.BalloonTipTitle = "Developed by Benjamin Kidd";
            TrayIcon.Text = "NotifyMyLife" + "\nActive Notifications: " + active.Length;

            TrayIcon.Icon = Properties.Resources.NotifyMyLife2;
            //optional doubleclick
            TrayIcon.DoubleClick += TrayIcon_DoubleClick;
            TrayIcon.ContextMenuStrip = new MenuContext().Initialize();
        }
    }
}
