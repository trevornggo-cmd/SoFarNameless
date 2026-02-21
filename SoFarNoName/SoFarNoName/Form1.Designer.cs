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
            this.lblPlayer = new System.Windows.Forms.Label();
            this.WButton = new System.Windows.Forms.Timer(this.components);
            this.SButton = new System.Windows.Forms.Timer(this.components);
            this.DButton = new System.Windows.Forms.Timer(this.components);
            this.AButton = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(385, 216);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(91, 31);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Player";
            // 
            // WButton
            // 
            this.WButton.Interval = 1;
            this.WButton.Tick += new System.EventHandler(this.W_Tick);
            // 
            // SButton
            // 
            this.SButton.Interval = 1;
            this.SButton.Tick += new System.EventHandler(this.S_Tick);
            // 
            // DButton
            // 
            this.DButton.Interval = 1;
            this.DButton.Tick += new System.EventHandler(this.D_Tick);
            // 
            // AButton
            // 
            this.AButton.Interval = 1;
            this.AButton.Tick += new System.EventHandler(this.A_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 485);
            this.Controls.Add(this.lblPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPlayer;
        private Timer WButton;
        private Timer SButton;
        private Timer DButton;
        private Timer AButton;
    }
}

