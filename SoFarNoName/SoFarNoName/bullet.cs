using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SoFarNoName
{
    internal class bullet
    {
        public int x;
        public int y;

        private int range;
        private double DirectionX;
        private double DirectionY;
        private double length;
        private int speed;
        private int distence = 0;
        private int damageCoolDown = 30;
        private int damageCoolDownCount = 0;
        public bullet(int playerX,int playerY,int DesX, int DesY, Form form,int range,int bulletSpeed)
        {
            this.range = range;
            speed = bulletSpeed;

            x = playerX;
            y = playerY;
            DirectionX = DesX - playerX;
            DirectionY = DesY - playerY;
            length = Math.Sqrt((DirectionX * DirectionX)+(DirectionY * DirectionY));
            DirectionY = DirectionY / length;
            DirectionX = DirectionX / length;
         

        }

        public Rectangle Bounds
        {
            get { return new Rectangle(x, y, 10, 10); }
        }

        public bool Traveling()
        {
            x += (int)(speed * DirectionX);
            y += (int)(speed * DirectionY);
            distence += speed;
            return distence < range;
        }

        public void redrawing(Graphics g)
        {
            g.FillEllipse(Brushes.Cyan, x, y, 10, 10);
        }

        public bool TryDoingDamage()
        {
            if(damageCoolDownCount <= 0) 
            {
                damageCoolDownCount = damageCoolDown;
                return true;
            }
            else
            {
                damageCoolDownCount--;
                return false;
            }
            
        }
    }
}
