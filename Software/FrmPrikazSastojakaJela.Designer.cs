
namespace ProgramskoIntenjerstvo
{
    partial class FrmPrikazSastojakaJela
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
            this.dgvPrikazSastojaka = new System.Windows.Forms.DataGridView();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.jelosadrziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namirnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazSastojaka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jelosadrziBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrikazSastojaka
            // 
            this.dgvPrikazSastojaka.AllowUserToOrderColumns = true;
            this.dgvPrikazSastojaka.AutoGenerateColumns = false;
            this.dgvPrikazSastojaka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrikazSastojaka.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrikazSastojaka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazSastojaka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namirnicaDataGridViewTextBoxColumn,
            this.kolicina});
            this.dgvPrikazSastojaka.DataSource = this.jelosadrziBindingSource;
            this.dgvPrikazSastojaka.Location = new System.Drawing.Point(6, 9);
            this.dgvPrikazSastojaka.Name = "dgvPrikazSastojaka";
            this.dgvPrikazSastojaka.Size = new System.Drawing.Size(469, 268);
            this.dgvPrikazSastojaka.TabIndex = 0;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(330, 283);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(145, 32);
            this.btnIzlaz.TabIndex = 1;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // jelosadrziBindingSource
            // 
            this.jelosadrziBindingSource.DataSource = typeof(ProgramskoIntenjerstvo.Jelo_sadrzi);
            // 
            // namirnicaDataGridViewTextBoxColumn
            // 
            this.namirnicaDataGridViewTextBoxColumn.DataPropertyName = "Namirnica";
            this.namirnicaDataGridViewTextBoxColumn.HeaderText = "Namirnica";
            this.namirnicaDataGridViewTextBoxColumn.Name = "namirnicaDataGridViewTextBoxColumn";
            // 
            // kolicina
            // 
            this.kolicina.DataPropertyName = "kolicina";
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            // 
            // FrmPrikazSastojakaJela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 324);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dgvPrikazSastojaka);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrikazSastojakaJela";
            this.Text = "Prikaz sastojaka jela";
            this.Load += new System.EventHandler(this.FrmPrikazSastojakaJela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazSastojaka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jelosadrziBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikazSastojaka;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelosadrzi1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelosadrzi2DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jelosadrziBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn namirnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
    }
}