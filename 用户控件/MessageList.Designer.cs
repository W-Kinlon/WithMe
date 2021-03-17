namespace QQ2020
{
    partial class MessageList
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastMessage = new System.Windows.Forms.Label();
            this.labelLastTime = new System.Windows.Forms.Label();
            this.picTips = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Location = new System.Drawing.Point(92, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(80, 33);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Code";
            this.labelName.MouseEnter += new System.EventHandler(this.MessageList_MouseEnter);
            this.labelName.MouseLeave += new System.EventHandler(this.MessageList_MouseLeave);
            // 
            // labelLastMessage
            // 
            this.labelLastMessage.AutoSize = true;
            this.labelLastMessage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLastMessage.Location = new System.Drawing.Point(94, 67);
            this.labelLastMessage.Name = "labelLastMessage";
            this.labelLastMessage.Size = new System.Drawing.Size(91, 20);
            this.labelLastMessage.TabIndex = 2;
            this.labelLastMessage.Text = "hello world";
            this.labelLastMessage.MouseEnter += new System.EventHandler(this.MessageList_MouseEnter);
            this.labelLastMessage.MouseLeave += new System.EventHandler(this.MessageList_MouseLeave);
            // 
            // labelLastTime
            // 
            this.labelLastTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastTime.AutoSize = true;
            this.labelLastTime.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labelLastTime.ForeColor = System.Drawing.Color.DarkGray;
            this.labelLastTime.Location = new System.Drawing.Point(262, 26);
            this.labelLastTime.Name = "labelLastTime";
            this.labelLastTime.Size = new System.Drawing.Size(54, 23);
            this.labelLastTime.TabIndex = 3;
            this.labelLastTime.Text = "19:00";
            this.labelLastTime.MouseEnter += new System.EventHandler(this.MessageList_MouseEnter);
            this.labelLastTime.MouseLeave += new System.EventHandler(this.MessageList_MouseLeave);
            // 
            // picTips
            // 
            this.picTips.BackColor = System.Drawing.Color.Transparent;
            this.picTips.BackgroundImage = global::QQ2020.Properties.Resources.新消息红点1;
            this.picTips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTips.Location = new System.Drawing.Point(312, 51);
            this.picTips.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTips.Name = "picTips";
            this.picTips.Size = new System.Drawing.Size(52, 50);
            this.picTips.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTips.TabIndex = 4;
            this.picTips.TabStop = false;
            this.picTips.Visible = false;
            this.picTips.MouseEnter += new System.EventHandler(this.MessageList_MouseEnter);
            this.picTips.MouseLeave += new System.EventHandler(this.MessageList_MouseLeave);
            // 
            // pictureUser
            // 
            this.pictureUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureUser.BackgroundImage = global::QQ2020.Properties.Resources.默认用户头像;
            this.pictureUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureUser.Location = new System.Drawing.Point(13, 18);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(60, 60);
            this.pictureUser.TabIndex = 0;
            this.pictureUser.TabStop = false;
            this.pictureUser.MouseEnter += new System.EventHandler(this.MessageList_MouseEnter);
            this.pictureUser.MouseLeave += new System.EventHandler(this.MessageList_MouseLeave);
            // 
            // MessageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelLastTime);
            this.Controls.Add(this.labelLastMessage);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.picTips);
            this.Name = "MessageList";
            this.Size = new System.Drawing.Size(367, 103);
            this.Load += new System.EventHandler(this.MessageList_Load);
            this.DoubleClick += new System.EventHandler(this.MessageList_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.MessageList_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MessageList_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picTips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastMessage;
        private System.Windows.Forms.Label labelLastTime;
        private System.Windows.Forms.PictureBox picTips;
    }
}
