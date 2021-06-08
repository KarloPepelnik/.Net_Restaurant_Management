
namespace ProgramskoIntenjerstvo
{
    partial class FrmEditStol
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
            this.txtBrojStola = new System.Windows.Forms.TextBox();
            this.txtPozicijaStola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojMjesta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPohrani = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj stola:";
            // 
            // txtBrojStola
            // 
            this.txtBrojStola.Location = new System.Drawing.Point(71, 39);
            this.txtBrojStola.Name = "txtBrojStola";
            this.txtBrojStola.Size = new System.Drawing.Size(34, 20);
            this.txtBrojStola.TabIndex = 1;
            // 
            // txtPozicijaStola
            // 
            this.txtPozicijaStola.Location = new System.Drawing.Point(89, 92);
            this.txtPozicijaStola.Name = "txtPozicijaStola";
            this.txtPozicijaStola.Size = new System.Drawing.Size(154, 20);
            this.txtPozicijaStola.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pozicija stola:";
            // 
            // txtBrojMjesta
            // 
            this.txtBrojMjesta.Location = new System.Drawing.Point(79, 142);
            this.txtBrojMjesta.Name = "txtBrojMjesta";
            this.txtBrojMjesta.Size = new System.Drawing.Size(35, 20);
            this.txtBrojMjesta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj mjesta:";
            // 
            // btnPohrani
            // 
            this.btnPohrani.Location = new System.Drawing.Point(31, 181);
            this.btnPohrani.Name = "btnPohrani";
            this.btnPohrani.Size = new System.Drawing.Size(101, 33);
            this.btnPohrani.TabIndex = 6;
            this.btnPohrani.Text = "Spremi";
            this.btnPohrani.UseVisualStyleBackColor = true;
            this.btnPohrani.Click += new System.EventHandler(this.btnPohrani_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(138, 181);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(101, 33);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmEditStol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 226);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPohrani);
            this.Controls.Add(this.txtBrojMjesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPozicijaStola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrojStola);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditStol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditStol";
            this.Load += new System.EventHandler(this.FrmEditStol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrojStola;
        private System.Windows.Forms.TextBox txtPozicijaStola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojMjesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPohrani;
        private System.Windows.Forms.Button btnOdustani;
    }
}