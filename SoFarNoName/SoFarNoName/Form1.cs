using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

           
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button bta = (Button)sender;
            if(bta.Text == "button1")
            {
                label1.BackColor = Color.Blue;
            }
            else if(bta.Text == "button2")
            {
                label1.BackColor = Color.Green;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
