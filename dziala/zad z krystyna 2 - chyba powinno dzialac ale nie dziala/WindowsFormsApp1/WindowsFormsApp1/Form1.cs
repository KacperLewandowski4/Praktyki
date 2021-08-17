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
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, checkBox1.Checked, checkBox2.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numericUpDown3.Value, checkBox5.Checked, textBox4.Text);
            DisplayBirthdayPartyCost();
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
        private void DisplayBirthdayPartyCost()
        {
            label8.Visible = birthdayParty.CakeWritingTooLong;
            decimal Cost = birthdayParty.Cost;
            textBox4.Text = Cost.ToString("c");
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDown3.Value;
            DisplayBirthdayPartyCost();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = checkBox5.Checked;
            DisplayBirthdayPartyCost();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = textBox3.Text;
            DisplayBirthdayPartyCost();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
