
namespace ProgramskoIntenjerstvo
{
    partial class FrmPregledJela
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtBoxNazivJelaSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrikaziSvaJela = new System.Windows.Forms.Button();
            this.cmbBoxSortOptions = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFilterPoKategoriji = new System.Windows.Forms.Button();
            this.cmbBoxKategorijaJelaSort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIzbrisiJelo = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.dgvPopisJela = new System.Windows.Forms.DataGridView();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisJela)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(439, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pregled svih jela";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnPretrazi);
            this.groupBox6.Controls.Add(this.txtBoxNazivJelaSearch);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(552, 575);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(288, 107);
            this.groupBox6.TabIndex = 20;
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
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click_1);
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
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(857, 704);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(148, 35);
            this.btnIzlaz.TabIndex = 18;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrikaziSvaJela);
            this.groupBox3.Controls.Add(this.cmbBoxSortOptions);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnFilterPoKategoriji);
            this.groupBox3.Controls.Add(this.cmbBoxKategorijaJelaSort);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(16, 568);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 119);
            this.groupBox3.TabIndex = 19;
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
            this.btnPrikaziSvaJela.Click += new System.EventHandler(this.btnPrikaziSvaJela_Click_1);
            // 
            // cmbBoxSortOptions
            // 
            this.cmbBoxSortOptions.FormattingEnabled = true;
            this.cmbBoxSortOptions.Location = new System.Drawing.Point(299, 58);
            this.cmbBoxSortOptions.Name = "cmbBoxSortOptions";
            this.cmbBoxSortOptions.Size = new System.Drawing.Size(203, 24);
            this.cmbBoxSortOptions.TabIndex = 4;
            this.cmbBoxSortOptions.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSortOptions_SelectedIndexChanged_1);
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
            this.btnFilterPoKategoriji.Click += new System.EventHandler(this.btnFilterPoKategoriji_Click_1);
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
            // btnIzbrisiJelo
            // 
            this.btnIzbrisiJelo.Location = new System.Drawing.Point(857, 629);
            this.btnIzbrisiJelo.Name = "btnIzbrisiJelo";
            this.btnIzbrisiJelo.Size = new System.Drawing.Size(148, 35);
            this.btnIzbrisiJelo.TabIndex = 13;
            this.btnIzbrisiJelo.Text = "Izbriši jelo";
            this.btnIzbrisiJelo.UseVisualStyleBackColor = true;
            this.btnIzbrisiJelo.Click += new System.EventHandler(this.btnIzbrisiJelo_Click_1);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(857, 583);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(148, 35);
            this.btnAzuriraj.TabIndex = 12;
            this.btnAzuriraj.Text = "Ažuriraj jelo";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click_1);
            // 
            // dgvPopisJela
            // 
            this.dgvPopisJela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPopisJela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopisJela.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPopisJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisJela.Location = new System.Drawing.Point(16, 71);
            this.dgvPopisJela.Name = "dgvPopisJela";
            this.dgvPopisJela.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPopisJela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisJela.Size = new System.Drawing.Size(989, 491);
            this.dgvPopisJela.TabIndex = 0;
            // 
            // FrmPregledJela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 751);
            this.Controls.Add(this.dgvPopisJela);
            this.Controls.Add(this.btnIzbrisiJelo);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPregledJela";
            this.Text = "Pregled jela";
            this.Load += new System.EventHandler(this.FrmPregledJela_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisJela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtBoxNazivJelaSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPrikaziSvaJela;
        private System.Windows.Forms.ComboBox cmbBoxSortOptions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFilterPoKategoriji;
        private System.Windows.Forms.ComboBox cmbBoxKategorijaJelaSort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPopisJela;
        private System.Windows.Forms.Button btnIzbrisiJelo;
        private System.Windows.Forms.Button btnAzuriraj;
    }
}