namespace Game_v1
{
    partial class MainGameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.powerBar = new System.Windows.Forms.ProgressBar();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.targetPicture = new System.Windows.Forms.PictureBox();
            this.Obsticle1 = new System.Windows.Forms.PictureBox();
            this.Obsticle2 = new System.Windows.Forms.PictureBox();
            this.HeliPicture = new System.Windows.Forms.PictureBox();
            this.ammoPicture = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.levelPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.textPassed = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obsticle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obsticle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeliPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoPicture)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.levelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 554);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // powerBar
            // 
            this.powerBar.Location = new System.Drawing.Point(5, 626);
            this.powerBar.Margin = new System.Windows.Forms.Padding(4);
            this.powerBar.Name = "powerBar";
            this.powerBar.Size = new System.Drawing.Size(720, 33);
            this.powerBar.TabIndex = 1;
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(1155, 444);
            this.healthBar.Margin = new System.Windows.Forms.Padding(4);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(133, 28);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            this.healthBar.Visible = false;
            // 
            // targetPicture
            // 
            this.targetPicture.BackColor = System.Drawing.Color.Transparent;
            this.targetPicture.Image = ((System.Drawing.Image)(resources.GetObject("targetPicture.Image")));
            this.targetPicture.Location = new System.Drawing.Point(1088, 480);
            this.targetPicture.Margin = new System.Windows.Forms.Padding(4);
            this.targetPicture.Name = "targetPicture";
            this.targetPicture.Size = new System.Drawing.Size(267, 123);
            this.targetPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.targetPicture.TabIndex = 4;
            this.targetPicture.TabStop = false;
            this.targetPicture.Click += new System.EventHandler(this.TargetPicture_Click);
            this.targetPicture.MouseLeave += new System.EventHandler(this.TargetPicture_MouseLeave);
            this.targetPicture.MouseHover += new System.EventHandler(this.TargetPicture_MouseHover);
            // 
            // Obsticle1
            // 
            this.Obsticle1.BackColor = System.Drawing.Color.Transparent;
            this.Obsticle1.Image = ((System.Drawing.Image)(resources.GetObject("Obsticle1.Image")));
            this.Obsticle1.InitialImage = null;
            this.Obsticle1.Location = new System.Drawing.Point(440, 418);
            this.Obsticle1.Margin = new System.Windows.Forms.Padding(4);
            this.Obsticle1.Name = "Obsticle1";
            this.Obsticle1.Size = new System.Drawing.Size(267, 185);
            this.Obsticle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obsticle1.TabIndex = 5;
            this.Obsticle1.TabStop = false;
            // 
            // Obsticle2
            // 
            this.Obsticle2.BackColor = System.Drawing.Color.Transparent;
            this.Obsticle2.Image = ((System.Drawing.Image)(resources.GetObject("Obsticle2.Image")));
            this.Obsticle2.InitialImage = null;
            this.Obsticle2.Location = new System.Drawing.Point(715, 337);
            this.Obsticle2.Margin = new System.Windows.Forms.Padding(4);
            this.Obsticle2.Name = "Obsticle2";
            this.Obsticle2.Size = new System.Drawing.Size(173, 266);
            this.Obsticle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obsticle2.TabIndex = 6;
            this.Obsticle2.TabStop = false;
            // 
            // HeliPicture
            // 
            this.HeliPicture.BackColor = System.Drawing.Color.Transparent;
            this.HeliPicture.Image = ((System.Drawing.Image)(resources.GetObject("HeliPicture.Image")));
            this.HeliPicture.Location = new System.Drawing.Point(605, 37);
            this.HeliPicture.Margin = new System.Windows.Forms.Padding(4);
            this.HeliPicture.Name = "HeliPicture";
            this.HeliPicture.Size = new System.Drawing.Size(173, 74);
            this.HeliPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeliPicture.TabIndex = 7;
            this.HeliPicture.TabStop = false;
            // 
            // ammoPicture
            // 
            this.ammoPicture.BackColor = System.Drawing.Color.Transparent;
            this.ammoPicture.Image = ((System.Drawing.Image)(resources.GetObject("ammoPicture.Image")));
            this.ammoPicture.Location = new System.Drawing.Point(627, 111);
            this.ammoPicture.Margin = new System.Windows.Forms.Padding(4);
            this.ammoPicture.Name = "ammoPicture";
            this.ammoPicture.Size = new System.Drawing.Size(80, 62);
            this.ammoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ammoPicture.TabIndex = 8;
            this.ammoPicture.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1149, 626);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1371, 26);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton6,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip1.Location = new System.Drawing.Point(85, 14);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(217, 234);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            this.toolStrip1.MouseLeave += new System.EventHandler(this.ToolStrip1_MouseLeave);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.toolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(136, 36);
            this.toolStripButton1.Text = "New Game";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            this.toolStripButton1.MouseHover += new System.EventHandler(this.ToolStripButton1_MouseHover);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.toolStripButton6.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(101, 36);
            this.toolStripButton6.Text = "Save As";
            this.toolStripButton6.Click += new System.EventHandler(this.ToolStripButton6_Click);
            this.toolStripButton6.MouseHover += new System.EventHandler(this.ToolStripButton6_MouseHover);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.toolStripButton2.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(69, 36);
            this.toolStripButton2.Text = "Save";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            this.toolStripButton2.MouseHover += new System.EventHandler(this.ToolStripButton2_MouseHover);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.toolStripButton3.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(78, 36);
            this.toolStripButton3.Text = "Open";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            this.toolStripButton3.MouseHover += new System.EventHandler(this.ToolStripButton3_MouseHover);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.toolStripButton4.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(80, 36);
            this.toolStripButton4.Text = "Pause";
            this.toolStripButton4.Click += new System.EventHandler(this.ToolStripButton4_Click);
            this.toolStripButton4.MouseHover += new System.EventHandler(this.ToolStripButton4_MouseHover);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.toolStripButton5.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(216, 36);
            this.toolStripButton5.Text = "Exit to Main Menu";
            this.toolStripButton5.Click += new System.EventHandler(this.ToolStripButton5_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Game_v1.Properties.Resources.menuIcon;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.PictureBox2_MouseLeave_1);
            this.pictureBox2.MouseHover += new System.EventHandler(this.PictureBox2_MouseHover_1);
            // 
            // levelPanel
            // 
            this.levelPanel.Controls.Add(this.label4);
            this.levelPanel.Controls.Add(this.score);
            this.levelPanel.Controls.Add(this.textPassed);
            this.levelPanel.Controls.Add(this.button3);
            this.levelPanel.Controls.Add(this.btnMainMenu);
            this.levelPanel.Controls.Add(this.btnRestart);
            this.levelPanel.Location = new System.Drawing.Point(269, 233);
            this.levelPanel.Margin = new System.Windows.Forms.Padding(4);
            this.levelPanel.Name = "levelPanel";
            this.levelPanel.Size = new System.Drawing.Size(833, 224);
            this.levelPanel.TabIndex = 15;
            this.levelPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Your score:";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(440, 64);
            this.score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(64, 25);
            this.score.TabIndex = 28;
            this.score.Text = "label4";
            this.score.Click += new System.EventHandler(this.Score_Click);
            // 
            // textPassed
            // 
            this.textPassed.AutoSize = true;
            this.textPassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassed.Location = new System.Drawing.Point(247, 16);
            this.textPassed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textPassed.Name = "textPassed";
            this.textPassed.Size = new System.Drawing.Size(319, 29);
            this.textPassed.TabIndex = 3;
            this.textPassed.Text = "YOU PASSED THE LEVEL";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(288, 105);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 85);
            this.button3.TabIndex = 2;
            this.button3.Text = "NEXT LEVEL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(553, 105);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(257, 85);
            this.btnMainMenu.TabIndex = 1;
            this.btnMainMenu.Text = "MAIN MENU";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(23, 105);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(257, 85);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "RESTART LEVEL";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(733, 626);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "POWER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(970, 626);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 31);
            this.label5.TabIndex = 28;
            this.label5.Text = "AMMO LEFT";
            // 
            // MainGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1371, 690);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.levelPanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ammoPicture);
            this.Controls.Add(this.HeliPicture);
            this.Controls.Add(this.Obsticle2);
            this.Controls.Add(this.Obsticle1);
            this.Controls.Add(this.targetPicture);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.powerBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainGameWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = " Level 1";
            this.Load += new System.EventHandler(this.MainGameWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainGameWindow_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainGameWindow_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainGameWindow_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainGameWindow_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obsticle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obsticle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeliPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoPicture)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.levelPanel.ResumeLayout(false);
            this.levelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar powerBar;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox targetPicture;
        private System.Windows.Forms.PictureBox Obsticle1;
        private System.Windows.Forms.PictureBox Obsticle2;
        private System.Windows.Forms.PictureBox HeliPicture;
        private System.Windows.Forms.PictureBox ammoPicture;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Panel levelPanel;
        private System.Windows.Forms.Label textPassed;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}