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
            this.CheckState = new System.Windows.Forms.Timer(this.components);
            this.StartBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentSpdLbl = new System.Windows.Forms.Label();
            this.CurrentAtkLbl = new System.Windows.Forms.Label();
            this.CurrentLvLbl = new System.Windows.Forms.Label();
            this.restartBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.StartBtn.Text = "Click to start next level";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartButton);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CurrentSpdLbl);
            this.panel1.Controls.Add(this.CurrentAtkLbl);
            this.panel1.Controls.Add(this.CurrentLvLbl);
            this.panel1.Location = new System.Drawing.Point(1363, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 185);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stats: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CurrentSpdLbl
            // 
            this.CurrentSpdLbl.AutoSize = true;
            this.CurrentSpdLbl.BackColor = System.Drawing.SystemColors.Info;
            this.CurrentSpdLbl.Location = new System.Drawing.Point(32, 86);
            this.CurrentSpdLbl.Name = "CurrentSpdLbl";
            this.CurrentSpdLbl.Size = new System.Drawing.Size(35, 13);
            this.CurrentSpdLbl.TabIndex = 3;
            this.CurrentSpdLbl.Text = "label1";
            // 
            // CurrentAtkLbl
            // 
            this.CurrentAtkLbl.AutoSize = true;
            this.CurrentAtkLbl.BackColor = System.Drawing.SystemColors.Info;
            this.CurrentAtkLbl.Location = new System.Drawing.Point(32, 112);
            this.CurrentAtkLbl.Name = "CurrentAtkLbl";
            this.CurrentAtkLbl.Size = new System.Drawing.Size(35, 13);
            this.CurrentAtkLbl.TabIndex = 2;
            this.CurrentAtkLbl.Text = "label1";
            // 
            // CurrentLvLbl
            // 
            this.CurrentLvLbl.AutoSize = true;
            this.CurrentLvLbl.BackColor = System.Drawing.SystemColors.Info;
            this.CurrentLvLbl.Location = new System.Drawing.Point(32, 57);
            this.CurrentLvLbl.Name = "CurrentLvLbl";
            this.CurrentLvLbl.Size = new System.Drawing.Size(35, 13);
            this.CurrentLvLbl.TabIndex = 0;
            this.CurrentLvLbl.Text = "label1";
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.restartBtn.Location = new System.Drawing.Point(640, 21);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(469, 103);
            this.restartBtn.TabIndex = 3;
            this.restartBtn.Text = "You have died congragulations! click if you want to restart";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1750, 820);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StartBtn);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private Timer CheckState;
        private Button StartBtn;
        private Panel panel1;
        private Label CurrentLvLbl;
        private Label label2;
        private Label CurrentSpdLbl;
        private Label CurrentAtkLbl;
        private Button restartBtn;
    }
}

