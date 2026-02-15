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
        public int count = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "WinForm Course Session 1";
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Name.ToLower().Contains("increment"))
            {
                count++;
                DisplayLbl.Text = $"{count}";
            }
            else if (btn.Name.ToLower().Contains("decrement"))
            {
                count--;
                DisplayLbl.Text = $"{count}";
            }
            else if (btn.Name.ToLower().Contains("set"))
            {
                int setValue;
                bool Parsable = int.TryParse(TxtValue.Text, out setValue);
                if (Parsable) { count = setValue; } else { TxtValue.Text = "Please enter a number"; }
                DisplayLbl.Text = $"{count}";
            }
        }
        private void TxtValue_Clicked(object sender, EventArgs e)
        {
            TxtValue.Text = "";
        }
    }
}
