using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class FrmTrenutnoStanje : Form
    {

        public FrmTrenutnoStanje()
        {
            InitializeComponent();
        }

        private void btnDodajNamirnicu_Click(object sender, EventArgs e)
        {
            FrmDodajNamirnicu form = new FrmDodajNamirnicu();
            form.ShowDialog();

            RefreshGUI();
        }

        private void FrmTrenutnoStanje_Load(object sender, EventArgs e)
        {
            RefreshGUI();
            FillFilterCmbBox();
            FillCategories();
        }

        private void RefreshGUI()
        {
            using (var context = new Entities())
            {
                var query = from n in context.Namirnica
                            select new { n.id_namirnica, n.naziv_namirnice, n.Kategorija.naziv_kategorije, n.temperatura_pohrane, n.Mjerna_jedinica.oznaka_mjerne_jedinice, n.kolicina_trenutna };



                dgvTrenutnoStanjeZaliha.DataSource = query.ToList();

                DgvTrenutneKolicineEdit();
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIzbrisiNamirnicu_Click(object sender, EventArgs e)
        {


            Namirnica trazenaNamirnica = GetSelectedNamirnica();

            using (var context = new Entities())
            {
                context.Namirnica.Attach(trazenaNamirnica);
                if (trazenaNamirnica != null)
                {
                    context.Namirnica.Remove(trazenaNamirnica);
                    context.SaveChanges();
                }

                else
                {
                    MessageBox.Show("Nije moguće izbrisati ovu namirnicu");
                }

            }

            RefreshGUI();
        }

        private void btnAzurirajNamirnicu_Click(object sender, EventArgs e)
        {
            FrmAzurirajNamirnicu form = new FrmAzurirajNamirnicu(GetSelectedNamirnica());
            form.ShowDialog();

            RefreshGUI();


        }

        private Namirnica GetSelectedNamirnica()
        {
            int namirnicaId = int.Parse(dgvTrenutnoStanjeZaliha.CurrentRow.Cells[0].Value.ToString());
            Namirnica selectedNamirnica;

            using (var context = new Entities())
            {
                List<Namirnica> listaNamirnica = context.Namirnica.ToList();

                selectedNamirnica = listaNamirnica.Find(x => x.id_namirnica == namirnicaId);

            }


            return selectedNamirnica;

        }

        private void FillFilterCmbBox()
        {
            List<String> cmbBoxSource = new List<string>()
            {
                "Prikazi sve namirnice",
                "Sortiraj prema nazivu uzlazno",
                "Sortiraj prema količini uzlazno",
                "Sortiraj prema količini silazno"
            };


            cmbBoxSortiraj.DataSource = cmbBoxSource;
        }

        private void FillCategories()
        {
            using (var context = new Entities())
            {
                var query = from k in context.Kategorija
                            select k;

                cmbBoxPrikazPoKategoriji.DataSource = query.ToList();
            }
        }

        private void cmbBoxSortiraj_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter(cmbBoxSortiraj.SelectedIndex);
        }

        private void Filter(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0: RefreshGUI(); break;
                case 1: SortByNameAscending(); break;
                case 2: SortByQuantityAscending(); break;
                case 3: SortByQuantityDescending(); break;
                default:
                    break;
            }
        }

        private void SortByQuantityDescending()
        {
            using (var context = new Entities())
            {
                var query = from n in context.Namirnica
                            orderby n.kolicina_trenutna descending
                            select new { n.id_namirnica, n.naziv_namirnice, n.Kategorija.naziv_kategorije, n.temperatura_pohrane, n.Mjerna_jedinica.oznaka_mjerne_jedinice, n.kolicina_trenutna };



                dgvTrenutnoStanjeZaliha.DataSource = query.ToList();
                DgvTrenutneKolicineEdit();
            }
        }

        private void SortByQuantityAscending()
        {
            using (var context = new Entities())
            {
                var query = from n in context.Namirnica
                            orderby n.kolicina_trenutna
                            select new { n.id_namirnica, n.naziv_namirnice, n.Kategorija.naziv_kategorije, n.temperatura_pohrane, n.Mjerna_jedinica.oznaka_mjerne_jedinice, n.kolicina_trenutna };



                dgvTrenutnoStanjeZaliha.DataSource = query.ToList();
                DgvTrenutneKolicineEdit();
            }

        }

        private void SortByNameAscending()
        {
            using (var context = new Entities())
            {
                var query = from n in context.Namirnica
                            orderby n.naziv_namirnice
                            select new { n.id_namirnica, n.naziv_namirnice, n.Kategorija.naziv_kategorije, n.temperatura_pohrane, n.Mjerna_jedinica.oznaka_mjerne_jedinice, n.kolicina_trenutna };



                dgvTrenutnoStanjeZaliha.DataSource = query.ToList();
                DgvTrenutneKolicineEdit();
            }
        }

        private void DgvTrenutneKolicineEdit()
        {
            dgvTrenutnoStanjeZaliha.Columns[0].Visible = false;
            dgvTrenutnoStanjeZaliha.Columns[1].HeaderText = "Naziv namirnice:";
            dgvTrenutnoStanjeZaliha.Columns[2].HeaderText = "Kategorija:";
            dgvTrenutnoStanjeZaliha.Columns[3].HeaderText = "Temperatura pohrane:";
            dgvTrenutnoStanjeZaliha.Columns[4].HeaderText = "Mjerna jedinica:";
            dgvTrenutnoStanjeZaliha.Columns[5].HeaderText = "Trenutna kolicina:";
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            string searchText = txtBoxPretraga.Text.ToLower();

            using (var context = new Entities())
            {
                var query = from n in context.Namirnica
                            where n.naziv_namirnice.Contains(searchText)
                            orderby n.naziv_namirnice
                            select new { n.id_namirnica, n.naziv_namirnice, n.Kategorija.naziv_kategorije, n.temperatura_pohrane, n.Mjerna_jedinica.oznaka_mjerne_jedinice, n.kolicina_trenutna };



                dgvTrenutnoStanjeZaliha.DataSource = query.ToList();
                DgvTrenutneKolicineEdit();
            }
        }

        private void btnPrikaziKategoriju_Click(object sender, EventArgs e)
        {
            Kategorija trazenaKategorija = cmbBoxPrikazPoKategoriji.SelectedItem as Kategorija;

            using (var context = new Entities())
            {
                var query = from n in context.Namirnica
                            where n.Kategorija.id_kategorija == trazenaKategorija.id_kategorija
                            select new { n.id_namirnica, n.naziv_namirnice, n.Kategorija.naziv_kategorije, n.temperatura_pohrane, n.Mjerna_jedinica.oznaka_mjerne_jedinice, n.kolicina_trenutna };



                dgvTrenutnoStanjeZaliha.DataSource = query.ToList();

                DgvTrenutneKolicineEdit();

            }
        }
    }
}


