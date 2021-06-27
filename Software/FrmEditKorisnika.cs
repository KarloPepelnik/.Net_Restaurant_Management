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
    public partial class FrmEditKorisnika : Form
    {
        private Korisnik Selektirani { get; set; }
        public FrmEditKorisnika(Korisnik korisnik)
        {
            InitializeComponent();
            Selektirani = korisnik;
        }

        private void FrmEditKorisnika_Load(object sender, EventArgs e)
        {
            List<string> tipoviKorisnika = new List<string>();
            tipoviKorisnika.Add("Administrator");
            tipoviKorisnika.Add("moderator");
            tipoviKorisnika.Add("registrirani_korisnik");
            txtID.Enabled = false;
            txtID.Text = Selektirani.id_korisnik.ToString();
            txtKorisnicko.Text = Selektirani.korisnicko_ime;
            txtLozinka.Text = Selektirani.lozinka;
            txtIme.Text = Selektirani.ime;
            txtPrezime.Text = Selektirani.prezime;
            txtEmail.Text = Selektirani.email;
            cboxTipKorisnika.DataSource = tipoviKorisnika;
            cboxTipKorisnika.SelectedIndex = Selektirani.tip_korisnik - 1;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                context.Korisnik.Attach(Selektirani);

                Selektirani.tip_korisnik = cboxTipKorisnika.SelectedIndex + 1;
                Selektirani.korisnicko_ime = txtKorisnicko.Text;
                Selektirani.lozinka = txtLozinka.Text;
                Selektirani.ime = txtIme.Text;
                Selektirani.prezime = txtPrezime.Text;
                Selektirani.email = txtEmail.Text;

                context.SaveChanges();
            }
            Close();
        }
    }
}
