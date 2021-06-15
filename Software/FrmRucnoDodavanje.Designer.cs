
namespace ProgramskoIntenjerstvo
{
    partial class FrmRucnoDodavanje
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
            this.dgvStolovi = new System.Windows.Forms.DataGridView();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dateTimeVrijeme = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDatum = new System.Windows.Forms.DateTimePicker();
            this.cboxStolovi = new System.Windows.Forms.ComboBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOprez = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStolovi
            // 
            this.dgvStolovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStolovi.Location = new System.Drawing.Point(278, 12);
            this.dgvStolovi.Name = "dgvStolovi";
            this.dgvStolovi.Size = new System.Drawing.Size(350, 163);
            this.dgvStolovi.TabIndex = 0;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(526, 234);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(102, 50);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(79, 234);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(102, 50);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dateTimeVrijeme
            // 
            this.dateTimeVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeVrijeme.Location = new System.Drawing.Point(212, 113);
            this.dateTimeVrijeme.Name = "dateTimeVrijeme";
            this.dateTimeVrijeme.ShowUpDown = true;
            this.dateTimeVrijeme.Size = new System.Drawing.Size(50, 20);
            this.dateTimeVrijeme.TabIndex = 24;
            // 
            // dateTimeDatum
            // 
            this.dateTimeDatum.Location = new System.Drawing.Point(99, 114);
            this.dateTimeDatum.Name = "dateTimeDatum";
            this.dateTimeDatum.Size = new System.Drawing.Size(107, 20);
            this.dateTimeDatum.TabIndex = 23;
            // 
            // cboxStolovi
            // 
            this.cboxStolovi.FormattingEnabled = true;
            this.cboxStolovi.Location = new System.Drawing.Point(79, 87);
            this.cboxStolovi.Name = "cboxStolovi";
            this.cboxStolovi.Size = new System.Drawing.Size(120, 21);
            this.cboxStolovi.TabIndex = 22;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(79, 143);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(120, 20);
            this.txtPrezime.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Datum i vrijeme:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Stol:";
            // 
            // labelOprez
            // 
            this.labelOprez.AutoSize = true;
            this.labelOprez.Location = new System.Drawing.Point(13, 39);
            this.labelOprez.Name = "labelOprez";
            this.labelOprez.Size = new System.Drawing.Size(231, 26);
            this.labelOprez.TabIndex = 25;
            this.labelOprez.Text = "Preporuča se razmak između rezervacija za stol\r\nod otprilike 3 sata.";
            // 
            // FrmRucnoDodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 296);
            this.Controls.Add(this.labelOprez);
            this.Controls.Add(this.dateTimeVrijeme);
            this.Controls.Add(this.dateTimeDatum);
            this.Controls.Add(this.cboxStolovi);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.dgvStolovi);
            this.KeyPreview = true;
            this.Name = "FrmRucnoDodavanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ručno dodavanje";
            this.Load += new System.EventHandler(this.FrmRucnoDodavanje_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRucnoDodavanje_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStolovi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DateTimePicker dateTimeVrijeme;
        private System.Windows.Forms.DateTimePicker dateTimeDatum;
        private System.Windows.Forms.ComboBox cboxStolovi;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOprez;
    }
}