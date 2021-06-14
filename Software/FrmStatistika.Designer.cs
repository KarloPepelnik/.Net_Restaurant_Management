
namespace ProgramskoIntenjerstvo
{
    partial class FrmStatistika
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
            this.btnStatistikaPosjecenosti = new System.Windows.Forms.Button();
            this.btnStatistikaJela = new System.Windows.Forms.Button();
            this.btnPrihodi = new System.Windows.Forms.Button();
            this.btnIzadi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStatistikaPosjecenosti
            // 
            this.btnStatistikaPosjecenosti.Location = new System.Drawing.Point(25, 126);
            this.btnStatistikaPosjecenosti.Name = "btnStatistikaPosjecenosti";
            this.btnStatistikaPosjecenosti.Size = new System.Drawing.Size(159, 93);
            this.btnStatistikaPosjecenosti.TabIndex = 0;
            this.btnStatistikaPosjecenosti.Text = "Statistika posjećenosti";
            this.btnStatistikaPosjecenosti.UseVisualStyleBackColor = true;
            this.btnStatistikaPosjecenosti.Click += new System.EventHandler(this.btnStatistikaPosjecenosti_Click);
            // 
            // btnStatistikaJela
            // 
            this.btnStatistikaJela.Location = new System.Drawing.Point(240, 126);
            this.btnStatistikaJela.Name = "btnStatistikaJela";
            this.btnStatistikaJela.Size = new System.Drawing.Size(159, 93);
            this.btnStatistikaJela.TabIndex = 1;
            this.btnStatistikaJela.Text = "Statistika o jelima";
            this.btnStatistikaJela.UseVisualStyleBackColor = true;
            // 
            // btnPrihodi
            // 
            this.btnPrihodi.Location = new System.Drawing.Point(458, 126);
            this.btnPrihodi.Name = "btnPrihodi";
            this.btnPrihodi.Size = new System.Drawing.Size(159, 93);
            this.btnPrihodi.TabIndex = 2;
            this.btnPrihodi.Text = "Statistika o prihodima";
            this.btnPrihodi.UseVisualStyleBackColor = true;
            this.btnPrihodi.Click += new System.EventHandler(this.btnPrihodi_Click);
            // 
            // btnIzadi
            // 
            this.btnIzadi.Location = new System.Drawing.Point(240, 269);
            this.btnIzadi.Name = "btnIzadi";
            this.btnIzadi.Size = new System.Drawing.Size(159, 93);
            this.btnIzadi.TabIndex = 3;
            this.btnIzadi.Text = "Izađi";
            this.btnIzadi.UseVisualStyleBackColor = true;
            this.btnIzadi.Click += new System.EventHandler(this.btnIzadi_Click);
            // 
            // FrmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 374);
            this.Controls.Add(this.btnIzadi);
            this.Controls.Add(this.btnPrihodi);
            this.Controls.Add(this.btnStatistikaJela);
            this.Controls.Add(this.btnStatistikaPosjecenosti);
            this.Name = "FrmStatistika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStatistika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStatistikaPosjecenosti;
        private System.Windows.Forms.Button btnStatistikaJela;
        private System.Windows.Forms.Button btnPrihodi;
        private System.Windows.Forms.Button btnIzadi;
    }
}