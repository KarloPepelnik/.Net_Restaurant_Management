
namespace ProgramskoIntenjerstvo
{
    partial class FrmDodajNamirnicu
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
            this.txtBoxKolicina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBoxMjernaJedinica = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxKategorija = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxTemperatura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajNamirnicu = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(101, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nova namirnica";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxKolicina);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbBoxMjernaJedinica);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbBoxKategorija);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxTemperatura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxNaziv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 264);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtBoxKolicina
            // 
            this.txtBoxKolicina.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxKolicina.Location = new System.Drawing.Point(155, 224);
            this.txtBoxKolicina.Name = "txtBoxKolicina";
            this.txtBoxKolicina.Size = new System.Drawing.Size(159, 25);
            this.txtBoxKolicina.TabIndex = 9;
            this.txtBoxKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(15, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Trenutna količina:";
            // 
            // cmbBoxMjernaJedinica
            // 
            this.cmbBoxMjernaJedinica.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBoxMjernaJedinica.FormattingEnabled = true;
            this.cmbBoxMjernaJedinica.Location = new System.Drawing.Point(162, 178);
            this.cmbBoxMjernaJedinica.Name = "cmbBoxMjernaJedinica";
            this.cmbBoxMjernaJedinica.Size = new System.Drawing.Size(151, 24);
            this.cmbBoxMjernaJedinica.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(15, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mjerna jedinica:";
            // 
            // cmbBoxKategorija
            // 
            this.cmbBoxKategorija.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBoxKategorija.FormattingEnabled = true;
            this.cmbBoxKategorija.Location = new System.Drawing.Point(162, 88);
            this.cmbBoxKategorija.Name = "cmbBoxKategorija";
            this.cmbBoxKategorija.Size = new System.Drawing.Size(151, 24);
            this.cmbBoxKategorija.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kategorija:";
            // 
            // txtBoxTemperatura
            // 
            this.txtBoxTemperatura.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxTemperatura.Location = new System.Drawing.Point(182, 133);
            this.txtBoxTemperatura.Name = "txtBoxTemperatura";
            this.txtBoxTemperatura.Size = new System.Drawing.Size(132, 25);
            this.txtBoxTemperatura.TabIndex = 3;
            this.txtBoxTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(11, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperatura pohrane:";
            // 
            // txtBoxNaziv
            // 
            this.txtBoxNaziv.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxNaziv.Location = new System.Drawing.Point(155, 46);
            this.txtBoxNaziv.Name = "txtBoxNaziv";
            this.txtBoxNaziv.Size = new System.Drawing.Size(159, 25);
            this.txtBoxNaziv.TabIndex = 1;
            this.txtBoxNaziv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naziv namirnice:";
            // 
            // btnDodajNamirnicu
            // 
            this.btnDodajNamirnicu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNamirnicu.Location = new System.Drawing.Point(173, 375);
            this.btnDodajNamirnicu.Name = "btnDodajNamirnicu";
            this.btnDodajNamirnicu.Size = new System.Drawing.Size(117, 26);
            this.btnDodajNamirnicu.TabIndex = 4;
            this.btnDodajNamirnicu.Text = "Dodaj namirnicu";
            this.btnDodajNamirnicu.UseVisualStyleBackColor = true;
            this.btnDodajNamirnicu.Click += new System.EventHandler(this.btnDodajNamirnicu_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(301, 375);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(106, 26);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmDodajNamirnicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 422);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodajNamirnicu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmDodajNamirnicu";
            this.Text = "Dodavanje namirnice";
            this.Load += new System.EventHandler(this.FrmDodajNamirnicu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxKolicina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBoxMjernaJedinica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBoxKategorija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxTemperatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajNamirnicu;
        private System.Windows.Forms.Button btnOdustani;
    }
}