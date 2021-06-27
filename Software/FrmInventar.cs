using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class FrmInventar : Form
    {
        public FrmInventar()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmInventar_Load(object sender, EventArgs e)
        {
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
                dgvStolovi.Columns["rezerviran"].Visible = false;
                dgvStolovi.Columns["rezervacija"].Visible = false;
                dgvStolovi.Columns["id_stol"].Visible = false;
                dgvStolovi.Columns["oznaka"].HeaderText = "Broj stola";
                dgvStolovi.Columns["oznaka"].DisplayIndex = 0;
                dgvStolovi.Columns["opis"].HeaderText = "Pozicija stola";
                dgvStolovi.Columns["broj_mjesta"].HeaderText = "Broj mjesta";
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Stol odabrani = dgvStolovi.CurrentRow.DataBoundItem as Stol;
            List<Rezervacija> odabrana = null;

            using (var context = new Entities())
            {
                var query = from r in context.Rezervacija
                            where r.id_stol == odabrani.id_stol
                            select r;
                odabrana = query.ToList();
            }

            if(odabrana.Count == 0)
            {
                using (var context = new Entities())
                {
                    context.Stol.Attach(odabrani);
                    context.Stol.Remove(odabrani);
                    context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Stol se nalazi u postojecoj rezervaciji!");
            }
            Osvjezi();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            Stol odabrani = dgvStolovi.CurrentRow.DataBoundItem as Stol;
            FrmEditStol forma = new FrmEditStol(odabrani);
            forma.ShowDialog();
            Osvjezi();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajStol forma = new FrmDodajStol();
            forma.ShowDialog();
            Osvjezi();
        }

        private void FrmInventar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, "RestoranApp.chm", HelpNavigator.Topic, "Inventar/index.html");
            }
        }
    }
}
