
namespace ProgramskoIntenjerstvo
{
    partial class FrmRezervacije
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
            this.kalendar = new System.Windows.Forms.MonthCalendar();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnObriši = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxStolovi = new System.Windows.Forms.ComboBox();
            this.dateTimeDatumIVrijeme = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // kalendar
            // 
            this.kalendar.Location = new System.Drawing.Point(18, 18);
            this.kalendar.Name = "kalendar";
            this.kalendar.TabIndex = 1;
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Location = new System.Drawing.Point(290, 18);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.Size = new System.Drawing.Size(460, 309);
            this.dgvRezervacije.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum i vrijeme:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(62, 406);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(93, 32);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(558, 333);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(93, 32);
            this.btnIzmjeni.TabIndex = 10;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            // 
            // btnObriši
            // 
            this.btnObriši.Location = new System.Drawing.Point(657, 333);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(93, 32);
            this.btnObriši.TabIndex = 11;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(695, 406);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(93, 32);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(80, 374);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(139, 20);
            this.txtPrezime.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Prezime:";
            // 
            // cboxStolovi
            // 
            this.cboxStolovi.FormattingEnabled = true;
            this.cboxStolovi.Location = new System.Drawing.Point(80, 318);
            this.cboxStolovi.Name = "cboxStolovi";
            this.cboxStolovi.Size = new System.Drawing.Size(139, 21);
            this.cboxStolovi.TabIndex = 15;
            // 
            // dateTimeDatumIVrijeme
            // 
            this.dateTimeDatumIVrijeme.Location = new System.Drawing.Point(100, 345);
            this.dateTimeDatumIVrijeme.Name = "dateTimeDatumIVrijeme";
            this.dateTimeDatumIVrijeme.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDatumIVrijeme.TabIndex = 16;
            // 
            // FrmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimeDatumIVrijeme);
            this.Controls.Add(this.cboxStolovi);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRezervacije);
            this.Controls.Add(this.kalendar);
            this.Name = "FrmRezervacije";
            this.Text = "FrmRezervacije";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar kalendar;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxStolovi;
        private System.Windows.Forms.DateTimePicker dateTimeDatumIVrijeme;
    }
}