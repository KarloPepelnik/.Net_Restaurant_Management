
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
            this.cmbBoxKategorijeJela = new System.Windows.Forms.ComboBox();
            this.btnDodajJelo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxCijena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDodajSastojkeJela = new System.Windows.Forms.Button();
            this.btnPrikaziSastojkeJela = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnIzbrisiJelo = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.dgvPopisJela = new System.Windows.Forms.DataGridView();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrikaziSvaJela = new System.Windows.Forms.Button();
            this.cmbBoxSortOptions = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFilterPoKategoriji = new System.Windows.Forms.Button();
            this.cmbBoxKategorijaJelaSort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtBoxNazivJelaSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisJela)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kategorija jela:";
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDodajSastojkeJela);
            this.groupBox5.Controls.Add(this.btnPrikaziSastojkeJela);
            this.groupBox5.Location = new System.Drawing.Point(631, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(196, 122);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sastojci jela";
            // 
            // btnDodajSastojkeJela
            // 
            this.btnDodajSastojkeJela.Location = new System.Drawing.Point(20, 72);
            this.btnDodajSastojkeJela.Name = "btnDodajSastojkeJela";
            this.btnDodajSastojkeJela.Size = new System.Drawing.Size(165, 43);
            this.btnDodajSastojkeJela.TabIndex = 2;
            this.btnDodajSastojkeJela.Text = "Dodaj ili uredi sastojke jela";
            this.btnDodajSastojkeJela.UseVisualStyleBackColor = true;
            this.btnDodajSastojkeJela.Click += new System.EventHandler(this.btnDodajSastojkeJela_Click);
            // 
            // btnPrikaziSastojkeJela
            // 
            this.btnPrikaziSastojkeJela.Location = new System.Drawing.Point(20, 33);
            this.btnPrikaziSastojkeJela.Name = "btnPrikaziSastojkeJela";
            this.btnPrikaziSastojkeJela.Size = new System.Drawing.Size(155, 24);
            this.btnPrikaziSastojkeJela.TabIndex = 1;
            this.btnPrikaziSastojkeJela.Text = "Prikaži sastojke jela";
            this.btnPrikaziSastojkeJela.UseVisualStyleBackColor = true;
            this.btnPrikaziSastojkeJela.Click += new System.EventHandler(this.btnPrikaziSastojkeJela_Click);
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
            // dgvPopisJela
            // 
            this.dgvPopisJela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPopisJela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopisJela.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPopisJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisJela.Location = new System.Drawing.Point(11, 31);
            this.dgvPopisJela.Name = "dgvPopisJela";
            this.dgvPopisJela.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPopisJela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisJela.Size = new System.Drawing.Size(614, 280);
            this.dgvPopisJela.TabIndex = 0;
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
            this.groupBox3.Controls.Add(this.btnPrikaziSvaJela);
            this.groupBox3.Controls.Add(this.cmbBoxSortOptions);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnFilterPoKategoriji);
            this.groupBox3.Controls.Add(this.cmbBoxKategorijaJelaSort);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(35, 579);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 119);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sortiranja i filtriranja";
            // 
            // btnPrikaziSvaJela
            // 
            this.btnPrikaziSvaJela.Location = new System.Drawing.Point(125, 88);
            this.btnPrikaziSvaJela.Name = "btnPrikaziSvaJela";
            this.btnPrikaziSvaJela.Size = new System.Drawing.Size(154, 26);
            this.btnPrikaziSvaJela.TabIndex = 5;
            this.btnPrikaziSvaJela.Text = "Prikaži sva jela";
            this.btnPrikaziSvaJela.UseVisualStyleBackColor = true;
            this.btnPrikaziSvaJela.Click += new System.EventHandler(this.btnPrikaziSvaJela_Click);
            // 
            // cmbBoxSortOptions
            // 
            this.cmbBoxSortOptions.FormattingEnabled = true;
            this.cmbBoxSortOptions.Location = new System.Drawing.Point(299, 58);
            this.cmbBoxSortOptions.Name = "cmbBoxSortOptions";
            this.cmbBoxSortOptions.Size = new System.Drawing.Size(203, 24);
            this.cmbBoxSortOptions.TabIndex = 4;
            this.cmbBoxSortOptions.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSortOptions_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sortiraj prema";
            // 
            // btnFilterPoKategoriji
            // 
            this.btnFilterPoKategoriji.Location = new System.Drawing.Point(125, 56);
            this.btnFilterPoKategoriji.Name = "btnFilterPoKategoriji";
            this.btnFilterPoKategoriji.Size = new System.Drawing.Size(154, 26);
            this.btnFilterPoKategoriji.TabIndex = 2;
            this.btnFilterPoKategoriji.Text = "Filtriraj";
            this.btnFilterPoKategoriji.UseVisualStyleBackColor = true;
            this.btnFilterPoKategoriji.Click += new System.EventHandler(this.btnFilterPoKategoriji_Click);
            // 
            // cmbBoxKategorijaJelaSort
            // 
            this.cmbBoxKategorijaJelaSort.FormattingEnabled = true;
            this.cmbBoxKategorijaJelaSort.Location = new System.Drawing.Point(125, 26);
            this.cmbBoxKategorijaJelaSort.Name = "cmbBoxKategorijaJelaSort";
            this.cmbBoxKategorijaJelaSort.Size = new System.Drawing.Size(154, 24);
            this.cmbBoxKategorijaJelaSort.TabIndex = 1;
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnPretrazi);
            this.groupBox6.Controls.Add(this.txtBoxNazivJelaSearch);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(585, 579);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(288, 96);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pretraživanje";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(114, 54);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(161, 26);
            this.btnPretrazi.TabIndex = 5;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisJela)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnDodajSastojkeJela;
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
        private System.Windows.Forms.Button btnPrikaziSvaJela;
    }
}