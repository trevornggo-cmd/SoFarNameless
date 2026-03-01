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
        List<Enemy> AllEnemies = new List<Enemy>();
        Player ThePlayer;
        List<bullet> allBuletsOnScreen = new List<bullet>();
        int CurrentLevel = 0;
        Random ran = new Random();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Little Surviver";
            this.KeyPreview = true;
            CheckState.Start();
            ThePlayer = new Player(10, 5, this);
            DoubleBuffered = true;
            restartBtn.Enabled = false;
            restartBtn.Visible = false;
        }



        private void StartGame()
        {
            

            int numOfEnemies = ran.Next(1, CurrentLevel + 2);

            for (int i = 0; i < CurrentLevel + 2; i++)
            {
                int x = ran.Next(0, this.ClientSize.Width - 50);
                int y = ran.Next(0, this.ClientSize.Height - 50);

                AllEnemies.Add(new Enemy(5 + CurrentLevel, 2, 1 + CurrentLevel, x, y, this, 60));

            }
            CurrentLevel++;

        }
        private void StartButton(object sender, EventArgs e)
        {
            StartBtn.Enabled = false;
            StartBtn.Visible = false;
            StartGame();

        }



        private void Game_Interval(object sender, EventArgs e)
        {
            CurrentAtkLbl.Text = $"Attack : {ThePlayer.peekStat("attack").ToString()}";
            CurrentSpdLbl.Text = $"Speed : {ThePlayer.peekStat("speed").ToString()}";
            CurrentLvLbl.Text = $"Current Level : {this.CurrentLevel}";


            ThePlayer.PlayerMoving();
            if(AllEnemies.Count <= 0 && !StartBtn.Enabled && !ThePlayer.checkIfDead())
            {
                StartBtn.Enabled = true;
                StartBtn.Visible = true;
            }
            for (int i = AllEnemies.Count - 1; i >= 0; i--)
            {
                AllEnemies[i].getCloser(ThePlayer.PlayerAvatar.Left, ThePlayer.PlayerAvatar.Top);
                if (AllEnemies[i].copyOfEnemy.Bounds.IntersectsWith(ThePlayer.PlayerAvatar.Bounds))
                {
                    if (AllEnemies[i].AliveStill && AllEnemies[i].TryAttack())
                    {
                        ThePlayer.ReciveDamage(AllEnemies[i].DMA);
                    }
                    else if (!AllEnemies[i].AliveStill)
                    {
                        string upgrade = AllEnemies[i].showListOfEdibleParts();
                        if (upgrade != null)
                        {
                            ThePlayer.PlayerUpgrade(upgrade,ran.Next(1,CurrentLevel + 1));
                            AllEnemies[i].EnemyGone();
                            AllEnemies.RemoveAt(i);
                            continue;
                        }
                    }
                }
            }
            for (int i = allBuletsOnScreen.Count - 1; i >= 0; i--)
            {
           
                if (AllEnemies.Count > 0)
                {
                    for (int j = AllEnemies.Count - 1; j >= 0; j--)
                    {
                        if (AllEnemies[j].AliveStill)
                        {
                            if (allBuletsOnScreen[i].Bounds.IntersectsWith(AllEnemies[j].copyOfEnemy.Bounds) && allBuletsOnScreen[i].TryDoingDamage())
                            {
                                AllEnemies[j].ReciveDamage(ThePlayer.peekStat("attack"));
                            }
                        }

                    }
                }
                if (!allBuletsOnScreen[i].Traveling())
                {
                    allBuletsOnScreen.RemoveAt(i);
                }
            }
            if (ThePlayer.checkIfDead())
            {
                restartBtn.Enabled = true;
                restartBtn.Visible = true;
                for(int i = AllEnemies.Count - 1; i >= 0; i--)
                {
                    AllEnemies[i].EnemyGone();
                    AllEnemies.RemoveAt(i);
                }
            }
            this.Invalidate();

        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) ThePlayer.MovingDirection(0, true);
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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bullet aBullet = new bullet(ThePlayer.PlayerAvatar.Left, ThePlayer.PlayerAvatar.Top, e.X, e.Y, this, 900, 10);
            allBuletsOnScreen.Add(aBullet);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (bullet b in allBuletsOnScreen)
            {
                b.redrawing(e.Graphics);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            CurrentLevel = 0;
            ThePlayer.PlayerStatReset();
            restartBtn.Enabled = false;
            restartBtn.Visible = false;
        }
    }


}
