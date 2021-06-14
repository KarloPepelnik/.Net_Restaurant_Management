using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class FrmRezervacije : Form
    {
        private Korisnik TrenutniKorisnik { get; set; }
        private List<DateTime> RezerviraniDatumi { get; set; }
        private List<Rezervacija> SveRezervacije { get; set; }
        private List<Rezervacija> SveNoveRezervacije { get; set; }
        private List<Stol> slobodniStolovi { get; set; }
        public FrmRezervacije(Korisnik korisnik)
        {
            InitializeComponent();
            RezerviraniDatumi = new List<DateTime>();
            SveNoveRezervacije = new List<Rezervacija>();
            SveRezervacije = new List<Rezervacija>();
            TrenutniKorisnik = korisnik;
            slobodniStolovi = new List<Stol>();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRezervacije_Load(object sender, EventArgs e)
        {
            if (TrenutniKorisnik.tip_korisnik > 2)
            {
                btnIzmjeni.Visible = false;
                btnObriši.Visible = false;
            }
            Osvjezi();
        }

        private void Osvjezi()
        {
            using (var context = new Entities())
            {
                var query = from r in context.Rezervacija
                            select r;
                var query1 = from s in context.Stol
                             select s;
                List<Stol> sviStolovi = query1.ToList();

                SveRezervacije = query.ToList();
                SveNoveRezervacije = ObrisiStareRezervacije(SveRezervacije);
                foreach (var rezervacija in SveNoveRezervacije)
                {
                    foreach (var stol in sviStolovi)
                    {
                        if (rezervacija.id_stol == stol.id_stol)
                        {
                            rezervacija.OznakaStola = stol.oznaka.Value;
                        }
                    }
                }
                RezerviraniDatumi.Clear();
                foreach (var rezervacija in SveNoveRezervacije)
                {
                    RezerviraniDatumi.Add(rezervacija.datum_vrijeme);
                }
                kalendar.BoldedDates = RezerviraniDatumi.ToArray();
                dgvRezervacije.DataSource = SveNoveRezervacije;
                dgvRezervacije.Columns["korisnik"].Visible = false;
                dgvRezervacije.Columns["stol"].Visible = false;
                dgvRezervacije.Columns["id_korisnik"].Visible = false;
                dgvRezervacije.Columns["id_rezervacija"].Visible = false;
                dgvRezervacije.Columns["opis_rezervacije"].HeaderText = "Prezime";
                dgvRezervacije.Columns["datum_vrijeme"].HeaderText = "Datum i vrijeme";
                dgvRezervacije.Columns["OznakaStola"].HeaderText = "Broj stola";
                dgvRezervacije.Columns["id_stol"].Visible = false;
            }
            Osvjezi_Stolove();
        }

        private List<Rezervacija> ObrisiStareRezervacije(List<Rezervacija> sveRezervacije)
        {
            foreach (var rezervacija in sveRezervacije.ToList())
            {
                if ((rezervacija.datum_vrijeme.Date < DateTime.Today.Date) || (rezervacija.datum_vrijeme.Date == DateTime.Today.Date && rezervacija.datum_vrijeme.TimeOfDay < DateTime.Now.TimeOfDay))
                {
                    sveRezervacije.Remove(rezervacija);
                }
            }
            return sveRezervacije;
        }

        private void Osvjezi_Stolove()
        {
            slobodniStolovi.Clear();
            cboxStolovi.DataSource = null;
            dgvStolovi.DataSource = null;

            using (var context = new Entities())
            {
                var query = from s in context.Stol
                            select s;
                List<Stol> sviStolovi = query.ToList();
                DateTime oznacenoVrijeme = kalendar.SelectionStart;

                foreach (var stol in sviStolovi)
                {
                    var query1 = from r in SveNoveRezervacije
                                 where r.id_stol == stol.id_stol && r.datum_vrijeme.Date == oznacenoVrijeme.Date
                                 //where r.id_stol == stol.id_stol && DbFunctions.TruncateTime(r.datum_vrijeme) == DbFunctions.TruncateTime(oznacenoVrijeme)
                                 select r;
                    if (query1.ToList().Count == 0)
                    {
                        slobodniStolovi.Add(stol);
                    }
                }
                cboxStolovi.DataSource = slobodniStolovi;
                dgvStolovi.DataSource = slobodniStolovi;
                dgvStolovi.Columns["rezerviran"].Visible = false;
                dgvStolovi.Columns["rezervacija"].Visible = false;
                dgvStolovi.Columns["id_stol"].Visible = false;
                dgvStolovi.Columns["oznaka"].HeaderText = "Broj stola";
                dgvStolovi.Columns["oznaka"].DisplayIndex = 0;
                dgvStolovi.Columns["opis"].HeaderText = "Pozicija stola";
                dgvStolovi.Columns["broj_mjesta"].HeaderText = "Broj mjesta";
            }
        }

        private void kalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            radioBtnDan.Checked = true;
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
            dgvRezervacije.Columns["OznakaStola"].HeaderText = "Broj stola";
            dgvRezervacije.Columns["id_stol"].Visible = false;

            dateTimeDatum.Value = kalendar.SelectionStart.Date;
            Osvjezi_Stolove();
            OsvjeziPogled();
        }

        private void OsvjeziPogled()
        {
            dgvRezervacije.DataSource = null;
            if (radioBtnDan.Checked)
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
                dgvRezervacije.Columns["OznakaStola"].HeaderText = "Broj stola";
                dgvRezervacije.Columns["id_stol"].Visible = false;
            }
            else if (radioBtnTjedan.Checked)
            {
                List<Rezervacija> tjedanRezervacije = new List<Rezervacija>();
                foreach (var rezervacija in SveRezervacije)
                {
                    if (rezervacija.datum_vrijeme.Date <= kalendar.SelectionStart.Date.AddDays(7) && rezervacija.datum_vrijeme.Date >= kalendar.SelectionStart.Date)
                    {
                        tjedanRezervacije.Add(rezervacija);
                    }
                }
                dgvRezervacije.DataSource = tjedanRezervacije;
                dgvRezervacije.Columns["korisnik"].Visible = false;
                dgvRezervacije.Columns["stol"].Visible = false;
                dgvRezervacije.Columns["id_korisnik"].Visible = false;
                dgvRezervacije.Columns["id_rezervacija"].Visible = false;
                dgvRezervacije.Columns["opis_rezervacije"].HeaderText = "Prezime";
                dgvRezervacije.Columns["datum_vrijeme"].HeaderText = "Datum i vrijeme";
                dgvRezervacije.Columns["OznakaStola"].HeaderText = "Broj stola";
                dgvRezervacije.Columns["id_stol"].Visible = false;
            }
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
            }
            Osvjezi();
            cboxStolovi.SelectedIndex = 0;
            dateTimeDatum.Value = DateTime.Now.Date;
            dateTimeVrijeme.Value = DateTime.Now;
            txtPrezime.Text = "";
        }

        private void btnRucnoDodaj_Click(object sender, EventArgs e)
        {
            FrmRucnoDodavanje forma = new FrmRucnoDodavanje(TrenutniKorisnik);
            forma.ShowDialog();
            Osvjezi();
        }

        private void radioBtnDan_CheckedChanged(object sender, EventArgs e)
        {
            OsvjeziPogled();
        }

        private void FrmRezervacije_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, "RestoranApp.chm", HelpNavigator.Topic, "Rezervacije/index.html");
            }
        }
    }
}
