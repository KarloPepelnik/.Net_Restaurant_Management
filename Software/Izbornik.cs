using System;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class Izbornik : Form
    {
        public static Korisnik TrenutniKorisnik { get; set; }
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
            if (TrenutniKorisnik.tip_korisnik != 1)
            {
                btnKorisnici.Hide();
                //btnMeni.Hide();
                btnInventar.Hide();
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
            Hide();
            forma.ShowDialog();
            Show();
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

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            FrmStatistika forma = new FrmStatistika();
            Hide();
            forma.ShowDialog();
            Show();
        }

        private void narudzbeZaVanBtn_Click(object sender, EventArgs e)
        {            
            PregledNarudzbiZaVan pregledNarudzbiZaVan = new PregledNarudzbiZaVan();
            Hide();
            pregledNarudzbiZaVan.ShowDialog();
            Show();
        }

        private void Izbornik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, "RestoranApp.chm", HelpNavigator.Topic, "Izbornik/index.html");
            }
        }
    }
}
