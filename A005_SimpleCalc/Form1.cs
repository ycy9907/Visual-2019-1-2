using System;
using System.Windows.Forms;

namespace A005_SimpleCalc
{
    public partial class Form1 : Form
  {
    private bool flag = false;  // 디폴트가 false
    private double savedValue = 0;  // 디폴트는 0
    private char op;

    public Form1()
    {
      InitializeComponent();
    }

    // savedValue와 현재 txtResult의 값을 op에 따라 계산한다
    private void btnEqual_Click(object sender, EventArgs e)
    {
      double v = double.Parse(txtResult.Text);
      double r; // 계산 결과
      switch(op)
      {
        case '+':
          r = savedValue + v;
          break;
        case '-':
          r = savedValue - v;
          break;
        case '*':
          r = savedValue * v;
          break;
        case '/':
          r = savedValue / v;
          break;
        default:
          return;
      }
      txtResult.Text = r.ToString();
    }

        private void btnDot_Click(object sender, EventArgs e)
    {
      if (txtResult.Text.Contains(".") == false)
        txtResult.Text += ".";
    }

        private void Number_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            Button btn = sender as Button;

            string no = btn.Text;

            if (txtResult.Text == "0" || flag == true)
            {
                txtResult.Text = no;
                flag = false;
            }
            else if (flag == false)
            {
                txtResult.Text += no;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text == "+")
                op = '+';
            else if (btn.Text == "-")
                op = '-';
            else if(btn.Text == "×")
                op = '*';
            else if (btn.Text == "÷")
                op = '/';
            flag = true;

            savedValue = double.Parse(txtResult.Text);
        }
    }
}
