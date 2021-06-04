
namespace ProgramskoIntenjerstvo
{
    partial class Izbornik
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
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.btnNarudžbe = new System.Windows.Forms.Button();
            this.btnZalihe = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnMeni = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.Location = new System.Drawing.Point(155, 69);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(135, 38);
            this.btnKorisnici.TabIndex = 0;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.UseVisualStyleBackColor = true;
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.Location = new System.Drawing.Point(155, 143);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(135, 38);
            this.btnRezervacije.TabIndex = 1;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.UseVisualStyleBackColor = true;
            // 
            // btnNarudžbe
            // 
            this.btnNarudžbe.Location = new System.Drawing.Point(155, 291);
            this.btnNarudžbe.Name = "btnNarudžbe";
            this.btnNarudžbe.Size = new System.Drawing.Size(135, 38);
            this.btnNarudžbe.TabIndex = 3;
            this.btnNarudžbe.Text = "Naručivanje";
            this.btnNarudžbe.UseVisualStyleBackColor = true;
            this.btnNarudžbe.Click += new System.EventHandler(this.btnNarudžbe_Click);
            // 
            // btnZalihe
            // 
            this.btnZalihe.Location = new System.Drawing.Point(155, 217);
            this.btnZalihe.Name = "btnZalihe";
            this.btnZalihe.Size = new System.Drawing.Size(135, 38);
            this.btnZalihe.TabIndex = 2;
            this.btnZalihe.Text = "Zalihe";
            this.btnZalihe.UseVisualStyleBackColor = true;
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(155, 439);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(135, 38);
            this.btnStatistika.TabIndex = 5;
            this.btnStatistika.Text = "Izrada statistike";
            this.btnStatistika.UseVisualStyleBackColor = true;
            // 
            // btnMeni
            // 
            this.btnMeni.Location = new System.Drawing.Point(155, 365);
            this.btnMeni.Name = "btnMeni";
            this.btnMeni.Size = new System.Drawing.Size(135, 38);
            this.btnMeni.TabIndex = 4;
            this.btnMeni.Text = "Meni";
            this.btnMeni.UseVisualStyleBackColor = true;
            this.btnMeni.Click += new System.EventHandler(this.btnMeni_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(316, 12);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(135, 38);
            this.btnOdjava.TabIndex = 6;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // Izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 557);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnMeni);
            this.Controls.Add(this.btnNarudžbe);
            this.Controls.Add(this.btnZalihe);
            this.Controls.Add(this.btnRezervacije);
            this.Controls.Add(this.btnKorisnici);
            this.Name = "Izbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izbornik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Button btnNarudžbe;
        private System.Windows.Forms.Button btnZalihe;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnMeni;
        private System.Windows.Forms.Button btnOdjava;
    }
}