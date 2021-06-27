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
    public partial class FrmKorisnici : Form
    {
        public FrmKorisnici()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmKorisnici_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            using (var context = new Entities())
            {
                var query = from k in context.Korisnik
                            select k;

                List<Korisnik> sviKorisnici = query.ToList();

                dgvKorisnici.DataSource = sviKorisnici;
                dgvKorisnici.Columns["dostava"].Visible = false;
                dgvKorisnici.Columns["rezervacija"].Visible = false;
                dgvKorisnici.Columns["Tip_korisnika"].Visible = false;
                dgvKorisnici.Columns["Narudzba"].Visible = false;
                dgvKorisnici.Columns["racun"].Visible = false;
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Korisnik selektirani = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;

            using (var context = new Entities())
            {
                context.Korisnik.Attach(selektirani);

                context.Korisnik.Remove(selektirani);
                context.SaveChanges();
            }
            RefreshGUI();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            Korisnik selektirani = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
            FrmEditKorisnika forma = new FrmEditKorisnika(selektirani);
            forma.ShowDialog();
            RefreshGUI();
        }
    }
}
