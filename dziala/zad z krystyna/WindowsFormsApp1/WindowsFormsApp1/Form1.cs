using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, checkBox1.Checked, checkBox2.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = checkBox1.Checked;
            DisplayDinnerPartyCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = checkBox2.Checked;
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            textBox1.Text = Cost.ToString("c");
        }
    }
}
