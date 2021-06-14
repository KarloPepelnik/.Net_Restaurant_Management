
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
            this.popisNarudzbiDgv = new System.Windows.Forms.DataGridView();
            this.izvrsenaButton = new System.Windows.Forms.Button();
            this.zatvoriBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisNarudzbiDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // popisNarudzbiDgv
            // 
            this.popisNarudzbiDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisNarudzbiDgv.Location = new System.Drawing.Point(12, 12);
            this.popisNarudzbiDgv.Name = "popisNarudzbiDgv";
            this.popisNarudzbiDgv.Size = new System.Drawing.Size(439, 309);
            this.popisNarudzbiDgv.TabIndex = 0;
            // 
            // izvrsenaButton
            // 
            this.izvrsenaButton.Location = new System.Drawing.Point(12, 343);
            this.izvrsenaButton.Name = "izvrsenaButton";
            this.izvrsenaButton.Size = new System.Drawing.Size(75, 23);
            this.izvrsenaButton.TabIndex = 1;
            this.izvrsenaButton.Text = "Izvršena";
            this.izvrsenaButton.UseVisualStyleBackColor = true;
            this.izvrsenaButton.Click += new System.EventHandler(this.izvrsenaButton_Click);
            // 
            // zatvoriBtn
            // 
            this.zatvoriBtn.Location = new System.Drawing.Point(377, 343);
            this.zatvoriBtn.Name = "zatvoriBtn";
            this.zatvoriBtn.Size = new System.Drawing.Size(75, 23);
            this.zatvoriBtn.TabIndex = 2;
            this.zatvoriBtn.Text = "Zatvori";
            this.zatvoriBtn.UseVisualStyleBackColor = true;
            this.zatvoriBtn.Click += new System.EventHandler(this.zatvoriBtn_Click);
            // 
            // PregledNarudzbiZaVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 381);
            this.Controls.Add(this.zatvoriBtn);
            this.Controls.Add(this.izvrsenaButton);
            this.Controls.Add(this.popisNarudzbiDgv);
            this.Name = "PregledNarudzbiZaVan";
            this.Text = "Narudžbe za van";
            this.Load += new System.EventHandler(this.PregledNarudzbiZaVan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisNarudzbiDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView popisNarudzbiDgv;
        private System.Windows.Forms.Button izvrsenaButton;
        private System.Windows.Forms.Button zatvoriBtn;
    }
}