
namespace ProgramskoIntenjerstvo
{
    partial class FrmStatistikaPopularnostiJela
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chrtPopularnostJela = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioBtnPredjela = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonGlavnaJela = new System.Windows.Forms.RadioButton();
            this.radioButtonDeserti = new System.Windows.Forms.RadioButton();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.jeloKolicinaViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrikazPoKategoriji = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPopularnostJela)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jeloKolicinaViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtPopularnostJela
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtPopularnostJela.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtPopularnostJela.Legends.Add(legend1);
            this.chrtPopularnostJela.Location = new System.Drawing.Point(12, 128);
            this.chrtPopularnostJela.Name = "chrtPopularnostJela";
            this.chrtPopularnostJela.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.Legend = "Legend1";
            series1.Name = "Broj narucenih jela";
            this.chrtPopularnostJela.Series.Add(series1);
            this.chrtPopularnostJela.Size = new System.Drawing.Size(775, 376);
            this.chrtPopularnostJela.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "Naslov";
            title1.Text = "Popularnost jela";
            this.chrtPopularnostJela.Titles.Add(title1);
            // 
            // radioBtnPredjela
            // 
            this.radioBtnPredjela.AutoSize = true;
            this.radioBtnPredjela.Location = new System.Drawing.Point(19, 43);
            this.radioBtnPredjela.Name = "radioBtnPredjela";
            this.radioBtnPredjela.Size = new System.Drawing.Size(202, 21);
            this.radioBtnPredjela.TabIndex = 1;
            this.radioBtnPredjela.TabStop = true;
            this.radioBtnPredjela.Text = "Prikaz popularnost predjela";
            this.radioBtnPredjela.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDeserti);
            this.groupBox1.Controls.Add(this.radioButtonGlavnaJela);
            this.groupBox1.Controls.Add(this.radioBtnPredjela);
            this.groupBox1.Location = new System.Drawing.Point(793, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategorija jela";
            // 
            // radioButtonGlavnaJela
            // 
            this.radioButtonGlavnaJela.AutoSize = true;
            this.radioButtonGlavnaJela.Location = new System.Drawing.Point(19, 94);
            this.radioButtonGlavnaJela.Name = "radioButtonGlavnaJela";
            this.radioButtonGlavnaJela.Size = new System.Drawing.Size(222, 21);
            this.radioButtonGlavnaJela.TabIndex = 2;
            this.radioButtonGlavnaJela.TabStop = true;
            this.radioButtonGlavnaJela.Text = "Prikaz popularnost glavnih jela";
            this.radioButtonGlavnaJela.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeserti
            // 
            this.radioButtonDeserti.AutoSize = true;
            this.radioButtonDeserti.Location = new System.Drawing.Point(19, 148);
            this.radioButtonDeserti.Name = "radioButtonDeserti";
            this.radioButtonDeserti.Size = new System.Drawing.Size(200, 21);
            this.radioButtonDeserti.TabIndex = 3;
            this.radioButtonDeserti.TabStop = true;
            this.radioButtonDeserti.Text = "Prikaz popularnost deserta";
            this.radioButtonDeserti.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Location = new System.Drawing.Point(799, 478);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(238, 26);
            this.btnPrikaziSve.TabIndex = 5;
            this.btnPrikaziSve.Text = "Prikaži popularnost svih jela";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            this.btnPrikaziSve.Click += new System.EventHandler(this.btnPrikaziSve_Click);
            // 
            // jeloKolicinaViewBindingSource
            // 
            this.jeloKolicinaViewBindingSource.DataSource = typeof(ProgramskoIntenjerstvo.JeloKolicinaView);
            // 
            // btnPrikazPoKategoriji
            // 
            this.btnPrikazPoKategoriji.Location = new System.Drawing.Point(793, 326);
            this.btnPrikazPoKategoriji.Name = "btnPrikazPoKategoriji";
            this.btnPrikazPoKategoriji.Size = new System.Drawing.Size(255, 26);
            this.btnPrikazPoKategoriji.TabIndex = 6;
            this.btnPrikazPoKategoriji.Text = "Prikaži";
            this.btnPrikazPoKategoriji.UseVisualStyleBackColor = true;
            this.btnPrikazPoKategoriji.Click += new System.EventHandler(this.btnPrikazPoKategoriji_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Statistika popularnosti jela";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmStatistikaPopularnostiJela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrikazPoKategoriji);
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chrtPopularnostJela);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStatistikaPopularnostiJela";
            this.Text = "Statistika popularnosti jela";
            this.Load += new System.EventHandler(this.FrmStatistikaPopularnostiJela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtPopularnostJela)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jeloKolicinaViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtPopularnostJela;
        private System.Windows.Forms.BindingSource jeloKolicinaViewBindingSource;
        private System.Windows.Forms.RadioButton radioBtnPredjela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDeserti;
        private System.Windows.Forms.RadioButton radioButtonGlavnaJela;
        private System.Windows.Forms.Button btnPrikaziSve;
        private System.Windows.Forms.Button btnPrikazPoKategoriji;
        private System.Windows.Forms.Label label1;
    }
}