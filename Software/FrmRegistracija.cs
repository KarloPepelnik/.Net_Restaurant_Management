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
    public partial class FrmRegistracija : Form
    {
        private List<Korisnik> sviKorisnici { get; set; }
        private Entities E { get; set; }
        private Validator Validator { get; set; }
        private ValidatorKorisnik ValidatorKorisnik { get; set; }
        public FrmRegistracija()
        {
            InitializeComponent();
            labelLozinka.Visible = false;
            labelEmail.Visible = false;
            labelPodudaraju.Visible = false;
            labelImeZauzeto.Visible = false;
            Validator = new Validator();
            ValidatorKorisnik = new ValidatorKorisnik();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            if (Validator.ProvjeriLozinku(txtBoxLozinka.Text) && Validator.ProvjeriEmail(txtBoxEmail.Text) && Validator.ProvjeriObadvijeLozinke(txtBoxLozinka.Text, txtLozinkaPonovo.Text) && !ValidatorKorisnik.ProvjeriKorisnickoIme(txtBoxKorime.Text))
            {
                Korisnik novi = new Korisnik();
                novi.tip_korisnik = 3;
                novi.korisnicko_ime = txtBoxKorime.Text;
                novi.lozinka = txtBoxLozinka.Text;
                novi.ime = txtBoxIme.Text;
                novi.prezime = txtBoxPrezime.Text;
                novi.email = txtBoxEmail.Text;

                E.Korisnik.Add(novi);
                E.SaveChanges();

                Close();
            }
        }

        private void FrmRegistracija_Load(object sender, EventArgs e)
        {
            E = new Entities();
            sviKorisnici = E.Korisnik.ToList();
        }

        private void ValidacijaKorisnickoIme()
        {
            if (ValidatorKorisnik.ProvjeriKorisnickoIme(txtBoxKorime.Text))
            {
                labelImeZauzeto.Visible = true;
            }
            else
            {
                labelImeZauzeto.Visible = false;
            }
        }
        private void ValidacijaFormatLozinke()
        {
            if (!Validator.ProvjeriLozinku(txtBoxLozinka.Text))
            {
                labelLozinka.Visible = true;
            }
            else
            {
                labelLozinka.Visible = false;
            }
        }
        private void ValidacijaPodudaranjeLozinke()
        {
            if (!Validator.ProvjeriObadvijeLozinke(txtBoxLozinka.Text, txtLozinkaPonovo.Text))
            {
                labelPodudaraju.Visible = true;
            }
            else
            {
                labelPodudaraju.Visible = false;
            }
        }
        private void ValidacijaEmail()
        {
            if (!Validator.ProvjeriEmail(txtBoxEmail.Text))
            {
                labelEmail.Visible = true;
            }
            else
            {
                labelEmail.Visible = false;
            }
        }

        private void txtBoxKorime_KeyUp(object sender, KeyEventArgs e)
        {
            ValidacijaKorisnickoIme();
        }

        private void txtBoxLozinka_KeyUp(object sender, KeyEventArgs e)
        {
            ValidacijaFormatLozinke();
        }

        private void txtLozinkaPonovo_KeyUp(object sender, KeyEventArgs e)
        {
            ValidacijaPodudaranjeLozinke();
        }

        private void txtBoxEmail_KeyUp(object sender, KeyEventArgs e)
        {
            ValidacijaEmail();
        }

        private void FrmRegistracija_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, "RestoranApp.chm", HelpNavigator.Topic, "Registracija/index.html");
            }
        }
    }
}
