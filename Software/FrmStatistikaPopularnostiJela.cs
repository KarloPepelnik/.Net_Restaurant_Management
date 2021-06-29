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

            using (var context = new Entities())
            {
                var queryJela = from sr in context.Stavke_racuna
                                select new JeloKolicinaView
                                {
                                    NazivJela = sr.Jelo.naziv_jela,
                                    Kolicina = sr.kolicina
                                };

                List<JeloKolicinaView> jeloKolicinaViews = queryJela.ToList();
                var grupiranaLista = jeloKolicinaViews.GroupBy(i => i.NazivJela).Select(i => new { NazivJela = i.Key, Kolicina = i.Sum(item => item.Kolicina) });

                chrtPopularnostJela.DataSource = grupiranaLista;
                chrtPopularnostJela.Series["Broj narucenih jela"].XValueMember = "NazivJela";
                chrtPopularnostJela.Series["Broj narucenih jela"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
                chrtPopularnostJela.Series["Broj narucenih jela"].YValueMembers = "Kolicina";
                chrtPopularnostJela.Series["Broj narucenih jela"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;

                

                jeloKolicinaViewBindingSource.DataSource = grupiranaLista;
            }
        }
    }
}
