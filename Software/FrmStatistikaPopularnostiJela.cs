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
    public partial class FrmStatistikaPopularnostiJela : Form
    {
        
        public FrmStatistikaPopularnostiJela()
        {
            InitializeComponent();
        }

        private void FrmStatistikaPopularnostiJela_Load(object sender, EventArgs e)
        {
            FillChart();
        }

        private void FillChart()
        {
            CreateSvaJelaChart();
        }

        private void CreateSvaJelaChart()
        {
            using (var context = new Entities())
            {
                var queryJela = from sr in context.Stavke_racuna
                                select new JeloKolicinaView
                                {
                                    NazivJela = sr.Jelo.naziv_jela,
                                    Kolicina = sr.kolicina,
                                    Kategorija = sr.Jelo.Kategorija.naziv_kategorije
                                };

                List<JeloKolicinaView> jeloKolicinaViews = queryJela.ToList();
                var grupiranaLista = jeloKolicinaViews.GroupBy(i => i.NazivJela).Select(i => new { NazivJela = i.Key, Kolicina = i.Sum(item => item.Kolicina) });

                chrtPopularnostJela.DataSource = grupiranaLista;
                chrtPopularnostJela.Series["Broj narucenih jela"].XValueMember = "NazivJela";
                chrtPopularnostJela.Series["Broj narucenih jela"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
                chrtPopularnostJela.Series["Broj narucenih jela"].YValueMembers = "Kolicina";
                chrtPopularnostJela.Series["Broj narucenih jela"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
            }
        }

        private void CreatePredjelaChart()
        {
            chrtPopularnostJela.Titles["Naslov"].Text = "Popularnost jela iz kategorije Predjelo";
            using (var context = new Entities())
            {
                var queryJela = from sr in context.Stavke_racuna
                                where sr.Jelo.Kategorija.naziv_kategorije == "Predjelo"
                                select new JeloKolicinaView
                                {
                                    NazivJela = sr.Jelo.naziv_jela,
                                    Kolicina = sr.kolicina,
                                    Kategorija = sr.Jelo.Kategorija.naziv_kategorije
                                };

                List<JeloKolicinaView> jeloKolicinaViews = queryJela.ToList();
                var grupiranaLista = jeloKolicinaViews.GroupBy(i => i.NazivJela).Select(i => new { NazivJela = i.Key, Kolicina = i.Sum(item => item.Kolicina) });

                chrtPopularnostJela.DataSource = grupiranaLista;
                chrtPopularnostJela.Series["Broj narucenih jela"].XValueMember = "NazivJela";
                chrtPopularnostJela.Series["Broj narucenih jela"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
                chrtPopularnostJela.Series["Broj narucenih jela"].YValueMembers = "Kolicina";
                chrtPopularnostJela.Series["Broj narucenih jela"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
            }
        }

        private void CreateGlavnaJelaChart()
        {
            chrtPopularnostJela.Titles["Naslov"].Text = "Popularnost jela iz kategorije Glavno jelo";
            using (var context = new Entities())
            {
                var queryJela = from sr in context.Stavke_racuna
                                where sr.Jelo.Kategorija.naziv_kategorije == "Glavno jelo"
                                select new JeloKolicinaView
                                {
                                    NazivJela = sr.Jelo.naziv_jela,
                                    Kolicina = sr.kolicina,
                                    Kategorija = sr.Jelo.Kategorija.naziv_kategorije
                                };

                List<JeloKolicinaView> jeloKolicinaViews = queryJela.ToList();
                var grupiranaLista = jeloKolicinaViews.GroupBy(i => i.NazivJela).Select(i => new { NazivJela = i.Key, Kolicina = i.Sum(item => item.Kolicina) });

                chrtPopularnostJela.DataSource = grupiranaLista;
                chrtPopularnostJela.Series["Broj narucenih jela"].XValueMember = "NazivJela";
                chrtPopularnostJela.Series["Broj narucenih jela"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
                chrtPopularnostJela.Series["Broj narucenih jela"].YValueMembers = "Kolicina";
                chrtPopularnostJela.Series["Broj narucenih jela"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
            }
        }

        private void CreateDesertiChart()
        {
            chrtPopularnostJela.Titles["Naslov"].Text = "Popularnost jela iz kategorije Desert";
            using (var context = new Entities())
            {
                var queryJela = from sr in context.Stavke_racuna
                                where sr.Jelo.Kategorija.naziv_kategorije == "Desert"
                                select new JeloKolicinaView
                                {
                                    NazivJela = sr.Jelo.naziv_jela,
                                    Kolicina = sr.kolicina,
                                    Kategorija = sr.Jelo.Kategorija.naziv_kategorije
                                };

                List<JeloKolicinaView> jeloKolicinaViews = queryJela.ToList();
                var grupiranaLista = jeloKolicinaViews.GroupBy(i => i.NazivJela).Select(i => new { NazivJela = i.Key, Kolicina = i.Sum(item => item.Kolicina) });

                chrtPopularnostJela.DataSource = grupiranaLista;
                chrtPopularnostJela.Series["Broj narucenih jela"].XValueMember = "NazivJela";
                chrtPopularnostJela.Series["Broj narucenih jela"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
                chrtPopularnostJela.Series["Broj narucenih jela"].YValueMembers = "Kolicina";
                chrtPopularnostJela.Series["Broj narucenih jela"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
            }
        }
        private void btnPrikazPoKategoriji_Click(object sender, EventArgs e)
        {
            if (radioBtnPredjela.Checked == true)
            {
                CreatePredjelaChart();
            }
            else
            {
                if (radioButtonGlavnaJela.Checked == true)
                {
                    CreateGlavnaJelaChart();
                }
                else
                {
                    CreateDesertiChart();
                }
            }
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            CreateSvaJelaChart();
        }
    }
}
