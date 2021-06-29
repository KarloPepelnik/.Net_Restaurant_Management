
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jeloKolicinaViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazivJelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPopularnostJela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jeloKolicinaViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtPopularnostJela
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtPopularnostJela.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtPopularnostJela.Legends.Add(legend1);
            this.chrtPopularnostJela.Location = new System.Drawing.Point(37, 30);
            this.chrtPopularnostJela.Name = "chrtPopularnostJela";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Broj narucenih jela";
            this.chrtPopularnostJela.Series.Add(series1);
            this.chrtPopularnostJela.Size = new System.Drawing.Size(633, 281);
            this.chrtPopularnostJela.TabIndex = 0;
            this.chrtPopularnostJela.Text = "dsdasa";
            title1.Name = "Title1";
            title1.Text = "Popularnost jela";
            this.chrtPopularnostJela.Titles.Add(title1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivJelaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jeloKolicinaViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 185);
            this.dataGridView1.TabIndex = 1;
            // 
            // jeloKolicinaViewBindingSource
            // 
            this.jeloKolicinaViewBindingSource.DataSource = typeof(ProgramskoIntenjerstvo.JeloKolicinaView);
            // 
            // nazivJelaDataGridViewTextBoxColumn
            // 
            this.nazivJelaDataGridViewTextBoxColumn.DataPropertyName = "NazivJela";
            this.nazivJelaDataGridViewTextBoxColumn.HeaderText = "NazivJela";
            this.nazivJelaDataGridViewTextBoxColumn.Name = "nazivJelaDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // FrmStatistikaPopularnostiJela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 577);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chrtPopularnostJela);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStatistikaPopularnostiJela";
            this.Text = "Statistika popularnosti jela";
            this.Load += new System.EventHandler(this.FrmStatistikaPopularnostiJela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtPopularnostJela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jeloKolicinaViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtPopularnostJela;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivJelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jeloKolicinaViewBindingSource;
    }
}