using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace A023_Arduino
{
    public partial class Form1 : Form
    {
        private SerialPort sPort;
        private double xCount=200;
        List<SensorData> myData = new List<SensorData> ();
        Random r = new Random();
        Timer t = new Timer();
        SqlConnection conn;
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\konynag\Desktop\의료IT 유채연\Visual18615032\A023_Arduino\SensorData.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();

            // ComboBox
            foreach (var ports in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(ports);
            }
            comboBox1.Text = "Select Port";

            // 아두이노의 A0에서 받는 값의 범위
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1023;

            // 차트 모양 세팅
            ChartSetting();

            // 숫자 버튼
            btnPortValue.BackColor = Color.Blue;
            btnPortValue.ForeColor = Color.White;
            btnPortValue.Text = "";
            btnPortValue.Font = new Font("맑은 고딕", 16, FontStyle.Bold);

            label1.Text = "Connection Time : ";
            textBox1.TextAlign = HorizontalAlignment.Center;
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = false;
            
        }

        private void ChartSetting()
        {
            chart1.ChartAreas.Clear(); // 차트 객체가 하나 만들어지면 ChartArea 하나랑 series 하나가 들어가 있기 때문에 초기화
            chart1.ChartAreas.Add("draw");
            chart1.ChartAreas["draw"].AxisX.Minimum = 0;
            chart1.ChartAreas["draw"].AxisX.Maximum = xCount;   // 최초에 차트 폭은 200으로 함
            chart1.ChartAreas["draw"].AxisX.Interval = xCount / 4;
            chart1.ChartAreas["draw"].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas["draw"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas["draw"].AxisY.Minimum = 0;
            chart1.ChartAreas["draw"].AxisY.Maximum = 1024;
            chart1.ChartAreas["draw"].AxisY.Interval = 200;
            chart1.ChartAreas["draw"].AxisY.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas["draw"].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas["draw"].BackColor = Color.Blue;

            chart1.ChartAreas["draw"].CursorX.AutoScroll = true;

            chart1.ChartAreas["draw"].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas["draw"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            chart1.ChartAreas["draw"].AxisX.ScrollBar.ButtonColor = Color.LightSteelBlue;

            chart1.Series.Clear();
            chart1.Series.Add("PhotoCell");
            chart1.Series["PhotoCell"].ChartType = SeriesChartType.Line;
            chart1.Series["PhotoCell"].Color = Color.LightGreen;
            chart1.Series["PhotoCell"].BorderWidth = 3;
            if (chart1.Legends.Count > 0)
                chart1.Legends.RemoveAt(0); // Legends를 지운다.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            sPort = new SerialPort(cb.SelectedItem.ToString());
            // sPort.Open();
            // sPort.DataReceived += SPort_DataReceived;
            
            t.Interval = 1000;
            t.Start();
            t.Tick += T_Tick;

            label1.Text = "Connection Time : " + DateTime.Now.ToString();
            btnDisconnect.Enabled = true;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            //Random r = new Random();
            string s = r.Next(1024).ToString();
            this.BeginInvoke((new Action(delegate { ShowValue(s); })));
        }

        private void SPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string s = sPort.ReadLine();
            this.BeginInvoke((new Action(delegate { ShowValue(s); })));
        }

        private void ShowValue(string s)
        {
            int v = Int32.Parse(s);
            if (v < 0 || v > 1023)  // 처음 시작할 때 작은 값이나 큰 값이 들어오는 경우 배제
                return;

            SensorData data = new SensorData(
              DateTime.Now.ToShortDateString(),
              DateTime.Now.ToString("HH:mm:ss"), v);
            myData.Add(data);
            DBInsert(data);
            //데이터는 데이터 베이스랑 파일에 저장할 수 있다
            //데이터 베이스는 서버에 두고 씀 / 내 컴퓨터에서만 쓰는 DB는 Local DB라고 함
            textBox1.Text = myData.Count.ToString();    // myData의 갯수를 표시
            progressBar1.Value = v;

            // ListBox에 시간과 값을 표시
            string item = DateTime.Now.ToString() + "\t" + s;
            listBox1.Items.Add(item);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;  // 계속 스크롤이 되도록 처리

            // Chart 표시
            chart1.Series["PhotoCell"].Points.Add(v);

            // zoom을 위해 200개까지는 기본, 데이터 갯수가 많아지면 200개만 보이지만, 스크롤 나타남
            chart1.ChartAreas["draw"].AxisX.Minimum = 0;
            chart1.ChartAreas["draw"].AxisX.Maximum = (myData.Count >= xCount) ? myData.Count : xCount;

            // change chart range : Zoom 사용  
            if (myData.Count > xCount)
            {
                chart1.ChartAreas["draw"].AxisX.ScaleView.Zoom(myData.Count - xCount, myData.Count);
            }
            else
            {
                chart1.ChartAreas["draw"].AxisX.ScaleView.Zoom(0, xCount);
            }

            // 숫자버튼 표시
            btnPortValue.Text = /*sPort.PortName +*/ "\n" + s;
        }

        private void DBInsert(SensorData data)
        {
            string sql = string.Format("Insert into SensorTable" +
        "(Date, Time, Value) Values('{0}','{1}',{2})",
        data.Date, data.Time, data.Value);

            try
            {
                using (conn = new SqlConnection(connString))
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                 conn.Close();
                }
            
        }

        private void btnPortValue_Click(object sender, EventArgs e)
        {
            t.Interval = 100; // 100은 0.1초 1000은 1초
            t.Start();
            t.Tick += T_Tick;

            label1.Text = "Connection Time : " + DateTime.Now.ToString();
            btnDisconnect.Enabled = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            t.Stop();
        }
    }
}
