﻿using System;
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
    /// UcSample2.xaml 的交互逻辑
    /// </summary>
    public partial class UcSample2 : UserControl
    {
        public UcSample2()
        {
            InitializeComponent();
        }

        public event EventHandler ChangeEvent;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ChangeEvent != null)
            {
                ChangeEvent(sender, new EventArgs());
            }
        }
    }
}
