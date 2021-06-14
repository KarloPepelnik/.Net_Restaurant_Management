using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class FrmEditStol : Form
    {
        private Stol OdabraniStol { get; set; }
        public FrmEditStol(Stol stol)
        {
            InitializeComponent();
            OdabraniStol = stol;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPohrani_Click(object sender, EventArgs e)
        {
            int idStol;
            using (var context = new Entities())
            {
                var query = from s in context.Stol
                            where s.oznaka == OdabraniStol.oznaka
                            select s;
                Stol pomocni = query.Single();
                idStol = pomocni.id_stol;
            }
            using (var context = new Entities())
            {
                context.Stol.Attach(OdabraniStol);
                OdabraniStol.id_stol = idStol;
                OdabraniStol.opis = txtPozicijaStola.Text;
                OdabraniStol.broj_mjesta = int.Parse(txtBrojMjesta.Text);
                context.SaveChanges();
            }
            Close();
        }

        private void FrmEditStol_Load(object sender, EventArgs e)
        {

            txtBrojStola.Text = OdabraniStol.oznaka.ToString();
            txtBrojStola.Enabled = false;
            txtPozicijaStola.Text = OdabraniStol.opis;
            txtBrojMjesta.Text = OdabraniStol.broj_mjesta.ToString();
        }
    }
}
