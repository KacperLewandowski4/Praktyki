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
        Greyhound[] GreyhoundArray = new Greyhound[4];
        Guy[] GuyArray = new Guy[3];
        Random MyRandom = new Random();
        public Form1()
        {
            InitializeComponent();
            GuyArray[0] = new Guy() { Name = "Kazik", Cash =2500, MyLabel = label5, MyRadioButton = radioButton1, MyBet = new Bet() };
            GuyArray[1] = new Guy() { Name = "Maciek", Cash =1250, MyLabel = label6, MyRadioButton = radioButton2, MyBet = new Bet() };
            GuyArray[2] = new Guy() { Name = "Grzesiek", Cash =620, MyLabel = label7, MyRadioButton = radioButton3, MyBet = new Bet() };
            for(int i = 0; i < GuyArray.Length; i++)
            {
                GuyArray[i].MyBet.Bettor = GuyArray[i];
            }
            GreyhoundArray[0] = new Greyhound() { MyPictureBox = pictureBox2, Randomizer = MyRandom, RaceTrackLength = pictureBox1.Width };
            GreyhoundArray[1] = new Greyhound() { MyPictureBox = pictureBox3, Randomizer = MyRandom, RaceTrackLength = pictureBox1.Width };
            GreyhoundArray[2] = new Greyhound() { MyPictureBox = pictureBox4, Randomizer = MyRandom, RaceTrackLength = pictureBox1.Width };
            GreyhoundArray[3] = new Greyhound() { MyPictureBox = pictureBox5, Randomizer = MyRandom, RaceTrackLength = pictureBox1.Width };
            label3.Text = GuyArray[0].Name;
            label1.Text = "Minimalny zakład: " + numericUpDown1.Minimum.ToString() + " $";

            for(int i=0; i < GuyArray.Length; i++)
            {
                GuyArray[i].UpdateLabels();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guyNumber = 0;
            if (radioButton1.Checked)
                guyNumber = 0;
            if (radioButton2.Checked)
                guyNumber = 1;
            if (radioButton3.Checked)
                guyNumber = 2;
            GuyArray[guyNumber].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            GuyArray[guyNumber].DisableRadioButton();
            GuyArray[guyNumber].UpdateLabels();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i <GreyhoundArray.Length; i++)
            {
                if(GreyhoundArray[i].Run() == true)
                {
                    groupBox1.Enabled = true;
                    timer1.Stop();
                    i++;
                    var result = MessageBox.Show("Pies nr" + i + " wygrał!");
                    for(int j=0;j<GreyhoundArray.Length;j++)
                    {
                        GreyhoundArray[j].TakeStartingPosition();
                    }
                    for(int j = 0; j<GuyArray.Length;j++)
                    {
                        if (GuyArray[j].MyBet == null)
                            break;
                        else
                        {
                            GuyArray[j].EnableRadioButton();
                            GuyArray[j].MyBet.PayOut(i);
                            GuyArray[j].Collect(i);
                            GuyArray[j].UpdateLabels();
                            GuyArray[j].ClearBet();
                        }
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = GuyArray[0].Name;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = GuyArray[1].Name;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = GuyArray[2].Name;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
