﻿namespace A005_SimpleCalc
{
  partial class Form1
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtResult.Location = new System.Drawing.Point(11, 19);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(285, 71);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn7.Location = new System.Drawing.Point(12, 108);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(68, 71);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn8.Location = new System.Drawing.Point(84, 108);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(68, 71);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn9.Location = new System.Drawing.Point(156, 108);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(68, 71);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlus.Location = new System.Drawing.Point(228, 108);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(68, 71);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinus.Location = new System.Drawing.Point(228, 185);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(68, 71);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn6.Location = new System.Drawing.Point(156, 185);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(68, 71);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn5.Location = new System.Drawing.Point(84, 185);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(68, 71);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn4.Location = new System.Drawing.Point(12, 185);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(68, 71);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTimes.Location = new System.Drawing.Point(228, 262);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(68, 71);
            this.btnTimes.TabIndex = 12;
            this.btnTimes.Text = "×";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn3.Location = new System.Drawing.Point(156, 262);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(68, 71);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn2.Location = new System.Drawing.Point(84, 262);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 71);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn1.Location = new System.Drawing.Point(12, 262);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 71);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDivide.Location = new System.Drawing.Point(228, 339);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(68, 71);
            this.btnDivide.TabIndex = 16;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEqual.Location = new System.Drawing.Point(156, 339);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(68, 71);
            this.btnEqual.TabIndex = 15;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn0.Location = new System.Drawing.Point(84, 339);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(68, 71);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDot.Location = new System.Drawing.Point(12, 339);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(68, 71);
            this.btnDot.TabIndex = 13;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 424);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.Text = "간단한 계산기 by  유채연";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtResult;
    private System.Windows.Forms.Button btn7;
    private System.Windows.Forms.Button btn8;
    private System.Windows.Forms.Button btn9;
    private System.Windows.Forms.Button btnPlus;
    private System.Windows.Forms.Button btnMinus;
    private System.Windows.Forms.Button btn6;
    private System.Windows.Forms.Button btn5;
    private System.Windows.Forms.Button btn4;
    private System.Windows.Forms.Button btnTimes;
    private System.Windows.Forms.Button btn3;
    private System.Windows.Forms.Button btn2;
    private System.Windows.Forms.Button btn1;
    private System.Windows.Forms.Button btnDivide;
    private System.Windows.Forms.Button btnEqual;
    private System.Windows.Forms.Button btn0;
    private System.Windows.Forms.Button btnDot;
  }
}

