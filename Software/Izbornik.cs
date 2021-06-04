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
    public partial class Izbornik : Form
    {
        public Izbornik()
        {
            InitializeComponent();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNarudžbe_Click(object sender, EventArgs e)
        {
            KreiranjeNarudzbi forma = new KreiranjeNarudzbi();
            Hide();
            forma.ShowDialog();
            Show();
        }

        private void btnMeni_Click(object sender, EventArgs e)
        {
            UpravljanjeKasom forma = new UpravljanjeKasom();
            Hide();
            forma.ShowDialog();
            Show();
        }
    }
}
