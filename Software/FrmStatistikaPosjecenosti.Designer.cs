
namespace ProgramskoIntenjerstvo
{
    partial class FrmStatistikaPosjecenosti
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPosjecenost = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBrojGostiju = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioBtnMjesec = new System.Windows.Forms.RadioButton();
            this.radioBtnTjedan = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIzadi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartPosjecenost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBrojGostiju)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPosjecenost
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPosjecenost.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPosjecenost.Legends.Add(legend3);
            this.chartPosjecenost.Location = new System.Drawing.Point(12, 39);
            this.chartPosjecenost.Name = "chartPosjecenost";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Broj rezervacija";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartPosjecenost.Series.Add(series3);
            this.chartPosjecenost.Size = new System.Drawing.Size(516, 432);
            this.chartPosjecenost.TabIndex = 0;
            this.chartPosjecenost.Text = "Graf posjećenosti";
            title2.Name = "Posjećenost";
            title2.Text = "Posjećenost";
            this.chartPosjecenost.Titles.Add(title2);
            // 
            // chartBrojGostiju
            // 
            chartArea4.Name = "ChartArea1";
            this.chartBrojGostiju.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartBrojGostiju.Legends.Add(legend4);
            this.chartBrojGostiju.Location = new System.Drawing.Point(623, 60);
            this.chartBrojGostiju.Name = "chartBrojGostiju";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartBrojGostiju.Series.Add(series4);
            this.chartBrojGostiju.Size = new System.Drawing.Size(387, 330);
            this.chartBrojGostiju.TabIndex = 1;
            this.chartBrojGostiju.Text = "chart2";
            // 
            // radioBtnMjesec
            // 
            this.radioBtnMjesec.AutoSize = true;
            this.radioBtnMjesec.Location = new System.Drawing.Point(168, 477);
            this.radioBtnMjesec.Name = "radioBtnMjesec";
            this.radioBtnMjesec.Size = new System.Drawing.Size(80, 17);
            this.radioBtnMjesec.TabIndex = 2;
            this.radioBtnMjesec.TabStop = true;
            this.radioBtnMjesec.Text = "Po mjesecu";
            this.radioBtnMjesec.UseVisualStyleBackColor = true;
            this.radioBtnMjesec.CheckedChanged += new System.EventHandler(this.radioBtnMjesec_CheckedChanged);
            // 
            // radioBtnTjedan
            // 
            this.radioBtnTjedan.AutoSize = true;
            this.radioBtnTjedan.Location = new System.Drawing.Point(254, 477);
            this.radioBtnTjedan.Name = "radioBtnTjedan";
            this.radioBtnTjedan.Size = new System.Drawing.Size(70, 17);
            this.radioBtnTjedan.TabIndex = 3;
            this.radioBtnTjedan.TabStop = true;
            this.radioBtnTjedan.Text = "Po tjednu";
            this.radioBtnTjedan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Statistika posjećenosti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Statistika broja gostiju:";
            // 
            // btnIzadi
            // 
            this.btnIzadi.Location = new System.Drawing.Point(958, 567);
            this.btnIzadi.Name = "btnIzadi";
            this.btnIzadi.Size = new System.Drawing.Size(112, 37);
            this.btnIzadi.TabIndex = 6;
            this.btnIzadi.Text = "Izađi";
            this.btnIzadi.UseVisualStyleBackColor = true;
            this.btnIzadi.Click += new System.EventHandler(this.btnIzadi_Click);
            // 
            // FrmStatistikaPosjecenosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 616);
            this.Controls.Add(this.btnIzadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBtnTjedan);
            this.Controls.Add(this.radioBtnMjesec);
            this.Controls.Add(this.chartBrojGostiju);
            this.Controls.Add(this.chartPosjecenost);
            this.Name = "FrmStatistikaPosjecenosti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStatistikaPosjecenosti";
            this.Load += new System.EventHandler(this.FrmStatistikaPosjecenosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPosjecenost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBrojGostiju)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPosjecenost;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBrojGostiju;
        private System.Windows.Forms.RadioButton radioBtnMjesec;
        private System.Windows.Forms.RadioButton radioBtnTjedan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIzadi;
    }
}