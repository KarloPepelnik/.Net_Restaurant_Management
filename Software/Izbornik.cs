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
            if(TrenutniKorisnik.tip_korisnik > 2)
            {
                btnKorisnici.Hide();
                btnMeni.Hide();
            }
        }

        private void btnZalihe_Click(object sender, EventArgs e)
        {
            FrmUpravljanjeZalihamaMain form = new FrmUpravljanjeZalihamaMain(TrenutniKorisnik);
            form.ShowDialog();
        }
    }
}
