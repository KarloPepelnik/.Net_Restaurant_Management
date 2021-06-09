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
    public partial class FrmAzurirajKategoriju : Form
    {
        private Kategorija selectedKategorija;
        public FrmAzurirajKategoriju(Kategorija kategorija)
        {
            InitializeComponent();
            selectedKategorija = kategorija;
        }

        private void FrmAzurirajKategorriju_Load(object sender, EventArgs e)
        {
            txtBoxNaziv.Text = selectedKategorija.naziv_kategorije;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                context.Kategorija.Attach(selectedKategorija);
                selectedKategorija.naziv_kategorije = txtBoxNaziv.Text;
                context.SaveChanges();
            }
            Close();
        }
    }
}
