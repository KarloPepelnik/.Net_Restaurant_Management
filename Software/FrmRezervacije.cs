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
        private List<DateTime> RezerviraniDatumi { get; set; }
        private List<Rezervacija> SveRezervacije { get; set; }
        public FrmRezervacije()
        {
            InitializeComponent();
            RezerviraniDatumi = new List<DateTime>();
            SveRezervacije = new List<Rezervacija>();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRezervacije_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            using (var context = new Entities())
            {
                var query = from r in context.Rezervacija
                            select r;

                SveRezervacije = query.ToList();
                foreach (var rezervacija in SveRezervacije) {
                
                    RezerviraniDatumi.Add(rezervacija.datum_vrijeme);
                }
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
        }
    }
}
