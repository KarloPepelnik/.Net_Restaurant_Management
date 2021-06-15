
namespace ProgramskoIntenjerstvo
{
    partial class IzradaTakeOut
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.racunTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.adresaTxt = new System.Windows.Forms.TextBox();
            this.telefonTxt = new System.Windows.Forms.TextBox();
            this.cijenaTxt = new System.Windows.Forms.TextBox();
            this.korisnikTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dodajBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(265, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // racunTxt
            // 
            this.racunTxt.Enabled = false;
            this.racunTxt.Location = new System.Drawing.Point(62, 112);
            this.racunTxt.Name = "racunTxt";
            this.racunTxt.Size = new System.Drawing.Size(100, 20);
            this.racunTxt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adresaTxt
            // 
            this.adresaTxt.Location = new System.Drawing.Point(33, 151);
            this.adresaTxt.Name = "adresaTxt";
            this.adresaTxt.Size = new System.Drawing.Size(162, 20);
            this.adresaTxt.TabIndex = 3;
            // 
            // telefonTxt
            // 
            this.telefonTxt.Location = new System.Drawing.Point(33, 190);
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(162, 20);
            this.telefonTxt.TabIndex = 4;
            // 
            // cijenaTxt
            // 
            this.cijenaTxt.Enabled = false;
            this.cijenaTxt.Location = new System.Drawing.Point(78, 229);
            this.cijenaTxt.Name = "cijenaTxt";
            this.cijenaTxt.Size = new System.Drawing.Size(75, 20);
            this.cijenaTxt.TabIndex = 5;
            // 
            // korisnikTxt
            // 
            this.korisnikTxt.Enabled = false;
            this.korisnikTxt.Location = new System.Drawing.Point(62, 73);
            this.korisnikTxt.Name = "korisnikTxt";
            this.korisnikTxt.Size = new System.Drawing.Size(100, 20);
            this.korisnikTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Šifra korisnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Šifra računa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adresa dostave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Broj telefona";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cijena dostave";
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(78, 348);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 12;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // IzradaTakeOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 404);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.korisnikTxt);
            this.Controls.Add(this.cijenaTxt);
            this.Controls.Add(this.telefonTxt);
            this.Controls.Add(this.adresaTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.racunTxt);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "IzradaTakeOut";
            this.Text = "Narudžba za van";
            this.Load += new System.EventHandler(this.IzradaTakeOut_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IzradaTakeOut_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox racunTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox adresaTxt;
        private System.Windows.Forms.TextBox telefonTxt;
        private System.Windows.Forms.TextBox cijenaTxt;
        private System.Windows.Forms.TextBox korisnikTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button dodajBtn;
    }
}