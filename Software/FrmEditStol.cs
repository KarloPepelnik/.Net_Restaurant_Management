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
            using (var context = new Entities())
            {
                context.Stol.Attach(OdabraniStol);
                OdabraniStol.id_stol = int.Parse(txtBrojStola.Text);
                OdabraniStol.opis = txtPozicijaStola.Text;
                OdabraniStol.broj_mjesta = int.Parse(txtBrojMjesta.Text);
                context.SaveChanges();
            }
            Close();
        }

        private void FrmEditStol_Load(object sender, EventArgs e)
        {
            txtBrojStola.Enabled = false;
            txtBrojStola.Text = OdabraniStol.id_stol.ToString();
            txtPozicijaStola.Text = OdabraniStol.opis;
            txtBrojMjesta.Text = OdabraniStol.broj_mjesta.ToString();
        }
    }
}
