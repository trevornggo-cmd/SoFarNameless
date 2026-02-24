using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SoFarNoName
{
    public partial class Form1 : Form
    {
        Enemy firstEnemy;
        Player ThePlayer;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Little Surviver";
            this.KeyPreview = true;
            CheckState.Start();
            ThePlayer = new Player(10, 5, this);
        }
       
        

        private void StartGame()
        {
            firstEnemy = new Enemy(10,2,1,200,200,this);

  
        }
        private void StartButton(object sender, EventArgs e)
        {
            StartBtn.Enabled = false;
            StartBtn.Visible = false;
            StartGame();
            
        }



        private void Game_Interval(object sender, EventArgs e)
        {
            ThePlayer.PlayerMoving();

            if (firstEnemy != null)
            {
                firstEnemy.getCloser(ThePlayer.PlayerAvatar.Left, ThePlayer.PlayerAvatar.Top);


                if (ThePlayer.PlayerAvatar.Bounds.IntersectsWith(firstEnemy.copyOfEnemy.Bounds))
                {
                    ThePlayer.ReciveDamage(firstEnemy.DMA);
                }
            }

        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) ThePlayer.MovingDirection(0,true);
            if (e.KeyCode == Keys.S) ThePlayer.MovingDirection(1, true);
            if (e.KeyCode == Keys.A) ThePlayer.MovingDirection(2, true);
            if (e.KeyCode == Keys.D) ThePlayer.MovingDirection(3, true);
        }
       



        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) ThePlayer.MovingDirection(0, false);
            if (e.KeyCode == Keys.S) ThePlayer.MovingDirection(1, false);
            if (e.KeyCode == Keys.A) ThePlayer.MovingDirection(2, false);
            if (e.KeyCode == Keys.D) ThePlayer.MovingDirection(3, false);
        }
    }

      
}
