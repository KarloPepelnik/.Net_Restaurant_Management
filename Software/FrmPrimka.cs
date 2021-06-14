using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class FrmPrimka : Form
    {
        public FrmPrimka()
        {
            InitializeComponent();
        }

        private void FrmPrimka_Load(object sender, EventArgs e)
        {
            FillListBox();
            FillCmbMjernaJedinica();
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

        private void FillCmbMjernaJedinica()
        {
            List<Mjerna_jedinica> mjerneJedinice;

            using (var context = new Entities())
            {
                mjerneJedinice = context.Mjerna_jedinica.ToList();
            }

            cmbBoxMjernaJedinica.DataSource = mjerneJedinice;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            txtBoxOdabranaNamirnica.Text = listBoxNamirnice.SelectedItem.ToString();
            txtBoxOdabranaNamirnica.ReadOnly = true;
        }

        private void btnUnesiPrimku_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                int namirnicaId = GetSelectedNamirnica().id_namirnica;
                float kolicinaZaprimanja = float.Parse(txtBoxKolicinaZaprimanja.Text);
                DateTime dateTime = dtpDatumPrimke.Value.Date;
                Mjerna_jedinica mjerna_Jedinica = cmbBoxMjernaJedinica.SelectedItem as Mjerna_jedinica;
                context.Mjerna_jedinica.Attach(mjerna_Jedinica);

                Primka newPrimka = new Primka()
                {
                    id_namirnica = namirnicaId,
                    kolicina = kolicinaZaprimanja,
                    datum_vrijeme = dateTime,
                    id_mjerna_jedinica = mjerna_Jedinica.id_mjerna_jedinica,
                };

                context.Primka.Add(newPrimka);

                Namirnica namirnicaEdit = GetSelectedNamirnica();
                context.Namirnica.Attach(namirnicaEdit);

                if (newPrimka.id_mjerna_jedinica == namirnicaEdit.id_mjerna_jedinica)
                {
                    namirnicaEdit.kolicina_trenutna += kolicinaZaprimanja;
                }
                else
                {
                    throw new InvalidOperationException($"Nemoguće pretvoriti mjerna jedinicu primke ({newPrimka.Mjerna_jedinica.oznaka_mjerne_jedinice}) " +
                                                        $" u mjernu jedinicu trenutne količine namirnice ({namirnicaEdit.Mjerna_jedinica.oznaka_mjerne_jedinice}) ");
                }


                context.SaveChanges();
            }

            MessageBox.Show($"Trenutačna zaliha {GetSelectedNamirnica().naziv_namirnice} uspješno ažurirana!");
            Close();
        }

        private Namirnica GetSelectedNamirnica()
        {
            string trazeniNaziv = txtBoxOdabranaNamirnica.Text;
            Namirnica selectedNamirnica;

            using (var context = new Entities())
            {
                List<Namirnica> listaNamirnica = context.Namirnica.ToList();

                selectedNamirnica = listaNamirnica.Find(x => x.naziv_namirnice == trazeniNaziv);
            }
            return selectedNamirnica;
        }
    }
}
