
namespace ProgramskoIntenjerstvo
{
    partial class FrmIzmjenaRezervacije
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.cboxStol = new System.Windows.Forms.ComboBox();
            this.datumIVrijeme = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum i vrijeme:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(65, 128);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezime:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(143, 176);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(53, 176);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 8;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cboxStol
            // 
            this.cboxStol.FormattingEnabled = true;
            this.cboxStol.Location = new System.Drawing.Point(53, 33);
            this.cboxStol.Name = "cboxStol";
            this.cboxStol.Size = new System.Drawing.Size(121, 21);
            this.cboxStol.TabIndex = 9;
            // 
            // datumIVrijeme
            // 
            this.datumIVrijeme.Location = new System.Drawing.Point(100, 75);
            this.datumIVrijeme.Name = "datumIVrijeme";
            this.datumIVrijeme.Size = new System.Drawing.Size(200, 20);
            this.datumIVrijeme.TabIndex = 10;
            // 
            // FrmIzmjenaRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 227);
            this.Controls.Add(this.datumIVrijeme);
            this.Controls.Add(this.cboxStol);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmIzmjenaRezervacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmjena rezervacije";
            this.Load += new System.EventHandler(this.FrmIzmjenaRezervacije_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmIzmjenaRezervacije_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox cboxStol;
        private System.Windows.Forms.DateTimePicker datumIVrijeme;
    }
}