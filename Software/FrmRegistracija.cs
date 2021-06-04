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
        public FrmRegistracija()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
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

        private void FrmRegistracija_Load(object sender, EventArgs e)
        {
            E = new Entities();
            sviKorisnici = E.Korisnik.ToList();
        }
    }
}
