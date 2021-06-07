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
    public partial class FrmIzmjenaRezervacije : Form
    {
        private Rezervacija Odabrana { get; set; }
        public FrmIzmjenaRezervacije(Rezervacija rezervacija)
        {
            InitializeComponent();
            Odabrana = rezervacija;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmIzmjenaRezervacije_Load(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                var query = from s in context.Stol
                            select s;

                List<Stol> sviStolovi = query.ToList();
                cboxStol.DataSource = sviStolovi;
                cboxStol.SelectedIndex = Odabrana.id_stol - 1;
            }
            datumIVrijeme.Format = DateTimePickerFormat.Custom;
            datumIVrijeme.CustomFormat = "d.M.yyyy. HH:mm";
            datumIVrijeme.Value = Odabrana.datum_vrijeme;
            txtPrezime.Text = Odabrana.opis_rezervacije;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                context.Rezervacija.Attach(Odabrana);
                Odabrana.id_stol = cboxStol.SelectedIndex + 1;
                Odabrana.datum_vrijeme = datumIVrijeme.Value;
                Odabrana.opis_rezervacije = txtPrezime.Text;
                context.SaveChanges();
            }
            Close();
        }
    }
}
