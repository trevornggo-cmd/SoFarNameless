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
using System.IO;

namespace SoFarNoName
{
    public partial class Form1 : Form
    {
        int playerSpeed = 10;

        public Form1()
        {
            InitializeComponent();
            this.Text = "little surviver";
            this.KeyPreview = true;
            CheckState.Start();
        }

        private void PlayerLbl_Click(object sender, EventArgs e)
        {

        }
      
        private bool up, down, left, right;
        private void Game_Interval(object sender, EventArgs e)
        {
            int VerticalMovement = 0;
            int HorizontalMovement = 0;
            
            if (up) VerticalMovement--;
            if (down) VerticalMovement++;
            if (left) HorizontalMovement--;
            if (right) HorizontalMovement++;

            PlayerLbl.Top += playerSpeed * VerticalMovement;
            PlayerLbl.Left += playerSpeed * HorizontalMovement;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) up = true;
            if (e.KeyCode == Keys.S) down = true;
            if (e.KeyCode == Keys.A) left = true;
            if (e.KeyCode == Keys.D) right = true;

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) up = false;
            if (e.KeyCode == Keys.S) down = false;
            if (e.KeyCode == Keys.A) left = false;
            if (e.KeyCode == Keys.D) right = false;
        }
    }

      
}
