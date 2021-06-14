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
    public partial class FrmUpravljanjeZalihamaAdminFeatures : Form
    {
        public FrmUpravljanjeZalihamaAdminFeatures()
        {
            InitializeComponent();
        }

        private void FrmUpravljanjeZalihamaAdminFeatures_Load(object sender, EventArgs e)
        {
            FillCmbNamirnica();
            txtBoxTrenutnoPrikazano.ReadOnly = true;
        }

        private void FillCmbNamirnica()
        {
            List<Namirnica> namirnice;

            using (var context = new Entities())
            {
                namirnice = context.Namirnica.ToList();
            }
            cmbBoxFilterNamirnica.DataSource = namirnice;
        }

        private void btnShowAllPrimke_Click(object sender, EventArgs e)
        {
            ShowAllPrimke();
        }

        private void ShowAllPrimke()
        {
            using (var context = new Entities())
            {
                var query = from p in context.Primka
                            select new { p.id_primka, p.Namirnica.naziv_namirnice, p.kolicina, p.Mjerna_jedinica.oznaka_mjerne_jedinice, p.datum_vrijeme };

                dgvAdminPrimkaIzdatnica.DataSource = query.ToList();
                DgvEdit();

            }

            txtBoxTrenutnoPrikazano.Text = "Primke";
        }

        private void DgvEdit()
        {
            dgvAdminPrimkaIzdatnica.Columns[0].Visible = false;
            dgvAdminPrimkaIzdatnica.Columns[1].HeaderText = "Naziv namirnice:";
            dgvAdminPrimkaIzdatnica.Columns[2].HeaderText = "Kolicina:";
            dgvAdminPrimkaIzdatnica.Columns[3].HeaderText = "Mjerna jedinica:";
            dgvAdminPrimkaIzdatnica.Columns[4].HeaderText = "Datum:";
        }

        private void btnShowAllIzdatnice_Click(object sender, EventArgs e)
        {
            ShowAllIzdatnice();
        }

        private void ShowAllIzdatnice()
        {
            using (var context = new Entities())
            {
                var query = from i in context.Izdatnica
                            select new { i.id_izdatnica, i.Namirnica.naziv_namirnice, i.kolicina, i.Mjerna_jedinica.oznaka_mjerne_jedinice, i.datum_vrijeme };

                dgvAdminPrimkaIzdatnica.DataSource = query.ToList();
                DgvEdit();
            }

            txtBoxTrenutnoPrikazano.Text = "Izdatnice";
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSortDatum_Click(object sender, EventArgs e)
        {
            if (txtBoxTrenutnoPrikazano.Text == "Primke")
            {
                using (var context = new Entities())
                {
                    var query = from p in context.Primka
                                orderby p.datum_vrijeme descending
                                select new { p.id_primka, p.Namirnica.naziv_namirnice, p.kolicina, p.Mjerna_jedinica.oznaka_mjerne_jedinice, p.datum_vrijeme };

                    dgvAdminPrimkaIzdatnica.DataSource = query.ToList();
                    DgvEdit();

                }
            }
            else
            {
                using (var context = new Entities())
                {
                    var query = from i in context.Izdatnica
                                orderby i.datum_vrijeme descending
                                select new { i.id_izdatnica, i.Namirnica.naziv_namirnice, i.kolicina, i.Mjerna_jedinica.oznaka_mjerne_jedinice, i.datum_vrijeme };

                    dgvAdminPrimkaIzdatnica.DataSource = query.ToList();
                    DgvEdit();
                }
            }
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            string trazenaNamirnica = cmbBoxFilterNamirnica.SelectedItem.ToString();

            if (txtBoxTrenutnoPrikazano.Text == "Primke")
            {
                using (var context = new Entities())
                {
                    var query = from p in context.Primka
                                where p.Namirnica.naziv_namirnice==trazenaNamirnica
                                select new { p.id_primka, p.Namirnica.naziv_namirnice, p.kolicina, p.Mjerna_jedinica.oznaka_mjerne_jedinice, p.datum_vrijeme };

                    dgvAdminPrimkaIzdatnica.DataSource = query.ToList();
                    DgvEdit();

                }
            }
            else
            {
                using (var context = new Entities())
                {
                    var query = from i in context.Izdatnica
                                where i.Namirnica.naziv_namirnice == trazenaNamirnica
                                select new { i.id_izdatnica, i.Namirnica.naziv_namirnice, i.kolicina, i.Mjerna_jedinica.oznaka_mjerne_jedinice, i.datum_vrijeme };

                    dgvAdminPrimkaIzdatnica.DataSource = query.ToList();
                    DgvEdit();
                }
            }
        }
        private Primka GetSelectedPrimka()
        {
            int primkaId = int.Parse(dgvAdminPrimkaIzdatnica.CurrentRow.Cells[0].Value.ToString());
            Primka selectedPrimka;

            using (var context = new Entities())
            {
                List<Primka> listaPrimka = context.Primka.ToList();

                selectedPrimka = listaPrimka.Find(x => x.id_primka == primkaId);
            }

            return selectedPrimka;

        }
        private Izdatnica GetSelectedIzdatnica()
        {
            int izdatnicaId = int.Parse(dgvAdminPrimkaIzdatnica.CurrentRow.Cells[0].Value.ToString());
            Izdatnica selectedIzdatnica;

            using (var context = new Entities())
            {
                List<Izdatnica> listaIzdatnica = context.Izdatnica.ToList();

                selectedIzdatnica = listaIzdatnica.Find(x => x.id_izdatnica == izdatnicaId);
            }

            return selectedIzdatnica;

        }
        private Namirnica GetSelectedNamirnicaFromPrimka()
        {
            int idNamirnica = GetSelectedPrimka().id_namirnica;
            List<Namirnica> namirnice;
            Namirnica wantedNamirnica;

            using (var context = new Entities())
            {
                namirnice = context.Namirnica.ToList();
            }
            wantedNamirnica = namirnice.Find(x => x.id_namirnica == idNamirnica);
            return wantedNamirnica;

        }
        private Namirnica GetSelectedNamirnicaFromIzdatnica()
        {
            int idNamirnica = GetSelectedIzdatnica().id_namirnica;
            List<Namirnica> namirnice;
            Namirnica wantedNamirnica;

            using (var context = new Entities())
            {
                namirnice = context.Namirnica.ToList();
            }
            wantedNamirnica = namirnice.Find(x => x.id_namirnica == idNamirnica);
            return wantedNamirnica;

        }
        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (txtBoxTrenutnoPrikazano.Text == "Primke")
            {
                Namirnica namirnicaEdit = GetSelectedNamirnicaFromPrimka();

                Primka trazenaPrimka = GetSelectedPrimka();

                using (var context = new Entities())
                {
                    context.Primka.Attach(trazenaPrimka);
                    context.Namirnica.Attach(namirnicaEdit);

                    if (trazenaPrimka != null)
                    {

                        namirnicaEdit.kolicina_trenutna -= trazenaPrimka.kolicina;
                        context.Primka.Remove(trazenaPrimka);

                        context.SaveChanges();

                        MessageBox.Show($"Primka izbrisana i količina {namirnicaEdit.naziv_namirnice} ažurirana!");
                    }

                    else
                    {
                        MessageBox.Show("Nije moguće izbrisati ovu primku");
                    }
                }
                ShowAllPrimke();
            }
            else
            {
                Izdatnica trazenaIzdatnica = GetSelectedIzdatnica();
                Namirnica trazenaNamirnica = GetSelectedNamirnicaFromIzdatnica();

                using (var context = new Entities())
                {
                    context.Namirnica.Attach(trazenaNamirnica);
                    context.Izdatnica.Attach(trazenaIzdatnica);

                    if (trazenaIzdatnica != null)
                    {
                        trazenaNamirnica.kolicina_trenutna += trazenaIzdatnica.kolicina;
                        context.Izdatnica.Remove(trazenaIzdatnica);
                        context.SaveChanges();
                        MessageBox.Show($"Izdatnica izbrisana i količina {trazenaNamirnica.naziv_namirnice} ažurirana!");
                    }

                    else
                    {
                        MessageBox.Show("Nije moguće izbrisati ovu primku");
                    }
                }
                ShowAllIzdatnice();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtBoxTrenutnoPrikazano.Text == "Primke")
            {
                FrmAzurirajPrimku form = new FrmAzurirajPrimku(GetSelectedPrimka());
                form.ShowDialog();

                ShowAllPrimke();
            }
            else
            {
                FrmAzurirajIzdatnicu frm = new FrmAzurirajIzdatnicu(GetSelectedIzdatnica());
                frm.ShowDialog();

                ShowAllIzdatnice();
            }
            
        }
    }
}
