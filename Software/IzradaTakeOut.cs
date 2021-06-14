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
        List<Stavke_racuna> hranaZaVan = new List<Stavke_racuna>();
        public IzradaTakeOut()
        {
            InitializeComponent();
        }

        private void IzradaTakeOut_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        private void Osvjezi() 
        {
            dataGridView1.DataSource = null;
            using (Entities context = new Entities())
            {
                var query = from s in context.Stavke_racuna
                            where s.id_racun == KreiranjeNarudzbi.racunZaVan.id_racun
                            select s;
                hranaZaVan = query.ToList();
            }
            dataGridView1.DataSource = hranaZaVan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
