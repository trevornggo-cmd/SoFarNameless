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
using System.IO;

namespace SoFarNoName
{
    public partial class Form1 : Form
    {
        const string SaveFile = "SavedTask.txt";

        public Form1()
        {
            InitializeComponent();
            this.Text = "WinForm Course Session 7";
            this.KeyPreview = true;
            ColorComboBox.Items.Add("Red");
            ColorComboBox.Items.Add("Green");
            ColorComboBox.Items.Add("Blue");
            if (File.Exists(SaveFile))
            {
                foreach(string line in File.ReadAllLines(SaveFile))
                {
                    TaskListBox.Items.Add(line);
                }

            }

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(TxtTask.Text == "Name of Task")
            {
                AddBtn.Text = "Please enter a task in the text box above";
            }
            else
            {
                TaskListBox.Items.Add(TxtTask.Text);
                
            }
        }

        private void TxtTask_Click(object sender, EventArgs e)
        {
            TxtTask.Text = "";
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if(TaskListBox.SelectedIndex != -1)
            {
                TaskListBox.Items.RemoveAt(TaskListBox.SelectedIndex);
            }
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedColor = ColorComboBox.SelectedItem.ToString();
            if (SelectedColor == "Red") this.BackColor = Color.Red;
            if (SelectedColor == "Blue") this.BackColor = Color.Blue;
            if (SelectedColor == "Green") this.BackColor = Color.Green;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            List<string> currentTasks = new List<string>();

            foreach(string items in TaskListBox.Items)
            {
                currentTasks.Add(items);
            }
            File.WriteAllLines(SaveFile, currentTasks.ToArray());
        }
    }

      
}
