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
    public partial class FrmUpravljanjeZalihamaMain : Form
    {
        public FrmUpravljanjeZalihamaMain()
        {
            InitializeComponent();
        }

        private void FrmUpravljanjeZalihamaMain_Load(object sender, EventArgs e)
        {
            OsvjeziTrenutnoDatumVrijeme();
        }

        private void OsvjeziTrenutnoDatumVrijeme()
        {
            txtBoxDatumVrijemeTrenutno.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
            txtBoxDatumVrijemeTrenutno.Enabled = false;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTrenutnoStanje_Click(object sender, EventArgs e)
        {
            FrmTrenutnoStanje form = new FrmTrenutnoStanje();
            form.ShowDialog();
        }

        private void btnDodajPrimku_Click(object sender, EventArgs e)
        {
            FrmPrimka frm = new FrmPrimka();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPrimka frmPrimka = new FrmPrimka();
            frmPrimka.ShowDialog();
        }

        private void btnNovaIzdatnica_Click(object sender, EventArgs e)
        {
            FrmIzdatnica frmIzdatnica = new FrmIzdatnica();
            frmIzdatnica.ShowDialog();
        }
    }
}
