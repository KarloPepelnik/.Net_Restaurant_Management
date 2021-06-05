
namespace ProgramskoIntenjerstvo
{
    partial class FrmTrenutnoStanje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTrenutnoStanjeZaliha = new System.Windows.Forms.DataGridView();
            this.btnDodajNamirnicu = new System.Windows.Forms.Button();
            this.btnAzurirajNamirnicu = new System.Windows.Forms.Button();
            this.btnIzbrisiNamirnicu = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrikaziKategoriju = new System.Windows.Forms.Button();
            this.cmbBoxPrikazPoKategoriji = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtBoxPretraga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxSortiraj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenutnoStanjeZaliha)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trenutno stanje zaliha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseWaitCursor = true;
            // 
            // dgvTrenutnoStanjeZaliha
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dgvTrenutnoStanjeZaliha.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrenutnoStanjeZaliha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrenutnoStanjeZaliha.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrenutnoStanjeZaliha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrenutnoStanjeZaliha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrenutnoStanjeZaliha.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrenutnoStanjeZaliha.Location = new System.Drawing.Point(12, 159);
            this.dgvTrenutnoStanjeZaliha.Name = "dgvTrenutnoStanjeZaliha";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrenutnoStanjeZaliha.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTrenutnoStanjeZaliha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrenutnoStanjeZaliha.Size = new System.Drawing.Size(922, 328);
            this.dgvTrenutnoStanjeZaliha.TabIndex = 2;
            this.dgvTrenutnoStanjeZaliha.UseWaitCursor = true;
            // 
            // btnDodajNamirnicu
            // 
            this.btnDodajNamirnicu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNamirnicu.Location = new System.Drawing.Point(526, 493);
            this.btnDodajNamirnicu.Name = "btnDodajNamirnicu";
            this.btnDodajNamirnicu.Size = new System.Drawing.Size(133, 28);
            this.btnDodajNamirnicu.TabIndex = 3;
            this.btnDodajNamirnicu.Text = "Dodaj namirnicu";
            this.btnDodajNamirnicu.UseVisualStyleBackColor = true;
            this.btnDodajNamirnicu.UseWaitCursor = true;
            this.btnDodajNamirnicu.Click += new System.EventHandler(this.btnDodajNamirnicu_Click);
            // 
            // btnAzurirajNamirnicu
            // 
            this.btnAzurirajNamirnicu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzurirajNamirnicu.Location = new System.Drawing.Point(665, 493);
            this.btnAzurirajNamirnicu.Name = "btnAzurirajNamirnicu";
            this.btnAzurirajNamirnicu.Size = new System.Drawing.Size(135, 28);
            this.btnAzurirajNamirnicu.TabIndex = 4;
            this.btnAzurirajNamirnicu.Text = "Ažuriraj namirnicu";
            this.btnAzurirajNamirnicu.UseVisualStyleBackColor = true;
            this.btnAzurirajNamirnicu.UseWaitCursor = true;
            this.btnAzurirajNamirnicu.Click += new System.EventHandler(this.btnAzurirajNamirnicu_Click);
            // 
            // btnIzbrisiNamirnicu
            // 
            this.btnIzbrisiNamirnicu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiNamirnicu.Location = new System.Drawing.Point(806, 493);
            this.btnIzbrisiNamirnicu.Name = "btnIzbrisiNamirnicu";
            this.btnIzbrisiNamirnicu.Size = new System.Drawing.Size(128, 28);
            this.btnIzbrisiNamirnicu.TabIndex = 5;
            this.btnIzbrisiNamirnicu.Text = "Izbriši namirnicu";
            this.btnIzbrisiNamirnicu.UseVisualStyleBackColor = true;
            this.btnIzbrisiNamirnicu.UseWaitCursor = true;
            this.btnIzbrisiNamirnicu.Click += new System.EventHandler(this.btnIzbrisiNamirnicu_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.Location = new System.Drawing.Point(806, 544);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(128, 32);
            this.btnIzlaz.TabIndex = 6;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.UseWaitCursor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrikaziKategoriju);
            this.groupBox1.Controls.Add(this.cmbBoxPrikazPoKategoriji);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnTrazi);
            this.groupBox1.Controls.Add(this.txtBoxPretraga);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbBoxSortiraj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 82);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            this.groupBox1.UseWaitCursor = true;
            // 
            // btnPrikaziKategoriju
            // 
            this.btnPrikaziKategoriju.Location = new System.Drawing.Point(788, 51);
            this.btnPrikaziKategoriju.Name = "btnPrikaziKategoriju";
            this.btnPrikaziKategoriju.Size = new System.Drawing.Size(134, 26);
            this.btnPrikaziKategoriju.TabIndex = 7;
            this.btnPrikaziKategoriju.Text = "Prikazi kategoriju";
            this.btnPrikaziKategoriju.UseVisualStyleBackColor = true;
            this.btnPrikaziKategoriju.UseWaitCursor = true;
            this.btnPrikaziKategoriju.Click += new System.EventHandler(this.btnPrikaziKategoriju_Click);
            // 
            // cmbBoxPrikazPoKategoriji
            // 
            this.cmbBoxPrikazPoKategoriji.FormattingEnabled = true;
            this.cmbBoxPrikazPoKategoriji.Location = new System.Drawing.Point(589, 51);
            this.cmbBoxPrikazPoKategoriji.Name = "cmbBoxPrikazPoKategoriji";
            this.cmbBoxPrikazPoKategoriji.Size = new System.Drawing.Size(193, 24);
            this.cmbBoxPrikazPoKategoriji.TabIndex = 6;
            this.cmbBoxPrikazPoKategoriji.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prikaz po kategoriji:";
            this.label4.UseWaitCursor = true;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(387, 56);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(137, 26);
            this.btnTrazi.TabIndex = 4;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.UseWaitCursor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // txtBoxPretraga
            // 
            this.txtBoxPretraga.Location = new System.Drawing.Point(387, 29);
            this.txtBoxPretraga.Name = "txtBoxPretraga";
            this.txtBoxPretraga.Size = new System.Drawing.Size(137, 22);
            this.txtBoxPretraga.TabIndex = 3;
            this.txtBoxPretraga.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pretraga po imenu:";
            this.label3.UseWaitCursor = true;
            // 
            // cmbBoxSortiraj
            // 
            this.cmbBoxSortiraj.FormattingEnabled = true;
            this.cmbBoxSortiraj.Location = new System.Drawing.Point(6, 48);
            this.cmbBoxSortiraj.Name = "cmbBoxSortiraj";
            this.cmbBoxSortiraj.Size = new System.Drawing.Size(204, 24);
            this.cmbBoxSortiraj.TabIndex = 1;
            this.cmbBoxSortiraj.UseWaitCursor = true;
            this.cmbBoxSortiraj.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSortiraj_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sortiraj prema:";
            this.label2.UseWaitCursor = true;
            // 
            // FrmTrenutnoStanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnIzbrisiNamirnicu);
            this.Controls.Add(this.btnAzurirajNamirnicu);
            this.Controls.Add(this.btnDodajNamirnicu);
            this.Controls.Add(this.dgvTrenutnoStanjeZaliha);
            this.Controls.Add(this.label1);
            this.Name = "FrmTrenutnoStanje";
            this.Text = "Trenutno stanje";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FrmTrenutnoStanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrenutnoStanjeZaliha)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTrenutnoStanjeZaliha;
        private System.Windows.Forms.Button btnDodajNamirnicu;
        private System.Windows.Forms.Button btnAzurirajNamirnicu;
        private System.Windows.Forms.Button btnIzbrisiNamirnicu;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxPretraga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBoxSortiraj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.ComboBox cmbBoxPrikazPoKategoriji;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrikaziKategoriju;
    }
}