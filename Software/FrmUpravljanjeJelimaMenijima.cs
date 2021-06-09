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
    public partial class FrmUpravljanjeJelimaMenijima : Form
    {
        public FrmUpravljanjeJelimaMenijima()
        {
            InitializeComponent();
        }

        private void btnKategorije_Click(object sender, EventArgs e)
        {
            FrmKategorijeJela form = new FrmKategorijeJela();
            form.ShowDialog();


        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajJelo_Click(object sender, EventArgs e)
        {
            FrmDodajJelo frmDodajJelo = new FrmDodajJelo();
            frmDodajJelo.ShowDialog();
        }
    }
}
