using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class UpravljanjeKasom : Form
    {        
        Entities E = new Entities();
        BindingList<Racun> racuniPoVremenu = new BindingList<Racun>();
        public UpravljanjeKasom()
        {
            InitializeComponent();
        }

        private void UpravljanjeKasom_Load(object sender, EventArgs e)
        {
            PostavljanjeKase();
            E.Racun.Load();
            Osvjezi();
        }
        private void Osvjezi()
        {
            string datum = vrijemeDatumPicker.Value.ToString("yyyy-MM-dd");
            popisRacunaDgv.DataSource = null;
            racuniPoVremenu.Clear();
            foreach (Racun r in E.Racun.Local)
            {
                if (r.datum_vrijeme.ToString("yyyy-MM-dd") == datum)
                    racuniPoVremenu.Add(r);
            }
            popisRacunaDgv.DataSource = racuniPoVremenu;
            popisRacunaDgv.Columns[1].Visible = false;
            popisRacunaDgv.Columns[2].Visible = false;
            popisRacunaDgv.Columns[5].Visible = false;
            popisRacunaDgv.Columns[6].Visible = false;
            popisRacunaDgv.Columns[7].Visible = false;
            stanjeKaseText.Text = DohvatiVrijednostKase().ToString();
        }

        private void vrijemeDatumPicker_ValueChanged(object sender, EventArgs e)
        {
            Osvjezi();
            PostavljanjeKase();
        }


        private void stornoBtn_Click(object sender, EventArgs e)
        {
            if(DohvatiVrijednostKase()>0){
                Racun selected = (Racun)popisRacunaDgv.CurrentRow.DataBoundItem;
                E.Database.ExecuteSqlCommand($"DELETE FROM Stavke_racuna WHERE id_racun = {selected.id_racun}");
                E.Database.ExecuteSqlCommand($"DELETE FROM Racun WHERE id_racun = {selected.id_racun}");
                E.Database.ExecuteSqlCommand($"UPDATE Kasa SET Stanje = {DohvatiVrijednostKase() - selected.iznos} WHERE datum = '{DateTime.Today.ToString("yyyy-MM-dd")}'");
                Osvjezi();
            }
        }

        private void zatvoriBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrikazStavki_Click(object sender, EventArgs e)
        {
            Osvjezi();
            Racun selected = (Racun)popisRacunaDgv.CurrentRow.DataBoundItem;
            List<Narucuje> artikli = new List<Narucuje>();
            List<Stavke_racuna> stavke = new List<Stavke_racuna>();
            List<Jelo> jela = new List<Jelo>();
            jela.Clear();

            PrikazStavki(stavke, selected, jela);

            popisArtikalaPoRacunuDgv.DataSource = null;
            popisArtikalaPoRacunuDgv.DataSource = jela;
            popisArtikalaPoRacunuDgv.Columns[1].Visible = false;
            popisArtikalaPoRacunuDgv.Columns[4].Visible = false;
            popisArtikalaPoRacunuDgv.Columns[5].Visible = false;
            popisArtikalaPoRacunuDgv.Columns[6].Visible = false;
            popisArtikalaPoRacunuDgv.Columns[7].Visible = false;
            popisArtikalaPoRacunuDgv.Columns[8].Visible = false;

        }
        private void PrikazStavki(List<Stavke_racuna> stavke, Racun selected, List<Jelo> jela)
        {
            int idNarudzbe = selected.id_narudzba;
            int idRacun = selected.id_racun;

            using (Entities context = new Entities())
            {
                var query = from s in context.Stavke_racuna
                            where s.id_racun == idRacun
                            select s;

                stavke = query.ToList();
            }
            foreach (Stavke_racuna s in stavke)
            {
                using (Entities context = new Entities())
                {
                    var query = from j in context.Jelo
                                where j.id_jelo == s.id_jelo
                                select j;
                    jela.AddRange(query);
                }
            }
        }
        public void PostavljanjeKase()
        {
            using (Entities context = new Entities())
            {
                var query = from k in context.Kasa
                            where k.datum == DateTime.Today
                            select k.stanje;
                if (query.Count() != 0)
                {
                    KreiranjeNarudzbi.polog = query.Single();
                }
                else
                {
                    KreiranjeNarudzbi.polog = 500;
                    E.Database.ExecuteSqlCommand($"INSERT INTO Kasa (stanje, datum) VALUES ({KreiranjeNarudzbi.polog}, '{DateTime.Now:yyyy-MM-dd}')");
                }
            }
        }
        public double DohvatiVrijednostKase()
        {
            double trenutnoStanje;
            using (Entities context = new Entities())
            {
                var query = from k in context.Kasa
                            where k.datum == DateTime.Today
                            select k.stanje;
                trenutnoStanje = query.Single();
            }
            return trenutnoStanje;
        }
    }
}
