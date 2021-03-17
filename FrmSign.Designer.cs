namespace QQ2020
{
    partial class FrmSign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSign));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.SignPwd2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SignPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SignName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.SignEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label5.Location = new System.Drawing.Point(508, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "(6~8位英/数)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label4.Location = new System.Drawing.Point(508, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "(2~6位中/英/数)";
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSign.ForeColor = System.Drawing.Color.White;
            this.btnSign.Location = new System.Drawing.Point(245, 439);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(313, 47);
            this.btnSign.TabIndex = 15;
            this.btnSign.Text = "注册";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // SignPwd2
            // 
            this.SignPwd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SignPwd2.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.SignPwd2.Location = new System.Drawing.Point(285, 260);
            this.SignPwd2.Name = "SignPwd2";
            this.SignPwd2.Size = new System.Drawing.Size(217, 38);
            this.SignPwd2.TabIndex = 14;
            this.SignPwd2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label3.Location = new System.Drawing.Point(145, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "确认密码：";
            // 
            // SignPwd
            // 
            this.SignPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SignPwd.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.SignPwd.Location = new System.Drawing.Point(285, 188);
            this.SignPwd.Name = "SignPwd";
            this.SignPwd.Size = new System.Drawing.Size(217, 38);
            this.SignPwd.TabIndex = 12;
            this.SignPwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label2.Location = new System.Drawing.Point(193, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "密码：";
            // 
            // SignName
            // 
            this.SignName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SignName.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.SignName.Location = new System.Drawing.Point(285, 125);
            this.SignName.Name = "SignName";
            this.SignName.Size = new System.Drawing.Size(217, 38);
            this.SignName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label1.Location = new System.Drawing.Point(169, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "用户名：";
            // 
            // ConfirmCode
            // 
            this.ConfirmCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmCode.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.ConfirmCode.Location = new System.Drawing.Point(285, 329);
            this.ConfirmCode.Name = "ConfirmCode";
            this.ConfirmCode.Size = new System.Drawing.Size(217, 38);
            this.ConfirmCode.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label6.Location = new System.Drawing.Point(169, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "验证码：";
            // 
            // btnSendCode
            // 
            this.btnSendCode.BackColor = System.Drawing.Color.Teal;
            this.btnSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCode.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.Location = new System.Drawing.Point(512, 329);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(70, 38);
            this.btnSendCode.TabIndex = 20;
            this.btnSendCode.Text = "发送";
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // SignEmail
            // 
            this.SignEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SignEmail.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.SignEmail.Location = new System.Drawing.Point(285, 49);
            this.SignEmail.Name = "SignEmail";
            this.SignEmail.Size = new System.Drawing.Size(256, 38);
            this.SignEmail.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label7.Location = new System.Drawing.Point(193, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 31);
            this.label7.TabIndex = 23;
            this.label7.Text = "邮箱：";
            // 
            // labCode
            // 
            this.labCode.AutoSize = true;
            this.labCode.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labCode.Location = new System.Drawing.Point(281, 370);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(168, 20);
            this.labCode.TabIndex = 25;
            this.labCode.Text = "验证码已发送至邮箱......";
            this.labCode.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSign
            // 
            this.AcceptButton = this.btnSign;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 570);
            this.Controls.Add(this.labCode);
            this.Controls.Add(this.SignEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.ConfirmCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.SignPwd2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SignPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 570);
            this.Name = "FrmSign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册账号";
            this.Load += new System.EventHandler(this.FrmSign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.TextBox SignPwd2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SignPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SignName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConfirmCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.TextBox SignEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Timer timer1;
    }
}