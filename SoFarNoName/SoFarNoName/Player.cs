using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SoFarNoName
{
    internal class Player
    {
        private int playerSpeed;
        public int playerMaxHealth;
        public int playerCurrentHealth;
        private int playerATK = 1;
        private Form form;

        private bool up, down, left, right;
        public Label PlayerAvatar = new Label();
        private CustomHealthLabel<Player> thePlayerHealthBar;
        public Player(int Speed, int Health, Form TheFormPlayerIsOn)
        {

            playerSpeed = Speed;
            playerMaxHealth = Health;
            playerCurrentHealth = Health;
            up = false;
            down = false;
            left = false;
            right = false;

            PlayerAvatar.Text = "Player";
            PlayerAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PlayerAvatar.Size = new System.Drawing.Size(80, 25);
            PlayerAvatar.Location = new System.Drawing.Point(TheFormPlayerIsOn.Width / 2 - 40, TheFormPlayerIsOn.Height / 2 - 13);
            PlayerAvatar.BackColor = Color.LightCoral;

            thePlayerHealthBar = new CustomHealthLabel<Player>(playerMaxHealth, this, PlayerAvatar);
            form = TheFormPlayerIsOn;
            thePlayerHealthBar.AddTheLabel(TheFormPlayerIsOn);
            TheFormPlayerIsOn.Controls.Add(PlayerAvatar);

        }

        public void PlayerMoving()
        {
            int VerticalMovement = 0;
            int HorizontalMovement = 0;

            if (up) VerticalMovement--;
            if (down) VerticalMovement++;
            if (left) HorizontalMovement--;
            if (right) HorizontalMovement++;

            PlayerAvatar.Top += VerticalMovement * playerSpeed;
            PlayerAvatar.Left += HorizontalMovement * playerSpeed;
            thePlayerHealthBar.Moving(playerSpeed);


        }

        public void PlayerUpgrade(string upgradeOption, int upByHowMuch)
        {
            if (upgradeOption.ToLower() == "leg")
            {
                playerSpeed += upByHowMuch;
            }
            else if (upgradeOption.ToLower() == "head")
            {
                playerATK += upByHowMuch;
            }
            else if (upgradeOption.ToLower() == "arm")
            {
                if (playerCurrentHealth + upByHowMuch < playerMaxHealth)
                {
                    playerCurrentHealth += upByHowMuch;
                }
                else
                {
                    playerCurrentHealth = playerMaxHealth;
                }
                thePlayerHealthBar.ShowCurrentHPStatus(playerCurrentHealth, playerMaxHealth);

            }
            else if (upgradeOption.ToLower() == "heart")
            {
                playerMaxHealth += upByHowMuch;
                thePlayerHealthBar.ShowCurrentHPStatus(playerCurrentHealth, playerMaxHealth);
            }
        }


        /// <summary>
        /// Enter a number these can be either 0,1,2 or 3 each representing up, down, left and right respectivly
        /// </summary>
        /// <param name="direction"></param>
        /// <summary>
        /// If true then is moving if false then is stoping
        /// </summary> 
        /// <param name="MovingOrStoping"></param>
        public void MovingDirection(int direction, bool MovingOrStoping)
        {
            if (!(direction > 3 || direction < 0))
            {
                if (MovingOrStoping)
                {
                    switch (direction)
                    {
                        case 0: up = true; break;
                        case 1: down = true; break;
                        case 2: left = true; break;
                        case 3: right = true; break;
                    }
                }
                else
                {
                    switch (direction)
                    {
                        case 0: up = false; break;
                        case 1: down = false; break;
                        case 2: left = false; break;
                        case 3: right = false; break;
                    }
                }
            }

        }

        public void ReciveDamage(int DamageRecived)
        {
            playerCurrentHealth -= DamageRecived;
            thePlayerHealthBar.ShowCurrentHPStatus(playerCurrentHealth, playerMaxHealth);

        }

        public int peekStat(string statToPeek)
        {
            if (statToPeek.ToLower() == "speed")
            {
                return playerSpeed;
            }
            else if (statToPeek.ToLower() == "maxhealth")
            {
                return playerMaxHealth;
            }
            else if (statToPeek.ToLower() == "currenthealth")
            {
                return playerCurrentHealth;
            }
            else if (statToPeek.ToLower() == "attack")
            {
                return playerATK;
            }
            return 0;
        }

        public bool checkIfDead()
        {
            if (playerCurrentHealth <= 0)
            {
                return true;
            }
            else return false;
        }

        public void PlayerStatReset()
        {
            playerSpeed = 10;
            playerATK = 1;
            playerMaxHealth = 5;
            playerCurrentHealth = playerMaxHealth;

        }

    }
}
