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
        public bool CLOSE = false;
        
        public MainWindow() {
            InitializeComponent();
            
            this.ShowInTaskbar = false;
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
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
