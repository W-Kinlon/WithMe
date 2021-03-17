namespace MyMusicBox
{
    partial class fraMusicBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fraMusicBox));
            this.picThema = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picLast = new System.Windows.Forms.PictureBox();
            this.lblDisplayTime = new System.Windows.Forms.Label();
            this.picMode = new System.Windows.Forms.PictureBox();
            this.picVolume = new System.Windows.Forms.PictureBox();
            this.picLove = new System.Windows.Forms.PictureBox();
            this.picList = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMins = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLyric1 = new System.Windows.Forms.Label();
            this.lblLyric2 = new System.Windows.Forms.Label();
            this.lblLyric3 = new System.Windows.Forms.Label();
            this.lblLyric4 = new System.Windows.Forms.Label();
            this.lblLyric5 = new System.Windows.Forms.Label();
            this.lblLyric6 = new System.Windows.Forms.Label();
            this.lblLyric7 = new System.Windows.Forms.Label();
            this.lblLyric8 = new System.Windows.Forms.Label();
            this.lblLyric9 = new System.Windows.Forms.Label();
            this.lblLyric10 = new System.Windows.Forms.Label();
            this.lblLyric11 = new System.Windows.Forms.Label();
            this.lblLyric12 = new System.Windows.Forms.Label();
            this.pnlMusic = new System.Windows.Forms.Panel();
            this.lblAddmusic = new System.Windows.Forms.Label();
            this.picAddmusic = new System.Windows.Forms.PictureBox();
            this.lblPlayList = new System.Windows.Forms.Label();
            this.pnlAll = new System.Windows.Forms.Panel();
            this.picSingle = new System.Windows.Forms.PictureBox();
            this.pnlMode = new System.Windows.Forms.Panel();
            this.picRandom = new System.Windows.Forms.PictureBox();
            this.picloop = new System.Windows.Forms.PictureBox();
            this.lblplaying = new System.Windows.Forms.Label();
            this.pnlControl1 = new System.Windows.Forms.Panel();
            this.pnlControl2 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.picThema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddmusic)).BeginInit();
            this.pnlAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSingle)).BeginInit();
            this.pnlMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRandom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picloop)).BeginInit();
            this.pnlControl1.SuspendLayout();
            this.pnlControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // picThema
            // 
            this.picThema.BackColor = System.Drawing.Color.Transparent;
            this.picThema.BackgroundImage = global::MyMusicBox.Properties.Resources.test;
            this.picThema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picThema.Location = new System.Drawing.Point(279, 0);
            this.picThema.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picThema.Name = "picThema";
            this.picThema.Size = new System.Drawing.Size(88, 94);
            this.picThema.TabIndex = 10;
            this.picThema.TabStop = false;
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.Color.Transparent;
            this.picPlay.BackgroundImage = global::MyMusicBox.Properties.Resources.play;
            this.picPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlay.Location = new System.Drawing.Point(84, 0);
            this.picPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(84, 90);
            this.picPlay.TabIndex = 3;
            this.picPlay.TabStop = false;
            this.picPlay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picPlay_MouseClick);
            this.picPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPlay_MouseDown);
            this.picPlay.MouseEnter += new System.EventHandler(this.picPlay_MouseEnter);
            this.picPlay.MouseLeave += new System.EventHandler(this.picPlay_MouseLeave);
            this.picPlay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picPlay_MouseUp);
            // 
            // picNext
            // 
            this.picNext.BackColor = System.Drawing.Color.Transparent;
            this.picNext.BackgroundImage = global::MyMusicBox.Properties.Resources.next_2;
            this.picNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNext.Location = new System.Drawing.Point(169, 0);
            this.picNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(84, 90);
            this.picNext.TabIndex = 5;
            this.picNext.TabStop = false;
            this.picNext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picNext_MouseClick);
            this.picNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picNext_MouseDown);
            this.picNext.MouseEnter += new System.EventHandler(this.picNext_MouseEnter);
            this.picNext.MouseLeave += new System.EventHandler(this.picNext_MouseLeave);
            this.picNext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picNext_MouseUp);
            // 
            // picLast
            // 
            this.picLast.BackColor = System.Drawing.Color.Transparent;
            this.picLast.BackgroundImage = global::MyMusicBox.Properties.Resources.last_3;
            this.picLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLast.Location = new System.Drawing.Point(0, 0);
            this.picLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picLast.Name = "picLast";
            this.picLast.Size = new System.Drawing.Size(84, 90);
            this.picLast.TabIndex = 4;
            this.picLast.TabStop = false;
            this.picLast.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picLast_MouseClick);
            this.picLast.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picLast_MouseDown);
            this.picLast.MouseEnter += new System.EventHandler(this.picLast_MouseEnter);
            this.picLast.MouseLeave += new System.EventHandler(this.picLast_MouseLeave);
            this.picLast.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picLast_MouseUp);
            // 
            // lblDisplayTime
            // 
            this.lblDisplayTime.AutoSize = true;
            this.lblDisplayTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayTime.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDisplayTime.ForeColor = System.Drawing.Color.White;
            this.lblDisplayTime.Location = new System.Drawing.Point(983, 856);
            this.lblDisplayTime.Name = "lblDisplayTime";
            this.lblDisplayTime.Size = new System.Drawing.Size(131, 22);
            this.lblDisplayTime.TabIndex = 5;
            this.lblDisplayTime.Text = "00:00/00:00";
            // 
            // picMode
            // 
            this.picMode.BackColor = System.Drawing.Color.Transparent;
            this.picMode.BackgroundImage = global::MyMusicBox.Properties.Resources.loop;
            this.picMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMode.Location = new System.Drawing.Point(3, 1);
            this.picMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picMode.Name = "picMode";
            this.picMode.Size = new System.Drawing.Size(84, 90);
            this.picMode.TabIndex = 9;
            this.picMode.TabStop = false;
            this.picMode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picMode_MouseClick);
            this.picMode.MouseEnter += new System.EventHandler(this.picMode_MouseEnter);
            this.picMode.MouseLeave += new System.EventHandler(this.picMode_MouseLeave);
            // 
            // picVolume
            // 
            this.picVolume.BackColor = System.Drawing.Color.Transparent;
            this.picVolume.BackgroundImage = global::MyMusicBox.Properties.Resources.volume;
            this.picVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVolume.Location = new System.Drawing.Point(86, 1);
            this.picVolume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picVolume.Name = "picVolume";
            this.picVolume.Size = new System.Drawing.Size(84, 90);
            this.picVolume.TabIndex = 8;
            this.picVolume.TabStop = false;
            this.picVolume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picVolume_MouseClick);
            this.picVolume.MouseEnter += new System.EventHandler(this.picVolume_MouseEnter);
            this.picVolume.MouseLeave += new System.EventHandler(this.picVolume_MouseLeave);
            // 
            // picLove
            // 
            this.picLove.BackColor = System.Drawing.Color.Transparent;
            this.picLove.BackgroundImage = global::MyMusicBox.Properties.Resources.like_1;
            this.picLove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLove.Location = new System.Drawing.Point(170, 1);
            this.picLove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picLove.Name = "picLove";
            this.picLove.Size = new System.Drawing.Size(84, 90);
            this.picLove.TabIndex = 7;
            this.picLove.TabStop = false;
            this.picLove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picLove_MouseClick);
            this.picLove.MouseEnter += new System.EventHandler(this.picLove_MouseEnter);
            this.picLove.MouseLeave += new System.EventHandler(this.picLove_MouseLeave);
            // 
            // picList
            // 
            this.picList.BackColor = System.Drawing.Color.Transparent;
            this.picList.BackgroundImage = global::MyMusicBox.Properties.Resources.musicList;
            this.picList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picList.Location = new System.Drawing.Point(254, 1);
            this.picList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picList.Name = "picList";
            this.picList.Size = new System.Drawing.Size(87, 92);
            this.picList.TabIndex = 6;
            this.picList.TabStop = false;
            this.picList.Click += new System.EventHandler(this.picList_Click);
            this.picList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picList_MouseClick);
            this.picList.MouseEnter += new System.EventHandler(this.picList_MouseEnter);
            this.picList.MouseLeave += new System.EventHandler(this.picList_MouseLeave);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::MyMusicBox.Properties.Resources.close;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Location = new System.Drawing.Point(1466, 2);
            this.picClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(57, 55);
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseClick);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // picMins
            // 
            this.picMins.BackColor = System.Drawing.Color.Transparent;
            this.picMins.BackgroundImage = global::MyMusicBox.Properties.Resources.mins;
            this.picMins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMins.Location = new System.Drawing.Point(1402, 2);
            this.picMins.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picMins.Name = "picMins";
            this.picMins.Size = new System.Drawing.Size(57, 55);
            this.picMins.TabIndex = 2;
            this.picMins.TabStop = false;
            this.picMins.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picMins_MouseClick);
            this.picMins.MouseEnter += new System.EventHandler(this.picMins_MouseEnter);
            this.picMins.MouseLeave += new System.EventHandler(this.picMins_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLyric1
            // 
            this.lblLyric1.AutoSize = true;
            this.lblLyric1.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric1.Font = new System.Drawing.Font("幼圆", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLyric1.ForeColor = System.Drawing.Color.White;
            this.lblLyric1.Location = new System.Drawing.Point(590, 56);
            this.lblLyric1.Name = "lblLyric1";
            this.lblLyric1.Size = new System.Drawing.Size(0, 16);
            this.lblLyric1.TabIndex = 4;
            // 
            // lblLyric2
            // 
            this.lblLyric2.AutoSize = true;
            this.lblLyric2.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLyric2.ForeColor = System.Drawing.Color.White;
            this.lblLyric2.Location = new System.Drawing.Point(590, 102);
            this.lblLyric2.Name = "lblLyric2";
            this.lblLyric2.Size = new System.Drawing.Size(0, 24);
            this.lblLyric2.TabIndex = 5;
            // 
            // lblLyric3
            // 
            this.lblLyric3.AutoSize = true;
            this.lblLyric3.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric3.Font = new System.Drawing.Font("幼圆", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLyric3.ForeColor = System.Drawing.Color.White;
            this.lblLyric3.Location = new System.Drawing.Point(590, 151);
            this.lblLyric3.Name = "lblLyric3";
            this.lblLyric3.Size = new System.Drawing.Size(0, 33);
            this.lblLyric3.TabIndex = 6;
            // 
            // lblLyric4
            // 
            this.lblLyric4.AutoSize = true;
            this.lblLyric4.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric4.Font = new System.Drawing.Font("幼圆", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLyric4.ForeColor = System.Drawing.Color.White;
            this.lblLyric4.Location = new System.Drawing.Point(590, 210);
            this.lblLyric4.Name = "lblLyric4";
            this.lblLyric4.Size = new System.Drawing.Size(0, 40);
            this.lblLyric4.TabIndex = 7;
            // 
            // lblLyric5
            // 
            this.lblLyric5.AutoSize = true;
            this.lblLyric5.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric5.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLyric5.ForeColor = System.Drawing.Color.White;
            this.lblLyric5.Location = new System.Drawing.Point(590, 278);
            this.lblLyric5.Name = "lblLyric5";
            this.lblLyric5.Size = new System.Drawing.Size(0, 48);
            this.lblLyric5.TabIndex = 8;
            // 
            // lblLyric6
            // 
            this.lblLyric6.AutoSize = true;
            this.lblLyric6.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric6.Font = new System.Drawing.Font("幼圆", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLyric6.ForeColor = System.Drawing.Color.Yellow;
            this.lblLyric6.Location = new System.Drawing.Point(590, 360);
            this.lblLyric6.Name = "lblLyric6";
            this.lblLyric6.Size = new System.Drawing.Size(0, 52);
            this.lblLyric6.TabIndex = 9;
            // 
            // lblLyric7
            // 
            this.lblLyric7.AutoSize = true;
            this.lblLyric7.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric7.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLyric7.ForeColor = System.Drawing.Color.White;
            this.lblLyric7.Location = new System.Drawing.Point(590, 436);
            this.lblLyric7.Name = "lblLyric7";
            this.lblLyric7.Size = new System.Drawing.Size(0, 48);
            this.lblLyric7.TabIndex = 10;
            // 
            // lblLyric8
            // 
            this.lblLyric8.AutoSize = true;
            this.lblLyric8.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric8.Font = new System.Drawing.Font("幼圆", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLyric8.ForeColor = System.Drawing.Color.White;
            this.lblLyric8.Location = new System.Drawing.Point(590, 504);
            this.lblLyric8.Name = "lblLyric8";
            this.lblLyric8.Size = new System.Drawing.Size(0, 45);
            this.lblLyric8.TabIndex = 11;
            // 
            // lblLyric9
            // 
            this.lblLyric9.AutoSize = true;
            this.lblLyric9.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric9.Font = new System.Drawing.Font("幼圆", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLyric9.ForeColor = System.Drawing.Color.White;
            this.lblLyric9.Location = new System.Drawing.Point(590, 569);
            this.lblLyric9.Name = "lblLyric9";
            this.lblLyric9.Size = new System.Drawing.Size(0, 40);
            this.lblLyric9.TabIndex = 12;
            // 
            // lblLyric10
            // 
            this.lblLyric10.AutoSize = true;
            this.lblLyric10.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric10.Font = new System.Drawing.Font("幼圆", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLyric10.ForeColor = System.Drawing.Color.White;
            this.lblLyric10.Location = new System.Drawing.Point(590, 628);
            this.lblLyric10.Name = "lblLyric10";
            this.lblLyric10.Size = new System.Drawing.Size(0, 33);
            this.lblLyric10.TabIndex = 13;
            // 
            // lblLyric11
            // 
            this.lblLyric11.AutoSize = true;
            this.lblLyric11.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric11.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLyric11.ForeColor = System.Drawing.Color.White;
            this.lblLyric11.Location = new System.Drawing.Point(590, 677);
            this.lblLyric11.Name = "lblLyric11";
            this.lblLyric11.Size = new System.Drawing.Size(0, 24);
            this.lblLyric11.TabIndex = 14;
            // 
            // lblLyric12
            // 
            this.lblLyric12.AutoSize = true;
            this.lblLyric12.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric12.Font = new System.Drawing.Font("幼圆", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLyric12.ForeColor = System.Drawing.Color.White;
            this.lblLyric12.Location = new System.Drawing.Point(590, 722);
            this.lblLyric12.Name = "lblLyric12";
            this.lblLyric12.Size = new System.Drawing.Size(0, 16);
            this.lblLyric12.TabIndex = 15;
            // 
            // pnlMusic
            // 
            this.pnlMusic.AutoScroll = true;
            this.pnlMusic.BackColor = System.Drawing.Color.Transparent;
            this.pnlMusic.Location = new System.Drawing.Point(0, 78);
            this.pnlMusic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMusic.Name = "pnlMusic";
            this.pnlMusic.Size = new System.Drawing.Size(338, 516);
            this.pnlMusic.TabIndex = 18;
            // 
            // lblAddmusic
            // 
            this.lblAddmusic.BackColor = System.Drawing.Color.Transparent;
            this.lblAddmusic.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddmusic.ForeColor = System.Drawing.Color.Gray;
            this.lblAddmusic.Location = new System.Drawing.Point(74, 622);
            this.lblAddmusic.Name = "lblAddmusic";
            this.lblAddmusic.Size = new System.Drawing.Size(128, 37);
            this.lblAddmusic.TabIndex = 3;
            this.lblAddmusic.Text = "添加歌曲";
            // 
            // picAddmusic
            // 
            this.picAddmusic.BackColor = System.Drawing.Color.Transparent;
            this.picAddmusic.BackgroundImage = global::MyMusicBox.Properties.Resources.addmusic;
            this.picAddmusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAddmusic.Location = new System.Drawing.Point(0, 601);
            this.picAddmusic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picAddmusic.Name = "picAddmusic";
            this.picAddmusic.Size = new System.Drawing.Size(68, 72);
            this.picAddmusic.TabIndex = 2;
            this.picAddmusic.TabStop = false;
            this.picAddmusic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picAddmusic_MouseClick);
            // 
            // lblPlayList
            // 
            this.lblPlayList.AutoSize = true;
            this.lblPlayList.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayList.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPlayList.ForeColor = System.Drawing.Color.White;
            this.lblPlayList.Location = new System.Drawing.Point(-2, 4);
            this.lblPlayList.Name = "lblPlayList";
            this.lblPlayList.Size = new System.Drawing.Size(106, 24);
            this.lblPlayList.TabIndex = 1;
            this.lblPlayList.Text = "播放列表";
            // 
            // pnlAll
            // 
            this.pnlAll.BackColor = System.Drawing.Color.Transparent;
            this.pnlAll.Controls.Add(this.lblPlayList);
            this.pnlAll.Controls.Add(this.picAddmusic);
            this.pnlAll.Controls.Add(this.pnlMusic);
            this.pnlAll.Controls.Add(this.lblAddmusic);
            this.pnlAll.Location = new System.Drawing.Point(1187, 182);
            this.pnlAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlAll.Name = "pnlAll";
            this.pnlAll.Size = new System.Drawing.Size(357, 672);
            this.pnlAll.TabIndex = 21;
            this.pnlAll.Visible = false;
            // 
            // picSingle
            // 
            this.picSingle.BackColor = System.Drawing.Color.Transparent;
            this.picSingle.BackgroundImage = global::MyMusicBox.Properties.Resources.single;
            this.picSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSingle.Location = new System.Drawing.Point(-17, 0);
            this.picSingle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picSingle.Name = "picSingle";
            this.picSingle.Size = new System.Drawing.Size(116, 90);
            this.picSingle.TabIndex = 22;
            this.picSingle.TabStop = false;
            this.picSingle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picSingle_MouseClick);
            this.picSingle.MouseEnter += new System.EventHandler(this.picSingle_MouseEnter);
            this.picSingle.MouseLeave += new System.EventHandler(this.picSingle_MouseLeave);
            // 
            // pnlMode
            // 
            this.pnlMode.BackColor = System.Drawing.Color.Transparent;
            this.pnlMode.Controls.Add(this.picRandom);
            this.pnlMode.Controls.Add(this.picloop);
            this.pnlMode.Controls.Add(this.picSingle);
            this.pnlMode.Location = new System.Drawing.Point(1188, 586);
            this.pnlMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMode.Name = "pnlMode";
            this.pnlMode.Size = new System.Drawing.Size(84, 270);
            this.pnlMode.TabIndex = 23;
            this.pnlMode.Visible = false;
            // 
            // picRandom
            // 
            this.picRandom.BackColor = System.Drawing.Color.Transparent;
            this.picRandom.BackgroundImage = global::MyMusicBox.Properties.Resources.random;
            this.picRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRandom.Location = new System.Drawing.Point(0, 178);
            this.picRandom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picRandom.Name = "picRandom";
            this.picRandom.Size = new System.Drawing.Size(84, 90);
            this.picRandom.TabIndex = 24;
            this.picRandom.TabStop = false;
            this.picRandom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picRandom_MouseClick);
            this.picRandom.MouseEnter += new System.EventHandler(this.picRandom_MouseEnter);
            this.picRandom.MouseLeave += new System.EventHandler(this.picRandom_MouseLeave);
            // 
            // picloop
            // 
            this.picloop.BackColor = System.Drawing.Color.Transparent;
            this.picloop.BackgroundImage = global::MyMusicBox.Properties.Resources.loop;
            this.picloop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picloop.Location = new System.Drawing.Point(0, 89);
            this.picloop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picloop.Name = "picloop";
            this.picloop.Size = new System.Drawing.Size(84, 90);
            this.picloop.TabIndex = 23;
            this.picloop.TabStop = false;
            this.picloop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picloop_MouseClick);
            this.picloop.MouseEnter += new System.EventHandler(this.picloop_MouseEnter);
            this.picloop.MouseLeave += new System.EventHandler(this.picloop_MouseLeave);
            // 
            // lblplaying
            // 
            this.lblplaying.AutoSize = true;
            this.lblplaying.BackColor = System.Drawing.Color.Transparent;
            this.lblplaying.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblplaying.ForeColor = System.Drawing.Color.White;
            this.lblplaying.Location = new System.Drawing.Point(512, 653);
            this.lblplaying.Name = "lblplaying";
            this.lblplaying.Size = new System.Drawing.Size(0, 22);
            this.lblplaying.TabIndex = 24;
            // 
            // pnlControl1
            // 
            this.pnlControl1.BackColor = System.Drawing.Color.Transparent;
            this.pnlControl1.Controls.Add(this.picNext);
            this.pnlControl1.Controls.Add(this.picPlay);
            this.pnlControl1.Controls.Add(this.picLast);
            this.pnlControl1.Controls.Add(this.picThema);
            this.pnlControl1.Location = new System.Drawing.Point(-2, 854);
            this.pnlControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControl1.Name = "pnlControl1";
            this.pnlControl1.Size = new System.Drawing.Size(370, 98);
            this.pnlControl1.TabIndex = 25;
            // 
            // pnlControl2
            // 
            this.pnlControl2.BackColor = System.Drawing.Color.Transparent;
            this.pnlControl2.Controls.Add(this.picVolume);
            this.pnlControl2.Controls.Add(this.picMode);
            this.pnlControl2.Controls.Add(this.picLove);
            this.pnlControl2.Controls.Add(this.picList);
            this.pnlControl2.Location = new System.Drawing.Point(1187, 854);
            this.pnlControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControl2.Name = "pnlControl2";
            this.pnlControl2.Size = new System.Drawing.Size(340, 95);
            this.pnlControl2.TabIndex = 26;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(421, 182);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(169, 115);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // fraMusicBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyMusicBox.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1527, 948);
            this.Controls.Add(this.pnlControl2);
            this.Controls.Add(this.pnlControl1);
            this.Controls.Add(this.lblplaying);
            this.Controls.Add(this.lblDisplayTime);
            this.Controls.Add(this.pnlMode);
            this.Controls.Add(this.lblLyric12);
            this.Controls.Add(this.lblLyric11);
            this.Controls.Add(this.lblLyric10);
            this.Controls.Add(this.lblLyric9);
            this.Controls.Add(this.lblLyric8);
            this.Controls.Add(this.lblLyric7);
            this.Controls.Add(this.lblLyric6);
            this.Controls.Add(this.lblLyric5);
            this.Controls.Add(this.lblLyric4);
            this.Controls.Add(this.lblLyric3);
            this.Controls.Add(this.lblLyric2);
            this.Controls.Add(this.lblLyric1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.picMins);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.pnlAll);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fraMusicBox";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fraMusicBox_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fraMusicBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fraMusicBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fraMusicBox_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picThema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddmusic)).EndInit();
            this.pnlAll.ResumeLayout(false);
            this.pnlAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSingle)).EndInit();
            this.pnlMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRandom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picloop)).EndInit();
            this.pnlControl1.ResumeLayout(false);
            this.pnlControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picMode;
        private System.Windows.Forms.PictureBox picVolume;
        private System.Windows.Forms.PictureBox picLove;
        private System.Windows.Forms.PictureBox picList;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picLast;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMins;
        private System.Windows.Forms.PictureBox picThema;
        private System.Windows.Forms.Label lblDisplayTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLyric1;
        private System.Windows.Forms.Label lblLyric2;
        private System.Windows.Forms.Label lblLyric3;
        private System.Windows.Forms.Label lblLyric4;
        private System.Windows.Forms.Label lblLyric5;
        private System.Windows.Forms.Label lblLyric6;
        private System.Windows.Forms.Label lblLyric7;
        private System.Windows.Forms.Label lblLyric8;
        private System.Windows.Forms.Label lblLyric9;
        private System.Windows.Forms.Label lblLyric10;
        private System.Windows.Forms.Label lblLyric11;
        private System.Windows.Forms.Label lblLyric12;
        private System.Windows.Forms.Panel pnlMusic;
        private System.Windows.Forms.Label lblPlayList;
        private System.Windows.Forms.PictureBox picAddmusic;
        private System.Windows.Forms.Label lblAddmusic;
        private System.Windows.Forms.Panel pnlAll;
        private System.Windows.Forms.PictureBox picSingle;
        private System.Windows.Forms.Panel pnlMode;
        private System.Windows.Forms.PictureBox picloop;
        private System.Windows.Forms.PictureBox picRandom;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblplaying;
        private System.Windows.Forms.Panel pnlControl1;
        private System.Windows.Forms.Panel pnlControl2;
    }
}

