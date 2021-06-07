
namespace ProgramskoIntenjerstvo
{
    partial class FrmEditKorisnika
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorisnicko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.cboxTipKorisnika = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(62, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(40, 20);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip korisnika:";
            // 
            // txtKorisnicko
            // 
            this.txtKorisnicko.Location = new System.Drawing.Point(96, 137);
            this.txtKorisnicko.Name = "txtKorisnicko";
            this.txtKorisnicko.Size = new System.Drawing.Size(157, 20);
            this.txtKorisnicko.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Korisničko ime:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(96, 188);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(157, 20);
            this.txtLozinka.TabIndex = 7;
            this.txtLozinka.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lozinka:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(96, 235);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(157, 20);
            this.txtIme.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(96, 290);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(157, 20);
            this.txtPrezime.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prezime:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(96, 337);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(107, 400);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(103, 27);
            this.btnSpremi.TabIndex = 14;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(216, 400);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(103, 27);
            this.btnOdustani.TabIndex = 15;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cboxTipKorisnika
            // 
            this.cboxTipKorisnika.FormattingEnabled = true;
            this.cboxTipKorisnika.Location = new System.Drawing.Point(88, 86);
            this.cboxTipKorisnika.Name = "cboxTipKorisnika";
            this.cboxTipKorisnika.Size = new System.Drawing.Size(121, 21);
            this.cboxTipKorisnika.TabIndex = 16;
            // 
            // FrmEditKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 441);
            this.Controls.Add(this.cboxTipKorisnika);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKorisnicko);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditKorisnika";
            this.Text = "FrmEditKorisnika";
            this.Load += new System.EventHandler(this.FrmEditKorisnika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorisnicko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ComboBox cboxTipKorisnika;
    }
}