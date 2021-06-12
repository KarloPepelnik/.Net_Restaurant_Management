
namespace ProgramskoIntenjerstvo
{
    partial class FrmPrimka
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxNamirnice = new System.Windows.Forms.ListBox();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.txtBoxOdabranaNamirnica = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxKolicinaZaprimanja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxMjernaJedinica = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpDatumPrimke = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUnesiPrimku = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nova primka";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxOdabranaNamirnica);
            this.groupBox1.Controls.Add(this.btnOdaberi);
            this.groupBox1.Controls.Add(this.listBoxNamirnice);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(27, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 262);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odabir namirnice ";
            // 
            // listBoxNamirnice
            // 
            this.listBoxNamirnice.FormattingEnabled = true;
            this.listBoxNamirnice.ItemHeight = 16;
            this.listBoxNamirnice.Location = new System.Drawing.Point(16, 31);
            this.listBoxNamirnice.Name = "listBoxNamirnice";
            this.listBoxNamirnice.Size = new System.Drawing.Size(288, 212);
            this.listBoxNamirnice.TabIndex = 0;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(333, 104);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(163, 33);
            this.btnOdaberi.TabIndex = 1;
            this.btnOdaberi.Text = "Odaberi namirnicu";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // txtBoxOdabranaNamirnica
            // 
            this.txtBoxOdabranaNamirnica.Location = new System.Drawing.Point(333, 171);
            this.txtBoxOdabranaNamirnica.Name = "txtBoxOdabranaNamirnica";
            this.txtBoxOdabranaNamirnica.Size = new System.Drawing.Size(164, 22);
            this.txtBoxOdabranaNamirnica.TabIndex = 2;
            this.txtBoxOdabranaNamirnica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbBoxMjernaJedinica);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBoxKolicinaZaprimanja);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(30, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 93);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odabir količine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Količina zaprimanja:";
            // 
            // txtBoxKolicinaZaprimanja
            // 
            this.txtBoxKolicinaZaprimanja.Location = new System.Drawing.Point(141, 41);
            this.txtBoxKolicinaZaprimanja.Name = "txtBoxKolicinaZaprimanja";
            this.txtBoxKolicinaZaprimanja.Size = new System.Drawing.Size(82, 22);
            this.txtBoxKolicinaZaprimanja.TabIndex = 1;
            this.txtBoxKolicinaZaprimanja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mjerna jedinica:";
            // 
            // cmbBoxMjernaJedinica
            // 
            this.cmbBoxMjernaJedinica.FormattingEnabled = true;
            this.cmbBoxMjernaJedinica.Location = new System.Drawing.Point(389, 39);
            this.cmbBoxMjernaJedinica.Name = "cmbBoxMjernaJedinica";
            this.cmbBoxMjernaJedinica.Size = new System.Drawing.Size(105, 24);
            this.cmbBoxMjernaJedinica.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dtpDatumPrimke);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(30, 479);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 79);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Odabir datuma";
            // 
            // dtpDatumPrimke
            // 
            this.dtpDatumPrimke.Location = new System.Drawing.Point(105, 35);
            this.dtpDatumPrimke.Name = "dtpDatumPrimke";
            this.dtpDatumPrimke.Size = new System.Drawing.Size(139, 22);
            this.dtpDatumPrimke.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Unesi datum: ";
            // 
            // btnUnesiPrimku
            // 
            this.btnUnesiPrimku.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnesiPrimku.Location = new System.Drawing.Point(295, 582);
            this.btnUnesiPrimku.Name = "btnUnesiPrimku";
            this.btnUnesiPrimku.Size = new System.Drawing.Size(113, 33);
            this.btnUnesiPrimku.TabIndex = 4;
            this.btnUnesiPrimku.Text = "Unesi primku";
            this.btnUnesiPrimku.UseVisualStyleBackColor = true;
            this.btnUnesiPrimku.Click += new System.EventHandler(this.btnUnesiPrimku_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(428, 582);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(113, 33);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmPrimka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 638);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUnesiPrimku);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrimka";
            this.Text = "Nova primka";
            this.Load += new System.EventHandler(this.FrmPrimka_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxNamirnice;
        private System.Windows.Forms.TextBox txtBoxOdabranaNamirnica;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbBoxMjernaJedinica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxKolicinaZaprimanja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatumPrimke;
        private System.Windows.Forms.Button btnUnesiPrimku;
        private System.Windows.Forms.Button btnOdustani;
    }
}