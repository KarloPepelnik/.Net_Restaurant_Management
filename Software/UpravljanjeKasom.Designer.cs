
namespace ProgramskoIntenjerstvo
{
    partial class UpravljanjeKasom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpravljanjeKasom));
            this.zatvoriBtn = new System.Windows.Forms.Button();
            this.prikaziJelaBtn = new System.Windows.Forms.Button();
            this.popisArtikalaPoRacunuDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.stanjeKaseText = new System.Windows.Forms.TextBox();
            this.stornoBtn = new System.Windows.Forms.Button();
            this.vrijemeDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.popisRacunaDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.popisArtikalaPoRacunuDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popisRacunaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // zatvoriBtn
            // 
            this.zatvoriBtn.Location = new System.Drawing.Point(315, 467);
            this.zatvoriBtn.Name = "zatvoriBtn";
            this.zatvoriBtn.Size = new System.Drawing.Size(75, 23);
            this.zatvoriBtn.TabIndex = 15;
            this.zatvoriBtn.Text = "Zatvori";
            this.zatvoriBtn.UseVisualStyleBackColor = true;
            this.zatvoriBtn.Click += new System.EventHandler(this.zatvoriBtn_Click);
            // 
            // prikaziJelaBtn
            // 
            this.prikaziJelaBtn.Location = new System.Drawing.Point(481, 427);
            this.prikaziJelaBtn.Name = "prikaziJelaBtn";
            this.prikaziJelaBtn.Size = new System.Drawing.Size(75, 23);
            this.prikaziJelaBtn.TabIndex = 14;
            this.prikaziJelaBtn.Text = "Prikaži Jela";
            this.prikaziJelaBtn.UseVisualStyleBackColor = true;
            // 
            // popisArtikalaPoRacunuDgv
            // 
            this.popisArtikalaPoRacunuDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisArtikalaPoRacunuDgv.Location = new System.Drawing.Point(356, 86);
            this.popisArtikalaPoRacunuDgv.Name = "popisArtikalaPoRacunuDgv";
            this.popisArtikalaPoRacunuDgv.Size = new System.Drawing.Size(329, 307);
            this.popisArtikalaPoRacunuDgv.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Stanje kase";
            // 
            // stanjeKaseText
            // 
            this.stanjeKaseText.Enabled = false;
            this.stanjeKaseText.Location = new System.Drawing.Point(474, 40);
            this.stanjeKaseText.Name = "stanjeKaseText";
            this.stanjeKaseText.Size = new System.Drawing.Size(100, 20);
            this.stanjeKaseText.TabIndex = 11;
            // 
            // stornoBtn
            // 
            this.stornoBtn.Location = new System.Drawing.Point(121, 423);
            this.stornoBtn.Name = "stornoBtn";
            this.stornoBtn.Size = new System.Drawing.Size(101, 31);
            this.stornoBtn.TabIndex = 10;
            this.stornoBtn.Text = "Storno računa";
            this.stornoBtn.UseVisualStyleBackColor = true;
            this.stornoBtn.Click += new System.EventHandler(this.stornoBtn_Click);
            // 
            // vrijemeDatumPicker
            // 
            this.vrijemeDatumPicker.CustomFormat = "yyyy-mm-dd";
            this.vrijemeDatumPicker.Location = new System.Drawing.Point(78, 14);
            this.vrijemeDatumPicker.Name = "vrijemeDatumPicker";
            this.vrijemeDatumPicker.Size = new System.Drawing.Size(200, 20);
            this.vrijemeDatumPicker.TabIndex = 9;
            this.vrijemeDatumPicker.Value = new System.DateTime(2021, 5, 28, 19, 20, 42, 0);
            this.vrijemeDatumPicker.ValueChanged += new System.EventHandler(this.vrijemeDatumPicker_ValueChanged);
            // 
            // popisRacunaDgv
            // 
            this.popisRacunaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisRacunaDgv.Location = new System.Drawing.Point(12, 40);
            this.popisRacunaDgv.Name = "popisRacunaDgv";
            this.popisRacunaDgv.Size = new System.Drawing.Size(338, 353);
            this.popisRacunaDgv.TabIndex = 8;
            this.popisRacunaDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.popisRacunaDgv_CellContentClick);
            // 
            // UpravljanjeKasom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 515);
            this.Controls.Add(this.zatvoriBtn);
            this.Controls.Add(this.prikaziJelaBtn);
            this.Controls.Add(this.popisArtikalaPoRacunuDgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stanjeKaseText);
            this.Controls.Add(this.stornoBtn);
            this.Controls.Add(this.vrijemeDatumPicker);
            this.Controls.Add(this.popisRacunaDgv);
            this.Name = "UpravljanjeKasom";
            this.Text = "Kasa";
            this.Load += new System.EventHandler(this.UpravljanjeKasom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisArtikalaPoRacunuDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popisRacunaDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zatvoriBtn;
        private System.Windows.Forms.Button prikaziJelaBtn;
        private System.Windows.Forms.DataGridView popisArtikalaPoRacunuDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stanjeKaseText;
        private System.Windows.Forms.Button stornoBtn;
        private System.Windows.Forms.DateTimePicker vrijemeDatumPicker;
        private System.Windows.Forms.DataGridView popisRacunaDgv;
    }
}