namespace A005_calculator1
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
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.bntadd = new System.Windows.Forms.Button();
            this.bntsub = new System.Windows.Forms.Button();
            this.bntmul = new System.Windows.Forms.Button();
            this.bntdiv = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblnum1.Location = new System.Drawing.Point(53, 33);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(38, 15);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "숫자1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblnum2.Location = new System.Drawing.Point(53, 70);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(38, 15);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "숫자2";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(130, 33);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 21);
            this.txtnum1.TabIndex = 2;
            this.txtnum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(130, 60);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 21);
            this.txtnum2.TabIndex = 3;
            this.txtnum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bntadd
            // 
            this.bntadd.BackColor = System.Drawing.Color.MintCream;
            this.bntadd.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bntadd.Location = new System.Drawing.Point(28, 116);
            this.bntadd.Name = "bntadd";
            this.bntadd.Size = new System.Drawing.Size(52, 40);
            this.bntadd.TabIndex = 4;
            this.bntadd.Text = "+";
            this.bntadd.UseVisualStyleBackColor = false;
            this.bntadd.Click += new System.EventHandler(this.bntadd_Click);
            // 
            // bntsub
            // 
            this.bntsub.BackColor = System.Drawing.Color.MintCream;
            this.bntsub.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bntsub.Location = new System.Drawing.Point(99, 116);
            this.bntsub.Name = "bntsub";
            this.bntsub.Size = new System.Drawing.Size(52, 40);
            this.bntsub.TabIndex = 5;
            this.bntsub.Text = "-";
            this.bntsub.UseVisualStyleBackColor = false;
            this.bntsub.Click += new System.EventHandler(this.bntsub_Click);
            // 
            // bntmul
            // 
            this.bntmul.BackColor = System.Drawing.Color.MintCream;
            this.bntmul.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bntmul.Location = new System.Drawing.Point(171, 116);
            this.bntmul.Name = "bntmul";
            this.bntmul.Size = new System.Drawing.Size(52, 40);
            this.bntmul.TabIndex = 7;
            this.bntmul.Text = "*";
            this.bntmul.UseVisualStyleBackColor = false;
            this.bntmul.Click += new System.EventHandler(this.button3_Click);
            // 
            // bntdiv
            // 
            this.bntdiv.BackColor = System.Drawing.Color.MintCream;
            this.bntdiv.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bntdiv.Location = new System.Drawing.Point(241, 116);
            this.bntdiv.Name = "bntdiv";
            this.bntdiv.Size = new System.Drawing.Size(52, 40);
            this.bntdiv.TabIndex = 6;
            this.bntdiv.Text = "/";
            this.bntdiv.UseVisualStyleBackColor = false;
            this.bntdiv.Click += new System.EventHandler(this.bntdiv_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblresult.Location = new System.Drawing.Point(53, 210);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(43, 15);
            this.lblresult.TabIndex = 8;
            this.lblresult.Text = "( )결과";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(128, 209);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(95, 21);
            this.txtresult.TabIndex = 9;
            this.txtresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtresult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(319, 288);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.bntmul);
            this.Controls.Add(this.bntdiv);
            this.Controls.Add(this.bntsub);
            this.Controls.Add(this.bntadd);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Name = "Form1";
            this.Text = "사칙계산기by 채연";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Button bntadd;
        private System.Windows.Forms.Button bntsub;
        private System.Windows.Forms.Button bntmul;
        private System.Windows.Forms.Button bntdiv;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtresult;
    }
}

