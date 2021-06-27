using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class FrmStatistikaPosjecenosti : Form
    {
        private List<Rezervacija> SveRezervacije { get; set; }
        private List<Stol> SviStolovi { get; set; }
        public FrmStatistikaPosjecenosti()
        {
            InitializeComponent();
            SveRezervacije = new List<Rezervacija>();
            SviStolovi = new List<Stol>();
        }

        private void btnIzadi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmStatistikaPosjecenosti_Load(object sender, EventArgs e)
        {
            radioBtnMjesec.Checked = true;
            using (var context = new Entities())
            {
                var query = from r in context.Rezervacija
                            select r;
                SveRezervacije = query.ToList();

                var query1 = from s in context.Stol
                             select s;
                SviStolovi = query1.ToList();
            }
            IzracunajPosjecenost();
            IzracunajProsjekGostiju();
        }

        private void IzracunajProsjekGostiju()
        {
            int[] brojGostiju = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach (var stol in SviStolovi)
            {
                foreach (var rezervacija in SveRezervacije)
                {
                    if (rezervacija.id_stol == stol.id_stol)
                    {
                        brojGostiju[stol.broj_mjesta - 1]++;
                    }
                }
            }

            for (int i = 1; i < 10; i++)
            {
                if (brojGostiju[i] > 0)
                {
                    chartBrojGostiju.Series["Broj gostiju"].Points.AddXY(i + 1, brojGostiju[i]);
                }

            }
        }

        private void IzracunajPosjecenost()
        {
            chartPosjecenost.Series["Broj rezervacija"].Points.Clear();

            int[] posjecenost = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] posjecenostTjedan = { 0, 0, 0, 0, 0, 0, 0 };
            int[] brojRezervacija = { 1, 1, 1, 1, 1, 1, 1 };

            for (int i = 1; i < 13; i++)
            {
                foreach (var rezervacija in SveRezervacije)
                {
                    if (rezervacija.datum_vrijeme.Date.Month == i)
                    {
                        posjecenost[i]++;
                    }
                }
            }
            for (int i = 0; i < 7; i++)
            {
                foreach (var rezervacija in SveRezervacije)
                {
                    if (rezervacija.datum_vrijeme.Date.DayOfWeek == (DayOfWeek)i)
                    {
                        posjecenostTjedan[i]++;
                        brojRezervacija[i]++;
                    }
                }
            }

            if (radioBtnMjesec.Checked)
            {
                for (int i = 1; i < 13; i++)
                {
                    chartPosjecenost.Series["Broj rezervacija"].Points.AddXY(i, posjecenost[i]);
                }
            }
            else
            {
                for (int i = 0; i < 7; i++)
                {
                    chartPosjecenost.Series["Broj rezervacija"].Points.AddXY(((DayOfWeek)i).ToString(), posjecenostTjedan[i]); ;
                    chartPosjecenost.Series["Broj rezervacija"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
                }
            }
        }

        private void radioBtnMjesec_CheckedChanged(object sender, EventArgs e)
        {
            IzracunajPosjecenost();
        }

        private void FrmStatistikaPosjecenosti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, "RestoranApp.chm", HelpNavigator.Topic, "Statistika_posje_enosti/index.html");
            }
        }
    }
}
