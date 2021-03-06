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
    public partial class Izbornik : Form
    {
        private Korisnik TrenutniKorisnik { get; set; }
        public Izbornik(Korisnik korisnik)
        {
            InitializeComponent();
            TrenutniKorisnik = korisnik;
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNarudžbe_Click(object sender, EventArgs e)
        {
            KreiranjeNarudzbi forma = new KreiranjeNarudzbi();
            Hide();
            forma.ShowDialog();
            Show();
        }

        private void btnMeni_Click(object sender, EventArgs e)
        {
            UpravljanjeKasom forma = new UpravljanjeKasom();
            Hide();
            forma.ShowDialog();
            Show();
        }

        private void Izbornik_Load(object sender, EventArgs e)
        {
            txtBoxTrenutniKorsinik.Text = TrenutniKorisnik.korisnicko_ime;
            txtBoxTrenutniKorsinik.ReadOnly = true;

            if(TrenutniKorisnik.tip_korisnik == 3)
            {
                btnKorisnici.Visible = false;
                btnMeni.Visible = false;
                btnInventar.Visible = false;
                btnUpravljanjeJelimaMenijima.Visible = false;
            }
        }

        private void btnZalihe_Click(object sender, EventArgs e)
        {
            FrmUpravljanjeZalihamaMain form = new FrmUpravljanjeZalihamaMain(TrenutniKorisnik);
            form.ShowDialog();
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            FrmKorisnici forma = new FrmKorisnici();
            forma.ShowDialog();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            FrmRezervacije forma = new FrmRezervacije(TrenutniKorisnik);
            Hide();
            forma.ShowDialog();
            Show();
        }

        private void btnInventar_Click(object sender, EventArgs e)
        {
            FrmInventar forma = new FrmInventar();
            Hide();
            forma.ShowDialog();
            Show();
        }

        private void btnUpravljanjeJelimaMenijima_Click(object sender, EventArgs e)
        {
            FrmUpravljanjeJelimaMenijima form = new FrmUpravljanjeJelimaMenijima();
            form.ShowDialog();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            FrmStatistika frmStatistika = new FrmStatistika();
            frmStatistika.ShowDialog();
        }
    }
}
