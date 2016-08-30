using NotifyMyLife2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace NotifyMyLife2 {
    class MenuContext {
        private Window Main;
        private ToolStripMenuItem OpenSettingsMenuItem,
            CloseMenuItem,
            AddNewNotificationMenuItem,
            StopAllNotificationsMenuItem,
            EnableNotificationsMenuItem;
        private ContextMenuStrip TrayIconContextMenu;
        public ContextMenuStrip Initialize(Window main) {
            this.Main = main;

            // optional icon menu   
            TrayIconContextMenu = new ContextMenuStrip();

            OpenSettingsMenuItem = new ToolStripMenuItem();
            CloseMenuItem = new ToolStripMenuItem();
            AddNewNotificationMenuItem = new ToolStripMenuItem();
            StopAllNotificationsMenuItem = new ToolStripMenuItem();
            EnableNotificationsMenuItem = new ToolStripMenuItem();

            TrayIconContextMenu.SuspendLayout();

            //TrayIconContextMenu

            TrayIconContextMenu.Items.AddRange(new ToolStripItem[] {OpenSettingsMenuItem,
                CloseMenuItem, AddNewNotificationMenuItem,
                StopAllNotificationsMenuItem,
                EnableNotificationsMenuItem
        });
            TrayIconContextMenu.Name = "TrayIconContextMenu";
            TrayIconContextMenu.Size = new System.Drawing.Size(153, 70);

            //closeMenuItem
            OpenSettingsMenuItem.Name = "OpenSettingsMenuItem";
            OpenSettingsMenuItem.Size = new System.Drawing.Size(152, 22);
            OpenSettingsMenuItem.Text = "Open Settings";
            OpenSettingsMenuItem.Click += new EventHandler(OpenSettingsMenuItem_Click);

            CloseMenuItem.Name = "CloseMenuItem";
            CloseMenuItem.Size = new System.Drawing.Size(152, 22);
            CloseMenuItem.Text = "Close NotifyMyLife2";
            CloseMenuItem.Click += new EventHandler(CloseMenuItem_Click);

            AddNewNotificationMenuItem.Name = "AddNewNotificationMenuItem";
            AddNewNotificationMenuItem.Size = new System.Drawing.Size(152, 22);
            AddNewNotificationMenuItem.Text = "Add New Notification";
            AddNewNotificationMenuItem.Click += new EventHandler(AddNewNotificationMenuItem_Click);

            StopAllNotificationsMenuItem.Name = "StopAllNotificationsMenuItem";
            StopAllNotificationsMenuItem.Size = new System.Drawing.Size(152, 22);
            StopAllNotificationsMenuItem.Text = "Stop All Notifications";
            StopAllNotificationsMenuItem.Click += new EventHandler(StopAllNotificationsMenuItem_Click);

            EnableNotificationsMenuItem.Name = "EnableNotificationsMenuItem";
            EnableNotificationsMenuItem.Size = new System.Drawing.Size(152, 22);
            EnableNotificationsMenuItem.Text = "Enable All Notifications";
            EnableNotificationsMenuItem.Click += new EventHandler(EnableNotificationsMenuItem_Click);

            TrayIconContextMenu.ResumeLayout(false);
            return TrayIconContextMenu;
        }

        private void OpenSettingsMenuItem_Click(object sender, EventArgs e) {
            Main.Show();
            Main.WindowState = WindowState.Normal;
        }
        private void CloseMenuItem_Click(object sender, EventArgs e) {
            if (System.Windows.Forms.MessageBox.Show("Do You Really Want To Close Me?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                System.Windows.Forms.Application.Exit();
                
            }
        }
        private void AddNewNotificationMenuItem_Click(object sender, EventArgs e) {
            Notification bob = new Notification();
            if (Properties.Settings.Default.Notifications == null) {
                Properties.Settings.Default.Notifications = new List<Notification>();
            }
            Properties.Settings.Default.Notifications.Add(bob);

        }
        private void StopAllNotificationsMenuItem_Click(object sender, EventArgs e) {

        }
        private void EnableNotificationsMenuItem_Click(object sender, EventArgs e) { }
    }
}
