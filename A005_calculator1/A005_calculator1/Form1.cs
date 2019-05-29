using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A005_calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text == "" || txtnum2.Text == "")
            {
                MessageBox.Show("숫자 두 개를 다 입력하세요!");
                return;
            }
            double result = .0;
            double no1 = double.Parse(txtnum1.Text);
            double no2 = double.Parse(txtnum2.Text);
            result = no1 * no2;
            txtresult.Text = result.ToString();
            lblresult.Text = "(*)결과";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntadd_Click(object sender, EventArgs e)
        {
            if(txtnum1.Text==""|| txtnum2.Text == "")
            {
                MessageBox.Show("숫자 두 개를 다 입력하세요!");
                return;
            }
            double result = .0;
            double no1=double.Parse(txtnum1.Text);
            double no2 = double.Parse(txtnum2.Text);
            result = no1 + no2;
            txtresult.Text = result.ToString();
            lblresult.Text = "(+)결과";
            
        }

        private void bntsub_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text == "" || txtnum2.Text == "")
            {
                MessageBox.Show("숫자 두 개를 다 입력하세요!");
                return;
            }
            double result = .0;
            double no1 = double.Parse(txtnum1.Text);
            double no2 = double.Parse(txtnum2.Text);
            result = no1 - no2;
            txtresult.Text = result.ToString();
            lblresult.Text = "(-)결과";
        }

        private void bntdiv_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text == "" || txtnum2.Text == "")
            {
                MessageBox.Show("숫자 두 개를 다 입력하세요!");
                return;
            }
            double result = .0;
            double no1 = double.Parse(txtnum1.Text);
            double no2 = double.Parse(txtnum2.Text);
            result = no1 / no2;
            txtresult.Text = result.ToString("0.00");
            lblresult.Text = "(/)결과";
        }
    }
}
