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
    public partial class FrmRezervacije : Form
    {
        private Korisnik TrenutniKorisnik { get; set; }
        private List<DateTime> RezerviraniDatumi { get; set; }
        private List<Rezervacija> SveRezervacije { get; set; }
        public FrmRezervacije(Korisnik korisnik)
        {
            InitializeComponent();
            RezerviraniDatumi = new List<DateTime>();
            SveRezervacije = new List<Rezervacija>();
            TrenutniKorisnik = korisnik;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRezervacije_Load(object sender, EventArgs e)
        {
            Osvjezi();
            using (var context = new Entities())
            {
                var query = from s in context.Stol
                            select s;
                List<Stol> sviStolovi = query.ToList();
                cboxStolovi.DataSource = sviStolovi;
            }
        }

        private void Osvjezi()
        {
            using (var context = new Entities())
            {
                var query = from r in context.Rezervacija
                            select r;

                SveRezervacije = query.ToList();
                RezerviraniDatumi.Clear();
                foreach (var rezervacija in SveRezervacije) {
                    RezerviraniDatumi.Add(rezervacija.datum_vrijeme);
                }
                kalendar.BoldedDates = RezerviraniDatumi.ToArray();
                dgvRezervacije.DataSource = SveRezervacije;
                dgvRezervacije.Columns["korisnik"].Visible = false;
                dgvRezervacije.Columns["stol"].Visible = false;
                dgvRezervacije.Columns["id_korisnik"].Visible = false;
                dgvRezervacije.Columns["id_rezervacija"].Visible = false;
                dgvRezervacije.Columns["opis_rezervacije"].HeaderText = "Prezime";
                dgvRezervacije.Columns["datum_vrijeme"].HeaderText = "Datum i vrijeme";
                dgvRezervacije.Columns["id_stol"].HeaderText = "Broj stola";
            }
        }

        private void kalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            List<Rezervacija> naDanRezervacije = new List<Rezervacija>();
            foreach (var rezervacija in SveRezervacije)
            {
                if (rezervacija.datum_vrijeme.ToShortDateString() == kalendar.SelectionStart.ToShortDateString())
                {
                    naDanRezervacije.Add(rezervacija);
                }
            }
            dgvRezervacije.DataSource = naDanRezervacije;
            dgvRezervacije.Columns["korisnik"].Visible = false;
            dgvRezervacije.Columns["stol"].Visible = false;
            dgvRezervacije.Columns["id_korisnik"].Visible = false;
            dgvRezervacije.Columns["id_rezervacija"].Visible = false;
            dgvRezervacije.Columns["opis_rezervacije"].HeaderText = "Prezime";
            dgvRezervacije.Columns["datum_vrijeme"].HeaderText = "Datum i vrijeme";
            dgvRezervacije.Columns["id_stol"].HeaderText = "Broj stola";

            dateTimeDatum.Value = kalendar.SelectionStart.Date;
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            Rezervacija odabrana = dgvRezervacije.CurrentRow.DataBoundItem as Rezervacija;
            FrmIzmjenaRezervacije forma = new FrmIzmjenaRezervacije(odabrana);
            forma.ShowDialog();
            Osvjezi();
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {
            Rezervacija odabrana = dgvRezervacije.CurrentRow.DataBoundItem as Rezervacija;
            using (var context = new Entities())
            {
                context.Rezervacija.Attach(odabrana);
                context.Rezervacija.Remove(odabrana);
                context.SaveChanges();
            }
            Osvjezi();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Rezervacija nova = new Rezervacija();
            nova.id_korisnik = TrenutniKorisnik.id_korisnik;
            nova.id_stol = cboxStolovi.SelectedIndex + 1;
            nova.datum_vrijeme = dateTimeDatum.Value.Date + dateTimeVrijeme.Value.TimeOfDay;
            nova.opis_rezervacije = txtPrezime.Text;

            using (var context = new Entities())
            {
                context.Rezervacija.Attach(nova);
                context.Rezervacija.Add(nova);
                context.SaveChanges();
            }
            Osvjezi();
            cboxStolovi.SelectedIndex = 0;
            dateTimeDatum.Value = DateTime.Now.Date;
            dateTimeVrijeme.Value = DateTime.Now;
            txtPrezime.Text = "";
        }
    }
}
