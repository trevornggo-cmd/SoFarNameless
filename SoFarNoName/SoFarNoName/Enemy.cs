using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace SoFarNoName
{
    internal class Enemy
    {
        private CustomHealthLabel<Enemy> enemyHealthBar;
        private int AttackCoolDownCounter;
        private int AttackCoolDown;
        private int HP, SPD;
        public int DMA;
        public int Xcoords, Ycoords;
        public bool AliveStill = true;
        public Label copyOfEnemy = new Label();
        public Enemy(int health, int speed, int damage, int xAxis, int yAxis ,Form1 WhichFormToSpawn,int AttackCoolDown)
        {
            HP = health;
            SPD = speed;
            DMA = damage;
            Xcoords = xAxis;
            Ycoords = yAxis;
            
            
            
            copyOfEnemy.Text = "Enemy";
            copyOfEnemy.BackColor = Color.Red;
            copyOfEnemy.Location = new System.Drawing.Point(Xcoords, Ycoords);
            copyOfEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enemyHealthBar = new CustomHealthLabel<Enemy>(HP,HP,this,copyOfEnemy);
            copyOfEnemy.Size = new System.Drawing.Size(80, 25);
            AttackCoolDownCounter = 0;
            this.AttackCoolDown = AttackCoolDown;

            

            WhichFormToSpawn.Controls.Add(copyOfEnemy);
            enemyHealthBar.AddTheLabel(WhichFormToSpawn);
            
        }

        public void getCloser( int playerXcoord, int playerYcoord)
        {
            if (AliveStill)
            {
                if (playerXcoord >= Xcoords) Xcoords += SPD;
                if (playerXcoord <= Xcoords) Xcoords -= SPD;
                if (playerYcoord >= Ycoords) Ycoords += SPD;
                if (playerYcoord <= Ycoords) Ycoords -= SPD;

                copyOfEnemy.Top = Ycoords;
                copyOfEnemy.Left = Xcoords;
                enemyHealthBar.Moving(SPD);
            }
            else
            {
                copyOfEnemy.BackColor = Color.Gray;
            }
           
        }
        public void ReciveDamage(int damageRecived)
        {
            HP -= damageRecived;
            enemyHealthBar.ShowRecivingDMA(damageRecived);
            if (HP <= 0)
            {
                AliveStill = false;
            }
        }
        public bool TryAttack()
        {
            if (AliveStill)
            {
                if (AttackCoolDownCounter > 0)
                {
                    AttackCoolDownCounter--;
                    return false;
                }
                else
                {
                    AttackCoolDownCounter = AttackCoolDown;
                    return true;
                }
            }
            else return false;
        }

       
       

    }
}
