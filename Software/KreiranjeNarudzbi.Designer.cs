
namespace ProgramskoIntenjerstvo
{
    partial class KreiranjeNarudzbi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KreiranjeNarudzbi));
            this.jeloDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.racunBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputDumpTXT = new System.Windows.Forms.TextBox();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.odabranaJelaDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.jeloDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odabranaJelaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // jeloDataGrid
            // 
            this.jeloDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jeloDataGrid.Location = new System.Drawing.Point(12, 53);
            this.jeloDataGrid.Name = "jeloDataGrid";
            this.jeloDataGrid.RowTemplate.Height = 25;
            this.jeloDataGrid.Size = new System.Drawing.Size(349, 228);
            this.jeloDataGrid.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jelo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // racunBtn
            // 
            this.racunBtn.Location = new System.Drawing.Point(360, 338);
            this.racunBtn.Name = "racunBtn";
            this.racunBtn.Size = new System.Drawing.Size(75, 23);
            this.racunBtn.TabIndex = 22;
            this.racunBtn.Text = "Izdaj račun";
            this.racunBtn.UseVisualStyleBackColor = true;
            this.racunBtn.Click += new System.EventHandler(this.racunBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(379, 183);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(40, 23);
            this.removeBtn.TabIndex = 21;
            this.removeBtn.Text = "<-";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ukupni iznos";
            // 
            // outputDumpTXT
            // 
            this.outputDumpTXT.Location = new System.Drawing.Point(350, 312);
            this.outputDumpTXT.Name = "outputDumpTXT";
            this.outputDumpTXT.Size = new System.Drawing.Size(100, 20);
            this.outputDumpTXT.TabIndex = 18;
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(379, 154);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(40, 23);
            this.dodajBtn.TabIndex = 17;
            this.dodajBtn.Text = "->";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // odabranaJelaDataGrid
            // 
            this.odabranaJelaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odabranaJelaDataGrid.Location = new System.Drawing.Point(446, 53);
            this.odabranaJelaDataGrid.Name = "odabranaJelaDataGrid";
            this.odabranaJelaDataGrid.RowTemplate.Height = 25;
            this.odabranaJelaDataGrid.Size = new System.Drawing.Size(203, 228);
            this.odabranaJelaDataGrid.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Odabrana Jela";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(220, 315);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Narudžba za van?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // KreiranjeNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 391);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.racunBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputDumpTXT);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.odabranaJelaDataGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jeloDataGrid);
            this.Name = "KreiranjeNarudzbi";
            this.Text = "KreiranjeNarudzbi";
            this.Load += new System.EventHandler(this.KreiranjeNarudzbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jeloDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odabranaJelaDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView jeloDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button racunBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outputDumpTXT;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.DataGridView odabranaJelaDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}