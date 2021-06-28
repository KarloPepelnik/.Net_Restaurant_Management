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
                var queryChart = from sr in context.Stavke_racuna
                                 select new { sr.Jelo.naziv_jela, sr.kolicina };

                chrtPopularnostJela.DataSource = queryChart.ToList();
            }
        }
    }
}
