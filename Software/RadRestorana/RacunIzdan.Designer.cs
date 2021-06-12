
namespace ProgramskoIntenjerstvo
{
    partial class RacunIzdan
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
            this.zatvoriBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zatvoriBtn
            // 
            this.zatvoriBtn.Location = new System.Drawing.Point(48, 90);
            this.zatvoriBtn.Name = "zatvoriBtn";
            this.zatvoriBtn.Size = new System.Drawing.Size(75, 23);
            this.zatvoriBtn.TabIndex = 5;
            this.zatvoriBtn.Text = "Ok";
            this.zatvoriBtn.UseVisualStyleBackColor = true;
            this.zatvoriBtn.Click += new System.EventHandler(this.zatvoriBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Racun je izdan!";
            // 
            // RacunIzdan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 145);
            this.Controls.Add(this.zatvoriBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RacunIzdan";
            this.Text = "Racun";
            this.Load += new System.EventHandler(this.RacunIzdan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zatvoriBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}