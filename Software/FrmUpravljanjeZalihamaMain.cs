using System;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class FrmUpravljanjeZalihamaMain : Form
    {
        private Korisnik CurrentUser { get; set; }
        public FrmUpravljanjeZalihamaMain(Korisnik korisnik)
        {
            InitializeComponent();
            CurrentUser = korisnik;
        }

        private void FrmUpravljanjeZalihamaMain_Load(object sender, EventArgs e)
        {
            OsvjeziTrenutnoDatumVrijeme();
            HideAdminFeatures();
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

        private void HideAdminFeatures()
        {
            if (CurrentUser.Tip_korisnika.id_tip != 1)
            {
                lblAdminOptions.Visible = false;
                btnAdminOptions.Visible = false;
            }
        }

        private void btnAdminOptions_Click(object sender, EventArgs e)
        {
            FrmUpravljanjeZalihamaAdminFeatures frmUpravljanjeZalihamaAdminFeatures = new FrmUpravljanjeZalihamaAdminFeatures();
            frmUpravljanjeZalihamaAdminFeatures.ShowDialog();
        }
    }
}
