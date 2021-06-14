using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class FrmAzurirajPrimku : Form
    {
        private Primka selectedPrimka;


        public FrmAzurirajPrimku(Primka primka)
        {
            InitializeComponent();

            selectedPrimka = primka;
        }

        public double prethodnaKolicina = 0;
        private void FrmAzurirajPrimku_Load(object sender, EventArgs e)
        {
            FillListBox();
            FillMjernu_jedinicu();
            txtBoxOdabranaNamirnica.Text = FillOdabranaNamirnica();
            txtBoxKolicinaZaprimanja.Text = selectedPrimka.kolicina.ToString();
            dtpDatumPrimke.Value = selectedPrimka.datum_vrijeme.Date;
            prethodnaKolicina = selectedPrimka.kolicina;

        }

        private string FillOdabranaNamirnica()
        {
            int idNamirnica = selectedPrimka.id_namirnica;
            List<Namirnica> namirnice;
            Namirnica wantedNamirnica;

            using (var context = new Entities())
            {
                namirnice = context.Namirnica.ToList();
            }
            wantedNamirnica = namirnice.Find(x => x.id_namirnica == idNamirnica);
            return wantedNamirnica.naziv_namirnice;
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
                if ((cmbBoxMjernaJedinica.Items[i] as Mjerna_jedinica).id_mjerna_jedinica == selectedPrimka.id_mjerna_jedinica)
                {
                    cmbBoxMjernaJedinica.SelectedIndex = i;
                    break;
                }
            }
        }

        private void FillListBox()
        {
            List<string> popisNazivaNamirnica = new List<string>();

            using (var context = new Entities())
            {
                foreach (var item in context.Namirnica)
                {
                    popisNazivaNamirnica.Add(item.naziv_namirnice);
                }
            }
            listBoxNamirnice.DataSource = popisNazivaNamirnica;
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            txtBoxOdabranaNamirnica.Text = listBoxNamirnice.SelectedItem.ToString();
            txtBoxOdabranaNamirnica.ReadOnly = false;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                context.Primka.Attach(selectedPrimka);

                int namirnica_id = GetSelectedNamirnica().id_namirnica;
                float novaKolicina = float.Parse(txtBoxKolicinaZaprimanja.Text);
                DateTime date = dtpDatumPrimke.Value.Date;
                Mjerna_jedinica mjerna_Jedinica = cmbBoxMjernaJedinica.SelectedItem as Mjerna_jedinica;


                selectedPrimka.id_namirnica = namirnica_id;
                selectedPrimka.kolicina = novaKolicina;
                selectedPrimka.Mjerna_jedinica.id_mjerna_jedinica = mjerna_Jedinica.id_mjerna_jedinica;
                selectedPrimka.datum_vrijeme = date;

                Namirnica namirnicaEdit = GetSelectedNamirnica();
                context.Namirnica.Attach(namirnicaEdit);

                if (selectedPrimka.id_mjerna_jedinica == namirnicaEdit.id_mjerna_jedinica)
                {
                    if (novaKolicina > prethodnaKolicina)
                    {
                        namirnicaEdit.kolicina_trenutna += (novaKolicina - prethodnaKolicina);
                    }
                    else
                    {
                        namirnicaEdit.kolicina_trenutna -= (prethodnaKolicina - novaKolicina);
                    }
                }
                else
                {
                    throw new InvalidOperationException($"Nemoguće pretvoriti mjerna jedinicu primke ({selectedPrimka.Mjerna_jedinica.oznaka_mjerne_jedinice}) " +
                                                        $" u mjernu jedinicu trenutne količine namirnice ({namirnicaEdit.Mjerna_jedinica.oznaka_mjerne_jedinice}) ");
                }

                context.SaveChanges();
                MessageBox.Show($"Uspješno azurirana kolicina za {namirnicaEdit.naziv_namirnice}! ");

            }
            Close();


        }


        private Namirnica GetSelectedNamirnica()
        {
            string trazeniNaziv = txtBoxOdabranaNamirnica.Text;
            Namirnica chosenNamirnica;

            using (var context = new Entities())
            {
                List<Namirnica> listaNamirnica = context.Namirnica.ToList();

                chosenNamirnica = listaNamirnica.Find(x => x.naziv_namirnice == trazeniNaziv);
            }
            return chosenNamirnica;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

