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
            return dgvPopisJela.CurrentRow.DataBoundItem as Jelo;
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
    }
}
