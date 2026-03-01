using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoFarNoName
{
    internal class CustomHealthLabel<T>
    {
        private Label EntityHealthBar = new Label();
        private Label EntityRemainingHealthBar = new Label();
        private Label HealthNumeric = new Label();
        private T Entity;
        private float EntityMaxHealth;
        public float remainingHealth;
        private int RemainingHealthBarOriginalWidth;
        private Label body;


        public CustomHealthLabel(int EntityMaxHealth,T entity,Label entityBody)
        {
            
            body = entityBody;
            this.EntityMaxHealth = EntityMaxHealth;
            remainingHealth = EntityMaxHealth;
            this.Entity = entity;

            EntityHealthBar.Text = "";
            EntityHealthBar.Size = new System.Drawing.Size(80, 25);
            EntityHealthBar.BackColor = Color.Gray;
            EntityHealthBar.Location = new System.Drawing.Point(entityBody.Left,entityBody.Top - 30);

            EntityRemainingHealthBar.Text = "";
            EntityRemainingHealthBar.Size = new System.Drawing.Size(80, 25);
            EntityRemainingHealthBar.BackColor = Color.Red;
            EntityRemainingHealthBar.Location = new System.Drawing.Point(entityBody.Left, entityBody.Top - 30);
            RemainingHealthBarOriginalWidth = EntityRemainingHealthBar.Width;

            HealthNumeric.Text = $"{remainingHealth}/{EntityMaxHealth}";
            HealthNumeric.Size = new System.Drawing.Size(80, 25);
            HealthNumeric.Location = new System.Drawing.Point(entityBody.Left, entityBody.Top - 60);
            HealthNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            HealthNumeric.BackColor = Color.Transparent;

          
        }
        public void AddTheLabel(Form formToPresent)
        {
            formToPresent.Controls.Add(EntityHealthBar);
            formToPresent.Controls.Add(EntityRemainingHealthBar);
            formToPresent.Controls.Add(HealthNumeric);


            EntityRemainingHealthBar.BringToFront();
            HealthNumeric.SendToBack();
            
        }

        /// <summary>
        /// true for plain = the horizontal plain false = the vertical plain. For addOrMinus true is moving right or up and false is left or down
        /// </summary>
        /// <param name="plain"></param>
        /// <param name="addOrMinus"></param>s
        public void Moving(int playerSpeed)
        {
            if(EntityRemainingHealthBar.Top > body.Top - 30)
            {
                EntityRemainingHealthBar.Top -= playerSpeed;
                EntityHealthBar.Top -= playerSpeed;
                HealthNumeric.Top -= playerSpeed;

            }
            else if (EntityRemainingHealthBar.Top < body.Top - 30)
            {
                EntityRemainingHealthBar.Top += playerSpeed;
                EntityHealthBar.Top += playerSpeed;
                HealthNumeric.Top += playerSpeed;
            }
            if (EntityRemainingHealthBar.Left > body.Left)
            {
                EntityRemainingHealthBar.Left -= playerSpeed;
                EntityHealthBar.Left -= playerSpeed;
                HealthNumeric.Left -= playerSpeed;

            }
            else if (EntityRemainingHealthBar.Left < body.Left)
            {
                EntityRemainingHealthBar.Left += playerSpeed;
                EntityHealthBar.Left += playerSpeed;
                HealthNumeric.Left += playerSpeed;

            }

            
        }
        public void ShowCurrentHPStatus(int remainingHealth,int maxHealth)
        {
            
            this.remainingHealth = remainingHealth;
            EntityMaxHealth = maxHealth;
            
            float percentage = this.remainingHealth / EntityMaxHealth;
            int widthOfBar = (int)(RemainingHealthBarOriginalWidth * percentage);
            
            EntityRemainingHealthBar.Size = new System.Drawing.Size(widthOfBar, 25);
           
            HealthNumeric.Text = $"{this.remainingHealth}/{EntityMaxHealth}" ;
        }

        public void HealthBarDispose()
        {
            EntityHealthBar.Dispose();
            EntityRemainingHealthBar.Dispose();
            HealthNumeric.Dispose();
        }
    }
}
