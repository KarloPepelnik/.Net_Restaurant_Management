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
        public PregledNarudzbiZaVan()
        {
            InitializeComponent();
        }
        public List<Dostava> narudzbe = new List<Dostava>();
        Entities E = new Entities();     

        
        public void Osvjezi()
        {
            narudzbeDgv.DataSource = null;
            using (Entities context = new Entities())
            {
                var query = from d in context.Dostava
                            select d;
                narudzbe = query.ToList();
            }
            narudzbeDgv.DataSource = narudzbe;
            narudzbeDgv.Columns[0].Visible = false;
            narudzbeDgv.Columns[1].Visible = false;
            narudzbeDgv.Columns[6].Visible = false;
            narudzbeDgv.Columns[7].Visible = false;            
        }

        private void Obrisi(Dostava selected)
        {
            E.Dostava.Attach(selected);
            E.Dostava.Remove(selected);
            E.Database.ExecuteSqlCommand($"DELETE FROM Dostava WHERE id_dostava = {selected.id_dostava}");
        }

        private void zatvoriBtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void izvrsenaBtn_Click(object sender, EventArgs e)
        {
            Dostava selected = (Dostava)narudzbeDgv.CurrentRow.DataBoundItem;
            Obrisi(selected);
            Osvjezi();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dostavaTableAdapter.FillBy(this._PI21_13_DBDataSet.Dostava);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void PregledNarudzbiZaVan_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void PregledNarudzbiZaVan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, "RestoranApp.chm", HelpNavigator.Topic, "Rezervacije/index.html");
            }
        }
    }
}

