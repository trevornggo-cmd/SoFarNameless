using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoFarNoName
{
    public partial class Form1 : Form
    {
        public int speed = 3;

        public int count = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "WinForm Course Session 1";
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {            

            if (e.KeyCode == Keys.W)
                WButton.Start();

            if (e.KeyCode == Keys.S)
                SButton.Start();

            if (e.KeyCode == Keys.A)
                AButton.Start();

            if (e.KeyCode == Keys.D)
                DButton.Start();
        }



        private void W_Tick(object sender, EventArgs e)
        {
            lblPlayer.Top -= speed;
        }
        private void S_Tick(object sender, EventArgs e)
        {
            lblPlayer.Top += speed;
        }
        private void A_Tick(object sender, EventArgs e)
        {
            lblPlayer.Left -= speed;
        }
        private void D_Tick(object sender, EventArgs e)
        {
            lblPlayer.Left += speed;
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                WButton.Stop();
            if (e.KeyCode == Keys.S)
                SButton.Stop();
            if (e.KeyCode == Keys.A)
                AButton.Stop();
            if (e.KeyCode == Keys.D)
                DButton.Stop();
        }
    }

      
}
