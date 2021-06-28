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
    public partial class FrmUrediKolicinuSastojkaJela : Form
    {

        private Jelo_sadrzi sastojak;
        public FrmUrediKolicinuSastojkaJela(Jelo_sadrzi selectedSastojak)
        {
            InitializeComponent();
            sastojak = selectedSastojak;
        }

        private void FrmUrediKolicinuSastojkaJela_Load(object sender, EventArgs e)
        {
            FillIngredientInfo();
        }

        private void FillIngredientInfo()
        {
            txtBoxOdabranaNamirnica.Text = sastojak.Namirnica.naziv_namirnice;
            txtBoxTrenutnaKolicina.Text = sastojak.kolicina.ToString();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                context.Jelo_sadrzi.Attach(sastojak);
                sastojak.kolicina = float.Parse(txtBoxNovaKolicina.Text);
                context.SaveChanges();
            }
            Close();

        }
    }
}
