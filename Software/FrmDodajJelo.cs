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
    public partial class FrmDodajJelo : Form
    {
        public FrmDodajJelo()
        {
            InitializeComponent();
        }

        private void FrmDodajJelo_Load(object sender, EventArgs e)
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
                dgvPopisJela.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvPopisJela.Columns[2].Width = 340;
                

            }
        }

        private void FillKategorijaJelaCmb()
        {
            using (var context = new Entities())
            {
                List<Kategorija> kategorije = context.Kategorija.ToList();
                cmbBoxKategorijeJela.DataSource = kategorije;
                cmbBoxKategorijaJelaSort.DataSource = kategorije;
            }
        }

        private void btnDodajJelo_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                string nazivJela = txtBoxNazivJela.Text;
                float cijenaJela = float.Parse(txtBoxCijena.Text);
                Kategorija kategorijaJela = cmbBoxKategorijeJela.SelectedItem as Kategorija;
                context.Kategorija.Attach(kategorijaJela);

                Jelo newJelo = new Jelo()
                {
                    naziv_jela = nazivJela,
                    cijena = cijenaJela,
                    id_kategorija = kategorijaJela.id_kategorija
                };

                
                context.Jelo.Add(newJelo);
                context.SaveChanges();
            }
            FillPopisJelaDgv();
            RefreshTxtBoxes();
        }

        private void RefreshTxtBoxes()
        {
            txtBoxNazivJela.Text = "";
            txtBoxCijena.Text = "";
        }

        private void btnIzbrisiJelo_Click(object sender, EventArgs e)
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

        private Jelo GetSelectedJelo()
        {
                return dgvPopisJela.Rows[0].DataBoundItem as Jelo;   
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            FrmAzurirajJelo frmAzurirajJelo = new FrmAzurirajJelo(GetSelectedJelo());
            frmAzurirajJelo.ShowDialog();

            FillPopisJelaDgv();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFilterPoKategoriji_Click(object sender, EventArgs e)
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

        private void btnPrikaziSvaJela_Click(object sender, EventArgs e)
        {
            FillPopisJelaDgv();
        }

        private void cmbBoxSortOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filer(cmbBoxSortOptions.SelectedIndex);
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

        private void btnPretrazi_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
