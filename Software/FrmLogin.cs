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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            Izbornik forma = new Izbornik();
            Hide();
            forma.ShowDialog();
            Show();
        }

        private void btnRegistrirajSe_Click(object sender, EventArgs e)
        {
            FrmRegistracija forma = new FrmRegistracija();
            Hide();
            forma.ShowDialog();
            Show();
        }
    }
}
