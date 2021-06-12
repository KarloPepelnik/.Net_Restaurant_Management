using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
