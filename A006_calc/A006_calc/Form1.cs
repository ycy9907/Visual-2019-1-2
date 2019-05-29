using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A006_calc
{
    public partial class Form1 : Form
    {
        private bool flag=false;
        private double saveValue=0;
        private char op;
        private double r;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNo1_Click(object sender, EventArgs e)
        {
            if( txtresult.Text=="0"||flag==true)
            {
                txtresult.Text = "1";
                flag = false;

            }
            else if(flag==false)
            {
                txtresult.Text += "1";
                
            }
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            flag = true;
            
            // 현재 txtresult에 있는 값을 나중에 계산하기 위해 저장해둔다
            saveValue = double.Parse(txtresult.Text);

            // 더하기 연산 중임을 저장해야 한다
            op = '+';

        }

        // savedValue와 현재 txtreult의 값을 op에 따라 계산한다.
        private void btnres_Click(object sender, EventArgs e)
        {
            double v = double.Parse(txtresult.Text);
            switch (op)
            {
                case '+':
                    r = saveValue + v;
                    break;
                case '-':
                    r = saveValue - v;
                    break;
                case '*':
                    r = saveValue * v;
                    break;
                case '/':
                    r = saveValue / v;
                    break;
                default:
                    return;

            }
            txtresult.Text = r.ToString();
        }

        private void btnNo2_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0" || flag == true)
            {
                txtresult.Text = "2";
                flag = false;

            }
            else if (flag == false)
            {
                txtresult.Text += "2";

            }
        }

        private void btnNo3_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0" || flag == true)
            {
                txtresult.Text = "3";
                flag = false;

            }
            else if (flag == false)
            {
                txtresult.Text += "3";

            }
        }

        private void btnNo4_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0" || flag == true)
            {
                txtresult.Text = "4";
                flag = false;

            }
            else if (flag == false)
            {
                txtresult.Text += "4";

            }
        }

        private void btnNo5_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0" || flag == true)
            {
                txtresult.Text = "5";
                flag = false;

            }
            else if (flag == false)
            {
                txtresult.Text += "5";

            }
        }

        private void btnNo6_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0" || flag == true)
            {
                txtresult.Text = "6";
                flag = false;

            }
            else if (flag == false)
            {
                txtresult.Text += "6";

            }
        }

        private void btnNo7_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0" || flag == true)
            {
                txtresult.Text = "7";
                flag = false;

            }
            else if (flag == false)
            {
                txtresult.Text += "7";

            }
        }

        private void btnNo8_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0" || flag == true)
            {
                txtresult.Text = "8";
                flag = false;

            }
            else if (flag == false)
            {
                txtresult.Text += "8";

            }
        }

        private void btnNo9_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0" || flag == true)
            {
                txtresult.Text = "9";
                flag = false;

            }
            else if (flag == false)
            {
                txtresult.Text += "9";

            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            flag = true;

            saveValue = double.Parse(txtresult.Text);

            op = '-';
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            flag = true;

            saveValue = double.Parse(txtresult.Text);

            op = '*';
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            flag = true;

            saveValue = double.Parse(txtresult.Text);

            op = '/';
        }

        private void bntdot_Click(object sender, EventArgs e)
        {
            if (txtresult.Text.Contains(".") == false)
                txtresult.Text += ".";
        }
    }
}
