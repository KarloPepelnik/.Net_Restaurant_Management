
namespace ProgramskoIntenjerstvo
{
    partial class FrmDodajSastojkeJelu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxOdabranoJelo = new System.Windows.Forms.TextBox();
            this.listBoxNamirnice = new System.Windows.Forms.ListBox();
            this.btnDodajSastojak = new System.Windows.Forms.Button();
            this.txtBoxOdabranaNamirnica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSastojciJela = new System.Windows.Forms.DataGridView();
            this.txtBoxKolicina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnOdaberiNamirnicu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIzbrisiSastojak = new System.Windows.Forms.Button();
            this.btnUrediKolicinu = new System.Windows.Forms.Button();
            this.namirnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jelosadrziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojciJela)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jelosadrziBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odabrano jelo:";
            // 
            // txtBoxOdabranoJelo
            // 
            this.txtBoxOdabranoJelo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxOdabranoJelo.Location = new System.Drawing.Point(117, 16);
            this.txtBoxOdabranoJelo.Name = "txtBoxOdabranoJelo";
            this.txtBoxOdabranoJelo.ReadOnly = true;
            this.txtBoxOdabranoJelo.Size = new System.Drawing.Size(471, 25);
            this.txtBoxOdabranoJelo.TabIndex = 1;
            this.txtBoxOdabranoJelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBoxNamirnice
            // 
            this.listBoxNamirnice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxNamirnice.FormattingEnabled = true;
            this.listBoxNamirnice.ItemHeight = 17;
            this.listBoxNamirnice.Location = new System.Drawing.Point(28, 63);
            this.listBoxNamirnice.Name = "listBoxNamirnice";
            this.listBoxNamirnice.Size = new System.Drawing.Size(317, 208);
            this.listBoxNamirnice.TabIndex = 2;
            // 
            // btnDodajSastojak
            // 
            this.btnDodajSastojak.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajSastojak.Location = new System.Drawing.Point(355, 178);
            this.btnDodajSastojak.Name = "btnDodajSastojak";
            this.btnDodajSastojak.Size = new System.Drawing.Size(228, 28);
            this.btnDodajSastojak.TabIndex = 3;
            this.btnDodajSastojak.Text = "Dodaj sastojak";
            this.btnDodajSastojak.UseVisualStyleBackColor = true;
            this.btnDodajSastojak.Click += new System.EventHandler(this.btnDodajSastojak_Click);
            // 
            // txtBoxOdabranaNamirnica
            // 
            this.txtBoxOdabranaNamirnica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxOdabranaNamirnica.Location = new System.Drawing.Point(354, 91);
            this.txtBoxOdabranaNamirnica.Name = "txtBoxOdabranaNamirnica";
            this.txtBoxOdabranaNamirnica.ReadOnly = true;
            this.txtBoxOdabranaNamirnica.Size = new System.Drawing.Size(228, 25);
            this.txtBoxOdabranaNamirnica.TabIndex = 5;
            this.txtBoxOdabranaNamirnica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(351, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odabrana namirnica:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSastojciJela);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(28, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 229);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sastojci jela";
            // 
            // dgvSastojciJela
            // 
            this.dgvSastojciJela.AllowUserToAddRows = false;
            this.dgvSastojciJela.AutoGenerateColumns = false;
            this.dgvSastojciJela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSastojciJela.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSastojciJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSastojciJela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namirnicaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dgvSastojciJela.DataSource = this.jelosadrziBindingSource;
            this.dgvSastojciJela.Location = new System.Drawing.Point(11, 18);
            this.dgvSastojciJela.Name = "dgvSastojciJela";
            this.dgvSastojciJela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSastojciJela.Size = new System.Drawing.Size(306, 201);
            this.dgvSastojciJela.TabIndex = 0;
            // 
            // txtBoxKolicina
            // 
            this.txtBoxKolicina.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxKolicina.Location = new System.Drawing.Point(415, 133);
            this.txtBoxKolicina.Name = "txtBoxKolicina";
            this.txtBoxKolicina.Size = new System.Drawing.Size(83, 25);
            this.txtBoxKolicina.TabIndex = 8;
            this.txtBoxKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxKolicina.TextChanged += new System.EventHandler(this.txtBoxKolicina_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(351, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Količina:";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDone.Location = new System.Drawing.Point(374, 507);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(180, 32);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Gotovo";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnOdaberiNamirnicu
            // 
            this.btnOdaberiNamirnicu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdaberiNamirnicu.Location = new System.Drawing.Point(28, 276);
            this.btnOdaberiNamirnicu.Name = "btnOdaberiNamirnicu";
            this.btnOdaberiNamirnicu.Size = new System.Drawing.Size(317, 28);
            this.btnOdaberiNamirnicu.TabIndex = 10;
            this.btnOdaberiNamirnicu.Text = "Odaberi namirnicu";
            this.btnOdaberiNamirnicu.UseVisualStyleBackColor = true;
            this.btnOdaberiNamirnicu.Click += new System.EventHandler(this.btnOdaberiNamirnicu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIzbrisiSastojak);
            this.groupBox2.Controls.Add(this.btnUrediKolicinu);
            this.groupBox2.Location = new System.Drawing.Point(368, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 117);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uredi sastojke jela";
            // 
            // btnIzbrisiSastojak
            // 
            this.btnIzbrisiSastojak.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiSastojak.Location = new System.Drawing.Point(6, 68);
            this.btnIzbrisiSastojak.Name = "btnIzbrisiSastojak";
            this.btnIzbrisiSastojak.Size = new System.Drawing.Size(206, 28);
            this.btnIzbrisiSastojak.TabIndex = 1;
            this.btnIzbrisiSastojak.Text = "Izbriši sastojak";
            this.btnIzbrisiSastojak.UseVisualStyleBackColor = true;
            this.btnIzbrisiSastojak.Click += new System.EventHandler(this.btnIzbrisiSastojak_Click);
            // 
            // btnUrediKolicinu
            // 
            this.btnUrediKolicinu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUrediKolicinu.Location = new System.Drawing.Point(6, 34);
            this.btnUrediKolicinu.Name = "btnUrediKolicinu";
            this.btnUrediKolicinu.Size = new System.Drawing.Size(206, 28);
            this.btnUrediKolicinu.TabIndex = 0;
            this.btnUrediKolicinu.Text = "Uredi količinu";
            this.btnUrediKolicinu.UseVisualStyleBackColor = true;
            this.btnUrediKolicinu.Click += new System.EventHandler(this.btnUrediKolicinu_Click);
            // 
            // namirnicaDataGridViewTextBoxColumn
            // 
            this.namirnicaDataGridViewTextBoxColumn.DataPropertyName = "Namirnica";
            this.namirnicaDataGridViewTextBoxColumn.HeaderText = "Namirnica";
            this.namirnicaDataGridViewTextBoxColumn.Name = "namirnicaDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // jelosadrziBindingSource
            // 
            this.jelosadrziBindingSource.DataSource = typeof(ProgramskoIntenjerstvo.Jelo_sadrzi);
            // 
            // FrmDodajSastojkeJelu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOdaberiNamirnicu);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtBoxKolicina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBoxOdabranaNamirnica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajSastojak);
            this.Controls.Add(this.listBoxNamirnice);
            this.Controls.Add(this.txtBoxOdabranoJelo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDodajSastojkeJelu";
            this.Text = "Dodaj sastojke jelu";
            this.Load += new System.EventHandler(this.FrmDodajSastojkeJelu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojciJela)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jelosadrziBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxOdabranoJelo;
        private System.Windows.Forms.ListBox listBoxNamirnice;
        private System.Windows.Forms.Button btnDodajSastojak;
        private System.Windows.Forms.TextBox txtBoxOdabranaNamirnica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSastojciJela;
        private System.Windows.Forms.TextBox txtBoxKolicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnOdaberiNamirnicu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIzbrisiSastojak;
        private System.Windows.Forms.Button btnUrediKolicinu;
        private System.Windows.Forms.DataGridViewTextBoxColumn namirnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jelosadrziBindingSource;
    }
}