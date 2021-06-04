
namespace ProgramskoIntenjerstvo
{
    partial class FrmLogin
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
            this.txtboxKorIme = new System.Windows.Forms.TextBox();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.btnRegistrirajSe = new System.Windows.Forms.Button();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxKorIme
            // 
            this.txtboxKorIme.Location = new System.Drawing.Point(180, 81);
            this.txtboxKorIme.Name = "txtboxKorIme";
            this.txtboxKorIme.Size = new System.Drawing.Size(134, 20);
            this.txtboxKorIme.TabIndex = 0;
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Location = new System.Drawing.Point(55, 207);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(139, 43);
            this.btnPrijaviSe.TabIndex = 2;
            this.btnPrijaviSe.Text = "Prijavi se!";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // btnRegistrirajSe
            // 
            this.btnRegistrirajSe.Location = new System.Drawing.Point(270, 207);
            this.btnRegistrirajSe.Name = "btnRegistrirajSe";
            this.btnRegistrirajSe.Size = new System.Drawing.Size(139, 43);
            this.btnRegistrirajSe.TabIndex = 3;
            this.btnRegistrirajSe.Text = "Registriraj se!";
            this.btnRegistrirajSe.UseVisualStyleBackColor = true;
            this.btnRegistrirajSe.Click += new System.EventHandler(this.btnRegistrirajSe_Click);
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.Location = new System.Drawing.Point(180, 152);
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.PasswordChar = '*';
            this.txtBoxLozinka.Size = new System.Drawing.Size(134, 20);
            this.txtBoxLozinka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lozinka:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 293);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxLozinka);
            this.Controls.Add(this.btnRegistrirajSe);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.txtboxKorIme);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxKorIme;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.Button btnRegistrirajSe;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}