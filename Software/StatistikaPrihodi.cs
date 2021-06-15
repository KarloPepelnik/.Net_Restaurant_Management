using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class StatistikaPrihodi : Form
    {
        private List<Racun> sviRacuni = new List<Racun>();
        public StatistikaPrihodi()
        {
            InitializeComponent();
        }

        private void zatvoriBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StatistikaPrihodi_Load(object sender, EventArgs e)
        {

            DohvatiPodatke();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DohvatiPodatke();
        }

        private void DohvatiPodatke()
        {
            DateTime picked = dateTimePicker1.Value.Date;
            DateTime temp;
            chart1.Series["Promet"].Points.Clear();
            double ukupnoRacuni = 0;

            for (int i = 0; i < 7; i++)
            {
                ukupnoRacuni = 0;
                temp = picked.AddDays(-i);
                using (Entities context = new Entities())
                {
                    var query = from r in context.Racun
                                where r.datum_vrijeme == temp
                                select r;
                    sviRacuni = query.ToList();
                }

                foreach (Racun r in sviRacuni)
                {
                    ukupnoRacuni += r.iznos;
                }

                chart1.Series["Promet"].Points.AddXY(temp.ToString().Replace(" 0:00:00", ""), ukupnoRacuni);
            }
        }

        private void StatistikaPrihodi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, "RestoranApp.chm", HelpNavigator.Topic, "Rezervacije/index.html");
            }
        }
    }
}
