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
    public partial class FrmPrikazSastojakaJela : Form
    {
        private Jelo jelo;
        public FrmPrikazSastojakaJela(Jelo selectedJelo)
        {
            InitializeComponent();
            jelo = selectedJelo;
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPrikazSastojakaJela_Load(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                var queryIngredients = from js in context.Jelo_sadrzi
                                       where js.id_jelo == jelo.id_jelo
                                       select new { js.Namirnica, js.kolicina};
                jelosadrziBindingSource.DataSource = queryIngredients.ToList();
                
                
            }
            
        }
    }
}
