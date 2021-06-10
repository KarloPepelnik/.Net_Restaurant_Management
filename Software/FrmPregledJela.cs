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
    public partial class FrmPregledJela : Form
    {
        public FrmPregledJela()
        {
            InitializeComponent();
        }

        private void FrmPregledJela_Load(object sender, EventArgs e)
        {
            FillKategorijaJelaCmb();
            FillPopisJelaDgv();
            FillSortOptionsCmb();
        }

        private void FillSortOptionsCmb()
        {
            List<string> opcijeSortiranja = new List<string>()
            {
                "Prikazi sva jela",
                "Prikazi jela prema nazivu uzlazno",
                "Prikazi jela prema nazivu silazno",
                "Prikazi jela prema cijeni uzlazno",
                "Prikazi jela prema cijeni silazno"
            };
            cmbBoxSortOptions.DataSource = opcijeSortiranja;
        }

        private void FillPopisJelaDgv()
        {
            using (var context = new Entities())
            {
                dgvPopisJela.DataSource = context.Jelo.ToList();
                dgvPopisJela.Columns[0].Visible = false;
                dgvPopisJela.Columns[1].Visible = false;
                dgvPopisJela.Columns[5].Visible = false;
                dgvPopisJela.Columns[6].Visible = false;
                dgvPopisJela.Columns[7].Visible = false;
                dgvPopisJela.Columns[8].Visible = false;
                dgvPopisJela.Columns[2].HeaderText = "Naziv jela";
                dgvPopisJela.Columns[3].HeaderText = "Cijena jela";
                dgvPopisJela.Rows[0].Selected = true;
                dgvPopisJela.Columns[3].DefaultCellStyle.Format = "c";
                
            }
        }

        private void FillKategorijaJelaCmb()
        {
            using (var context = new Entities())
            {
                List<Kategorija> kategorije = context.Kategorija.ToList();
                cmbBoxKategorijaJelaSort.DataSource = kategorije;
            }
        }

        private Jelo GetSelectedJelo()
        {
            return dgvPopisJela.Rows[0].DataBoundItem as Jelo;
        }

        private void Filer(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0: FillPopisJelaDgv(); break;
                case 1: FilterSvaJelaNazivAsc(); break;
                case 2: FilterSvaJelaNazivDesc(); break;
                case 3: FilterSvaJelaCijenaAsc(); break;
                case 4: FilterSvaJelaCijenaDesc(); break;

            }
        }

        private void FilterSvaJelaCijenaDesc()
        {
            using (var context = new Entities())
            {
                var query = from j in context.Jelo
                            orderby j.cijena descending
                            select j;
                dgvPopisJela.DataSource = query.ToList();
            }
        }

        private void FilterSvaJelaCijenaAsc()
        {
            using (var context = new Entities())
            {
                var query = from j in context.Jelo
                            orderby j.cijena ascending
                            select j;
                dgvPopisJela.DataSource = query.ToList();
            }
        }

        private void FilterSvaJelaNazivDesc()
        {
            using (var context = new Entities())
            {
                var query = from j in context.Jelo
                            orderby j.naziv_jela descending
                            select j;
                dgvPopisJela.DataSource = query.ToList();
            }
        }

        private void FilterSvaJelaNazivAsc()
        {
            using (var context = new Entities())
            {
                var query = from j in context.Jelo
                            orderby j.naziv_jela ascending
                            select j;
                dgvPopisJela.DataSource = query.ToList();
            }
        }

        private void btnIzbrisiJelo_Click_1(object sender, EventArgs e)
        {
            Jelo selectedJelo = GetSelectedJelo();
            using (var context = new Entities())
            {
                context.Jelo.Attach(selectedJelo);
                context.Jelo.Remove(selectedJelo);
                context.SaveChanges();
            }
            FillPopisJelaDgv();
        }

        private void btnAzuriraj_Click_1(object sender, EventArgs e)
        {
            FrmAzurirajJelo frmAzurirajJelo = new FrmAzurirajJelo(GetSelectedJelo());
            frmAzurirajJelo.ShowDialog();

            FillPopisJelaDgv();
        }

        private void btnIzlaz_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPretrazi_Click_1(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                string searchName = txtBoxNazivJelaSearch.Text.ToLower();
                var query = from j in context.Jelo
                            where j.naziv_jela.ToLower().Contains(searchName)
                            select j;
                dgvPopisJela.DataSource = query.ToList();
                txtBoxNazivJelaSearch.Text = "";
            }
        }

        private void btnFilterPoKategoriji_Click_1(object sender, EventArgs e)
        {
            Kategorija selectedKategorija = cmbBoxKategorijaJelaSort.SelectedItem as Kategorija;
            using (var context = new Entities())
            {
                var query = from j in context.Jelo
                            where j.id_kategorija == selectedKategorija.id_kategorija
                            select j;

                dgvPopisJela.DataSource = query.ToList();
            }
        }

        private void btnPrikaziSvaJela_Click_1(object sender, EventArgs e)
        {
            FillPopisJelaDgv();
        }

        private void cmbBoxSortOptions_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Filer(cmbBoxSortOptions.SelectedIndex);
        }
    }
}
