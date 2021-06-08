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
            novi.id_stol = int.Parse(txtBrojStola.Text);
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
    }
}
