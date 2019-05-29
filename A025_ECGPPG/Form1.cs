using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace A025_ECGPPG
{
    public partial class Form1 : Form
    {
        Timer mytimer = new Timer();
        public Form1()
        {
            InitializeComponent();

            chart1.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            this.Text = "ECG/PPG by 유채연";

            EcgRead();
            PpgRead();

            mytimer.Interval = 10; // 0.01초
            mytimer.Tick += Mytimer_Tick;

        }

        int cursorX = 0; // 현재 그래프에 표시되는 데이터의 시작점

        private void Mytimer_Tick(object sender, EventArgs e)
        {
            if (cursorX + 500 <= ecgCount)
                chart1.ChartAreas["Draw"].AxisX.ScaleView.Zoom(cursorX, cursorX + 500);
            else
                mytimer.Stop();
            cursorX += 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                 
        }

        private void ChartSetting()
        {
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            chart1.ChartAreas.Add("Draw");
            chart1.ChartAreas["Draw"].BackColor = Color.Black;
            // x축
            chart1.ChartAreas["Draw"].AxisX.Minimum = 0;
            chart1.ChartAreas["Draw"].AxisX.Maximum = ecgCount; // ecgCount의 값이 ppgCount 보다 작기 때문
            chart1.ChartAreas["Draw"].AxisX.Interval = 50;
            chart1.ChartAreas["Draw"].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["Draw"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            // y축
            chart1.ChartAreas["Draw"].AxisY.Minimum = -3;
            chart1.ChartAreas["Draw"].AxisY.Maximum = 5; 
            chart1.ChartAreas["Draw"].AxisY.Interval = 0.5;
            chart1.ChartAreas["Draw"].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["Draw"].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            //series 추가
            chart1.Series.Add("ECG");
            chart1.Series["ECG"].ChartType = SeriesChartType.Line;
            chart1.Series["ECG"].Color = Color.LightGreen;
            chart1.Series["ECG"].BorderWidth = 2;
            chart1.Series["ECG"].LegendText = "ECG";

            chart1.Series.Add("PPG");
            chart1.Series["PPG"].ChartType = SeriesChartType.Line;
            chart1.Series["PPG"].Color = Color.Orange;
            chart1.Series["PPG"].BorderWidth = 2;
            chart1.Series["PPG"].LegendText = "PPG";

        }
        double[] ppg = new double[50000];
        int ppgCount;

        private void PpgRead()
        {
            string fileName = "../../Data/PPG.txt"; // 두 칸 위에 있다.
            string[] lines = File.ReadAllLines(fileName);

            //for (int i = 0; i < lines.Length; i++) // for문 쓰는 방법
            //{
            //    ppg[i] = double.Parse(lines[i]);
            //}
            // 최대값, 최소값 찾기
            double max = double.MaxValue;
            double min = double.MinValue;
            for (int i = 0; i < lines.Length; i++)
            {
                ppg[i] = double.Parse(lines[i]);
                if (ppg[i] > max)
                    max = ppg[i];
                else if (ppg[i] < min)
                    min = ppg[i];
            }
            ppgCount = lines.Length;
            string s = String.Format("PPG :Count = {0}, Min = {1}, Max = {2}",ppgCount, min, max);
            MessageBox.Show(s);
        }

        double[] ecg = new double[50000];
        int ecgCount;
        
        private void EcgRead()
        {
            string fileName = "../../Data/ecg.txt"; // 두 칸 위에 있다.
            string[] lines = File.ReadAllLines(fileName);

            //int i = 0;

            //foreach (var line in lines) // foreach 쓰는 방법
            //{
            //    ecg[i] = double.Parse(line);
            //    i++;
            //}
            //for (int i = 0; i < lines.Length; i++) // for문 쓰는 방법
            //{
            //    ecg[i] = double.Parse(lines[i]);
            //}
            // 최대값, 최소값 찾기
            double max = double.MaxValue;
            double min = double.MinValue;
            for(int i=0; i < lines.Length; i++)
            {
                ecg[i] = double.Parse(lines[i]) +3;
                if (ecg[i] > max)
                    max = ecg[i];
                else if (ecg[i] < min)
                    min = ecg[i];
            }
            ecgCount = lines.Length;
            string s = String.Format("ECG : Count = {0}, Min = {1}, Max = {2}", ecgCount, min, max);
            MessageBox.Show(s);
            //MessageBox.Show("ECG : Count = " + ecgCount + ", Min = " + min + ", Max = " + max);
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ChartSetting();
            foreach (var v in ecg)
                chart1.Series["ECG"].Points.Add(v);

            foreach (var v in ppg)
                chart1.Series["PPG"].Points.Add(v);

        }

        private void autoScrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mytimer.Start();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mytimer.Stop();
            chart1.ChartAreas["Draw"].AxisX.ScaleView.Zoom(0, ecgCount);
        }

        bool autoScrollFlag = false;
        private void chart1_Click(object sender, EventArgs e)
        {
            if (autoScrollFlag == false)
            {
                mytimer.Start();
                autoScrollFlag = true;
            }
            else
            {
                mytimer.Stop();
                autoScrollFlag = false;
            }
        }
    }
}
