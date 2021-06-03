using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class UpravljanjeKasom : Form
    {
        Entities E = new Entities();
        List<Racun> racuniPoVremenu = new List<Racun>();
        public UpravljanjeKasom()
        {
            InitializeComponent();
        }

        private void UpravljanjeKasom_Load(object sender, EventArgs e)
        {            
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
            stanjeKaseText.Text = KreiranjeNarudzbi.polog.ToString();
        }

        private void vrijemeDatumPicker_ValueChanged(object sender, EventArgs e)
        {
            Osvjezi();
        }

       
        private void stornoBtn_Click(object sender, EventArgs e)
        {
            Racun selected = (Racun)popisRacunaDgv.CurrentRow.DataBoundItem;
            string sql = $"DELETE FROM Racun WHERE id_racun = {selected.id_racun}";
            E.Database.ExecuteSqlCommand(sql);
            Osvjezi();
        }

        private void zatvoriBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void popisRacunaDgv_SelectionChanged(object sender, EventArgs e)
        {
            Racun selected = (Racun)popisRacunaDgv.CurrentRow.DataBoundItem;
            popisArtikalaPoRacunuDgv.DataSource = null;
            List<Narucuje> artikli = new List<Narucuje>();
            List<Jelo> jela = new List<Jelo>();
            int idNarudzbe = selected.id_narudzba;
            using (Entities context = new Entities())
            {
                var query = from n in context.Narucuje
                            where n.id_narudzba == idNarudzbe
                            select n;

                artikli = query.ToList();
            }

            foreach (Narucuje n in artikli)
            {
                using (Entities context = new Entities())
                {
                    var query = from j in context.Jelo
                                where j.id_jelo == n.id_jelo
                                select j;
                    jela.AddRange(query);
                }
            }
            popisArtikalaPoRacunuDgv.DataSource = jela;
            popisArtikalaPoRacunuDgv.Columns[3].Visible = false;
            popisArtikalaPoRacunuDgv.Columns[4].Visible = false;
            popisArtikalaPoRacunuDgv.Columns[5].Visible = false;
        }
    }
}
