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

namespace 翻转
{
    /// <summary>
    /// UcSample1.xaml 的交互逻辑
    /// </summary>
    public partial class UcSample1 : UserControl
    {
        public UcSample1()
        {
            InitializeComponent();
        }

        public event EventHandler CloseEvent;
        public event EventHandler ChangeEvent;

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeEvent != null)
            {
                ChangeEvent(sender, new EventArgs());
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            if (CloseEvent != null)
            {
                CloseEvent(sender, new EventArgs());
            }
        }
    }
}
