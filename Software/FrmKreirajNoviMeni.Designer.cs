
namespace ProgramskoIntenjerstvo
{
    partial class FrmKreirajNoviMeni
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
            this.btnOdaberiPredjelo = new System.Windows.Forms.Button();
            this.listBoxPredjela = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOdaberiGlJelo = new System.Windows.Forms.Button();
            this.listBoxGlavnaJela = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOdaberiDesert = new System.Windows.Forms.Button();
            this.listBoxDeserti = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBoxCijenaMenija = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxDatumMenija = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxOdabranoGlavnoJelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxOdabraniDesert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxOdabranoPredjelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpVazeciDatumMenija = new System.Windows.Forms.DateTimePicker();
            this.btnKreirajMeni = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtBoxNazivMenija = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxCijenaBezValute = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kreiraj novi meni";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOdaberiPredjelo);
            this.groupBox1.Controls.Add(this.listBoxPredjela);
            this.groupBox1.Location = new System.Drawing.Point(29, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 288);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odabir predjela";
            // 
            // btnOdaberiPredjelo
            // 
            this.btnOdaberiPredjelo.Location = new System.Drawing.Point(9, 251);
            this.btnOdaberiPredjelo.Name = "btnOdaberiPredjelo";
            this.btnOdaberiPredjelo.Size = new System.Drawing.Size(309, 24);
            this.btnOdaberiPredjelo.TabIndex = 1;
            this.btnOdaberiPredjelo.Text = "Odaberi označeno predjelo";
            this.btnOdaberiPredjelo.UseVisualStyleBackColor = true;
            this.btnOdaberiPredjelo.Click += new System.EventHandler(this.btnOdaberiPredjelo_Click);
            // 
            // listBoxPredjela
            // 
            this.listBoxPredjela.FormattingEnabled = true;
            this.listBoxPredjela.ItemHeight = 16;
            this.listBoxPredjela.Location = new System.Drawing.Point(7, 17);
            this.listBoxPredjela.Name = "listBoxPredjela";
            this.listBoxPredjela.Size = new System.Drawing.Size(311, 228);
            this.listBoxPredjela.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOdaberiGlJelo);
            this.groupBox2.Controls.Add(this.listBoxGlavnaJela);
            this.groupBox2.Location = new System.Drawing.Point(396, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 288);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odabir glavnog jela";
            // 
            // btnOdaberiGlJelo
            // 
            this.btnOdaberiGlJelo.Location = new System.Drawing.Point(6, 255);
            this.btnOdaberiGlJelo.Name = "btnOdaberiGlJelo";
            this.btnOdaberiGlJelo.Size = new System.Drawing.Size(312, 24);
            this.btnOdaberiGlJelo.TabIndex = 2;
            this.btnOdaberiGlJelo.Text = "Odaberi označeno glavno jelo";
            this.btnOdaberiGlJelo.UseVisualStyleBackColor = true;
            this.btnOdaberiGlJelo.Click += new System.EventHandler(this.btnOdaberiGlJelo_Click);
            // 
            // listBoxGlavnaJela
            // 
            this.listBoxGlavnaJela.FormattingEnabled = true;
            this.listBoxGlavnaJela.ItemHeight = 16;
            this.listBoxGlavnaJela.Location = new System.Drawing.Point(6, 21);
            this.listBoxGlavnaJela.Name = "listBoxGlavnaJela";
            this.listBoxGlavnaJela.Size = new System.Drawing.Size(311, 228);
            this.listBoxGlavnaJela.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOdaberiDesert);
            this.groupBox3.Controls.Add(this.listBoxDeserti);
            this.groupBox3.Location = new System.Drawing.Point(763, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 288);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Odabir deserta";
            // 
            // btnOdaberiDesert
            // 
            this.btnOdaberiDesert.Location = new System.Drawing.Point(6, 255);
            this.btnOdaberiDesert.Name = "btnOdaberiDesert";
            this.btnOdaberiDesert.Size = new System.Drawing.Size(312, 24);
            this.btnOdaberiDesert.TabIndex = 3;
            this.btnOdaberiDesert.Text = "Odaberi označeni desert";
            this.btnOdaberiDesert.UseVisualStyleBackColor = true;
            this.btnOdaberiDesert.Click += new System.EventHandler(this.btnOdaberiDesert_Click);
            // 
            // listBoxDeserti
            // 
            this.listBoxDeserti.FormattingEnabled = true;
            this.listBoxDeserti.ItemHeight = 16;
            this.listBoxDeserti.Location = new System.Drawing.Point(6, 21);
            this.listBoxDeserti.Name = "listBoxDeserti";
            this.listBoxDeserti.Size = new System.Drawing.Size(311, 228);
            this.listBoxDeserti.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBoxCijenaBezValute);
            this.groupBox4.Controls.Add(this.txtBoxCijenaMenija);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtBoxDatumMenija);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtBoxOdabranoGlavnoJelo);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtBoxOdabraniDesert);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtBoxOdabranoPredjelo);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(243, 495);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(598, 135);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trenutni podaci o meniju:";
            // 
            // txtBoxCijenaMenija
            // 
            this.txtBoxCijenaMenija.Location = new System.Drawing.Point(459, 69);
            this.txtBoxCijenaMenija.Name = "txtBoxCijenaMenija";
            this.txtBoxCijenaMenija.ReadOnly = true;
            this.txtBoxCijenaMenija.Size = new System.Drawing.Size(118, 22);
            this.txtBoxCijenaMenija.TabIndex = 9;
            this.txtBoxCijenaMenija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cijena:";
            // 
            // txtBoxDatumMenija
            // 
            this.txtBoxDatumMenija.Location = new System.Drawing.Point(459, 35);
            this.txtBoxDatumMenija.Name = "txtBoxDatumMenija";
            this.txtBoxDatumMenija.ReadOnly = true;
            this.txtBoxDatumMenija.Size = new System.Drawing.Size(118, 22);
            this.txtBoxDatumMenija.TabIndex = 7;
            this.txtBoxDatumMenija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Datum:";
            // 
            // txtBoxOdabranoGlavnoJelo
            // 
            this.txtBoxOdabranoGlavnoJelo.Location = new System.Drawing.Point(105, 66);
            this.txtBoxOdabranoGlavnoJelo.Name = "txtBoxOdabranoGlavnoJelo";
            this.txtBoxOdabranoGlavnoJelo.ReadOnly = true;
            this.txtBoxOdabranoGlavnoJelo.Size = new System.Drawing.Size(270, 22);
            this.txtBoxOdabranoGlavnoJelo.TabIndex = 5;
            this.txtBoxOdabranoGlavnoJelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Glavno jelo:";
            // 
            // txtBoxOdabraniDesert
            // 
            this.txtBoxOdabraniDesert.Location = new System.Drawing.Point(105, 97);
            this.txtBoxOdabraniDesert.Name = "txtBoxOdabraniDesert";
            this.txtBoxOdabraniDesert.ReadOnly = true;
            this.txtBoxOdabraniDesert.Size = new System.Drawing.Size(270, 22);
            this.txtBoxOdabraniDesert.TabIndex = 3;
            this.txtBoxOdabraniDesert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desert:";
            // 
            // txtBoxOdabranoPredjelo
            // 
            this.txtBoxOdabranoPredjelo.Location = new System.Drawing.Point(105, 35);
            this.txtBoxOdabranoPredjelo.Name = "txtBoxOdabranoPredjelo";
            this.txtBoxOdabranoPredjelo.ReadOnly = true;
            this.txtBoxOdabranoPredjelo.Size = new System.Drawing.Size(270, 22);
            this.txtBoxOdabranoPredjelo.TabIndex = 1;
            this.txtBoxOdabranoPredjelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Predjelo:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.dtpVazeciDatumMenija);
            this.groupBox5.Location = new System.Drawing.Point(396, 72);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(308, 99);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datum menija:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Odaberi važeći datum:";
            // 
            // dtpVazeciDatumMenija
            // 
            this.dtpVazeciDatumMenija.Location = new System.Drawing.Point(149, 48);
            this.dtpVazeciDatumMenija.Name = "dtpVazeciDatumMenija";
            this.dtpVazeciDatumMenija.Size = new System.Drawing.Size(145, 22);
            this.dtpVazeciDatumMenija.TabIndex = 0;
            this.dtpVazeciDatumMenija.ValueChanged += new System.EventHandler(this.dtpVazeciDatumMenija_ValueChanged);
            // 
            // btnKreirajMeni
            // 
            this.btnKreirajMeni.Location = new System.Drawing.Point(886, 498);
            this.btnKreirajMeni.Name = "btnKreirajMeni";
            this.btnKreirajMeni.Size = new System.Drawing.Size(159, 72);
            this.btnKreirajMeni.TabIndex = 8;
            this.btnKreirajMeni.Text = "Kreiraj meni";
            this.btnKreirajMeni.UseVisualStyleBackColor = true;
            this.btnKreirajMeni.Click += new System.EventHandler(this.btnKreirajMeni_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(886, 592);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(159, 29);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtBoxNazivMenija);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(29, 72);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(324, 99);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Naziv menija";
            // 
            // txtBoxNazivMenija
            // 
            this.txtBoxNazivMenija.Location = new System.Drawing.Point(132, 50);
            this.txtBoxNazivMenija.Name = "txtBoxNazivMenija";
            this.txtBoxNazivMenija.Size = new System.Drawing.Size(186, 22);
            this.txtBoxNazivMenija.TabIndex = 10;
            this.txtBoxNazivMenija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Unesi naziv menija:";
            // 
            // txtBoxCijenaBezValute
            // 
            this.txtBoxCijenaBezValute.Location = new System.Drawing.Point(459, 107);
            this.txtBoxCijenaBezValute.Name = "txtBoxCijenaBezValute";
            this.txtBoxCijenaBezValute.ReadOnly = true;
            this.txtBoxCijenaBezValute.Size = new System.Drawing.Size(118, 22);
            this.txtBoxCijenaBezValute.TabIndex = 10;
            this.txtBoxCijenaBezValute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxCijenaBezValute.Visible = false;
            // 
            // FrmKreirajNoviMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 659);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnKreirajMeni);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmKreirajNoviMeni";
            this.Text = "Novi meni";
            this.Load += new System.EventHandler(this.FrmKreirajNoviMeni_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOdaberiPredjelo;
        private System.Windows.Forms.ListBox listBoxPredjela;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOdaberiGlJelo;
        private System.Windows.Forms.ListBox listBoxGlavnaJela;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOdaberiDesert;
        private System.Windows.Forms.ListBox listBoxDeserti;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBoxCijenaMenija;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxDatumMenija;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxOdabranoGlavnoJelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxOdabraniDesert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxOdabranoPredjelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpVazeciDatumMenija;
        private System.Windows.Forms.Button btnKreirajMeni;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtBoxNazivMenija;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxCijenaBezValute;
    }
}