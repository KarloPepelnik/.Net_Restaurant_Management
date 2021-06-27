using System;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class FrmStatistika : Form
    {
        public FrmStatistika()
        {
            InitializeComponent();
        }

        private void btnStatistikaPosjecenosti_Click(object sender, EventArgs e)
        {
            FrmStatistikaPosjecenosti forma = new FrmStatistikaPosjecenosti();
            Hide();
            forma.ShowDialog();
            Show();
        }

        private void btnIzadi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrihodi_Click(object sender, EventArgs e)
        {
            StatistikaPrihodi statistikaPrihodi = new StatistikaPrihodi();
            Hide();
            statistikaPrihodi.ShowDialog();
            Show();
        }
    }
}
