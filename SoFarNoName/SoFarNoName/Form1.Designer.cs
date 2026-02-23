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
            this.SuspendLayout();
            // 
            // PlayerLbl
            // 
            this.PlayerLbl.AutoSize = true;
            this.PlayerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLbl.Location = new System.Drawing.Point(427, 275);
            this.PlayerLbl.Name = "PlayerLbl";
            this.PlayerLbl.Size = new System.Drawing.Size(73, 25);
            this.PlayerLbl.TabIndex = 0;
            this.PlayerLbl.Text = "Player";
            this.PlayerLbl.Click += new System.EventHandler(this.PlayerLbl_Click);
            // 
            // CheckState
            // 
            this.CheckState.Interval = 10;
            this.CheckState.Tick += new System.EventHandler(this.Game_Interval);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(984, 561);
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
    }
}

