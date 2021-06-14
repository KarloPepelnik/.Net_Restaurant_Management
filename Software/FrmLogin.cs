using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class FrmLogin : Form
    {
        private Entities E { get; set; }
        private Korisnik TrenutniKorisnik { get; set; }
        private List<Korisnik> sviKorisnici { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            bool lozinkaOk = false;
            bool korisnickoOk = false;

            foreach (var korisnik in sviKorisnici)
            {
                if (korisnik.korisnicko_ime == txtboxKorIme.Text)
                {
                    korisnickoOk = true;
                    if (korisnik.lozinka == txtBoxLozinka.Text)
                    {
                        lozinkaOk = true;
                        TrenutniKorisnik = korisnik;
                    }
                }
            }

            if (lozinkaOk && korisnickoOk)
            {
                Izbornik forma = new Izbornik(TrenutniKorisnik);
                txtboxKorIme.Text = "";
                txtBoxLozinka.Text = "";
                Hide();
                forma.ShowDialog();
                Show();
                Osvjezi();
            }
            else if (!lozinkaOk && korisnickoOk)
            {
                MessageBox.Show("Kriva lozinka!");
            }
            else
            {
                MessageBox.Show("Nepostojeći korisnik!");
            }
        }

        private void btnRegistrirajSe_Click(object sender, EventArgs e)
        {
            FrmRegistracija forma = new FrmRegistracija();
            Hide();
            forma.ShowDialog();
            Show();
            Osvjezi();
        }

        private void Osvjezi()
        {
            E = new Entities();
            sviKorisnici = E.Korisnik.ToList();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
    }
}
