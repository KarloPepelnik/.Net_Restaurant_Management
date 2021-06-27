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
    public partial class FrmKreirajNoviMeni : Form
    {
        public FrmKreirajNoviMeni()
        {
            InitializeComponent();
        }

        private void FrmKreirajNoviMeni_Load(object sender, EventArgs e)
        {
            FillListBoxes();
        }

        private void FillListBoxes()
        {
            using (var context = new Entities())
            {
                var queryPredjela = from j in context.Jelo
                            where j.Kategorija.naziv_kategorije == "Predjelo"
                            select j.naziv_jela;

                listBoxPredjela.DataSource = queryPredjela.ToList();
                

                var queryGlJela = from j in context.Jelo
                                  where j.Kategorija.naziv_kategorije == "Glavno jelo"
                                  select j.naziv_jela;

                listBoxGlavnaJela.DataSource = queryGlJela.ToList();

                var queryDesert = from j in context.Jelo
                                  where j.Kategorija.naziv_kategorije == "Desert"
                                  select j.naziv_jela;

                listBoxDeserti.DataSource = queryDesert.ToList();
            }
        }

        private void btnOdaberiPredjelo_Click(object sender, EventArgs e)
        {
            txtBoxOdabranoPredjelo.Text = listBoxPredjela.SelectedItem.ToString();
            RefreshMenuPrice();
        }

        private void RefreshMenuPrice()
        {
            double menuPrice = 0;
            double predjeloPrice = 0;
            double glJeloPrice = 0;
            double desertPrice = 0;

            if (listBoxPredjela.SelectedItem != null)
            {
                string selectedPredjeloNaziv = listBoxPredjela.SelectedItem.ToString();
                using (var context = new Entities())
                {
                    var queryPredjeloPrice = from j in context.Jelo
                                             where j.naziv_jela == selectedPredjeloNaziv
                                             select j;
                    Jelo selectedPredjelo = queryPredjeloPrice.Single();
                    predjeloPrice = selectedPredjelo.cijena;
                }
                
            }

            if (listBoxGlavnaJela.SelectedItem != null)
            {
                string selectedGlavnoJeloNaziv = listBoxGlavnaJela.SelectedItem.ToString();
                using (var context = new Entities())
                {
                    var queryGlavnoJelo = from j in context.Jelo
                                          where j.naziv_jela == selectedGlavnoJeloNaziv
                                          select j;
                    Jelo selectedGlavnoJelo = queryGlavnoJelo.Single();
                    glJeloPrice = selectedGlavnoJelo.cijena;
                }
            }
            if (listBoxDeserti.SelectedItem != null)
            {
                string selectedDesertNaziv = listBoxDeserti.SelectedItem.ToString();
                using (var context = new Entities())
                {
                    var queryDesert = from j in context.Jelo
                                          where j.naziv_jela == selectedDesertNaziv
                                          select j;
                    Jelo selectedDesert = queryDesert.Single();
                    desertPrice = selectedDesert.cijena;
                }
            }
            
            menuPrice = predjeloPrice + glJeloPrice + desertPrice;
            txtBoxCijenaMenija.Text = menuPrice.ToString() + " HRK";

        }

        private void btnOdaberiGlJelo_Click(object sender, EventArgs e)
        {
            txtBoxOdabranoGlavnoJelo.Text = listBoxGlavnaJela.SelectedItem.ToString();
            RefreshMenuPrice();
        }

        private void btnOdaberiDesert_Click(object sender, EventArgs e)
        {
            txtBoxOdabraniDesert.Text = listBoxDeserti.SelectedItem.ToString();
            RefreshMenuPrice();
        }

        private void dtpVazeciDatumMenija_ValueChanged(object sender, EventArgs e)
        {
            txtBoxDatumMenija.Text = dtpVazeciDatumMenija.Value.Date.ToString();
        }

        private void btnKreirajMeni_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                string nazivMenija = txtBoxNazivMenija.Text;
                DateTime datumMenija = dtpVazeciDatumMenija.Value;

                Meni newMeni = new Meni()
                {
                    naziv = nazivMenija,
                    datum = datumMenija
                };
                
                context.Meni.Add(newMeni);
                context.SaveChanges();

                string predjeloNaziv = listBoxPredjela.SelectedItem.ToString();


                var queryPredjeloId = from j in context.Jelo
                                      where j.naziv_jela == predjeloNaziv
                                      select j;
                Jelo predjelo = queryPredjeloId.Single();
                int predjeloId = predjelo.id_jelo;
                Na_meniju na_MenijuPredjelo = new Na_meniju()
                {
                    id_meni = newMeni.id_meni,
                    id_jelo = predjeloId
                };
                context.Na_meniju.Add(na_MenijuPredjelo);
                context.SaveChanges();

                string glavnoJeloNaziv = listBoxGlavnaJela.SelectedItem.ToString();
                
                var queryGlJeloId = from j in context.Jelo
                                    where j.naziv_jela == glavnoJeloNaziv
                                    select j;
                Jelo glavnoJelo = queryGlJeloId.Single();
                int glavnoJeloId = glavnoJelo.id_jelo;

                Na_meniju na_MenijuGlavnoJelo = new Na_meniju()
                {
                    id_meni = newMeni.id_meni,
                    id_jelo = glavnoJeloId
                };
                context.Na_meniju.Add(na_MenijuGlavnoJelo);
                context.SaveChanges();

                string desertNaziv = listBoxDeserti.SelectedItem.ToString();
                var queryDesertId = from j in context.Jelo
                                    where j.naziv_jela == desertNaziv
                                    select j;
                Jelo desert = queryDesertId.Single();
                int desertId = desert.id_jelo;

                Na_meniju na_MenijuDesert = new Na_meniju()
                {
                    id_meni = newMeni.id_meni,
                    id_jelo = desertId
                };
                context.Na_meniju.Add(na_MenijuDesert);
                context.SaveChanges();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
