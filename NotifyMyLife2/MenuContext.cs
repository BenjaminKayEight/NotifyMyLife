using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyMyLife2 {
    class MenuContext {
        private ToolStripMenuItem CloseMenuItem,
            AddNewNotificationMenuItem,
            StopAllNotificationsMenuItem,
            EnableNotificationsMenuItem;
        private ContextMenuStrip TrayIconContextMenu;
        public ContextMenuStrip Initialize() {

            // optional icon menu   
            TrayIconContextMenu = new ContextMenuStrip();

            CloseMenuItem = new ToolStripMenuItem();
            AddNewNotificationMenuItem = new ToolStripMenuItem();
            StopAllNotificationsMenuItem = new ToolStripMenuItem();
            EnableNotificationsMenuItem = new ToolStripMenuItem();

            TrayIconContextMenu.SuspendLayout();

            //TrayIconContextMenu

            TrayIconContextMenu.Items.AddRange(new ToolStripItem[] {
                CloseMenuItem, AddNewNotificationMenuItem,
                StopAllNotificationsMenuItem,
                EnableNotificationsMenuItem
        });
            TrayIconContextMenu.Name = "TrayIconContextMenu";
            TrayIconContextMenu.Size = new System.Drawing.Size(153, 70);

            //closeMenuItem
            CloseMenuItem.Name = "CloseMenuItem";
            CloseMenuItem.Size = new System.Drawing.Size(152, 22);
            CloseMenuItem.Text = "Close NotifyMyLife";
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
        private void CloseMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Do You Really Want To Close Me?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                Application.Exit();
            }
        }
        private void AddNewNotificationMenuItem_Click(object sender, EventArgs e) {

        }
        private void StopAllNotificationsMenuItem_Click(object sender, EventArgs e) {

        }
        private void EnableNotificationsMenuItem_Click(object sender, EventArgs e) { }
    }
}
