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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPopularnostJela_Click(object sender, EventArgs e)
        {
            FrmStatistikaPopularnostiJela frmStatistikaPopularnostiJela = new FrmStatistikaPopularnostiJela();
            frmStatistikaPopularnostiJela.ShowDialog();
        }
    }
}
