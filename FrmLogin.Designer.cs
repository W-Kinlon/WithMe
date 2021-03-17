namespace QQ2020
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.AutoLogin = new System.Windows.Forms.CheckBox();
            this.RemPas = new System.Windows.Forms.CheckBox();
            this.RePas = new System.Windows.Forms.LinkLabel();
            this.Sign = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.picCode = new System.Windows.Forms.PictureBox();
            this.picSmallQQ = new System.Windows.Forms.PictureBox();
            this.picLock = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.picBigQQ = new System.Windows.Forms.PictureBox();
            this.picAddUser = new System.Windows.Forms.PictureBox();
            this.TxtUser = new CCWin.SkinControl.SkinTextBox();
            this.TxtPas = new CCWin.SkinControl.SkinTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmallQQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBigQQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(99, 339);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(313, 47);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // AutoLogin
            // 
            this.AutoLogin.AutoSize = true;
            this.AutoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoLogin.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.AutoLogin.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AutoLogin.Location = new System.Drawing.Point(110, 305);
            this.AutoLogin.Name = "AutoLogin";
            this.AutoLogin.Size = new System.Drawing.Size(91, 24);
            this.AutoLogin.TabIndex = 4;
            this.AutoLogin.Text = "自动登录";
            this.AutoLogin.UseVisualStyleBackColor = true;
            this.AutoLogin.MouseEnter += new System.EventHandler(this.AutoLogin_MouseEnter);
            this.AutoLogin.MouseLeave += new System.EventHandler(this.AutoLogin_MouseLeave);
            // 
            // RemPas
            // 
            this.RemPas.AutoSize = true;
            this.RemPas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemPas.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.RemPas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RemPas.Location = new System.Drawing.Point(217, 305);
            this.RemPas.Name = "RemPas";
            this.RemPas.Size = new System.Drawing.Size(91, 24);
            this.RemPas.TabIndex = 5;
            this.RemPas.Text = "记住密码";
            this.RemPas.UseVisualStyleBackColor = true;
            this.RemPas.MouseEnter += new System.EventHandler(this.RemPas_MouseEnter);
            this.RemPas.MouseLeave += new System.EventHandler(this.RemPas_MouseLeave);
            // 
            // RePas
            // 
            this.RePas.AutoSize = true;
            this.RePas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RePas.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.RePas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RePas.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.RePas.LinkColor = System.Drawing.SystemColors.ControlDark;
            this.RePas.Location = new System.Drawing.Point(326, 305);
            this.RePas.Name = "RePas";
            this.RePas.Size = new System.Drawing.Size(69, 20);
            this.RePas.TabIndex = 6;
            this.RePas.TabStop = true;
            this.RePas.Text = "找回密码";
            this.RePas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RePas_LinkClicked);
            this.RePas.MouseEnter += new System.EventHandler(this.RePas_MouseEnter);
            this.RePas.MouseLeave += new System.EventHandler(this.RePas_MouseLeave);
            // 
            // Sign
            // 
            this.Sign.AutoSize = true;
            this.Sign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sign.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Sign.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Sign.LinkColor = System.Drawing.SystemColors.ControlDark;
            this.Sign.Location = new System.Drawing.Point(12, 387);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(69, 20);
            this.Sign.TabIndex = 7;
            this.Sign.TabStop = true;
            this.Sign.Text = "注册账号";
            this.Sign.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            this.Sign.MouseEnter += new System.EventHandler(this.Sign_MouseEnter);
            this.Sign.MouseLeave += new System.EventHandler(this.Sign_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // picCode
            // 
            this.picCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCode.BackgroundImage")));
            this.picCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCode.Location = new System.Drawing.Point(479, 372);
            this.picCode.Name = "picCode";
            this.picCode.Size = new System.Drawing.Size(34, 30);
            this.picCode.TabIndex = 16;
            this.picCode.TabStop = false;
            this.picCode.MouseEnter += new System.EventHandler(this.picCode_MouseEnter);
            this.picCode.MouseLeave += new System.EventHandler(this.picCode_MouseLeave);
            // 
            // picSmallQQ
            // 
            this.picSmallQQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSmallQQ.BackgroundImage")));
            this.picSmallQQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSmallQQ.Location = new System.Drawing.Point(110, 215);
            this.picSmallQQ.Name = "picSmallQQ";
            this.picSmallQQ.Size = new System.Drawing.Size(18, 20);
            this.picSmallQQ.TabIndex = 15;
            this.picSmallQQ.TabStop = false;
            this.picSmallQQ.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // picLock
            // 
            this.picLock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLock.BackgroundImage")));
            this.picLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLock.Location = new System.Drawing.Point(110, 263);
            this.picLock.Name = "picLock";
            this.picLock.Size = new System.Drawing.Size(18, 20);
            this.picLock.TabIndex = 14;
            this.picLock.TabStop = false;
            this.picLock.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(475, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(16, 16);
            this.btnMin.TabIndex = 10;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseEnter += new System.EventHandler(this.btnMin_MouseEnter);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(440, 9);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(20, 20);
            this.btnSetting.TabIndex = 9;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.MouseEnter += new System.EventHandler(this.btnSetting_MouseEnter);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(507, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // picBigQQ
            // 
            this.picBigQQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBigQQ.BackColor = System.Drawing.Color.Transparent;
            this.picBigQQ.BackgroundImage = global::QQ2020.Properties.Resources.headqq1;
            this.picBigQQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBigQQ.Location = new System.Drawing.Point(227, 100);
            this.picBigQQ.Name = "picBigQQ";
            this.picBigQQ.Size = new System.Drawing.Size(81, 79);
            this.picBigQQ.TabIndex = 11;
            this.picBigQQ.TabStop = false;
            this.picBigQQ.Click += new System.EventHandler(this.pictureBox2_Click);
            this.picBigQQ.MouseEnter += new System.EventHandler(this.picBigQQ_MouseEnter);
            this.picBigQQ.MouseLeave += new System.EventHandler(this.picBigQQ_MouseLeave);
            // 
            // picAddUser
            // 
            this.picAddUser.BackColor = System.Drawing.Color.Transparent;
            this.picAddUser.Image = ((System.Drawing.Image)(resources.GetObject("picAddUser.Image")));
            this.picAddUser.Location = new System.Drawing.Point(237, 109);
            this.picAddUser.Name = "picAddUser";
            this.picAddUser.Size = new System.Drawing.Size(57, 57);
            this.picAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddUser.TabIndex = 17;
            this.picAddUser.TabStop = false;
            this.picAddUser.MouseEnter += new System.EventHandler(this.picAddUser_MouseEnter);
            this.picAddUser.MouseLeave += new System.EventHandler(this.picAddUser_MouseLeave);
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.Transparent;
            this.TxtUser.DownBack = null;
            this.TxtUser.Icon = global::QQ2020.Properties.Resources.down_dis;
            this.TxtUser.IconIsButton = false;
            this.TxtUser.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TxtUser.IsPasswordChat = '\0';
            this.TxtUser.IsSystemPasswordChar = false;
            this.TxtUser.Lines = new string[0];
            this.TxtUser.Location = new System.Drawing.Point(166, 212);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(0);
            this.TxtUser.MaxLength = 32767;
            this.TxtUser.MinimumSize = new System.Drawing.Size(28, 28);
            this.TxtUser.MouseBack = null;
            this.TxtUser.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TxtUser.Multiline = true;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.NormlBack = null;
            this.TxtUser.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.TxtUser.ReadOnly = false;
            this.TxtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUser.Size = new System.Drawing.Size(197, 32);
            // 
            // 
            // 
            this.TxtUser.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUser.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.TxtUser.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.TxtUser.SkinTxt.Multiline = true;
            this.TxtUser.SkinTxt.Name = "BaseText";
            this.TxtUser.SkinTxt.Size = new System.Drawing.Size(164, 22);
            this.TxtUser.SkinTxt.TabIndex = 0;
            this.TxtUser.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TxtUser.SkinTxt.WaterText = "用户名";
            this.TxtUser.TabIndex = 25;
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtUser.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TxtUser.WaterText = "用户名";
            this.TxtUser.WordWrap = true;
            // 
            // TxtPas
            // 
            this.TxtPas.BackColor = System.Drawing.Color.Transparent;
            this.TxtPas.DownBack = null;
            this.TxtPas.Icon = global::QQ2020.Properties.Resources.keyboard;
            this.TxtPas.IconIsButton = true;
            this.TxtPas.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TxtPas.IsPasswordChat = '●';
            this.TxtPas.IsSystemPasswordChar = true;
            this.TxtPas.Lines = new string[0];
            this.TxtPas.Location = new System.Drawing.Point(166, 260);
            this.TxtPas.Margin = new System.Windows.Forms.Padding(0);
            this.TxtPas.MaxLength = 32767;
            this.TxtPas.MinimumSize = new System.Drawing.Size(0, 28);
            this.TxtPas.MouseBack = null;
            this.TxtPas.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TxtPas.Multiline = false;
            this.TxtPas.Name = "TxtPas";
            this.TxtPas.NormlBack = null;
            this.TxtPas.Padding = new System.Windows.Forms.Padding(5, 5, 51, 5);
            this.TxtPas.ReadOnly = false;
            this.TxtPas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPas.Size = new System.Drawing.Size(197, 28);
            // 
            // 
            // 
            this.TxtPas.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.TxtPas.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.TxtPas.SkinTxt.Name = "BaseText";
            this.TxtPas.SkinTxt.PasswordChar = '●';
            this.TxtPas.SkinTxt.TabIndex = 0;
            this.TxtPas.SkinTxt.UseSystemPasswordChar = true;
            this.TxtPas.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TxtPas.SkinTxt.WaterText = "密码";
            this.TxtPas.TabIndex = 26;
            this.TxtPas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPas.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TxtPas.WaterText = "密码";
            this.TxtPas.WordWrap = true;
            this.TxtPas.IconClick += new System.EventHandler(this.TxtPas_IconClick);
            this.TxtPas.Paint += new System.Windows.Forms.PaintEventHandler(this.TxtPas_Paint);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 411);
            this.ControlBox = false;
            this.Controls.Add(this.TxtPas);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.picCode);
            this.Controls.Add(this.picSmallQQ);
            this.Controls.Add(this.picLock);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.RePas);
            this.Controls.Add(this.RemPas);
            this.Controls.Add(this.AutoLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picBigQQ);
            this.Controls.Add(this.picAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithMe";
            this.TransparencyKey = System.Drawing.Color.PaleGreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QQLogin_FormClosing);
            this.Load += new System.EventHandler(this.QQLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QQLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.QQLogin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmallQQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBigQQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox AutoLogin;
        private System.Windows.Forms.CheckBox RemPas;
        private System.Windows.Forms.LinkLabel RePas;
        private System.Windows.Forms.LinkLabel Sign;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.PictureBox picBigQQ;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picLock;
        private System.Windows.Forms.PictureBox picSmallQQ;
        private System.Windows.Forms.PictureBox picCode;
        private System.Windows.Forms.PictureBox picAddUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private CCWin.SkinControl.SkinTextBox TxtPas;
        public CCWin.SkinControl.SkinTextBox TxtUser;
    }
}

