﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProgramskoIntenjerstvo
{
    public partial class FrmKorisnici : Form
    {
        public FrmKorisnici()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmKorisnici_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            using (var context = new Entities())
            {
                var query = from k in context.Korisnik
                            select k;

                List<Korisnik> sviKorisnici = query.ToList();

                dgvKorisnici.DataSource = sviKorisnici;
                dgvKorisnici.Columns["dostava"].Visible = false;
                dgvKorisnici.Columns["rezervacija"].Visible = false;
                dgvKorisnici.Columns["Tip_korisnika"].Visible = false;
                dgvKorisnici.Columns["Narudzba"].Visible = false;
                dgvKorisnici.Columns["racun"].Visible = false;
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Korisnik selektirani = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
            List<Rezervacija> odabrana = null;

            using (var context = new Entities())
            {
                var query = from r in context.Rezervacija
                            where r.id_korisnik == selektirani.id_korisnik
                            select r;
                odabrana = query.ToList();
            }

            if(odabrana.Count == 0)
            {

                using (var context = new Entities())
                {
                    context.Korisnik.Attach(selektirani);

                    context.Korisnik.Remove(selektirani);
                    context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Korisnik povezan sa rezervacijom!");
            }
            RefreshGUI();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            Korisnik selektirani = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
            FrmEditKorisnika forma = new FrmEditKorisnika(selektirani);
            forma.ShowDialog();
            RefreshGUI();
        }

        private void FrmKorisnici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, "RestoranApp.chm", HelpNavigator.Topic, "Korisnici/index.html");
            }
        }
    }
}
