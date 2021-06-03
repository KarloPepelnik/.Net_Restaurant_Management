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
    public partial class RacunIzdan : Form
    {
        public RacunIzdan()
        {
            InitializeComponent();
        }

        private void RacunIzdan_Load(object sender, EventArgs e)
        {

        }

        private void zatvoriBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
