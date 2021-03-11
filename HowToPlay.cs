using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_v1
{
    public partial class HowToPlay : Form
    {
       
        public HowToPlay()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e) // Don't got it
        {
            MessageBox.Show("Read it again", "Read it again", MessageBoxButtons.OK);
        }

        
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void HowToPlay_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
