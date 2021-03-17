namespace QQ2020
{
    partial class FrmCutScreen
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
            this.pnlCutMag_glass = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picMagImage = new System.Windows.Forms.PictureBox();
            this.labRGB = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCutMag_glass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMagImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCutMag_glass
            // 
            this.pnlCutMag_glass.BackColor = System.Drawing.Color.Black;
            this.pnlCutMag_glass.Controls.Add(this.label2);
            this.pnlCutMag_glass.Controls.Add(this.label1);
            this.pnlCutMag_glass.Controls.Add(this.picMagImage);
            this.pnlCutMag_glass.Controls.Add(this.labRGB);
            this.pnlCutMag_glass.Controls.Add(this.labSize);
            this.pnlCutMag_glass.Location = new System.Drawing.Point(300, 100);
            this.pnlCutMag_glass.Name = "pnlCutMag_glass";
            this.pnlCutMag_glass.Size = new System.Drawing.Size(200, 250);
            this.pnlCutMag_glass.TabIndex = 7;
            this.pnlCutMag_glass.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "按Ctrl+C复制色号";
            // 
            // picMagImage
            // 
            this.picMagImage.BackColor = System.Drawing.Color.White;
            this.picMagImage.Location = new System.Drawing.Point(0, 0);
            this.picMagImage.Margin = new System.Windows.Forms.Padding(0);
            this.picMagImage.Name = "picMagImage";
            this.picMagImage.Size = new System.Drawing.Size(200, 150);
            this.picMagImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMagImage.TabIndex = 4;
            this.picMagImage.TabStop = false;
            // 
            // labRGB
            // 
            this.labRGB.AutoSize = true;
            this.labRGB.ForeColor = System.Drawing.Color.White;
            this.labRGB.Location = new System.Drawing.Point(3, 180);
            this.labRGB.Name = "labRGB";
            this.labRGB.Size = new System.Drawing.Size(152, 18);
            this.labRGB.TabIndex = 6;
            this.labRGB.Text = "(rgb)255,255,255";
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.ForeColor = System.Drawing.Color.White;
            this.labSize.Location = new System.Drawing.Point(3, 155);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(89, 18);
            this.labSize.TabIndex = 5;
            this.labSize.Text = "(size)0,0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "按ESC退出";
            // 
            // FrmCutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCutMag_glass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCutScreen";
            this.Text = "FrmScreenBody";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmScreenBody_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCutScreen_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmScreenBody_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmScreenBody_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmScreenBody_MouseUp);
            this.pnlCutMag_glass.ResumeLayout(false);
            this.pnlCutMag_glass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMagImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCutMag_glass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labRGB;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.PictureBox picMagImage;
        private System.Windows.Forms.Label label2;
    }
}