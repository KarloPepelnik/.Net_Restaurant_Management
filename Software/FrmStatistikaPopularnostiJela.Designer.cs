
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrtPopularnostJela = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPopularnostJela)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtPopularnostJela
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtPopularnostJela.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtPopularnostJela.Legends.Add(legend1);
            this.chrtPopularnostJela.Location = new System.Drawing.Point(113, 159);
            this.chrtPopularnostJela.Name = "chrtPopularnostJela";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtPopularnostJela.Series.Add(series1);
            this.chrtPopularnostJela.Size = new System.Drawing.Size(633, 281);
            this.chrtPopularnostJela.TabIndex = 0;
            this.chrtPopularnostJela.Text = "dsdasa";
            // 
            // FrmStatistikaPopularnostiJela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 577);
            this.Controls.Add(this.chrtPopularnostJela);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmStatistikaPopularnostiJela";
            this.Text = "Statistika popularnosti jela";
            this.Load += new System.EventHandler(this.FrmStatistikaPopularnostiJela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtPopularnostJela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtPopularnostJela;
    }
}