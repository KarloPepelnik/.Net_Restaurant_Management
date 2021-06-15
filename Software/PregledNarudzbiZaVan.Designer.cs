
namespace ProgramskoIntenjerstvo
{
    partial class PregledNarudzbiZaVan
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
            this.izvrsenaBtn = new System.Windows.Forms.Button();
            this.zatvoriBtn = new System.Windows.Forms.Button();
            this.narudzbeDgv = new System.Windows.Forms.DataGridView();
            this.dostavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PI21_13_DBDataSet = new ProgramskoIntenjerstvo._PI21_13_DBDataSet();
            this.dostavaTableAdapter = new ProgramskoIntenjerstvo._PI21_13_DBDataSetTableAdapters.DostavaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostavaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PI21_13_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // izvrsenaBtn
            // 
            this.izvrsenaBtn.Location = new System.Drawing.Point(12, 372);
            this.izvrsenaBtn.Name = "izvrsenaBtn";
            this.izvrsenaBtn.Size = new System.Drawing.Size(75, 23);
            this.izvrsenaBtn.TabIndex = 1;
            this.izvrsenaBtn.Text = "Izvršena";
            this.izvrsenaBtn.UseVisualStyleBackColor = true;
            this.izvrsenaBtn.Click += new System.EventHandler(this.izvrsenaBtn_Click);
            // 
            // zatvoriBtn
            // 
            this.zatvoriBtn.Location = new System.Drawing.Point(381, 372);
            this.zatvoriBtn.Name = "zatvoriBtn";
            this.zatvoriBtn.Size = new System.Drawing.Size(75, 23);
            this.zatvoriBtn.TabIndex = 2;
            this.zatvoriBtn.Text = "Zatvori";
            this.zatvoriBtn.UseVisualStyleBackColor = true;
            this.zatvoriBtn.Click += new System.EventHandler(this.zatvoriBtn_Click_1);
            // 
            // narudzbeDgv
            // 
            this.narudzbeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.narudzbeDgv.Location = new System.Drawing.Point(12, 12);
            this.narudzbeDgv.Name = "narudzbeDgv";
            this.narudzbeDgv.Size = new System.Drawing.Size(444, 354);
            this.narudzbeDgv.TabIndex = 3;
            // 
            // dostavaBindingSource
            // 
            this.dostavaBindingSource.DataMember = "Dostava";
            this.dostavaBindingSource.DataSource = this._PI21_13_DBDataSet;
            // 
            // _PI21_13_DBDataSet
            // 
            this._PI21_13_DBDataSet.DataSetName = "_PI21_13_DBDataSet";
            this._PI21_13_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dostavaTableAdapter
            // 
            this.dostavaTableAdapter.ClearBeforeFill = true;
            // 
            // PregledNarudzbiZaVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 411);
            this.Controls.Add(this.narudzbeDgv);
            this.Controls.Add(this.zatvoriBtn);
            this.Controls.Add(this.izvrsenaBtn);
            this.Name = "PregledNarudzbiZaVan";
            this.Text = "Narudžbe za van";
            this.Load += new System.EventHandler(this.PregledNarudzbiZaVan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostavaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PI21_13_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button izvrsenaBtn;
        private System.Windows.Forms.Button zatvoriBtn;
        private _PI21_13_DBDataSet _PI21_13_DBDataSet;
        private System.Windows.Forms.BindingSource dostavaBindingSource;
        private _PI21_13_DBDataSetTableAdapters.DostavaTableAdapter dostavaTableAdapter;
        private System.Windows.Forms.DataGridView narudzbeDgv;
    }
}