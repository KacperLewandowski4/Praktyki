﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagnesikiZKodem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> a = new List<string>();


            string zilch = "zero";
            string first = "jeden";
            string second = "dwa";
            string third = "trzy";
            string fourth = "4.2";
            string twopointtwo = "2.2";


            a.Add(zilch);
            a.Add(first);
            a.Add(second);
            a.Add(third);


            if (a.Contains("trzy"))
            {
                a.Add("cztery");
            }


            a.RemoveAt(2);


            if (a.IndexOf("cztery") != 4)
            {
                a.Add(fourth);
            }


            if (a.Contains("dwa"))
            {
                a.Add(twopointtwo);
            }


            printL(a);

        }

        public void printL(List<string> a)
        {
            string result = "";


            foreach (string element in a)
            {
                result += "\n" + element;
            }


            MessageBox.Show(result);


        }

    }
}