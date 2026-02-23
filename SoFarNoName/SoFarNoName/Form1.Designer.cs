using System.Windows.Forms;

namespace SoFarNoName
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlayerLbl = new System.Windows.Forms.Label();
            this.CheckState = new System.Windows.Forms.Timer(this.components);
            this.StartBtn = new System.Windows.Forms.Button();
            this.EnemyMovements = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PlayerLbl
            // 
            this.PlayerLbl.AutoSize = true;
            this.PlayerLbl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PlayerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLbl.Location = new System.Drawing.Point(838, 385);
            this.PlayerLbl.Name = "PlayerLbl";
            this.PlayerLbl.Size = new System.Drawing.Size(73, 25);
            this.PlayerLbl.TabIndex = 0;
            this.PlayerLbl.Text = "Player";
            // 
            // CheckState
            // 
            this.CheckState.Interval = 10;
            this.CheckState.Tick += new System.EventHandler(this.Game_Interval);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartBtn.Location = new System.Drawing.Point(640, 151);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(470, 159);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Click to start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartButton);
            // 
            // EnemyMovements
            // 
            this.EnemyMovements.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1750, 820);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.PlayerLbl);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label PlayerLbl;
        private Timer CheckState;
        private Button StartBtn;
        private Timer EnemyMovements;
    }
}

