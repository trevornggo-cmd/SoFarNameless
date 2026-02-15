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
            this.DisplayLbl = new System.Windows.Forms.Label();
            this.DecrementBtn = new System.Windows.Forms.Button();
            this.IncrementBtn = new System.Windows.Forms.Button();
            this.SetBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayLbl
            // 
            this.DisplayLbl.AutoSize = true;
            this.DisplayLbl.Location = new System.Drawing.Point(372, 180);
            this.DisplayLbl.Name = "DisplayLbl";
            this.DisplayLbl.Size = new System.Drawing.Size(35, 13);
            this.DisplayLbl.TabIndex = 0;
            this.DisplayLbl.Text = "label1";
            // 
            // DecrementBtn
            // 
            this.DecrementBtn.Location = new System.Drawing.Point(129, 119);
            this.DecrementBtn.Name = "DecrementBtn";
            this.DecrementBtn.Size = new System.Drawing.Size(75, 23);
            this.DecrementBtn.TabIndex = 1;
            this.DecrementBtn.Text = "-";
            this.DecrementBtn.UseVisualStyleBackColor = true;
            this.DecrementBtn.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // IncrementBtn
            // 
            this.IncrementBtn.Location = new System.Drawing.Point(23, 119);
            this.IncrementBtn.Name = "IncrementBtn";
            this.IncrementBtn.Size = new System.Drawing.Size(75, 23);
            this.IncrementBtn.TabIndex = 2;
            this.IncrementBtn.Text = "+";
            this.IncrementBtn.UseVisualStyleBackColor = true;
            this.IncrementBtn.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // SetBtn
            // 
            this.SetBtn.Location = new System.Drawing.Point(23, 26);
            this.SetBtn.Name = "SetBtn";
            this.SetBtn.Size = new System.Drawing.Size(75, 23);
            this.SetBtn.TabIndex = 3;
            this.SetBtn.Text = "Set value ";
            this.SetBtn.UseVisualStyleBackColor = true;
            this.SetBtn.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.TxtValue);
            this.panel1.Controls.Add(this.SetBtn);
            this.panel1.Controls.Add(this.DecrementBtn);
            this.panel1.Controls.Add(this.IncrementBtn);
            this.panel1.Location = new System.Drawing.Point(630, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 176);
            this.panel1.TabIndex = 4;
            // 
            // TxtValue
            // 
            this.TxtValue.Location = new System.Drawing.Point(104, 28);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(100, 20);
            this.TxtValue.TabIndex = 4;
            this.TxtValue.Text = "Enter value to set";
            this.TxtValue.Click += new System.EventHandler(this.TxtValue_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DisplayLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DisplayLbl;
        private Button DecrementBtn;
        private Button IncrementBtn;
        private Button SetBtn;
        private Panel panel1;
        private TextBox TxtValue;
    }
}

