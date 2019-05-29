using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A026_Test_DigitalClock
{
    
    public partial class Form1 : Form
    {
        Timer mytimer = new Timer();
        public Form1()
        {
            InitializeComponent();
       
            this.Text = "윈도우 디지털시계 by 유채연";
            mytimer.Interval = 10; // 0.01초
            mytimer.Tick += Mytimer_Tick;
            mytimer.Start();
            
        }

        private void Mytimer_Tick(object sender, EventArgs e)
        {
            dClock.Text = DateTime.Now.ToString() + DateTime.Now.Millisecond;
            string s = String.Format("{0}:{1,3:000}", DateTime.Now.ToString(), DateTime.Now.Millisecond);
            dClock.Text = s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
