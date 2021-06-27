
namespace ProgramskoIntenjerstvo
{
    partial class FrmUpravljanjeJelimaMenijima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpravljanjeJelimaMenijima));
            this.label1 = new System.Windows.Forms.Label();
            this.tabCtrlJelaMeniji = new System.Windows.Forms.TabControl();
            this.tabPageJela = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPregledJela = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKategorije = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDodajJelo = new System.Windows.Forms.Button();
            this.tabPageMeniji = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKreirajMeni = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAllMenus = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabCtrlJelaMeniji.SuspendLayout();
            this.tabPageJela.SuspendLayout();
            this.tabPageMeniji.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jela i meniji";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabCtrlJelaMeniji
            // 
            this.tabCtrlJelaMeniji.Controls.Add(this.tabPageJela);
            this.tabCtrlJelaMeniji.Controls.Add(this.tabPageMeniji);
            this.tabCtrlJelaMeniji.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabCtrlJelaMeniji.Location = new System.Drawing.Point(31, 79);
            this.tabCtrlJelaMeniji.Name = "tabCtrlJelaMeniji";
            this.tabCtrlJelaMeniji.SelectedIndex = 0;
            this.tabCtrlJelaMeniji.Size = new System.Drawing.Size(644, 335);
            this.tabCtrlJelaMeniji.TabIndex = 3;
            // 
            // tabPageJela
            // 
            this.tabPageJela.Controls.Add(this.label6);
            this.tabPageJela.Controls.Add(this.label4);
            this.tabPageJela.Controls.Add(this.label3);
            this.tabPageJela.Controls.Add(this.btnPregledJela);
            this.tabPageJela.Controls.Add(this.label2);
            this.tabPageJela.Controls.Add(this.btnKategorije);
            this.tabPageJela.Controls.Add(this.label5);
            this.tabPageJela.Controls.Add(this.btnDodajJelo);
            this.tabPageJela.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPageJela.Location = new System.Drawing.Point(4, 25);
            this.tabPageJela.Name = "tabPageJela";
            this.tabPageJela.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJela.Size = new System.Drawing.Size(636, 306);
            this.tabPageJela.TabIndex = 0;
            this.tabPageJela.Text = "Upravljanje jelima";
            this.tabPageJela.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(459, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kategorije namirnica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(18, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dodaj sastojke jela";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(252, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pregled svih jela";
            // 
            // btnPregledJela
            // 
            this.btnPregledJela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPregledJela.BackgroundImage")));
            this.btnPregledJela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPregledJela.Location = new System.Drawing.Point(241, 82);
            this.btnPregledJela.Name = "btnPregledJela";
            this.btnPregledJela.Size = new System.Drawing.Size(155, 115);
            this.btnPregledJela.TabIndex = 15;
            this.btnPregledJela.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPregledJela.UseVisualStyleBackColor = true;
            this.btnPregledJela.Click += new System.EventHandler(this.btnPregledJela_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(477, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kategorije jela";
            // 
            // btnKategorije
            // 
            this.btnKategorije.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKategorije.BackgroundImage")));
            this.btnKategorije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKategorije.Location = new System.Drawing.Point(463, 82);
            this.btnKategorije.Name = "btnKategorije";
            this.btnKategorije.Size = new System.Drawing.Size(144, 115);
            this.btnKategorije.TabIndex = 13;
            this.btnKategorije.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKategorije.UseVisualStyleBackColor = true;
            this.btnKategorije.Click += new System.EventHandler(this.btnKategorije_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(29, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dodaj novo jelo";
            // 
            // btnDodajJelo
            // 
            this.btnDodajJelo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajJelo.BackgroundImage")));
            this.btnDodajJelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodajJelo.Location = new System.Drawing.Point(22, 82);
            this.btnDodajJelo.Name = "btnDodajJelo";
            this.btnDodajJelo.Size = new System.Drawing.Size(144, 115);
            this.btnDodajJelo.TabIndex = 11;
            this.btnDodajJelo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDodajJelo.UseVisualStyleBackColor = true;
            this.btnDodajJelo.Click += new System.EventHandler(this.btnDodajJelo_Click);
            // 
            // tabPageMeniji
            // 
            this.tabPageMeniji.Controls.Add(this.label9);
            this.tabPageMeniji.Controls.Add(this.label8);
            this.tabPageMeniji.Controls.Add(this.btnAllMenus);
            this.tabPageMeniji.Controls.Add(this.label7);
            this.tabPageMeniji.Controls.Add(this.btnKreirajMeni);
            this.tabPageMeniji.Location = new System.Drawing.Point(4, 25);
            this.tabPageMeniji.Name = "tabPageMeniji";
            this.tabPageMeniji.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMeniji.Size = new System.Drawing.Size(636, 306);
            this.tabPageMeniji.TabIndex = 1;
            this.tabPageMeniji.Text = "Upravljanje menijima";
            this.tabPageMeniji.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(126, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kreiraj novi meni";
            // 
            // btnKreirajMeni
            // 
            this.btnKreirajMeni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKreirajMeni.BackgroundImage")));
            this.btnKreirajMeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKreirajMeni.Location = new System.Drawing.Point(130, 76);
            this.btnKreirajMeni.Name = "btnKreirajMeni";
            this.btnKreirajMeni.Size = new System.Drawing.Size(133, 115);
            this.btnKreirajMeni.TabIndex = 11;
            this.btnKreirajMeni.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKreirajMeni.UseVisualStyleBackColor = true;
            this.btnKreirajMeni.Click += new System.EventHandler(this.btnKreirajMeni_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(525, 452);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(150, 28);
            this.btnPovratak.TabIndex = 4;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(350, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pregled svih menija";
            // 
            // btnAllMenus
            // 
            this.btnAllMenus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAllMenus.BackgroundImage")));
            this.btnAllMenus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllMenus.Location = new System.Drawing.Point(354, 76);
            this.btnAllMenus.Name = "btnAllMenus";
            this.btnAllMenus.Size = new System.Drawing.Size(133, 115);
            this.btnAllMenus.TabIndex = 13;
            this.btnAllMenus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAllMenus.UseVisualStyleBackColor = true;
            this.btnAllMenus.Click += new System.EventHandler(this.btnAllMenus_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(350, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Izvoz menija u PDF";
            // 
            // FrmUpravljanjeJelimaMenijima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 492);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.tabCtrlJelaMeniji);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmUpravljanjeJelimaMenijima";
            this.Text = "Upravljanje jelima i menijima";
            this.tabCtrlJelaMeniji.ResumeLayout(false);
            this.tabPageJela.ResumeLayout(false);
            this.tabPageJela.PerformLayout();
            this.tabPageMeniji.ResumeLayout(false);
            this.tabPageMeniji.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabCtrlJelaMeniji;
        private System.Windows.Forms.TabPage tabPageJela;
        private System.Windows.Forms.TabPage tabPageMeniji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKategorije;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDodajJelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPregledJela;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKreirajMeni;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAllMenus;
    }
}