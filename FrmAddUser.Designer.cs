namespace QQ2020
{
    partial class FrmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUser));
            this.textName = new System.Windows.Forms.TextBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.labAdd = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.textName.Location = new System.Drawing.Point(135, 89);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(264, 40);
            this.textName.TabIndex = 0;
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.Transparent;
            this.picSearch.BackgroundImage = global::QQ2020.Properties.Resources.搜索;
            this.picSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearch.Location = new System.Drawing.Point(441, 89);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(40, 40);
            this.picSearch.TabIndex = 1;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            this.picSearch.MouseEnter += new System.EventHandler(this.picSearch_MouseEnter);
            this.picSearch.MouseLeave += new System.EventHandler(this.picSearch_MouseLeave);
            // 
            // labAdd
            // 
            this.labAdd.AutoSize = true;
            this.labAdd.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.labAdd.Location = new System.Drawing.Point(193, 26);
            this.labAdd.Name = "labAdd";
            this.labAdd.Size = new System.Drawing.Size(156, 45);
            this.labAdd.TabIndex = 2;
            this.labAdd.Text = "添加好友";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 153);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(582, 300);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labAdd);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.textName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FrmAddUser";
            this.Text = "添加好友";
            this.Load += new System.EventHandler(this.FrmAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Label labAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}