using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Test2_AlgorithmChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Algorithm Control in WinForm by 채연";
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Timer t = new Timer();
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            // 추가
            chart1.ChartAreas.Add("Draw");
            chart1.ChartAreas["Draw"].BackColor = Color.Black;

            // x축 y축 설정
            chart1.ChartAreas["Draw"].AxisX.Minimum = 0;
            chart1.ChartAreas["Draw"].AxisX.Maximum = 100;
            chart1.ChartAreas["Draw"].AxisX.Interval = 20;
            chart1.ChartAreas["Draw"].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["Draw"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas["Draw"].AxisY.Minimum = 0;
            chart1.ChartAreas["Draw"].AxisY.Maximum = 100;
            chart1.ChartAreas["Draw"].AxisY.Interval = 20;
            chart1.ChartAreas["Draw"].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["Draw"].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // 시간 복잡도 설정
           
            // Series 추가(ln N)      
            chart1.Series.Add("lnN");
            chart1.Series["lnN"].ChartType = SeriesChartType.Line;
            chart1.Series["lnN"].Color = Color.LightGreen;
            chart1.Series["lnN"].BorderWidth = 2;
            chart1.Series["lnN"].LegendText = "lnN(x)/x";

            // Series 추가(N)   
            chart1.Series.Add("N");
            chart1.Series["N"].ChartType = SeriesChartType.Line;
            chart1.Series["N"].Color = Color.Orange;
            chart1.Series["N"].BorderWidth = 2;
            chart1.Series["N"].LegendText = "N(x)/x";

            // Series 추가(N^2)   
            chart1.Series.Add("N^2");
            chart1.Series["N^2"].ChartType = SeriesChartType.Line;
            chart1.Series["N^2"].Color = Color.Red;
            chart1.Series["N^2"].BorderWidth = 2;
            chart1.Series["N^2"].LegendText = "N^2(x)/x";

            // Series 추가(NlnN)   
            chart1.Series.Add("NlnN");
            chart1.Series["NlnN"].ChartType = SeriesChartType.Line;
            chart1.Series["NlnN"].Color = Color.Blue;
            chart1.Series["NlnN"].BorderWidth = 2;
            chart1.Series["NlnN"].LegendText = "NlnN(x)/x";

            for (double x = 0.1; x < 100; x += 0.1)
            {
                double y = Math.Log(Algorithm_lnN(100),2);
                chart1.Series["lnN"].Points.AddXY(x, y);

                y = Algorithm_N (100);
                chart1.Series["N"].Points.AddXY(x, y);

                y = Algorithm_N(100)*x;
                chart1.Series["N^2"].Points.AddXY(x, y);

                y =Math.Log( Algorithm_NlnN(100),2)*x;
                chart1.Series["NlnN"].Points.AddXY(x, y);


            }


        }
        //private void T_Tick(object sender, EventArgs e)
        //{
        //    //Random r = new Random();
        //    int s = Algorithm_N(100);
        //    this.BeginInvoke((new Action(delegate { Algorithm_N(s); })));
        //}
        // 시간 복잡도 함수
        private int Algorithm_lnN(int n)
        {
            int k = 0;
            // lnN
            while (n > 1) { 
                n = n / 2;
                k++;
            }
            return k;
        }
        private int Algorithm_N(int n)
        {
            int k = 0;
           for(int i=0;i<n;i++)
            {
                k = k + i;
            }
            return k;
        }
        private int Algorithm_N2(int n)
        {
            int k = 0;
            int sum = 0;
            // N^2
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    sum += i;
                    k++;
                }
            }
            return k;
        }
        private int Algorithm_NlnN(int n)
        {
            int k = 0;
            while (n > 1)
            {
                n = n / 2;
                k++;
            }
            return k;
        }

    }
}
