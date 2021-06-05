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
    public partial class FrmDodajNamirnicu : Form
    {
        public FrmDodajNamirnicu()
        {
            InitializeComponent();
        }

        private void FrmDodajNamirnicu_Load(object sender, EventArgs e)
        {
            FillCategory();
            FillMjernaJedinica();
        }


        private void FillMjernaJedinica()
        {
            List<Mjerna_jedinica> mjerne_Jedinice;

            using (var context = new Entities())
            {
                mjerne_Jedinice = context.Mjerna_jedinica.ToList();
            }

            cmbBoxMjernaJedinica.DataSource = mjerne_Jedinice;
        }

        private void FillCategory()
        {
            List<Kategorija> kategorije;
            
            using (var context = new Entities())
            {
                kategorije = context.Kategorija.ToList();
            }

            cmbBoxKategorija.DataSource = kategorije;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajNamirnicu_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                string naziv = txtBoxNaziv.Text;
                float temperatura = float.Parse(txtBoxTemperatura.Text);
                
                Kategorija kategorija = cmbBoxKategorija.SelectedItem as Kategorija;
                context.Kategorija.Attach(kategorija);
                
                Mjerna_jedinica mjerna_Jedinica = cmbBoxMjernaJedinica.SelectedItem as Mjerna_jedinica;
                context.Mjerna_jedinica.Attach(mjerna_Jedinica);

                float kolicina = float.Parse(txtBoxKolicina.Text);

                Namirnica novaNamirnica = new Namirnica
                {
                    naziv_namirnice=naziv,
                    id_kategorije=kategorija.id_kategorija,
                    temperatura_pohrane = temperatura,
                    id_mjerna_jedinica = mjerna_Jedinica.id_mjerna_jedinica,
                    kolicina_trenutna = kolicina
                };

                context.Namirnica.Add(novaNamirnica);
                context.SaveChanges();

                Close();
            }
        }
    }
}
