using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class KreiranjeNarudzbi : Form
    {
        Entities E = new Entities();
        Dictionary<Jelo, int> jela = new Dictionary<Jelo, int>();
        double ukupno;
        public static double polog { get; set; } = 500;
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
            jeloDataGrid.Columns[1].HeaderText = "Jelo";
            jeloDataGrid.Columns[2].HeaderText = "Cijena";
            jeloDataGrid.Columns[3].HeaderText = "Opis";
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
            int value;
            if (jela.TryGetValue(selected, out value))
            {
                jela[selected] = value + 1;
                ukupno += selected.cijena_jela;
                polog += selected.cijena_jela;
            }
            else
            {
                ukupno += selected.cijena_jela;
                polog += selected.cijena_jela;
                jela.Add(selected, 1);
            }
            outputDumpTXT.Text = ukupno.ToString();
            odabranaJelaDataGrid.DataSource = null;
            odabranaJelaDataGrid.DataSource = jela.ToList();
            odabranaJelaDataGrid.Columns[0].HeaderText = "Jelo";
            odabranaJelaDataGrid.Columns[1].HeaderText = "Kolicina";
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            int value;

            KeyValuePair<Jelo, int> selected = (KeyValuePair<Jelo, int>)odabranaJelaDataGrid.CurrentRow.DataBoundItem;

            Jelo jelo = selected.Key;
            if (jela.TryGetValue(jelo, out value))
            {
                jela[jelo] = value - 1;
                ukupno -= jelo.cijena_jela;
                polog -= jelo.cijena_jela;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void racunBtn_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Jelo, int> k in jela)
            {
                string sql = $"INSERT INTO Narucuje (id_narudzba, id_jelo, kolicina) VALUES (1, {k.Key.id_jelo}, {k.Value})";
                E.Database.ExecuteSqlCommand(sql);
            }

            DateTime now = DateTime.Now;

            string sql1 = $"INSERT INTO Racun (id_narudzba, id_korisnik, iznos, datum_vrijeme) VALUES (1, 2, {ukupno}, '{now.ToString("yyyy-MM-dd")}')";
            E.Database.ExecuteSqlCommand(sql1);

            ukupno = 0;
            RacunIzdan racunIzdan = new RacunIzdan();
            racunIzdan.ShowDialog();
            jela.Clear();
            odabranaJelaDataGrid.DataSource = null;
            outputDumpTXT.Text = null;
            removeBtn.Enabled = false;
        }
    }
}

