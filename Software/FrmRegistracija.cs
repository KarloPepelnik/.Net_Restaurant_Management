using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProgramskoIntenjerstvo
{
    public partial class FrmRegistracija : Form
    {
        private List<Korisnik> sviKorisnici { get; set; }
        private Entities E { get; set; }
        private Regex rxLozinka { get; set; }
        private Regex rxEmail { get; set; }
        public FrmRegistracija()
        {
            InitializeComponent();
            rxLozinka = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$");
            rxEmail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            labelLozinka.Visible = false;
            labelEmail.Visible = false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            labelLozinka.Visible = false;
            labelEmail.Visible = false;
            if (rxLozinka.Match(txtBoxLozinka.Text).Success && rxEmail.Match(txtBoxEmail.Text).Success)
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
            else if(!rxLozinka.Match(txtBoxLozinka.Text).Success)
            {
                labelLozinka.Visible = true;
            }
            else if (!rxEmail.Match(txtBoxEmail.Text).Success)
            {
                labelEmail.Visible = true;
            }
        }

        private void FrmRegistracija_Load(object sender, EventArgs e)
        {
            E = new Entities();
            sviKorisnici = E.Korisnik.ToList();
        }
    }
}
