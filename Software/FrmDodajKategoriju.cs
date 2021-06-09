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
    public partial class FrmDodajKategoriju : Form
    {
        public FrmDodajKategoriju()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                string nazivKategorije = txtBoxNaziiv.Text;
                Kategorija newKategorija = new Kategorija()
                {
                    naziv_kategorije = nazivKategorije
                };
                context.Kategorija.Add(newKategorija);
                context.SaveChanges();
            }

            Close();
        }
    }
}
