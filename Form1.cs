using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_v1
{
    public partial class Form1 : Form
    {
        SoundPlayer music = new SoundPlayer(Game_v1.Properties.Resources.backgroundMusic);
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnHow_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
           
        }

        private void LbNewGame_Click(object sender, EventArgs e)
        {
            clickSound();
            this.Hide();
            MainGameWindow game = new MainGameWindow();
            game.ShowDialog();
            if (game.DialogResult == DialogResult.Yes) secondLevel();
            else if (game.DialogResult == DialogResult.No) firstLevel();
            else if (game.DialogResult == DialogResult.Cancel) this.Show();
        }
        public void secondLevel()
        {
            Level2 game2 = new Level2();
            game2.ShowDialog();
            if (game2.DialogResult == DialogResult.Yes) secondLevel();
            else if (game2.DialogResult == DialogResult.Cancel) this.Show();
            else if (game2.DialogResult == DialogResult.Cancel) this.Show();
        }
        public void firstLevel()
        {
            MainGameWindow game1 = new MainGameWindow();
            game1.ShowDialog();
            if (game1.DialogResult == DialogResult.Yes) secondLevel();
            else if (game1.DialogResult == DialogResult.No) firstLevel();
            else if (game1.DialogResult == DialogResult.Cancel) this.Show();
        }
        private void LbHowToPlay_Click(object sender, EventArgs e)
        {
            clickSound();
            System.Threading.Thread.Sleep(600);
            music.Play();
            HowToPlay form = new HowToPlay();

            var temp = form.ShowDialog();
            if (temp == DialogResult.OK || temp == DialogResult.Cancel)
                music.Stop();
        }

        private void LbQuit_Click(object sender, EventArgs e)
        {
            clickSound();
            var result = MessageBox.Show("Quit game?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LbNewGame_MouseHover(object sender, EventArgs e)
        {
            lbNewGame.ForeColor = Color.Gold;
            selectSound();
        }

        private void LbHowToPlay_MouseHover(object sender, EventArgs e)
        {
            lbHowToPlay.ForeColor = Color.Gold;
            selectSound();
        }

        private void LbQuit_MouseHover(object sender, EventArgs e)
        {
            lbQuit.ForeColor = Color.Gold;
            selectSound();
        }

        private void LbNewGame_MouseLeave(object sender, EventArgs e)
        {
            lbNewGame.ForeColor = Color.White;
        }

        private void LbHowToPlay_MouseLeave(object sender, EventArgs e)
        {
            lbHowToPlay.ForeColor = Color.White;
        }

        private void LbQuit_MouseLeave(object sender, EventArgs e)
        {
            lbQuit.ForeColor = Color.White;
        }

        private void selectSound()
        {
            SoundPlayer audio = new SoundPlayer(Game_v1.Properties.Resources.selectSound1); 
            audio.Play();
        }
        private void clickSound()
        {
            SoundPlayer audio = new SoundPlayer(Game_v1.Properties.Resources.clickSound);
            audio.Play();
        }

        private void LbNewGame_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
