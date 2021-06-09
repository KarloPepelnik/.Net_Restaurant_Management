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
    public partial class FrmKategorijeJela : Form
    {
        public FrmKategorijeJela()
        {
            InitializeComponent();
        }

        private void FrmKategorijeJela_Load(object sender, EventArgs e)
        {
            FIllDgv();
        }

        private void FIllDgv()
        {
            using (var context = new Entities())
            {
                List<Kategorija> kategorije = context.Kategorija.ToList();
                dgvKategorijeJela.DataSource = kategorije;
                dgvKategorijeJela.Columns[0].HeaderText = "Sifra kategorije";
                dgvKategorijeJela.Columns[1].HeaderText = "Naziv kategorije";
                dgvKategorijeJela.Columns[2].Visible = false;
                dgvKategorijeJela.Columns[3].Visible = false;
            }
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            FrmDodajKategoriju frmDodaj = new FrmDodajKategoriju();
            frmDodaj.ShowDialog();

            FIllDgv();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Kategorija GetSelectedKategorija()
        {
            return dgvKategorijeJela.CurrentRow.DataBoundItem as Kategorija;
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                Kategorija selectedKategorija = GetSelectedKategorija();
                context.Kategorija.Attach(selectedKategorija);
                context.Kategorija.Remove(selectedKategorija);
                context.SaveChanges();
            }

            FIllDgv();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            FrmAzurirajKategoriju frmAzuriraj = new FrmAzurirajKategoriju(GetSelectedKategorija());
            frmAzuriraj.ShowDialog();

            FIllDgv();
        }
    }
}
