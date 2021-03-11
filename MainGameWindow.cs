using System;
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
    public partial class MainGameWindow : Form
{

    public Point mousePoint { get; set; }
    public double speed;    // speed = power
    public bool increase; // powerBar dali se zgolemuva ili namaluva
    public int hits;
    public int total;
    public double radians;
    public bool drawAim;
    public string FileName { get; set; }
    Aim aim { get; set; }
    Barrel barrel { get; set; }
    AmmoMagazine ammo { get; set; }

    SoundPlayer tankFire = new SoundPlayer(Game_v1.Properties.Resources.tankFire);
    SoundPlayer explosionSound = new SoundPlayer(Game_v1.Properties.Resources.explosion);
    SoundPlayer reloadSound = new SoundPlayer(Game_v1.Properties.Resources.reloadSound);

    public MainGameWindow()
    {
        this.DoubleBuffered = true;
        InitializeComponent();
        FileName = string.Empty;
        mousePoint = new Point();
        barrel = new Barrel(new Point(130, 460));
        aim = new Aim();
        radians = 0;
        ammo = new AmmoMagazine();
        hits = 0;
        total = 0;
        increase = true;
        speed = 0;      // max speed 25, min speed 0
        healthBar.Visible = true;
        drawAim = true;

        GC.Collect();
        GC.WaitForPendingFinalizers();
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
        ammo.score = ((double)hits / total * 10);
        score.Text = String.Format("{0:0.00}/10", ammo.score);

        barrel.motionHeli(); //helicopter blades rotation
        if (!(barrel.upY)) // up-down motion of heli picture
        {
            HeliPicture.Location = new Point(HeliPicture.Location.X, HeliPicture.Location.Y + 2);
            ammoPicture.Location = new Point(ammoPicture.Location.X, ammoPicture.Location.Y + 2);
        }
        else
        {
            HeliPicture.Location = new Point(HeliPicture.Location.X, HeliPicture.Location.Y - 2);
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
            levelPanel.Visible = true;
            button3.Visible = false; // next level button
            textPassed.Text = "YOU FAILED THE LEVEL";
        }   //check helicopter hit

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
                levelPanel.Visible = true;
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }   // Check hits on target building minus 10 health per hit

        ammo.isHit(Obsticle1.Location, new Point(Obsticle1.Location.X + Obsticle1.Width, Obsticle1.Location.Y + Obsticle1.Height));
        ammo.isHit(Obsticle2.Location, new Point(Obsticle2.Location.X + Obsticle2.Width, Obsticle2.Location.Y + Obsticle2.Height));
        ammo.isHit(new Point(0, 490), new Point(this.Width, this.Height)); // ground obsticle
        if (ammo.getAmmo && ammo.isHit(ammoPicture.Location, new Point(ammoPicture.Location.X + ammoPicture.Width, ammoPicture.Location.Y + ammoPicture.Height)))
        {
            reloadSound.Play();
            ammo.count += 5;
            ammo.getAmmo = false;
            ammoPicture.Visible = false;
        }
        label1.Text = ammo.count.ToString();
        Invalidate(true);
    }

    bool drawHeli = true;
    private void MainGameWindow_Paint(object sender, PaintEventArgs e)
    {
        barrel.drawBarrel(e.Graphics, radians);
        ammo.draw(e.Graphics);
        if (drawAim && !toolStrip1.Visible)
            aim.draw(e.Graphics);
        if (drawHeli)
            barrel.drawHeli(e.Graphics);
    }

    private void MainGameWindow_MouseClick(object sender, MouseEventArgs e) // set angle with mouseClick
    {  // ogranicen e agolot na interval 0 <= x <= 90
        double opp = 460 - e.Y;
        double adj = e.X - 130;
        if (e.X < 130 && e.Y < 460) radians = (Math.PI) / 2;
        else if (e.Y > 460) radians = 0;
        else radians = (Math.Atan2(opp, adj));
    }

    private void MainGameWindow_KeyPress(object sender, KeyPressEventArgs e) // space to shoot
    {
        if (e.KeyChar == ' ')
        {
            if (ammo.count == 0 && healthBar.Value != 0)
            {
                timer1.Stop();
                levelPanel.Visible = true;
                button3.Visible = false; // next level button
                textPassed.Text = "YOU FAILED THE LEVEL";
            }
            if (ammo.count != 0)
            {
                tankFire.Play();
                speed = (powerBar.Value / 4);
                var speedx = Math.Cos(radians) * speed;
                var speedy = Math.Sin(radians) * (-speed);
                var posx = barrel.getBarrelExit().X;
                var posy = barrel.getBarrelExit().Y;
                Ammo t = new Ammo(new Point(posx, posy), speedx, speedy);
                ammo.add(t);
                total++;
                ammo.count--;
            }
        }
    }

    private void MainGameWindow_Load(object sender, EventArgs e)
    {

    }

    private void PictureBox2_MouseHover(object sender, EventArgs e)
    {

    }

    private void PictureBox2_MouseLeave(object sender, EventArgs e)
    {

    }

    private void MainGameWindow_MouseMove(object sender, MouseEventArgs e)
    {
        var temp = new Point(e.X, e.Y);
        mousePoint = temp;
    }

    private void TargetPicture_Click(object sender, EventArgs e)
    {

    }

    private void TargetPicture_MouseHover(object sender, EventArgs e)
    {

    }

    private void TargetPicture_MouseLeave(object sender, EventArgs e)
    {

    }

    private void Timer2_Tick(object sender, EventArgs e) //slower timer
    {

    }

    private void ToolStripButton1_Click(object sender, EventArgs e) // New Game
    {
        timer1.Stop();
        var res = MessageBox.Show("Are you sure you want to start a new game?", "Start a new game",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
            DialogResult = DialogResult.No;
        }
        if (toolStripButton4.Text != "Resume")
            timer1.Start();
    }

    private void ToolStripButton2_Click(object sender, EventArgs e) // Save
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

    private void ToolStripButton3_Click(object sender, EventArgs e) // Open
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

    private void ToolStripButton4_Click(object sender, EventArgs e) // Pause
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

    private void ToolStripButton5_Click(object sender, EventArgs e) // How to Play
    {

    }

    private void ToolStripButton6_Click(object sender, EventArgs e) // Save As
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

    private void PictureBox2_MouseHover_1(object sender, EventArgs e)
    {
        drawAim = false;
    }
    private void PictureBox2_MouseLeave_1(object sender, EventArgs e)
    {
        drawAim = true;
    }

    private void ToolStripButton1_MouseHover(object sender, EventArgs e)
    {

    }

    private void ToolStripButton6_MouseHover(object sender, EventArgs e)
    {

    }

    private void ToolStripButton2_MouseHover(object sender, EventArgs e)
    {

    }

    private void ToolStripButton3_MouseHover(object sender, EventArgs e)
    {

    }

    private void ToolStripButton4_MouseHover(object sender, EventArgs e)
    {

    }

    private void ToolStrip1_MouseLeave(object sender, EventArgs e)
    {
        toolStrip1.Visible = false;
    }

    private void PictureBox2_Click(object sender, EventArgs e)
    {
        toolStrip1.Visible = !toolStrip1.Visible;
    }

    private void ToolStripButton5_Click_1(object sender, EventArgs e)
    {
        this.Close();
    }

    private void Button3_Click(object sender, EventArgs e) // Next level
    {
        DialogResult = DialogResult.Yes; //yes == next level
    }

    private void BtnRestart_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.No; // no == same level
    }

    private void BtnMainMenu_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel; // cancel == main menu
    }

        private void Score_Click(object sender, EventArgs e)
        {

        }
    } }


