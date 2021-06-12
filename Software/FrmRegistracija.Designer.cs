
namespace ProgramskoIntenjerstvo
{
    partial class FrmRegistracija
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.txtBoxKorime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.btnRegistriraj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelponovo = new System.Windows.Forms.Label();
            this.txtLozinkaPonovo = new System.Windows.Forms.TextBox();
            this.labelPodudaraju = new System.Windows.Forms.Label();
            this.labelImeZauzeto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ime:";
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Location = new System.Drawing.Point(145, 113);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(134, 20);
            this.txtBoxPrezime.TabIndex = 2;
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Location = new System.Drawing.Point(145, 42);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(134, 20);
            this.txtBoxIme.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lozinka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Korisničko ime:";
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.Location = new System.Drawing.Point(145, 244);
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.Size = new System.Drawing.Size(134, 20);
            this.txtBoxLozinka.TabIndex = 4;
            this.txtBoxLozinka.UseSystemPasswordChar = true;
            this.txtBoxLozinka.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxLozinka_KeyUp);
            // 
            // txtBoxKorime
            // 
            this.txtBoxKorime.Location = new System.Drawing.Point(145, 176);
            this.txtBoxKorime.Name = "txtBoxKorime";
            this.txtBoxKorime.Size = new System.Drawing.Size(134, 20);
            this.txtBoxKorime.TabIndex = 3;
            this.txtBoxKorime.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxKorime_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(145, 383);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(134, 20);
            this.txtBoxEmail.TabIndex = 6;
            this.txtBoxEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxEmail_KeyUp);
            // 
            // btnRegistriraj
            // 
            this.btnRegistriraj.Location = new System.Drawing.Point(41, 442);
            this.btnRegistriraj.Name = "btnRegistriraj";
            this.btnRegistriraj.Size = new System.Drawing.Size(120, 43);
            this.btnRegistriraj.TabIndex = 7;
            this.btnRegistriraj.Text = "Registriraj!";
            this.btnRegistriraj.UseVisualStyleBackColor = true;
            this.btnRegistriraj.Click += new System.EventHandler(this.btnRegistriraj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(219, 442);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(120, 43);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani!";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.ForeColor = System.Drawing.Color.Red;
            this.labelLozinka.Location = new System.Drawing.Point(285, 226);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(217, 52);
            this.labelLozinka.TabIndex = 19;
            this.labelLozinka.Text = "Preslaba lozinka! \r\nLozinka mora sadržavati slova i brojeve!\r\nLozinka mora imati " +
    "najmanje 8 znakova.\r\nLozinka mora imati barem jedno veliko slovo.";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.Color.Red;
            this.labelEmail.Location = new System.Drawing.Point(285, 377);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(129, 26);
            this.labelEmail.TabIndex = 20;
            this.labelEmail.Text = "Neispravan format emaila!\r\nnpr. netko@nesto.hr";
            // 
            // labelponovo
            // 
            this.labelponovo.AutoSize = true;
            this.labelponovo.Location = new System.Drawing.Point(40, 313);
            this.labelponovo.Name = "labelponovo";
            this.labelponovo.Size = new System.Drawing.Size(86, 13);
            this.labelponovo.TabIndex = 22;
            this.labelponovo.Text = "Lozinka ponovo:";
            // 
            // txtLozinkaPonovo
            // 
            this.txtLozinkaPonovo.Location = new System.Drawing.Point(145, 310);
            this.txtLozinkaPonovo.Name = "txtLozinkaPonovo";
            this.txtLozinkaPonovo.Size = new System.Drawing.Size(134, 20);
            this.txtLozinkaPonovo.TabIndex = 5;
            this.txtLozinkaPonovo.UseSystemPasswordChar = true;
            this.txtLozinkaPonovo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLozinkaPonovo_KeyUp);
            // 
            // labelPodudaraju
            // 
            this.labelPodudaraju.AutoSize = true;
            this.labelPodudaraju.ForeColor = System.Drawing.Color.Red;
            this.labelPodudaraju.Location = new System.Drawing.Point(285, 310);
            this.labelPodudaraju.Name = "labelPodudaraju";
            this.labelPodudaraju.Size = new System.Drawing.Size(132, 13);
            this.labelPodudaraju.TabIndex = 23;
            this.labelPodudaraju.Text = "Lozinke se ne podudaraju!";
            // 
            // labelImeZauzeto
            // 
            this.labelImeZauzeto.AutoSize = true;
            this.labelImeZauzeto.ForeColor = System.Drawing.Color.Red;
            this.labelImeZauzeto.Location = new System.Drawing.Point(285, 179);
            this.labelImeZauzeto.Name = "labelImeZauzeto";
            this.labelImeZauzeto.Size = new System.Drawing.Size(118, 13);
            this.labelImeZauzeto.TabIndex = 24;
            this.labelImeZauzeto.Text = "Korisničko ime zauzeto!";
            // 
            // FrmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 540);
            this.Controls.Add(this.labelImeZauzeto);
            this.Controls.Add(this.labelPodudaraju);
            this.Controls.Add(this.labelponovo);
            this.Controls.Add(this.txtLozinkaPonovo);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnRegistriraj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxLozinka);
            this.Controls.Add(this.txtBoxKorime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPrezime);
            this.Controls.Add(this.txtBoxIme);
            this.Name = "FrmRegistracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistracija";
            this.Load += new System.EventHandler(this.FrmRegistracija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.TextBox txtBoxKorime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Button btnRegistriraj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelponovo;
        private System.Windows.Forms.TextBox txtLozinkaPonovo;
        private System.Windows.Forms.Label labelPodudaraju;
        private System.Windows.Forms.Label labelImeZauzeto;
    }
}