
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
            this.dateTimeDatum = new System.Windows.Forms.DateTimePicker();
            this.dateTimeVrijeme = new System.Windows.Forms.DateTimePicker();
            this.dgvStolovi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRucnoDodaj = new System.Windows.Forms.Button();
            this.radioBtnDan = new System.Windows.Forms.RadioButton();
            this.radioBtnTjedan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).BeginInit();
            this.SuspendLayout();
            // 
            // kalendar
            // 
            this.kalendar.Location = new System.Drawing.Point(18, 18);
            this.kalendar.Name = "kalendar";
            this.kalendar.TabIndex = 1;
            this.kalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.kalendar_DateSelected);
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Location = new System.Drawing.Point(312, 71);
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
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(580, 386);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(93, 32);
            this.btnIzmjeni.TabIndex = 10;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnObriši
            // 
            this.btnObriši.Location = new System.Drawing.Point(679, 386);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(93, 32);
            this.btnObriši.TabIndex = 11;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = true;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(1111, 408);
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
            this.txtPrezime.Size = new System.Drawing.Size(125, 20);
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
            this.cboxStolovi.Size = new System.Drawing.Size(125, 21);
            this.cboxStolovi.TabIndex = 15;
            // 
            // dateTimeDatum
            // 
            this.dateTimeDatum.Location = new System.Drawing.Point(100, 345);
            this.dateTimeDatum.Name = "dateTimeDatum";
            this.dateTimeDatum.Size = new System.Drawing.Size(112, 20);
            this.dateTimeDatum.TabIndex = 16;
            // 
            // dateTimeVrijeme
            // 
            this.dateTimeVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeVrijeme.Location = new System.Drawing.Point(218, 345);
            this.dateTimeVrijeme.Name = "dateTimeVrijeme";
            this.dateTimeVrijeme.ShowUpDown = true;
            this.dateTimeVrijeme.Size = new System.Drawing.Size(50, 20);
            this.dateTimeVrijeme.TabIndex = 17;
            // 
            // dgvStolovi
            // 
            this.dgvStolovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStolovi.Location = new System.Drawing.Point(859, 51);
            this.dgvStolovi.Name = "dgvStolovi";
            this.dgvStolovi.Size = new System.Drawing.Size(345, 196);
            this.dgvStolovi.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(856, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Stolovi:";
            // 
            // btnRucnoDodaj
            // 
            this.btnRucnoDodaj.Location = new System.Drawing.Point(481, 385);
            this.btnRucnoDodaj.Name = "btnRucnoDodaj";
            this.btnRucnoDodaj.Size = new System.Drawing.Size(93, 32);
            this.btnRucnoDodaj.TabIndex = 20;
            this.btnRucnoDodaj.Text = "Ručno dodaj";
            this.btnRucnoDodaj.UseVisualStyleBackColor = true;
            this.btnRucnoDodaj.Click += new System.EventHandler(this.btnRucnoDodaj_Click);
            // 
            // radioBtnDan
            // 
            this.radioBtnDan.AutoSize = true;
            this.radioBtnDan.Location = new System.Drawing.Point(469, 48);
            this.radioBtnDan.Name = "radioBtnDan";
            this.radioBtnDan.Size = new System.Drawing.Size(45, 17);
            this.radioBtnDan.TabIndex = 21;
            this.radioBtnDan.TabStop = true;
            this.radioBtnDan.Text = "Dan";
            this.radioBtnDan.UseVisualStyleBackColor = true;
            this.radioBtnDan.CheckedChanged += new System.EventHandler(this.radioBtnDan_CheckedChanged);
            // 
            // radioBtnTjedan
            // 
            this.radioBtnTjedan.AutoSize = true;
            this.radioBtnTjedan.Location = new System.Drawing.Point(560, 48);
            this.radioBtnTjedan.Name = "radioBtnTjedan";
            this.radioBtnTjedan.Size = new System.Drawing.Size(58, 17);
            this.radioBtnTjedan.TabIndex = 22;
            this.radioBtnTjedan.TabStop = true;
            this.radioBtnTjedan.Text = "Tjedan";
            this.radioBtnTjedan.UseVisualStyleBackColor = true;
            // 
            // FrmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 452);
            this.Controls.Add(this.radioBtnTjedan);
            this.Controls.Add(this.radioBtnDan);
            this.Controls.Add(this.btnRucnoDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvStolovi);
            this.Controls.Add(this.dateTimeVrijeme);
            this.Controls.Add(this.dateTimeDatum);
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
            this.KeyPreview = true;
            this.Name = "FrmRezervacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.FrmRezervacije_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRezervacije_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimeDatum;
        private System.Windows.Forms.DateTimePicker dateTimeVrijeme;
        private System.Windows.Forms.DataGridView dgvStolovi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRucnoDodaj;
        private System.Windows.Forms.RadioButton radioBtnDan;
        private System.Windows.Forms.RadioButton radioBtnTjedan;
    }
}