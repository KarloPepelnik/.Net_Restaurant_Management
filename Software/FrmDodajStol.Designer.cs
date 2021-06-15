
namespace ProgramskoIntenjerstvo
{
    partial class FrmDodajStol
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPohrani = new System.Windows.Forms.Button();
            this.txtBrojMjesta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPozicijaStola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojStola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(138, 148);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(101, 33);
            this.btnOdustani.TabIndex = 15;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPohrani
            // 
            this.btnPohrani.Location = new System.Drawing.Point(31, 148);
            this.btnPohrani.Name = "btnPohrani";
            this.btnPohrani.Size = new System.Drawing.Size(101, 33);
            this.btnPohrani.TabIndex = 14;
            this.btnPohrani.Text = "Spremi";
            this.btnPohrani.UseVisualStyleBackColor = true;
            this.btnPohrani.Click += new System.EventHandler(this.btnPohrani_Click);
            // 
            // txtBrojMjesta
            // 
            this.txtBrojMjesta.Location = new System.Drawing.Point(79, 109);
            this.txtBrojMjesta.Name = "txtBrojMjesta";
            this.txtBrojMjesta.Size = new System.Drawing.Size(35, 20);
            this.txtBrojMjesta.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Broj mjesta:";
            // 
            // txtPozicijaStola
            // 
            this.txtPozicijaStola.Location = new System.Drawing.Point(89, 59);
            this.txtPozicijaStola.Name = "txtPozicijaStola";
            this.txtPozicijaStola.Size = new System.Drawing.Size(154, 20);
            this.txtPozicijaStola.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pozicija stola:";
            // 
            // txtBrojStola
            // 
            this.txtBrojStola.Location = new System.Drawing.Point(71, 16);
            this.txtBrojStola.Name = "txtBrojStola";
            this.txtBrojStola.Size = new System.Drawing.Size(34, 20);
            this.txtBrojStola.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Broj stola:";
            // 
            // FrmDodajStol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 213);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPohrani);
            this.Controls.Add(this.txtBrojMjesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPozicijaStola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrojStola);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmDodajStol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje stolova";
            this.Load += new System.EventHandler(this.FrmDodajStol_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDodajStol_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPohrani;
        private System.Windows.Forms.TextBox txtBrojMjesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPozicijaStola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojStola;
        private System.Windows.Forms.Label label1;
    }
}