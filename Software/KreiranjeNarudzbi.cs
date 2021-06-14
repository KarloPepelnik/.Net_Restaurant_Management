using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class KreiranjeNarudzbi : Form
    {
        Entities E = new Entities();
        Dictionary<Jelo, int> jela = new Dictionary<Jelo, int>();
        int sifraRacuna;
        public static Racun racunZaVan { get; set; }
        double ukupno;
        public static double polog { get; set; }
        public KreiranjeNarudzbi()
        {
            InitializeComponent();
        }

        private void KreiranjeNarudzbi_Load(object sender, EventArgs e)
        {
            outputDumpTXT.Enabled = false;
            removeBtn.Enabled = false;
            ukupno = 0;
            Osvjezi();
        }
        private void Osvjezi()
        {
            E.Jelo.Load();
            jeloDataGrid.DataSource = null;
            jeloDataGrid.DataSource = E.Jelo.Local;
            jeloDataGrid.Columns[0].Visible = false;
            jeloDataGrid.Columns[4].Visible = false;
            jeloDataGrid.Columns[5].Visible = false;
            jeloDataGrid.Columns[6].Visible = false;
            jeloDataGrid.Columns[7].Visible = false;
            jeloDataGrid.Columns[8].Visible = false;
            jeloDataGrid.Columns[1].HeaderText = "Jelo";
            jeloDataGrid.Columns[2].HeaderText = "Opis";
            jeloDataGrid.Columns[3].HeaderText = "Cijena";
            racunBtn.Enabled = false;
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (removeBtn.Enabled == false)
            {
                removeBtn.Enabled = true;
                racunBtn.Enabled = true;
            }

            Jelo selected = (Jelo)jeloDataGrid.CurrentRow.DataBoundItem;
            DodajJelo(selected);

            outputDumpTXT.Text = ukupno.ToString();
            odabranaJelaDataGrid.DataSource = null;
            odabranaJelaDataGrid.DataSource = jela.ToList();
            odabranaJelaDataGrid.Columns[0].HeaderText = "Jelo";
            odabranaJelaDataGrid.Columns[1].HeaderText = "Kolicina";
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            KeyValuePair<Jelo, int> selected = (KeyValuePair<Jelo, int>)odabranaJelaDataGrid.CurrentRow.DataBoundItem;
            ObrisiJelo(selected);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void racunBtn_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                KreirajRacun();
                using (Entities context = new Entities())
                {
                    var query = from k in context.Kasa
                                where k.datum == DateTime.Today
                                select k.stanje;
                    polog = query.Single();
                }

                E.Database.ExecuteSqlCommand($"UPDATE Kasa SET stanje = {polog + ukupno} WHERE datum = '{DateTime.Today.ToString("yyyy-MM-dd")}'");
                RacunIzdan racunIzdan = new RacunIzdan();
                racunIzdan.ShowDialog();
                jela.Clear();
                odabranaJelaDataGrid.DataSource = null;
                outputDumpTXT.Text = null;
                removeBtn.Enabled = false;
                ukupno = 0;
            }
            else
            {
                KreirajRacun();
                IzradaTakeOut takeOut = new IzradaTakeOut(sifraRacuna);
                Hide();
                takeOut.ShowDialog();
                Show();
                Close();
            }
        }

        public void ObrisiJelo(KeyValuePair<Jelo, int> selected)
        {
            int value;
            Jelo jelo = selected.Key;
            if (jela.TryGetValue(jelo, out value))
            {
                jela[jelo] = value - 1;
                ukupno -= jelo.cijena;
                polog -= jelo.cijena;
            }

            if (jela[jelo] == 0)
            {
                jela.Remove(jelo);
            }
            if (jela.Count == 0)
            {
                removeBtn.Enabled = false;
                racunBtn.Enabled = false;
            }
            outputDumpTXT.Text = ukupno.ToString();
            odabranaJelaDataGrid.DataSource = null;
            odabranaJelaDataGrid.DataSource = jela.ToList();
        }
        public void DodajJelo(Jelo selected)
        {

            int value;
            if (jela.TryGetValue(selected, out value))
            {
                jela[selected] = value + 1;
                ukupno += selected.cijena;
                polog += selected.cijena;

            }
            else
            {
                ukupno += selected.cijena;
                polog += selected.cijena;
                jela.Add(selected, 1);
            }
        }
        public void KreirajRacun()
        {
            DateTime now = DateTime.Now;
            KreiranjeNarudzbi.racunZaVan = new Racun();
            string sql1 = $"INSERT INTO Racun (id_narudzba, id_korisnik, iznos, datum_vrijeme) VALUES (1, 2, {ukupno}, '{now.ToString("yyyy-MM-dd")}')";
            E.Database.ExecuteSqlCommand(sql1);            
            using (Entities context = new Entities())
            {
                var query = context.Racun.OrderByDescending(i => i.id_racun).FirstOrDefault();
                sifraRacuna = query.id_racun;
            }            
            foreach (KeyValuePair<Jelo, int> k in jela)
            {
                string sql3 = $"INSERT INTO Stavke_racuna (id_racun, id_jelo, kolicina) VALUES ({sifraRacuna}, {k.Key.id_jelo}, {k.Value})";
                E.Database.ExecuteSqlCommand(sql3);
            }
        }

    }
}

