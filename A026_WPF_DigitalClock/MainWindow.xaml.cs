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
using System.Windows.Threading;

namespace A026_WPF_DigitalClock
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer t = new DispatcherTimer();  // form이랑 다르다
        public MainWindow()
        {
            InitializeComponent();

            
            t.Interval = new TimeSpan(0, 0, 0, 0, 10); //100으로 하면 0.1초 10은 0.01초
            t.Tick += T_Tick;
            t.Start();

            DispatcherTimer t1 = new DispatcherTimer();
            t1.Interval = new TimeSpan(0, 0, 10); // 1분은 (0,1,0) 이건 10초
            t1.Tick += T1_Tick;
            t1.Start();

        }

        private void T1_Tick(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            dClock.Text = DateTime.Now.ToString() + DateTime.Now.Millisecond;
            string s = String.Format("{0}:{1,3:000}", DateTime.Now.ToString(), DateTime.Now.Millisecond);
            dClock.Text = s;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            t.Start();
        }
    }
}
