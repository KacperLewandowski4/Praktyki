using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();

            bob = new Guy();
            bob.Name = "Bob";
            bob.Cash = 100;

            joe = new Guy();
            joe.Name = "Joe";
            joe.Cash = 50;
        }
        public void UpdateForm()
        {
            label1.Text = joe.Name + "ma" + joe.Cash + " zł";
            label2.Text = bob.Name + "ma" + bob.Cash + " zł";
            label3.Text = "Bank ma" + bank + " zł";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank nie posiada takiej ilości pieniędzy");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Plik_faceta.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, joe);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Plik_faceta.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                joe = (Guy)formatter.Deserialize(input);
            }
            UpdateForm();
        }
    }
}
