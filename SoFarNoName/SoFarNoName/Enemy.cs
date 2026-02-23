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
        Form1 form;
        private int HP, SPD, DMA;
        public int Xcoords, Ycoords;
        public bool AliveStill = true;
        Label copyOfEnemy = new Label();
        public Enemy(int health, int speed, int damage, int xAxis, int yAxis ,Form1 WhichFormToSpawn)
        {
            HP = health;
            SPD = speed;
            DMA = damage;
            Xcoords = xAxis;
            Ycoords = yAxis;
            this.form = WhichFormToSpawn;
            
            copyOfEnemy.Text = "Enemy";
            copyOfEnemy.BackColor = Color.Red;
            copyOfEnemy.Location = new System.Drawing.Point(Xcoords, Ycoords);
            copyOfEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            copyOfEnemy.Size = new System.Drawing.Size(80, 25);

            form.Controls.Add(copyOfEnemy);
        }

        public void getCloser(ref int playerHealth, int playerXcoord, int playerYcoord)
        {
            if (playerXcoord > Xcoords) Xcoords += SPD;
            if (playerXcoord < Xcoords) Xcoords -= SPD;
            if (playerYcoord > Ycoords) Ycoords += SPD;
            if (playerYcoord < Ycoords) Ycoords -= SPD;

            copyOfEnemy.Top = Ycoords;
            copyOfEnemy.Left = Xcoords;


            if(playerYcoord == Ycoords && playerXcoord == Xcoords)
            {
                playerHealth -= DMA;
            }
           
        }
        public void ReciveDamage(int damageRecived)
        {
            HP -= damageRecived;
            if (HP < 0)
            {
                AliveStill = false;
            }
        }

       

    }
}
