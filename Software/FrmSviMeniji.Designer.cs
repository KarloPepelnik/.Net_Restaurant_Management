
namespace ProgramskoIntenjerstvo
{
    partial class FrmSviMeniji
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
            this.dgvMeniji = new System.Windows.Forms.DataGridView();
            this.txtBoxGlavnoJelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxiDesert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPredjelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnKreirajPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeniji)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMeniji
            // 
            this.dgvMeniji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeniji.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMeniji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeniji.Location = new System.Drawing.Point(58, 100);
            this.dgvMeniji.Name = "dgvMeniji";
            this.dgvMeniji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeniji.Size = new System.Drawing.Size(794, 270);
            this.dgvMeniji.TabIndex = 0;
            this.dgvMeniji.SelectionChanged += new System.EventHandler(this.dgvMeniji_SelectionChanged);
            // 
            // txtBoxGlavnoJelo
            // 
            this.txtBoxGlavnoJelo.Location = new System.Drawing.Point(102, 60);
            this.txtBoxGlavnoJelo.Name = "txtBoxGlavnoJelo";
            this.txtBoxGlavnoJelo.ReadOnly = true;
            this.txtBoxGlavnoJelo.Size = new System.Drawing.Size(332, 22);
            this.txtBoxGlavnoJelo.TabIndex = 11;
            this.txtBoxGlavnoJelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Glavno jelo:";
            // 
            // txtBoxiDesert
            // 
            this.txtBoxiDesert.Location = new System.Drawing.Point(102, 91);
            this.txtBoxiDesert.Name = "txtBoxiDesert";
            this.txtBoxiDesert.ReadOnly = true;
            this.txtBoxiDesert.Size = new System.Drawing.Size(332, 22);
            this.txtBoxiDesert.TabIndex = 9;
            this.txtBoxiDesert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Desert:";
            // 
            // txtBoxPredjelo
            // 
            this.txtBoxPredjelo.Location = new System.Drawing.Point(102, 29);
            this.txtBoxPredjelo.Name = "txtBoxPredjelo";
            this.txtBoxPredjelo.ReadOnly = true;
            this.txtBoxPredjelo.Size = new System.Drawing.Size(332, 22);
            this.txtBoxPredjelo.TabIndex = 7;
            this.txtBoxPredjelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Predjelo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxGlavnoJelo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxiDesert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxPredjelo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(58, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 136);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jela odabranog menija";
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(558, 376);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(294, 31);
            this.btnIzbrisi.TabIndex = 13;
            this.btnIzbrisi.Text = "Izbriši meni";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnKreirajPDF
            // 
            this.btnKreirajPDF.Location = new System.Drawing.Point(558, 472);
            this.btnKreirajPDF.Name = "btnKreirajPDF";
            this.btnKreirajPDF.Size = new System.Drawing.Size(294, 40);
            this.btnKreirajPDF.TabIndex = 14;
            this.btnKreirajPDF.Text = "Kreiraj meni u PDF obliku";
            this.btnKreirajPDF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(326, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pregled svih menija";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmSviMeniji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKreirajPDF);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMeniji);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSviMeniji";
            this.Text = "Pregled svih menija";
            this.Load += new System.EventHandler(this.FrmSviMeniji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeniji)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMeniji;
        private System.Windows.Forms.TextBox txtBoxGlavnoJelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxiDesert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPredjelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnKreirajPDF;
        private System.Windows.Forms.Label label1;
    }
}