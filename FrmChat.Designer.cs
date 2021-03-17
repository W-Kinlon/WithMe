using System.Drawing;//因隐藏标题栏后移动而添加
using System.Windows.Forms;//因隐藏标题栏后移动而添加

namespace QQ2020
{
    partial class FrmChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChat));
            this.labName = new System.Windows.Forms.Label();
            this.flowLP_Chat = new System.Windows.Forms.FlowLayoutPanel();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picChatTool_2 = new System.Windows.Forms.PictureBox();
            this.picChatTool_1 = new System.Windows.Forms.PictureBox();
            this.picChatTooln = new System.Windows.Forms.PictureBox();
            this.picChatTool6 = new System.Windows.Forms.PictureBox();
            this.picChatTool5 = new System.Windows.Forms.PictureBox();
            this.picChatTool4 = new System.Windows.Forms.PictureBox();
            this.picChatTool2 = new System.Windows.Forms.PictureBox();
            this.picChatTool3 = new System.Windows.Forms.PictureBox();
            this.picChatTool1 = new System.Windows.Forms.PictureBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.picKongJian = new System.Windows.Forms.PictureBox();
            this.picRenWu = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTooln)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKongJian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRenWu)).BeginInit();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labName.Location = new System.Drawing.Point(322, 10);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(69, 27);
            this.labName.TabIndex = 0;
            this.labName.Text = "Name";
            // 
            // flowLP_Chat
            // 
            this.flowLP_Chat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLP_Chat.AutoScroll = true;
            this.flowLP_Chat.BackColor = System.Drawing.Color.White;
            this.flowLP_Chat.Location = new System.Drawing.Point(2, 41);
            this.flowLP_Chat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLP_Chat.Name = "flowLP_Chat";
            this.flowLP_Chat.Size = new System.Drawing.Size(577, 405);
            this.flowLP_Chat.TabIndex = 1;
            // 
            // rtbChat
            // 
            this.rtbChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbChat.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbChat.Location = new System.Drawing.Point(0, 39);
            this.rtbChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(577, 84);
            this.rtbChat.TabIndex = 2;
            this.rtbChat.Text = "";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.picChatTool_2);
            this.panel2.Controls.Add(this.picChatTool_1);
            this.panel2.Controls.Add(this.picChatTooln);
            this.panel2.Controls.Add(this.picChatTool6);
            this.panel2.Controls.Add(this.picChatTool5);
            this.panel2.Controls.Add(this.picChatTool4);
            this.panel2.Controls.Add(this.picChatTool2);
            this.panel2.Controls.Add(this.picChatTool3);
            this.panel2.Controls.Add(this.picChatTool1);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.rtbChat);
            this.panel2.Location = new System.Drawing.Point(2, 451);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 164);
            this.panel2.TabIndex = 4;
            // 
            // picChatTool_2
            // 
            this.picChatTool_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picChatTool_2.Image = global::QQ2020.Properties.Resources.chatTool_2;
            this.picChatTool_2.Location = new System.Drawing.Point(508, 10);
            this.picChatTool_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picChatTool_2.Name = "picChatTool_2";
            this.picChatTool_2.Size = new System.Drawing.Size(27, 25);
            this.picChatTool_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChatTool_2.TabIndex = 12;
            this.picChatTool_2.TabStop = false;
            // 
            // picChatTool_1
            // 
            this.picChatTool_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picChatTool_1.Image = global::QQ2020.Properties.Resources.chatTool_1;
            this.picChatTool_1.Location = new System.Drawing.Point(540, 10);
            this.picChatTool_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picChatTool_1.Name = "picChatTool_1";
            this.picChatTool_1.Size = new System.Drawing.Size(27, 25);
            this.picChatTool_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChatTool_1.TabIndex = 11;
            this.picChatTool_1.TabStop = false;
            // 
            // picChatTooln
            // 
            this.picChatTooln.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picChatTooln.Image = global::QQ2020.Properties.Resources.chatTooln;
            this.picChatTooln.Location = new System.Drawing.Point(201, 10);
            this.picChatTooln.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picChatTooln.Name = "picChatTooln";
            this.picChatTooln.Size = new System.Drawing.Size(27, 25);
            this.picChatTooln.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChatTooln.TabIndex = 10;
            this.picChatTooln.TabStop = false;
            // 
            // picChatTool6
            // 
            this.picChatTool6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picChatTool6.Image = global::QQ2020.Properties.Resources.chatTool6;
            this.picChatTool6.Location = new System.Drawing.Point(169, 10);
            this.picChatTool6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picChatTool6.Name = "picChatTool6";
            this.picChatTool6.Size = new System.Drawing.Size(27, 25);
            this.picChatTool6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChatTool6.TabIndex = 9;
            this.picChatTool6.TabStop = false;
            // 
            // picChatTool5
            // 
            this.picChatTool5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picChatTool5.Image = global::QQ2020.Properties.Resources.chatTool5;
            this.picChatTool5.Location = new System.Drawing.Point(137, 10);
            this.picChatTool5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picChatTool5.Name = "picChatTool5";
            this.picChatTool5.Size = new System.Drawing.Size(27, 25);
            this.picChatTool5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChatTool5.TabIndex = 8;
            this.picChatTool5.TabStop = false;
            // 
            // picChatTool4
            // 
            this.picChatTool4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picChatTool4.Image = global::QQ2020.Properties.Resources.chatTool4;
            this.picChatTool4.Location = new System.Drawing.Point(105, 10);
            this.picChatTool4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picChatTool4.Name = "picChatTool4";
            this.picChatTool4.Size = new System.Drawing.Size(27, 25);
            this.picChatTool4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChatTool4.TabIndex = 7;
            this.picChatTool4.TabStop = false;
            // 
            // picChatTool2
            // 
            this.picChatTool2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picChatTool2.Image = global::QQ2020.Properties.Resources.chatTool2;
            this.picChatTool2.Location = new System.Drawing.Point(41, 10);
            this.picChatTool2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picChatTool2.Name = "picChatTool2";
            this.picChatTool2.Size = new System.Drawing.Size(27, 25);
            this.picChatTool2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChatTool2.TabIndex = 6;
            this.picChatTool2.TabStop = false;
            // 
            // picChatTool3
            // 
            this.picChatTool3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picChatTool3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picChatTool3.Image = global::QQ2020.Properties.Resources.chatTool3;
            this.picChatTool3.Location = new System.Drawing.Point(73, 10);
            this.picChatTool3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picChatTool3.Name = "picChatTool3";
            this.picChatTool3.Size = new System.Drawing.Size(27, 25);
            this.picChatTool3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChatTool3.TabIndex = 5;
            this.picChatTool3.TabStop = false;
            this.picChatTool3.Click += new System.EventHandler(this.picChatTool3_Click);
            // 
            // picChatTool1
            // 
            this.picChatTool1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picChatTool1.Image = global::QQ2020.Properties.Resources.chatTool1;
            this.picChatTool1.Location = new System.Drawing.Point(9, 10);
            this.picChatTool1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picChatTool1.Name = "picChatTool1";
            this.picChatTool1.Size = new System.Drawing.Size(27, 25);
            this.picChatTool1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChatTool1.TabIndex = 4;
            this.picChatTool1.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.DimGray;
            this.btnSend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(485, 128);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(89, 33);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // picMin
            // 
            this.picMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMin.Image = global::QQ2020.Properties.Resources.最小化;
            this.picMin.Location = new System.Drawing.Point(656, 10);
            this.picMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(27, 25);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMin.TabIndex = 4;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            this.picMin.MouseEnter += new System.EventHandler(this.picMin_MouseEnter);
            this.picMin.MouseLeave += new System.EventHandler(this.picMin_MouseLeave);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = global::QQ2020.Properties.Resources.关闭1;
            this.picClose.Location = new System.Drawing.Point(740, 10);
            this.picClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(27, 25);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 3;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // picMax
            // 
            this.picMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMax.Cursor = System.Windows.Forms.Cursors.Default;
            this.picMax.Image = global::QQ2020.Properties.Resources.最大化;
            this.picMax.Location = new System.Drawing.Point(698, 10);
            this.picMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMax.Name = "picMax";
            this.picMax.Size = new System.Drawing.Size(27, 25);
            this.picMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMax.TabIndex = 1;
            this.picMax.TabStop = false;
            this.picMax.Click += new System.EventHandler(this.picMax_Click);
            this.picMax.MouseEnter += new System.EventHandler(this.picMax_MouseEnter);
            this.picMax.MouseLeave += new System.EventHandler(this.picMax_MouseLeave);
            // 
            // picKongJian
            // 
            this.picKongJian.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picKongJian.Image = global::QQ2020.Properties.Resources.聊天QQ空间;
            this.picKongJian.Location = new System.Drawing.Point(401, 11);
            this.picKongJian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picKongJian.Name = "picKongJian";
            this.picKongJian.Size = new System.Drawing.Size(27, 25);
            this.picKongJian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKongJian.TabIndex = 2;
            this.picKongJian.TabStop = false;
            // 
            // picRenWu
            // 
            this.picRenWu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picRenWu.Image = global::QQ2020.Properties.Resources.chat背景;
            this.picRenWu.Location = new System.Drawing.Point(581, 41);
            this.picRenWu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picRenWu.Name = "picRenWu";
            this.picRenWu.Size = new System.Drawing.Size(186, 574);
            this.picRenWu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRenWu.TabIndex = 6;
            this.picRenWu.TabStop = false;
            // 
            // FrmChat
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 616);
            this.Controls.Add(this.picRenWu);
            this.Controls.Add(this.picMin);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picMax);
            this.Controls.Add(this.picKongJian);
            this.Controls.Add(this.flowLP_Chat);
            this.Controls.Add(this.labName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(772, 616);
            this.Name = "FrmChat";
            this.Text = "FrmChat";
            this.Load += new System.EventHandler(this.FrmChat_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTooln)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChatTool1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKongJian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRenWu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region 隐藏标题栏后移动窗口
        ///<summary>
        ///鼠标按下，开启移动
        ///<summary>
        ///<param name="e"><param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            m_mousePos = Cursor.Position;
            m_isMouseDown = true;
        }

        ///<summary>
        ///鼠标抬起，关闭移动
        ///<summary>
        ///<param name="e"><param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            m_isMouseDown = false;
            this.Focus();
        }

        ///<summary>
        ///移动窗口
        ///<summary>
        ///<param name="e"><param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (m_isMouseDown)
            {
                Point tempPos = Cursor.Position;
                this.Location = new Point(Location.X + (tempPos.X - m_mousePos.X),
                    Location.Y + (tempPos.Y - m_mousePos.Y));
                m_mousePos = Cursor.Position;
            }
        }
        #endregion
        private System.Windows.Forms.PictureBox picMax;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.FlowLayoutPanel flowLP_Chat;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picKongJian;
        private PictureBox picChatTool1;
        private PictureBox picChatTool_2;
        private PictureBox picChatTool_1;
        private PictureBox picChatTooln;
        private PictureBox picChatTool6;
        private PictureBox picChatTool5;
        private PictureBox picChatTool4;
        private PictureBox picChatTool2;
        private PictureBox picChatTool3;
        private PictureBox picRenWu;

        public Point m_mousePos { get; private set; }//因隐藏标题栏后移动而添加
        public bool m_isMouseDown { get; private set; }//因隐藏标题栏后移动而添加
    }
}