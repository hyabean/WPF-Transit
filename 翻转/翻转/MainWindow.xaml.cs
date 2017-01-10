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
using System.Windows.Media.Media3D;
using System.Windows.Media.Animation;

namespace 翻转
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
        // 支持标题栏拖动  
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // 获取鼠标相对标题栏位置  
            Point position = e.GetPosition(gridTitleBar);

            // 如果鼠标位置在标题栏内，允许拖动  
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (position.X >= 0 && position.X < gridTitleBar.ActualWidth && position.Y >= 0 && position.Y < gridTitleBar.ActualHeight)
                {
                    this.DragMove();
                }
            }
        }  

        private void OnClick(object sender, RoutedEventArgs e)
        {
            Button btn = e.OriginalSource as Button;
            if (btn != null)
            {
                string s = btn.Content.ToString();
                if (s == "关闭")
                {
                    this.Close();
                }
                DoubleAnimation da = new DoubleAnimation();
                da.Duration = new Duration(TimeSpan.FromSeconds(1));
                if (s == "向前")
                {
                    da.To = 0d;
                }
                else if (s == "向后")
                {
                    da.To = 180d;
                }
                this.axr.BeginAnimation(AxisAngleRotation3D.AngleProperty, da);
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UcSample1_OnChangeEvent(object sender, EventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation();
            da.Duration = new Duration(TimeSpan.FromSeconds(1));
                da.To = 180d;
            this.axr.BeginAnimation(AxisAngleRotation3D.AngleProperty, da);
        }

        private void UcSample1_OnCloseEvent(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UcSample2_OnChangeEvent(object sender, EventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation();
            da.Duration = new Duration(TimeSpan.FromSeconds(1));
            da.To = 0d;
            this.axr.BeginAnimation(AxisAngleRotation3D.AngleProperty, da);
        }
    }
}
