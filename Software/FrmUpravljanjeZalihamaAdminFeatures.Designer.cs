
namespace ProgramskoIntenjerstvo
{
    partial class FrmUpravljanjeZalihamaAdminFeatures
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAdminPrimkaIzdatnica = new System.Windows.Forms.DataGridView();
            this.btnShowAllPrimke = new System.Windows.Forms.Button();
            this.btnShowAllIzdatnice = new System.Windows.Forms.Button();
            this.btnSortDatum = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTrenutnoPrikazano = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.cmbBoxFilterNamirnica = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPrimkaIzdatnica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Napredno upravljanje zalihama";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvAdminPrimkaIzdatnica
            // 
            this.dgvAdminPrimkaIzdatnica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminPrimkaIzdatnica.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdminPrimkaIzdatnica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAdminPrimkaIzdatnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdminPrimkaIzdatnica.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAdminPrimkaIzdatnica.Location = new System.Drawing.Point(18, 124);
            this.dgvAdminPrimkaIzdatnica.Name = "dgvAdminPrimkaIzdatnica";
            this.dgvAdminPrimkaIzdatnica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminPrimkaIzdatnica.Size = new System.Drawing.Size(824, 325);
            this.dgvAdminPrimkaIzdatnica.TabIndex = 10;
            // 
            // btnShowAllPrimke
            // 
            this.btnShowAllPrimke.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowAllPrimke.Location = new System.Drawing.Point(538, 92);
            this.btnShowAllPrimke.Name = "btnShowAllPrimke";
            this.btnShowAllPrimke.Size = new System.Drawing.Size(149, 25);
            this.btnShowAllPrimke.TabIndex = 11;
            this.btnShowAllPrimke.Text = "Prikazi sve primke";
            this.btnShowAllPrimke.UseVisualStyleBackColor = true;
            this.btnShowAllPrimke.Click += new System.EventHandler(this.btnShowAllPrimke_Click);
            // 
            // btnShowAllIzdatnice
            // 
            this.btnShowAllIzdatnice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowAllIzdatnice.Location = new System.Drawing.Point(693, 92);
            this.btnShowAllIzdatnice.Name = "btnShowAllIzdatnice";
            this.btnShowAllIzdatnice.Size = new System.Drawing.Size(149, 25);
            this.btnShowAllIzdatnice.TabIndex = 12;
            this.btnShowAllIzdatnice.Text = "Prikazi sve izdatnice";
            this.btnShowAllIzdatnice.UseVisualStyleBackColor = true;
            this.btnShowAllIzdatnice.Click += new System.EventHandler(this.btnShowAllIzdatnice_Click);
            // 
            // btnSortDatum
            // 
            this.btnSortDatum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSortDatum.Location = new System.Drawing.Point(18, 465);
            this.btnSortDatum.Name = "btnSortDatum";
            this.btnSortDatum.Size = new System.Drawing.Size(149, 25);
            this.btnSortDatum.TabIndex = 13;
            this.btnSortDatum.Text = "Sortiraj po datumu";
            this.btnSortDatum.UseVisualStyleBackColor = true;
            this.btnSortDatum.Click += new System.EventHandler(this.btnSortDatum_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Trenutno prikazano:";
            // 
            // txtBoxTrenutnoPrikazano
            // 
            this.txtBoxTrenutnoPrikazano.Location = new System.Drawing.Point(156, 98);
            this.txtBoxTrenutnoPrikazano.Name = "txtBoxTrenutnoPrikazano";
            this.txtBoxTrenutnoPrikazano.Size = new System.Drawing.Size(127, 20);
            this.txtBoxTrenutnoPrikazano.TabIndex = 17;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Location = new System.Drawing.Point(480, 467);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(182, 32);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Azuriraj primku/izdatnicu";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisi.Location = new System.Drawing.Point(668, 466);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(174, 33);
            this.btnIzbrisi.TabIndex = 19;
            this.btnIzbrisi.Text = "Izbrisi primku/izdatnicu";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(749, 523);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(93, 28);
            this.btnIzlaz.TabIndex = 20;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // cmbBoxFilterNamirnica
            // 
            this.cmbBoxFilterNamirnica.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBoxFilterNamirnica.FormattingEnabled = true;
            this.cmbBoxFilterNamirnica.Location = new System.Drawing.Point(187, 491);
            this.cmbBoxFilterNamirnica.Name = "cmbBoxFilterNamirnica";
            this.cmbBoxFilterNamirnica.Size = new System.Drawing.Size(162, 24);
            this.cmbBoxFilterNamirnica.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(184, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filtriraj po namirnici";
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFiltriraj.Location = new System.Drawing.Point(187, 523);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(161, 27);
            this.btnFiltriraj.TabIndex = 21;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // FrmUpravljanjeZalihamaAdminFeatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 563);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtBoxTrenutnoPrikazano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBoxFilterNamirnica);
            this.Controls.Add(this.btnSortDatum);
            this.Controls.Add(this.btnShowAllIzdatnice);
            this.Controls.Add(this.btnShowAllPrimke);
            this.Controls.Add(this.dgvAdminPrimkaIzdatnica);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpravljanjeZalihamaAdminFeatures";
            this.Text = "Mogućnosti administratora";
            this.Load += new System.EventHandler(this.FrmUpravljanjeZalihamaAdminFeatures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPrimkaIzdatnica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAdminPrimkaIzdatnica;
        private System.Windows.Forms.Button btnShowAllPrimke;
        private System.Windows.Forms.Button btnShowAllIzdatnice;
        private System.Windows.Forms.Button btnSortDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTrenutnoPrikazano;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.ComboBox cmbBoxFilterNamirnica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltriraj;
    }
}