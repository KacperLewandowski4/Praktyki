
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.exits = new System.Windows.Forms.ComboBox();
            this.goHere = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.RichTextBox();
            this.goThroughTheDoor = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exits
            // 
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(102, 242);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(292, 21);
            this.exits.TabIndex = 0;
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(12, 240);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(84, 23);
            this.goHere.TabIndex = 1;
            this.goHere.Text = "Idź tutaj:";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 12);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(382, 222);
            this.description.TabIndex = 2;
            this.description.Text = "";
            // 
            // goThroughTheDoor
            // 
            this.goThroughTheDoor.Location = new System.Drawing.Point(12, 269);
            this.goThroughTheDoor.Name = "goThroughTheDoor";
            this.goThroughTheDoor.Size = new System.Drawing.Size(382, 23);
            this.goThroughTheDoor.TabIndex = 3;
            this.goThroughTheDoor.Text = "Przejdź przez drzwi";
            this.goThroughTheDoor.UseVisualStyleBackColor = true;
            this.goThroughTheDoor.Click += new System.EventHandler(this.goThroughTheDoor_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(12, 298);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(382, 23);
            this.check.TabIndex = 4;
            this.check.Text = "----";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(12, 327);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(382, 23);
            this.hide.TabIndex = 5;
            this.hide.Text = "Kryj się";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.check);
            this.Controls.Add(this.goThroughTheDoor);
            this.Controls.Add(this.description);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.exits);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Button goThroughTheDoor;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button hide;
    }
}

