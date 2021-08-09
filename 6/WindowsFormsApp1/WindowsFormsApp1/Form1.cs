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
            comboBox1.SelectedIndex=0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" });
            workers[1] = new Worker(new string[] { "Pielęgnacja jaj", "Nauczanie pszczółek" });
            workers[2] = new Worker(new string[] { "Utrzymywanie ula", "Patrol z żądłami" });
            workers[3] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Pielęgnacja jaj", "Nauczanie pszczółek","Utrzymywanie ula","Patrol z żądłami" });
            queen = new Queen(workers);

        }
        private Queen queen;
        private void button2_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(comboBox1.Text, (int)shifts.Value) == false)
                MessageBox.Show("Nie ma dostępnych robotnic do wykonania zadania '" + comboBox1.Text + "'", "Królowa pszczół mówi...");
            else
                MessageBox.Show("Zadanie '" + comboBox1.Text + "' będzie ukończone za " + shifts.Value + " zmiany", "Królowa pszczół mówi...");

        }

        private void shifts_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
