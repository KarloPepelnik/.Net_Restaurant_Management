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
    
    public partial class FrmAzurirajJelo : Form
    {
        private Jelo selectedJelo;
        public FrmAzurirajJelo(Jelo jelo)
        {
            InitializeComponent();
            selectedJelo = jelo;
        }

        private void FrmAzurirajJelo_Load(object sender, EventArgs e)
        {
            txtBoxNazivJela.Text = selectedJelo.naziv_jela;
            txtBoxCijena.Text = selectedJelo.cijena.ToString();
            FillKategoriju();
        }

        private void FillKategoriju()
        {
            List<Kategorija> kategorije;

            using (var context = new Entities())
            {
                kategorije = context.Kategorija.ToList();
            }


            cmbBoxKategorijeJela.DataSource = kategorije;

            for (int i = 0; i < cmbBoxKategorijeJela.Items.Count; i++)
            {
                if ((cmbBoxKategorijeJela.Items[i] as Kategorija).id_kategorija == selectedJelo.id_kategorija)
                {
                    cmbBoxKategorijeJela.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                context.Jelo.Attach(selectedJelo);
                
                string noviNazivJela = txtBoxNazivJela.Text;
                float novaCijenaJela = float.Parse(txtBoxCijena.Text);
                Kategorija novaKategorija = cmbBoxKategorijeJela.SelectedItem as Kategorija;


                selectedJelo.naziv_jela = noviNazivJela;
                selectedJelo.cijena = novaCijenaJela;
                selectedJelo.id_kategorija = novaKategorija.id_kategorija;

                context.SaveChanges();
            }
            Close();
        }
    }
}
