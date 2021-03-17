namespace QQ2020
{
    partial class UserList
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQianMing = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.labEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQianMing
            // 
            this.labelQianMing.AutoSize = true;
            this.labelQianMing.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelQianMing.Location = new System.Drawing.Point(177, 25);
            this.labelQianMing.Name = "labelQianMing";
            this.labelQianMing.Size = new System.Drawing.Size(119, 27);
            this.labelQianMing.TabIndex = 5;
            this.labelQianMing.Text = "hello world";
            this.labelQianMing.MouseEnter += new System.EventHandler(this.UserList_MouseEnter);
            this.labelQianMing.MouseLeave += new System.EventHandler(this.UserList_MouseLeave);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Location = new System.Drawing.Point(59, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(80, 33);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Code";
            this.labelName.MouseEnter += new System.EventHandler(this.UserList_MouseEnter);
            this.labelName.MouseLeave += new System.EventHandler(this.UserList_MouseLeave);
            // 
            // pictureUser
            // 
            this.pictureUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureUser.BackgroundImage = global::QQ2020.Properties.Resources.默认用户头像;
            this.pictureUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureUser.Location = new System.Drawing.Point(3, 7);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(50, 50);
            this.pictureUser.TabIndex = 3;
            this.pictureUser.TabStop = false;
            this.pictureUser.MouseEnter += new System.EventHandler(this.UserList_MouseEnter);
            this.pictureUser.MouseLeave += new System.EventHandler(this.UserList_MouseLeave);
            // 
            // labEmail
            // 
            this.labEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labEmail.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labEmail.Location = new System.Drawing.Point(346, 7);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(119, 27);
            this.labEmail.TabIndex = 6;
            this.labEmail.Text = "hello world";
            this.labEmail.MouseEnter += new System.EventHandler(this.UserList_MouseEnter);
            this.labEmail.MouseLeave += new System.EventHandler(this.UserList_MouseLeave);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labelQianMing);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureUser);
            this.Name = "UserList";
            this.Size = new System.Drawing.Size(560, 60);
            this.Load += new System.EventHandler(this.UserList_Load);
            this.Click += new System.EventHandler(this.UserList_Click);
            this.MouseEnter += new System.EventHandler(this.UserList_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserList_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQianMing;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label labEmail;
    }
}
