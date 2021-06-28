
namespace ProgramskoIntenjerstvo
{
    partial class FrmMenuReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MeniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Na_menijuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MeniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Na_menijuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Black;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsMeni";
            reportDataSource1.Value = this.MeniBindingSource;
            reportDataSource2.Name = "DsJelo";
            reportDataSource2.Value = this.JeloBindingSource;
            reportDataSource3.Name = "DsNaMeniju";
            reportDataSource3.Value = this.Na_menijuBindingSource;
            reportDataSource4.Name = "DataSetMeni";
            reportDataSource4.Value = this.JeloBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProgramskoIntenjerstvo.ReportKreiranjeMenija.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(634, 861);
            this.reportViewer1.TabIndex = 0;
            // 
            // MeniBindingSource
            // 
            this.MeniBindingSource.DataSource = typeof(ProgramskoIntenjerstvo.Meni);
            // 
            // JeloBindingSource
            // 
            this.JeloBindingSource.DataSource = typeof(ProgramskoIntenjerstvo.Jelo);
            // 
            // Na_menijuBindingSource
            // 
            this.Na_menijuBindingSource.DataSource = typeof(ProgramskoIntenjerstvo.Na_meniju);
            // 
            // FrmMenuReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 861);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenuReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvještaj meni";
            this.Load += new System.EventHandler(this.FrmMenuReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MeniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Na_menijuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MeniBindingSource;
        private System.Windows.Forms.BindingSource JeloBindingSource;
        private System.Windows.Forms.BindingSource Na_menijuBindingSource;
    }
}