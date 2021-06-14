using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class FrmRucnoDodavanje : Form
    {
        private Korisnik TrenutniKorisnik { get; set; }
        public FrmRucnoDodavanje(Korisnik korisnik)
        {
            InitializeComponent();
            TrenutniKorisnik = korisnik;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRucnoDodavanje_Load(object sender, EventArgs e)
        {
            labelOprez.ForeColor = Color.Red;
            Osvjezi();
        }

        private void Osvjezi()
        {
            using (var context = new Entities())
            {
                var query = from s in context.Stol
                            select s;
                List<Stol> sviStolovi = query.ToList();
                dgvStolovi.DataSource = sviStolovi;
                cboxStolovi.DataSource = sviStolovi;
                dgvStolovi.Columns["rezerviran"].Visible = false;
                dgvStolovi.Columns["rezervacija"].Visible = false;
                dgvStolovi.Columns["id_stol"].Visible = false;
                dgvStolovi.Columns["oznaka"].HeaderText = "Broj stola";
                dgvStolovi.Columns["oznaka"].DisplayIndex = 0;
                dgvStolovi.Columns["opis"].HeaderText = "Pozicija stola";
                dgvStolovi.Columns["broj_mjesta"].HeaderText = "Broj mjesta";
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int idStola;
            int odabraniStol = int.Parse(cboxStolovi.SelectedItem.ToString());
            using (var context = new Entities())
            {
                var query = from s in context.Stol
                            where s.oznaka == odabraniStol
                            select s;
                Stol pomocni = query.Single();
                idStola = pomocni.id_stol;
            }
            Rezervacija nova = new Rezervacija();
            nova.id_korisnik = TrenutniKorisnik.id_korisnik;
            nova.id_stol = idStola;
            nova.datum_vrijeme = dateTimeDatum.Value.Date + dateTimeVrijeme.Value.TimeOfDay;
            nova.opis_rezervacije = txtPrezime.Text;

            if (dateTimeDatum.Value.Date < DateTime.Today.Date)
            {
                MessageBox.Show("Ne možete rezervirati datum prije današnjeg dana!");
            }
            else if (dateTimeVrijeme.Value.TimeOfDay < DateTime.Now.TimeOfDay && dateTimeDatum.Value.Date == DateTime.Today.Date)
            {
                MessageBox.Show("Ne možete rezervirati termin prije trenutnog vremena!");
            }
            else
            {
                using (var context = new Entities())
                {
                    context.Rezervacija.Attach(nova);
                    context.Rezervacija.Add(nova);
                    context.SaveChanges();
                }
                Close();
            }
        }
    }
}
