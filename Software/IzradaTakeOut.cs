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
    public partial class IzradaTakeOut : Form
    {
        public int sifraRacuna { get; set; }
        Racun trenutniRacun = new Racun();
        Stavke_racuna trenutnaStavka = new Stavke_racuna();
        List<Jelo> jelaSaNarudzbe = new List<Jelo>();
        Entities E = new Entities();
        public IzradaTakeOut(int sifraRacuna)
        {
            this.sifraRacuna = sifraRacuna;
            InitializeComponent();
        }
        
        public IzradaTakeOut()
        {
            InitializeComponent();
        }

        private void IzradaTakeOut_Load(object sender, EventArgs e)
        {           
            Osvjezi();
            korisnikTxt.Text = Izbornik.TrenutniKorisnik.korisnicko_ime;
            racunTxt.Text = sifraRacuna.ToString();
            cijenaTxt.Text = "25";
        }
        private void Osvjezi() 
        {
            dataGridView1.DataSource = null;
            using (Entities context = new Entities())
            {
                var query = from r in context.Racun
                            where r.id_racun == sifraRacuna
                            select r;
                trenutniRacun = query.Single();
            }
            using (Entities context = new Entities())
            {
                var query = from s in context.Stavke_racuna
                            where s.id_racun == trenutniRacun.id_racun
                            select s;
                trenutnaStavka = query.Single();
            }
            using (Entities context = new Entities())
            {
                var query = from j in context.Jelo
                            where j.id_jelo == trenutnaStavka.id_jelo
                            select j;
                jelaSaNarudzbe = query.ToList();
            }
            dataGridView1.DataSource = jelaSaNarudzbe;
            dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            E.Database.ExecuteSqlCommand($"INSERT INTO Dostava (id_korisnik, id_racun, adresa_dostave, broj_telefona, cijena_dostave)" +
                $" VALUES ({Izbornik.TrenutniKorisnik.id_korisnik}, {sifraRacuna}, '{adresaTxt.Text}', '{telefonTxt.Text}', 25)");
            NarudzbaIzdana narudzbaIzdana = new NarudzbaIzdana();
            Hide();
            narudzbaIzdana.ShowDialog();
            Show();
            Close();
        }
    }
}
