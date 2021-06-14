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
    public partial class PregledNarudzbiZaVan : Form
    {
        public List<Dostava> narudzbe = new List<Dostava>();
        Entities E = new Entities();
        public PregledNarudzbiZaVan()
        {
            InitializeComponent();
        }

        private void PregledNarudzbiZaVan_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        public void Osvjezi()
        {
            popisNarudzbiDgv.DataSource = null;
            using (Entities context = new Entities())
            {
                var query = from d in context.Dostava
                            select d;
                narudzbe = query.ToList();
            }
            popisNarudzbiDgv.DataSource = narudzbe;
            popisNarudzbiDgv.Columns[0].Visible = false;
            popisNarudzbiDgv.Columns[1].Visible = false;
            popisNarudzbiDgv.Columns[6].Visible = false;
            popisNarudzbiDgv.Columns[7].Visible = false;

        }

        private void zatvoriBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void izvrsenaButton_Click(object sender, EventArgs e)
        {
            Dostava selected = (Dostava)popisNarudzbiDgv.CurrentRow.DataBoundItem;
            Obrisi(selected);            
            Osvjezi();
        }
        private void Obrisi(Dostava selected)
        {
            E.Dostava.Attach(selected);
            E.Dostava.Remove(selected);
            E.Database.ExecuteSqlCommand($"DELETE FROM Dostava WHERE id_dostava = {selected.id_dostava}");
        }
    }
}
