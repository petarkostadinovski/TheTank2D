using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_v1
{
    public partial class Level2 : Form
    {
        public Point mousePoint { get; set; }
        public double speed;    // speed = power
        public bool increase; // powerBar dali se zgolemuva ili namaluva
        public int hits;
        public int total;
        public double radians;
        public bool drawAim;
        public bool RopeHit;

        public string FileName { get; set; }
        Aim aim { get; set; }
        Barrel barrel { get; set; }
        AmmoMagazine ammo { get; set; }

        SoundPlayer tankFire = new SoundPlayer(Game_v1.Properties.Resources.tankFire);
        SoundPlayer explosionSound = new SoundPlayer(Game_v1.Properties.Resources.explosion);
        SoundPlayer reloadSound = new SoundPlayer(Game_v1.Properties.Resources.reloadSound);
        SoundPlayer wallReleaseSound = new SoundPlayer(Game_v1.Properties.Resources.wallRelease);

        public Level2()
        {
            FileName = string.Empty;
            mousePoint = new Point();
            this.DoubleBuffered = true;
            InitializeComponent();
            barrel = new Barrel(new Point(40,475));
            aim = new Aim();
            radians = 0;
            ammo = new AmmoMagazine();
            hits = 0;
            total = 0;
            increase = true;
            speed = 0; // max speed 25, min speed 0
            healthBar.Visible = true;
            drawAim = true;
            RopeHit = false;         
            barrel.ropeHeight = 80;
            barrel.ropeWidth = 3;
            barrel.wallHeight = 300;
            barrel.wallWidth = 10;
            barrel.wallPosX = 630;
            barrel.wallPosY = 10;
            barrel.buttonPosX = 480;
            barrel.buttonPosY = 415;
            barrel.buttonHeight = 20;
            barrel.buttonWidth = 20;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void Level2_Paint(object sender, PaintEventArgs e)
        {
            barrel.drawBarrel(e.Graphics, radians);
            ammo.drawGrayAmmo(e.Graphics);
            if (drawAim && !toolStrip1.Visible)
                aim.draw(e.Graphics);
            if (drawHeli)
                barrel.drawHeli(e.Graphics);

            barrel.drawRope(e.Graphics);
            barrel.drawWall(e.Graphics);
            barrel.drawButton(e.Graphics);
        }
          
        private void Level2_MouseClick(object sender, MouseEventArgs e)
        {
            // ogranicen e agolot na interval 0 <= x <= 90
            double opp = 475 - e.Y;
            double adj = e.X - 40;
            if (e.X < 40 && e.Y < 475) radians = (Math.PI) / 2;
            else if (e.Y > 475) radians = 0;
            else radians = (Math.Atan2(opp, adj));
        }

        private void Level2_MouseMove(object sender, MouseEventArgs e)
        {
            var temp = new Point(e.X, e.Y);
            mousePoint = temp;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            var res = MessageBox.Show("Are you sure you want to start a new game?", "Start a new game",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                DialogResult = DialogResult.Yes;
            }
            if (toolStripButton4.Text != "Resume")
                timer1.Start();
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var dialog = new SaveFileDialog();
            dialog.Filter = "Tank Game document (*.tgd)|*.tgd";
            dialog.Title = "Save your game";
            if (FileName != string.Empty)
                dialog.FileName = FileName.Substring(FileName.LastIndexOf('\\') + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                FileName = dialog.FileName;
            else
            {
                if (toolStripButton4.Text != "Resume")
                    timer1.Start();
                return;
            }

            try
            {
                using (var stream = new FileStream(FileName, FileMode.Create, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, ammo);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXEPTION HAS HAPPENED! HERE ARE DETAILS:\n\n{exception}");
            }
            finally
            {
                if (toolStripButton4.Text != "Resume")
                    timer1.Start();
            }
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (FileName == string.Empty)
            {
                ToolStripButton6_Click(sender, e);
                return;
            }
            try
            {
                using (var stream = new FileStream(FileName, FileMode.Create, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, ammo);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXEPTION HAS HAPPENED! HERE ARE DETAILS:\n\n{exception}");
            }
            finally
            {
                if (toolStripButton4.Text != "Resume")
                    timer1.Start();
            }
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var dialog = new OpenFileDialog();
            dialog.Filter = "Tank Game document (*.tgd)|*.tgd";
            dialog.Title = "Open your game";
            if (FileName != string.Empty)
                dialog.FileName = FileName.Substring(FileName.LastIndexOf('\\') + 1);

            if (dialog.ShowDialog() == DialogResult.OK)
                FileName = dialog.FileName;
            else
            {
                if (toolStripButton4.Text != "Resume")
                    timer1.Start();
                return;
            }
            try
            {
                using (var stream = new FileStream(FileName, FileMode.Open, FileAccess.Read))
                {
                    var formatter = new BinaryFormatter();
                    ammo = (AmmoMagazine)formatter.Deserialize(stream);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"EXEPTION HAS HAPPENED! HERE ARE DETAILS:\n\n{exception}");
            }
            finally
            {
                Invalidate(true);
                if (toolStripButton4.Text != "Resume")
                    timer1.Start();
            }
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            if (toolStripButton4.Text == "Pause")
            {
                timer1.Stop();
                toolStripButton4.Text = "Resume";
            }
            else
            {
                timer1.Start();
                toolStripButton4.Text = "Pause";
            }
            Invalidate(true);
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void HeliPicture_Click(object sender, EventArgs e)
        {

        }

        private void AmmoPicture_Click(object sender, EventArgs e)
        {

        }

        private void TargetPicture_Click(object sender, EventArgs e)
        {

        }

        private void HealthBar_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            barrel.motionHeli(); //helicopter blades rotation
            ammoLeft.Text = ammo.count.ToString();
            ammo.score = ((double)hits / total * 10);
            score.Text = String.Format("{0:0.00}/10", ammo.score);

            if (!(barrel.upY)) // up-down motion of heli picture
            {
                HeliPicture.Location = new Point(HeliPicture.Location.X, HeliPicture.Location.Y + 2);
                if(RopeHit==false)
                    ammoPicture.Location = new Point(ammoPicture.Location.X, ammoPicture.Location.Y + 2);
            }
            else
            {
                HeliPicture.Location = new Point(HeliPicture.Location.X, HeliPicture.Location.Y - 2);
                if (RopeHit == false)
                 ammoPicture.Location = new Point(ammoPicture.Location.X, ammoPicture.Location.Y - 2);
            }

            toolStripStatusLabel1.Text = "Hits: " + hits + " - Misses: " + (total - hits);

            barrel.move(radians);
            ammo.move();
            ammo.Check();
            aim.move(mousePoint);

            try
            {
                if (powerBar.Value == 100) increase = false;
                if (powerBar.Value == 0) increase = true;
                if (increase)
                {
                    powerBar.Value += 2;
                }
                else
                {
                    powerBar.Value -= 2;
                }
            }
            catch { }

           if (ammo.isHit(HeliPicture.Location, new Point(HeliPicture.Location.X + 130, HeliPicture.Location.Y + 60)))
            {
                explosionSound.Play();
                HeliPicture.Visible = false;
                drawHeli = false;
                MessageBox.Show("You killed your pilot.", "Game Over", MessageBoxButtons.OK);
                timer1.Stop();
                levelPanel2.Visible = true;
                textPassed.Text = "YOU FAILED THE LEVEL";
            }   // check helicopter hit

            if (healthBar.Value > 0 && ammo.isHit(targetPicture.Location,
             new Point(targetPicture.Location.X + targetPicture.Width, targetPicture.Location.Y + targetPicture.Height)))
            {
                explosionSound.Play();
                hits++;
                healthBar.Value -= 20;
                if (healthBar.Value <= 0)
                {
                    targetPicture.Visible = false;
                    healthBar.Visible = false;
                    levelPanel2.Visible = true;
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                }
            }   // Check hits on target building minus 10 health per hit

            ammo.isHit(Obsticle1.Location, new Point(Obsticle1.Location.X + Obsticle1.Width, Obsticle1.Location.Y + Obsticle1.Height));
            ammo.isHit(new Point(330,435), new Point(this.Width,this.Height));  // ground obsticle
            ammo.isHit(new Point(530,310), new Point(this.Width, this.Height)); // ground obsticle
            ammo.isHit(new Point(barrel.wallPosX, barrel.wallPosY),             // wall collide 
                new Point(barrel.wallPosX+barrel.wallWidth+5, barrel.wallPosY+barrel.wallHeight+5));

            if (ammo.isHit(new Point(barrel.ropePosX,barrel.ropePosY),
                new Point(barrel.ropePosX+barrel.ropeWidth, barrel.ropePosY + barrel.ropeHeight)) || RopeHit==true)
            {
                barrel.upY = true;
                if (barrel.heliY1 == 20 ) barrel.heliY1 = 19;
                    RopeHit = true;
                if ((ammoPicture.Location.Y >= 396 & ammoPicture.Location.Y <= 400))
                {
                    barrel.RopeDelete();
                    barrel.RopeFall();
                    
                    if (ammoPicture.Visible) // move wall
                    {
                        barrel.moveWall();
                        //wallReleaseSound.Play();
                    }
                }
                else
                {
                    barrel.RopeFall();
                    ammoPicture.Location = new Point(ammoPicture.Location.X, ammoPicture.Location.Y + 5);
                }
            }
            else if(RopeHit==false)
            {
                barrel.moveRope(HeliPicture.Location.X, HeliPicture.Location.Y);
            }

            if (ammo.getAmmo && ammo.isHit(ammoPicture.Location, new Point(ammoPicture.Location.X + ammoPicture.Width, ammoPicture.Location.Y + ammoPicture.Height)))
            {
                reloadSound.Play();
                ammo.count += 5;
                ammo.getAmmo = false;
                ammoPicture.Visible = false;
            }
            Invalidate(true);
        }
        bool drawHeli = true;
        private void Timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void PowerBar_Click(object sender, EventArgs e)
        {

        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Level2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                if (ammo.count == 0 && healthBar.Value != 0)
                {
                    timer1.Stop();
                    levelPanel2.Visible = true;
                    textPassed.Text = "YOU FAILED THE LEVEL";
                }
                if (ammo.count != 0)
                {
                    tankFire.Play();
                    speed = (powerBar.Value / 4);
                    var speedx = Math.Cos(radians) * speed;
                    var speedy = Math.Sin(radians) * speed * -1;
                    var posx = barrel.getBarrelExit().X;
                    var posy = barrel.getBarrelExit().Y;
                    Ammo t = new Ammo(new Point(posx, posy), speedx, speedy);
                    ammo.add(t);
                    ammo.count--;
                    total++;
                }
            }
        }

        private void PictureBox2_MouseHover(object sender, EventArgs e)
        {
            drawAim = false;
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            drawAim = true;
        }

        private void ToolStrip1_MouseLeave(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
        }

        private void ToolStrip1_MouseHover(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
        }

        private void BtnRestart2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes; // yes == level 2
        }

        private void BtnMainMenu2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // cancel == main menu
        }

        private void QuestionMark_MouseHover(object sender, EventArgs e)
        {
            hintLabel.Visible = true;
        }

        private void QuestionMark_MouseLeave(object sender, EventArgs e)
        {
            hintLabel.Visible = false;
        }
    }
}
