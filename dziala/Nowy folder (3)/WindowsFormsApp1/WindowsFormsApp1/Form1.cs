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
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (radioButton1.Checked == true)
                food = Flapjack.Chrupkiego;
            else if (radioButton2.Checked == true)
                food = Flapjack.Wilgotnego;
            else if (radioButton3.Checked == true)
                food = Flapjack.Rumianego;
            else
                    food = Flapjack.Bananowego;

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)numericUpDown1.Value);
            RedrawList();
        }
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text)) return;
            breakfastLine.Enqueue(new Lumberjack(textBox1.Text));
            textBox1.Text = "";
            RedrawList();
        }
        private void RedrawList()
        {
            int number = 1;
            line.Items.Clear();
            foreach(Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if(breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                richTextBox1.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                richTextBox1.Text = currentLumberjack.Name + " ma " + currentLumberjack.FlapjackCount + " naleśników";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            richTextBox1.Text = "";
            RedrawList();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
