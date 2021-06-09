
namespace ProgramskoIntenjerstvo
{
    partial class FrmDodajSastojkeJela
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
            this.btnSpremiSastojke = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvSastojciJela = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbBoxMjernaJedinica = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodajSastojak = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxKolicina = new System.Windows.Forms.TextBox();
            this.listBoxNamirnica = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxOdabranoJelo = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojciJela)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpremiSastojke
            // 
            this.btnSpremiSastojke.Location = new System.Drawing.Point(821, 441);
            this.btnSpremiSastojke.Name = "btnSpremiSastojke";
            this.btnSpremiSastojke.Size = new System.Drawing.Size(136, 30);
            this.btnSpremiSastojke.TabIndex = 13;
            this.btnSpremiSastojke.Text = "Spremi sastojke jela";
            this.btnSpremiSastojke.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(963, 441);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(133, 30);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgvSastojciJela);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.listBoxNamirnica);
            this.groupBox2.Location = new System.Drawing.Point(27, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1069, 344);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sastojci jela";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trenutni sastojci jela:";
            // 
            // dgvSastojciJela
            // 
            this.dgvSastojciJela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSastojciJela.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSastojciJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSastojciJela.Location = new System.Drawing.Point(607, 45);
            this.dgvSastojciJela.Name = "dgvSastojciJela";
            this.dgvSastojciJela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSastojciJela.Size = new System.Drawing.Size(456, 293);
            this.dgvSastojciJela.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbBoxMjernaJedinica);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnDodajSastojak);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtBoxKolicina);
            this.groupBox3.Location = new System.Drawing.Point(346, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 213);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodaj sastojak";
            // 
            // cmbBoxMjernaJedinica
            // 
            this.cmbBoxMjernaJedinica.FormattingEnabled = true;
            this.cmbBoxMjernaJedinica.Location = new System.Drawing.Point(108, 71);
            this.cmbBoxMjernaJedinica.Name = "cmbBoxMjernaJedinica";
            this.cmbBoxMjernaJedinica.Size = new System.Drawing.Size(106, 24);
            this.cmbBoxMjernaJedinica.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mjerna jedinica:";
            // 
            // btnDodajSastojak
            // 
            this.btnDodajSastojak.Location = new System.Drawing.Point(108, 112);
            this.btnDodajSastojak.Name = "btnDodajSastojak";
            this.btnDodajSastojak.Size = new System.Drawing.Size(106, 35);
            this.btnDodajSastojak.TabIndex = 2;
            this.btnDodajSastojak.Text = "Dodaj";
            this.btnDodajSastojak.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Količina:";
            // 
            // txtBoxKolicina
            // 
            this.txtBoxKolicina.Location = new System.Drawing.Point(108, 38);
            this.txtBoxKolicina.Name = "txtBoxKolicina";
            this.txtBoxKolicina.Size = new System.Drawing.Size(106, 22);
            this.txtBoxKolicina.TabIndex = 3;
            this.txtBoxKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBoxNamirnica
            // 
            this.listBoxNamirnica.FormattingEnabled = true;
            this.listBoxNamirnica.ItemHeight = 16;
            this.listBoxNamirnica.Location = new System.Drawing.Point(9, 30);
            this.listBoxNamirnica.Name = "listBoxNamirnica";
            this.listBoxNamirnica.Size = new System.Drawing.Size(331, 308);
            this.listBoxNamirnica.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Odabrano jelo: ";
            // 
            // txtBoxOdabranoJelo
            // 
            this.txtBoxOdabranoJelo.Location = new System.Drawing.Point(116, 31);
            this.txtBoxOdabranoJelo.Name = "txtBoxOdabranoJelo";
            this.txtBoxOdabranoJelo.Size = new System.Drawing.Size(170, 22);
            this.txtBoxOdabranoJelo.TabIndex = 15;
            this.txtBoxOdabranoJelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmDodajSastojkeJela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 481);
            this.Controls.Add(this.txtBoxOdabranoJelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpremiSastojke);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDodajSastojkeJela";
            this.Text = "Dodaj sastojke";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojciJela)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremiSastojke;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvSastojciJela;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbBoxMjernaJedinica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodajSastojak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxKolicina;
        private System.Windows.Forms.ListBox listBoxNamirnica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxOdabranoJelo;
    }
}