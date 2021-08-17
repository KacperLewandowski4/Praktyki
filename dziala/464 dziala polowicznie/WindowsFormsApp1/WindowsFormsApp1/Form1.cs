using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            currentExcuse.LastUsed = lastUsed.Value;
        }
        private Excuse currentExcuse = new Excuse();
        private string selectedFolder = "";
        private bool formChanged = false;
        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(description.Text) || String.IsNullOrEmpty(results.Text))
            {
                MessageBox.Show("Określ wymówkę i rezultat", "Nie można zapisać pliku",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Pliki tekstowe (*.txt)|*txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.FileName = fileDate.Text + ".txt";
            DialogResult result = saveFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Wymówka zapisana");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = "Pliki tekstowe (*.txt)|*txt|Wszystkie pliki (*.*)|*.*";
                openFileDialog1.FileName = fileDate.Text + ".txt";
                DialogResult result = openFileDialog1.ShowDialog();
                if(result == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }
        private bool CheckChanged()
        {
            if(formChanged)
            {
                DialogResult result = MessageBox.Show("Bieżąca wymówka nie została zapisana. Czy kontynuować?",
                    "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            currentExcuse.Description = fileDate.Text;
            UpdateForm(true);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            currentExcuse.Results = results.Text;
            UpdateForm(true);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }
        private void UpdateForm(bool changed)
        {
            if(!changed)
            {
                this.fileDate.Text = currentExcuse.Description;
                this.results.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Program do zarządzania wymówkami";
            }
            else
            {
                this.Text = "Program do zarządzania wymówkami*";
                this.formChanged = changed;
            }
        }
    }
}
