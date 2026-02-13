using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoFarNoName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "WinForm Course Session 1";

            Button button1 = new Button();
            button1.Text = "Button1";
            button1.Top = 10;
            Button button2 = new Button();
            button2.Text = "Button2";
            button2.Top = 70;

            this.Controls.Add(button2);
            this.Controls.Add(button1);



        }
    }
}
