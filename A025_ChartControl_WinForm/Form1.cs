﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace A025_ChartControl_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Chart Control in WinForm by 채연";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            // 추가
            chart1.ChartAreas.Add("Draw");
            chart1.ChartAreas["Draw"].BackColor = Color.Black;

            // x축 y축 설정
            chart1.ChartAreas["Draw"].AxisX.Minimum = -20;
            chart1.ChartAreas["Draw"].AxisX.Maximum = 20;
            chart1.ChartAreas["Draw"].AxisX.Interval = 2;
            chart1.ChartAreas["Draw"].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["Draw"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas["Draw"].AxisY.Minimum = -2;
            chart1.ChartAreas["Draw"].AxisY.Maximum = 2;
            chart1.ChartAreas["Draw"].AxisY.Interval = 0.5;
            chart1.ChartAreas["Draw"].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["Draw"].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // Series 추가(Sin)      
            chart1.Series.Add("Sin");
            chart1.Series["Sin"].ChartType = SeriesChartType.Line;
            chart1.Series["Sin"].Color = Color.LightGreen;
            chart1.Series["Sin"].BorderWidth = 2;
            chart1.Series["Sin"].LegendText = "sin(x)/x";

            // Series 추가(Cos)   
            chart1.Series.Add("Cos");
            chart1.Series["Cos"].ChartType = SeriesChartType.Line;
            chart1.Series["Cos"].Color = Color.Orange;
            chart1.Series["Cos"].BorderWidth = 2;
            chart1.Series["Cos"].LegendText = "cos(x)/x";

            for (double x = -20; x < 20; x += 0.1)
            {
                double y = Math.Sin(x) / x;
                chart1.Series["Sin"].Points.AddXY(x, y);

                y = Math.Cos(x) / x;
                chart1.Series["Cos"].Points.AddXY(x, y);
            }


        }
    }
}
