
namespace ProgramskoIntenjerstvo
{
    partial class FrmUrediKolicinuSastojkaJela
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
            this.txtBoxOdabranaNamirnica = new System.Windows.Forms.TextBox();
            this.txtBoxTrenutnaKolicina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNovaKolicina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odabrani sastojak";
            // 
            // txtBoxOdabranaNamirnica
            // 
            this.txtBoxOdabranaNamirnica.Location = new System.Drawing.Point(120, 29);
            this.txtBoxOdabranaNamirnica.Name = "txtBoxOdabranaNamirnica";
            this.txtBoxOdabranaNamirnica.ReadOnly = true;
            this.txtBoxOdabranaNamirnica.Size = new System.Drawing.Size(157, 22);
            this.txtBoxOdabranaNamirnica.TabIndex = 1;
            // 
            // txtBoxTrenutnaKolicina
            // 
            this.txtBoxTrenutnaKolicina.Location = new System.Drawing.Point(128, 22);
            this.txtBoxTrenutnaKolicina.Name = "txtBoxTrenutnaKolicina";
            this.txtBoxTrenutnaKolicina.ReadOnly = true;
            this.txtBoxTrenutnaKolicina.Size = new System.Drawing.Size(100, 22);
            this.txtBoxTrenutnaKolicina.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trenutna količina:";
            // 
            // txtBoxNovaKolicina
            // 
            this.txtBoxNovaKolicina.Location = new System.Drawing.Point(128, 67);
            this.txtBoxNovaKolicina.Name = "txtBoxNovaKolicina";
            this.txtBoxNovaKolicina.Size = new System.Drawing.Size(100, 22);
            this.txtBoxNovaKolicina.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nova količina:";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(106, 209);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(82, 27);
            this.btnIzlaz.TabIndex = 6;
            this.btnIzlaz.Text = "Odustani";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(195, 209);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(82, 27);
            this.btnSpremi.TabIndex = 7;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxNovaKolicina);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxTrenutnaKolicina);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(43, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 102);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // FrmUrediKolicinuSastojkaJela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 248);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.txtBoxOdabranaNamirnica);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmUrediKolicinuSastojkaJela";
            this.Text = "Uredi količinu";
            this.Load += new System.EventHandler(this.FrmUrediKolicinuSastojkaJela_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxOdabranaNamirnica;
        private System.Windows.Forms.TextBox txtBoxTrenutnaKolicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNovaKolicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}