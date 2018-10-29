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

namespace WPF_Demo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowStyle = WindowStyle.None;
            }
            else
            {
                this.WindowStyle = WindowStyle.SingleBorderWindow;                
            }
        }

        private void mainWindowDoubleclick(object sender, MouseButtonEventArgs e)
        {            
            if(this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void mainWindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "Escape")
            {
                this.WindowState = WindowState.Normal;
            }
        }
    }
}
