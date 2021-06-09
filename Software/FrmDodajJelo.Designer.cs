
namespace ProgramskoIntenjerstvo
{
    partial class FrmDodajJelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajJelo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNazivJela = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxCijena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxKategorijeJela = new System.Windows.Forms.ComboBox();
            this.btnDodajJelo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPopisJela = new System.Windows.Forms.DataGridView();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnIzbrisiJelo = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPrikaziSastojkeJela = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxKategorijaJelaSort = new System.Windows.Forms.ComboBox();
            this.btnFilterPoKategoriji = new System.Windows.Forms.Button();
            this.cmbBoxSortOptions = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtBoxNazivJelaSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisJela)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Upravljanje jelima";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv jela:";
            // 
            // txtBoxNazivJela
            // 
            this.txtBoxNazivJela.Location = new System.Drawing.Point(108, 28);
            this.txtBoxNazivJela.Name = "txtBoxNazivJela";
            this.txtBoxNazivJela.Size = new System.Drawing.Size(331, 22);
            this.txtBoxNazivJela.TabIndex = 5;
            this.txtBoxNazivJela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBoxKategorijeJela);
            this.groupBox1.Controls.Add(this.btnDodajJelo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxCijena);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxNazivJela);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(194, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 138);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo jelo";
            // 
            // txtBoxCijena
            // 
            this.txtBoxCijena.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxCijena.Location = new System.Drawing.Point(108, 59);
            this.txtBoxCijena.Name = "txtBoxCijena";
            this.txtBoxCijena.Size = new System.Drawing.Size(88, 22);
            this.txtBoxCijena.TabIndex = 7;
            this.txtBoxCijena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cijena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kategorija jela:";
            // 
            // cmbBoxKategorijeJela
            // 
            this.cmbBoxKategorijeJela.FormattingEnabled = true;
            this.cmbBoxKategorijeJela.Location = new System.Drawing.Point(108, 89);
            this.cmbBoxKategorijeJela.Name = "cmbBoxKategorijeJela";
            this.cmbBoxKategorijeJela.Size = new System.Drawing.Size(195, 24);
            this.cmbBoxKategorijeJela.TabIndex = 9;
            // 
            // btnDodajJelo
            // 
            this.btnDodajJelo.Location = new System.Drawing.Point(520, 20);
            this.btnDodajJelo.Name = "btnDodajJelo";
            this.btnDodajJelo.Size = new System.Drawing.Size(133, 30);
            this.btnDodajJelo.TabIndex = 9;
            this.btnDodajJelo.Text = "Dodaj jelo";
            this.btnDodajJelo.UseVisualStyleBackColor = true;
            this.btnDodajJelo.Click += new System.EventHandler(this.btnDodajJelo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(26, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 138);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.dgvPopisJela);
            this.groupBox2.Location = new System.Drawing.Point(31, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 322);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Popis svih jela";
            // 
            // dgvPopisJela
            // 
            this.dgvPopisJela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopisJela.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPopisJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisJela.Location = new System.Drawing.Point(11, 31);
            this.dgvPopisJela.Name = "dgvPopisJela";
            this.dgvPopisJela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisJela.Size = new System.Drawing.Size(614, 280);
            this.dgvPopisJela.TabIndex = 0;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(27, 21);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(148, 35);
            this.btnAzuriraj.TabIndex = 12;
            this.btnAzuriraj.Text = "Ažuriraj jelo";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnIzbrisiJelo
            // 
            this.btnIzbrisiJelo.Location = new System.Drawing.Point(27, 62);
            this.btnIzbrisiJelo.Name = "btnIzbrisiJelo";
            this.btnIzbrisiJelo.Size = new System.Drawing.Size(148, 35);
            this.btnIzbrisiJelo.TabIndex = 13;
            this.btnIzbrisiJelo.Text = "Izbriši jelo";
            this.btnIzbrisiJelo.UseVisualStyleBackColor = true;
            this.btnIzbrisiJelo.Click += new System.EventHandler(this.btnIzbrisiJelo_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(748, 683);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(125, 35);
            this.btnIzlaz.TabIndex = 14;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbBoxSortOptions);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnFilterPoKategoriji);
            this.groupBox3.Controls.Add(this.cmbBoxKategorijaJelaSort);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(35, 579);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 97);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sortiranja i filtriranja";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnIzbrisiJelo);
            this.groupBox4.Controls.Add(this.btnAzuriraj);
            this.groupBox4.Location = new System.Drawing.Point(631, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(196, 114);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // btnPrikaziSastojkeJela
            // 
            this.btnPrikaziSastojkeJela.Location = new System.Drawing.Point(20, 33);
            this.btnPrikaziSastojkeJela.Name = "btnPrikaziSastojkeJela";
            this.btnPrikaziSastojkeJela.Size = new System.Drawing.Size(155, 24);
            this.btnPrikaziSastojkeJela.TabIndex = 1;
            this.btnPrikaziSastojkeJela.Text = "Prikaži sastojke jela";
            this.btnPrikaziSastojkeJela.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj sastojke jela";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.btnPrikaziSastojkeJela);
            this.groupBox5.Location = new System.Drawing.Point(631, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(196, 151);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sastojci jela";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Uredi sastojke jela";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Odaberi kategoriju";
            // 
            // cmbBoxKategorijaJelaSort
            // 
            this.cmbBoxKategorijaJelaSort.FormattingEnabled = true;
            this.cmbBoxKategorijaJelaSort.Location = new System.Drawing.Point(125, 26);
            this.cmbBoxKategorijaJelaSort.Name = "cmbBoxKategorijaJelaSort";
            this.cmbBoxKategorijaJelaSort.Size = new System.Drawing.Size(154, 24);
            this.cmbBoxKategorijaJelaSort.TabIndex = 1;
            // 
            // btnFilterPoKategoriji
            // 
            this.btnFilterPoKategoriji.Location = new System.Drawing.Point(125, 56);
            this.btnFilterPoKategoriji.Name = "btnFilterPoKategoriji";
            this.btnFilterPoKategoriji.Size = new System.Drawing.Size(154, 26);
            this.btnFilterPoKategoriji.TabIndex = 2;
            this.btnFilterPoKategoriji.Text = "Filtriraj";
            this.btnFilterPoKategoriji.UseVisualStyleBackColor = true;
            // 
            // cmbBoxSortOptions
            // 
            this.cmbBoxSortOptions.FormattingEnabled = true;
            this.cmbBoxSortOptions.Location = new System.Drawing.Point(308, 45);
            this.cmbBoxSortOptions.Name = "cmbBoxSortOptions";
            this.cmbBoxSortOptions.Size = new System.Drawing.Size(154, 24);
            this.cmbBoxSortOptions.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sortiraj prema";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnPretrazi);
            this.groupBox6.Controls.Add(this.txtBoxNazivJelaSearch);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(535, 579);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(338, 96);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pretraživanje";
            // 
            // txtBoxNazivJelaSearch
            // 
            this.txtBoxNazivJelaSearch.Location = new System.Drawing.Point(114, 24);
            this.txtBoxNazivJelaSearch.Name = "txtBoxNazivJelaSearch";
            this.txtBoxNazivJelaSearch.Size = new System.Drawing.Size(161, 22);
            this.txtBoxNazivJelaSearch.TabIndex = 11;
            this.txtBoxNazivJelaSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Unesi naziv jela:";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(114, 54);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(161, 26);
            this.btnPretrazi.TabIndex = 5;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // FrmDodajJelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 730);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDodajJelo";
            this.Text = "Dodaj jelo";
            this.Load += new System.EventHandler(this.FrmDodajJelo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisJela)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNazivJela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBoxKategorijeJela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxCijena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodajJelo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPopisJela;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnIzbrisiJelo;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrikaziSastojkeJela;
        private System.Windows.Forms.ComboBox cmbBoxSortOptions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFilterPoKategoriji;
        private System.Windows.Forms.ComboBox cmbBoxKategorijaJelaSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtBoxNazivJelaSearch;
        private System.Windows.Forms.Label label7;
    }
}