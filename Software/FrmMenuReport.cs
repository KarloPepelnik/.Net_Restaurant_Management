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
    public partial class FrmMenuReport : Form
    {
        private int idMeni;
        public FrmMenuReport(int selectedMeniId)
        {
            InitializeComponent();
            idMeni = selectedMeniId;
        }

        private void FrmMenuReport_Load(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                var queryMenu = from m in context.Meni
                            where m.id_meni == idMeni
                            select m;

                Meni meni = queryMenu.Single();
                MeniBindingSource.DataSource = meni;

                var queryMeals = from n in context.Na_meniju
                                 from j in context.Jelo
                                 where n.id_meni == idMeni && n.id_jelo == j.id_jelo
                                 select j;
                List<Jelo> jela = queryMeals.ToList();
                JeloBindingSource.DataSource = jela;

                

            }
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }


    }
}
