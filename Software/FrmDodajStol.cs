using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class FrmDodajStol : Form
    {
        public FrmDodajStol()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPohrani_Click(object sender, EventArgs e)
        {
            Stol novi = new Stol();
            novi.oznaka = int.Parse(txtBrojStola.Text);
            novi.opis = txtPozicijaStola.Text;
            novi.broj_mjesta = int.Parse(txtBrojMjesta.Text);

            using (var context = new Entities())
            {
                context.Stol.Attach(novi);
                context.Stol.Add(novi);
                context.SaveChanges();
            }
            Close();
        }

        private void FrmDodajStol_Load(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                var query = from s in context.Stol
                            select s;
                List<Stol> sviStolovi = query.ToList();
                Stol pomocni = sviStolovi.Last();
                txtBrojStola.Text = (pomocni.oznaka + 1).ToString();
            }
            txtBrojStola.Enabled = false;
        }
    }
}
