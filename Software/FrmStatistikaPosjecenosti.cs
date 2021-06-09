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
        }

        private void IzracunajPosjecenost()
        {
            chartPosjecenost.Series["Broj rezervacija"].Points.Clear();

            int[] posjecenost = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 1; i < 13; i++)
            {
                foreach (var rezervacija in SveRezervacije)
                {
                    if(rezervacija.datum_vrijeme.Date.Month == i)
                    {
                        posjecenost[i]++;
                    }
                }
            }

            if (radioBtnMjesec.Checked)
            {
                for (int i = 1; i < 13; i++)
                {
                    chartPosjecenost.Series["Broj rezervacija"].Points.AddXY(i,posjecenost[i]);
                }
            }
            else
            {
                chartPosjecenost.Series["Broj rezervacija"].Points.AddXY(1, 200);
            }
        }

        private void radioBtnMjesec_CheckedChanged(object sender, EventArgs e)
        {
            IzracunajPosjecenost();
        }
    }
}
