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
    public partial class FrmAzurirajNamirnicu : Form
    {
        private Namirnica selectedNamirnica;

        
        public FrmAzurirajNamirnicu(Namirnica namirnica)
        {
            InitializeComponent();
            selectedNamirnica = namirnica;
        }

        private void FrmAzurirajNamirnicu_Load_1(object sender, EventArgs e)
        {
            FillKategoriju();
            FillMjernu_jedinicu();

            txtBoxNaziv.Text = selectedNamirnica.naziv_namirnice;
            txtBoxTemperatura.Text = selectedNamirnica.temperatura_pohrane.ToString();
            txtBoxKolicina.Text = selectedNamirnica.kolicina_trenutna.ToString();
        }
        
        private void FillMjernu_jedinicu()
        {
            List<Mjerna_jedinica> mjerneJedinice;

            using (var context = new Entities())
            {
                mjerneJedinice = context.Mjerna_jedinica.ToList();
            }
         
            cmbBoxMjernaJedinica.DataSource = mjerneJedinice;

            for (int i = 0; i < cmbBoxMjernaJedinica.Items.Count; i++)
            {
                if ((cmbBoxMjernaJedinica.Items[i] as Mjerna_jedinica).id_mjerna_jedinica == selectedNamirnica.id_mjerna_jedinica)
                {
                    cmbBoxMjernaJedinica.SelectedIndex = i;
                    break;
                }
            }
        }

        private void FillKategoriju()
        {
            List<Kategorija> kategorije;

            using (var context = new Entities())
            {
                kategorije = context.Kategorija.ToList();
            }
            
            

            cmbBoxKategorija.DataSource = kategorije;

            for (int i = 0; i < cmbBoxKategorija.Items.Count; i++)
            {
                if ((cmbBoxKategorija.Items[i] as Kategorija).id_kategorija == selectedNamirnica.id_kategorije)
                {
                    cmbBoxKategorija.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnSpremiPromjene_Click_1(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                context.Namirnica.Attach(selectedNamirnica);

                string naziv = txtBoxNaziv.Text;
                float temperatura = float.Parse(txtBoxTemperatura.Text);

                Kategorija kategorija = cmbBoxKategorija.SelectedItem as Kategorija;
                

                Mjerna_jedinica mjerna_Jedinica = cmbBoxMjernaJedinica.SelectedItem as Mjerna_jedinica;
                

                float kolicina = float.Parse(txtBoxKolicina.Text);

                

                selectedNamirnica.naziv_namirnice = naziv;
                selectedNamirnica.Kategorija.id_kategorija = kategorija.id_kategorija;
                selectedNamirnica.temperatura_pohrane = temperatura;
                selectedNamirnica.Mjerna_jedinica.id_mjerna_jedinica = mjerna_Jedinica.id_mjerna_jedinica;
                selectedNamirnica.kolicina_trenutna = kolicina;

                context.SaveChanges();

            }
                Close();
            
        }

        private void btnOdustani_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}


