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
    public partial class FrmDodajSastojkeJelu : Form
    {
        private Jelo jelo;
        public FrmDodajSastojkeJelu(Jelo selectedJelo)
        {
            InitializeComponent();
            jelo = selectedJelo;
        }

        private void FrmDodajSastojkeJelu_Load(object sender, EventArgs e)
        {
            FillListBox();
            FillDgv();
            FillTxtBox();
            RefreshButtons();
        }

        private void RefreshButtons()
        {
            if (txtBoxOdabranaNamirnica.Text == "" || txtBoxKolicina.Text == "")
            {
                btnDodajSastojak.Enabled = false;
            }
            else
            {
                btnDodajSastojak.Enabled = true;
            }
        }

        private void FillTxtBox()
        {
            txtBoxOdabranoJelo.Text = jelo.naziv_jela;
        }

        private void FillDgv()
        {
            using (var context = new Entities())
            {
                var queryIngredients = from js in context.Jelo_sadrzi
                                       where js.id_jelo == jelo.id_jelo
                                       select js;
                jelosadrziBindingSource.DataSource = queryIngredients.ToList();
            }
        }

        private void FillListBox()
        {
            using (var context = new Entities())
            {
                var queryNamirnica = from n in context.Namirnica
                                     select n.naziv_namirnice;
                List<string> namirnice = queryNamirnica.ToList();
                listBoxNamirnice.DataSource = namirnice;
            }
        }

        private void btnDodajSastojak_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                float kolicinaNamirnice = float.Parse(txtBoxKolicina.Text);
                string nazivNamirnice = listBoxNamirnice.SelectedItem.ToString();
                var queryNamirnicaSearch = from n in context.Namirnica
                                           where n.naziv_namirnice == nazivNamirnice
                                           select n;
                Namirnica selectedNamirnica = queryNamirnicaSearch.Single();

                Jelo_sadrzi sadrzi = new Jelo_sadrzi()
                {
                    id_jelo = jelo.id_jelo,
                    id_namirnica = selectedNamirnica.id_namirnica,
                    kolicina = kolicinaNamirnice
                };

                context.Jelo_sadrzi.Add(sadrzi);
                context.SaveChanges();

                FillDgv();
                txtBoxOdabranaNamirnica.Text = "";
                txtBoxKolicina.Text = "";
            }
        }

        private void btnOdaberiNamirnicu_Click(object sender, EventArgs e)
        {
            txtBoxOdabranaNamirnica.Text = listBoxNamirnice.SelectedItem.ToString();
        }

        private void txtBoxKolicina_TextChanged(object sender, EventArgs e)
        {
            RefreshButtons();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUrediKolicinu_Click(object sender, EventArgs e)
        {
            FrmUrediKolicinuSastojkaJela frmUrediKolicinuSastojkaJela = new FrmUrediKolicinuSastojkaJela(GetSelectedSastojak());
            frmUrediKolicinuSastojkaJela.ShowDialog();

            FillDgv();
        }


        private void btnIzbrisiSastojak_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                Jelo_sadrzi sastojak = GetSelectedSastojak();
                if (sastojak!=null)
                {
                    context.Jelo_sadrzi.Attach(sastojak);
                    context.Jelo_sadrzi.Remove(sastojak);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Nije označen nijedan sastojak!");
                }
                FillDgv();
            }
        }

        private Jelo_sadrzi GetSelectedSastojak()
        {
            return dgvSastojciJela.CurrentRow.DataBoundItem as Jelo_sadrzi;
        }
    }
}
