namespace Game_v1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbNewGame = new System.Windows.Forms.Label();
            this.lbHowToPlay = new System.Windows.Forms.Label();
            this.lbQuit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNewGame
            // 
            this.lbNewGame.AllowDrop = true;
            this.lbNewGame.AutoSize = true;
            this.lbNewGame.BackColor = System.Drawing.Color.Transparent;
            this.lbNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNewGame.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewGame.ForeColor = System.Drawing.Color.DarkGray;
            this.lbNewGame.Location = new System.Drawing.Point(312, 284);
            this.lbNewGame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewGame.Name = "lbNewGame";
            this.lbNewGame.Size = new System.Drawing.Size(112, 26);
            this.lbNewGame.TabIndex = 3;
            this.lbNewGame.Text = "New Game";
            this.lbNewGame.Click += new System.EventHandler(this.LbNewGame_Click);
            this.lbNewGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LbNewGame_MouseClick);
            this.lbNewGame.MouseLeave += new System.EventHandler(this.LbNewGame_MouseLeave);
            this.lbNewGame.MouseHover += new System.EventHandler(this.LbNewGame_MouseHover);
            // 
            // lbHowToPlay
            // 
            this.lbHowToPlay.AutoSize = true;
            this.lbHowToPlay.BackColor = System.Drawing.Color.Transparent;
            this.lbHowToPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbHowToPlay.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHowToPlay.ForeColor = System.Drawing.Color.DarkGray;
            this.lbHowToPlay.Location = new System.Drawing.Point(305, 319);
            this.lbHowToPlay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHowToPlay.Name = "lbHowToPlay";
            this.lbHowToPlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbHowToPlay.Size = new System.Drawing.Size(127, 26);
            this.lbHowToPlay.TabIndex = 4;
            this.lbHowToPlay.Text = "How to Play";
            this.lbHowToPlay.Click += new System.EventHandler(this.LbHowToPlay_Click);
            this.lbHowToPlay.MouseLeave += new System.EventHandler(this.LbHowToPlay_MouseLeave);
            this.lbHowToPlay.MouseHover += new System.EventHandler(this.LbHowToPlay_MouseHover);
            // 
            // lbQuit
            // 
            this.lbQuit.AutoSize = true;
            this.lbQuit.BackColor = System.Drawing.Color.Transparent;
            this.lbQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbQuit.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuit.ForeColor = System.Drawing.Color.DarkGray;
            this.lbQuit.Location = new System.Drawing.Point(317, 358);
            this.lbQuit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuit.Name = "lbQuit";
            this.lbQuit.Size = new System.Drawing.Size(107, 26);
            this.lbQuit.TabIndex = 5;
            this.lbQuit.Text = "Exit Game";
            this.lbQuit.Click += new System.EventHandler(this.LbQuit_Click);
            this.lbQuit.MouseLeave += new System.EventHandler(this.LbQuit_MouseLeave);
            this.lbQuit.MouseHover += new System.EventHandler(this.LbQuit_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Game_v1.Properties.Resources.nameImage;
            this.pictureBox1.Location = new System.Drawing.Point(432, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 370);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "v1.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 392);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbQuit);
            this.Controls.Add(this.lbHowToPlay);
            this.Controls.Add(this.lbNewGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = " Tank Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNewGame;
        private System.Windows.Forms.Label lbHowToPlay;
        private System.Windows.Forms.Label lbQuit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

