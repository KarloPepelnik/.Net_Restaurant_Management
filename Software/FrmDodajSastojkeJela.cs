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
    public partial class FrmDodajSastojkeJela : Form
    {
        public FrmDodajSastojkeJela()
        {
            InitializeComponent();
        }

        private void RefreshAddIngredientButton()
        {
            if (txtBoxKolicina.Text == "")
            {
                btnDodajSastojak.Enabled = false;
            }
        }

        private void FillNamirniceListBox()
        {
            using (var context = new Entities())
            {
                listBoxNamirnica.DataSource = context.Namirnica.ToList();
            }
        }




        private void btnDodajSastojak_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {

            }
        }
    }

}
