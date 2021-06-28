using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class FrmSviMeniji : Form
    {
        public FrmSviMeniji()
        {
            InitializeComponent();
        }

        private void FrmSviMeniji_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void FillDGV()
        {
            using (var context = new Entities())
            {
                dgvMeniji.DataSource = context.Meni.ToList();
                dgvMeniji.Columns[0].Visible = false;
                dgvMeniji.Columns[4].Visible = false;
                dgvMeniji.Columns[1].HeaderText = "Naziv menija";
                dgvMeniji.Columns[2].HeaderText = "Datum menija";
                dgvMeniji.Columns[3].HeaderText = "Cijena menija";
                dgvMeniji.Columns[3].DefaultCellStyle.Format = "c";
            }        
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            Meni selectedMeni = GetSelectedMeni();
            using (var context = new Entities())
            {
                context.Meni.Attach(selectedMeni);
                context.Meni.Remove(selectedMeni);
                context.SaveChanges();
            }
            FillDGV();
        }

        private Meni GetSelectedMeni()
        {
            return dgvMeniji.CurrentRow.DataBoundItem as Meni;
        }

        private void dgvMeniji_SelectionChanged(object sender, EventArgs e)
        {
            int MeniId = GetSelectedMeni().id_meni;
            using (var context = new Entities())
            {
                var query = from n in context.Na_meniju
                            where n.id_meni == MeniId
                            select n.id_jelo;

                List<int> listaIdJela = query.ToList();
                if (listaIdJela.Count != 0)
                {
                    int idPredjelo = listaIdJela[0];
                    int idGlJelo = listaIdJela[1];
                    int idDesert = listaIdJela[2];

                    var idPredjeloQuery = (from j in context.Jelo
                                           where j.id_jelo == idPredjelo
                                           select new
                                           {
                                               j.naziv_jela
                                           }).FirstOrDefault();

                    txtBoxPredjelo.Text = idPredjeloQuery.naziv_jela;

                    var idGlavnoJeloQuery = (from j in context.Jelo
                                             where j.id_jelo == idGlJelo
                                             select new
                                             {
                                                 j.naziv_jela
                                             }).FirstOrDefault();

                    txtBoxGlavnoJelo.Text = idGlavnoJeloQuery.naziv_jela;

                    var idDesertQuery = (from j in context.Jelo
                                         where j.id_jelo == idDesert
                                         select new
                                         {
                                             j.naziv_jela
                                         }).FirstOrDefault();

                    txtBoxiDesert.Text = idDesertQuery.naziv_jela;
                }
                

               
            }
        }

        private void btnKreirajPDF_Click(object sender, EventArgs e)
        {
            FrmMenuReport frmMenuReport = new FrmMenuReport(GetSelectedMeni().id_meni);
            frmMenuReport.ShowDialog();
            

        }

        

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
