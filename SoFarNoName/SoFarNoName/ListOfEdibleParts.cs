using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoFarNoName
{
    internal class ListOfEdibleParts
    {

        private ListBox EdibleComponents = new ListBox();
        private Button ConfirmBtn = new Button();
        private bool shown = false;
        private string choice;
        public bool choiceConfirmed = false;
        
        public ListOfEdibleParts(Label PlaceToShow)
        {
           
            Random ran = new Random();
            for(int i = 0; i < 5; i++)
            {
                int rng = ran.Next(1, 11);
                if (rng == 1 && !EdibleComponents.Items.Contains("Head")) EdibleComponents.Items.Add("Head");
                else if (rng > 1 && rng <= 3 && !EdibleComponents.Items.Contains("Arm")) EdibleComponents.Items.Add("Arm");
                else if (rng > 3 && rng <= 5 && !EdibleComponents.Items.Contains("Leg")) EdibleComponents.Items.Add("Leg");
                

            }
            if(EdibleComponents.Items.Count == 0)
            {
                EdibleComponents.Items.Add("You got nothing(select this option to get rid of the corpes)");
            }

            EdibleComponents.Location = new System.Drawing.Point(PlaceToShow.Left, PlaceToShow.Top - 140);
            EdibleComponents.Size = new System.Drawing.Size(80, 100);

            ConfirmBtn.Location = new System.Drawing.Point(EdibleComponents.Left + 100,EdibleComponents.Top);
            ConfirmBtn.Size = new System.Drawing.Size(70, 25);
            ConfirmBtn.BackColor = Color.DarkSlateGray;
            ConfirmBtn.Click += new System.EventHandler(ConfirmSelection);
            ConfirmBtn.Text = "Confirm Choice";
            
        }

        public string ReturnChoice()
        {

            return choice;
        }

        public void Show(Form formToShow)
        {
            if (!shown)
            {
                formToShow.Controls.Add(EdibleComponents);
                formToShow.Controls.Add(ConfirmBtn);
                shown = true;
            }
        }

        private void ConfirmSelection(object sender,EventArgs e)
        {
            if(EdibleComponents.SelectedIndex != -1)
            {
                choice = ReturnSelectedItem();
                choiceConfirmed = true;
            }
        }

        private string ReturnSelectedItem()
        {
            return EdibleComponents.SelectedItem.ToString();
        }

        public void deletingList()
        {
            EdibleComponents.Dispose();
            ConfirmBtn.Dispose();
        }
    }
}
