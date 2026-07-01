using DigitalniRepozitorijum.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class RecenzentiForm : Form
    {
        public RecenzentiForm()
        {
            InitializeComponent();
        }

        private void RecenzentiForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            try
            {
                dataGridView.DataSource = null;

                ISession sesija = DataLayer.GetSession();
                var recenzenti = sesija.Query<Istrazivac>().Where(i => i.JeRecenzent == true).ToList();

                List<dynamic> prikazRecenzenata = new List<dynamic>();
                foreach (var recenzent in recenzenti)
                {
                    prikazRecenzenata.Add(new
                    {
                        Id = recenzent.Id,
                        Recenzent = $"{recenzent.Ime} {recenzent.Prezime}",
                        Preporuka = ""
                    });
                }

                dataGridView.DataSource = prikazRecenzenata;
                sesija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska: {ex.Message}", "Greska pri ucitavanju recenzenata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? GetSelectedId()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                return (int)dataGridView.SelectedRows[0].Cells["colId"].Value;
            }
            return null;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajRecenzentaForm forma = new DodajRecenzentaForm();
            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (id == null)
            {
                MessageBox.Show("Molimo, odaberite recenzenta za izmenu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IzmeniRecenzentaForm forma = new IzmeniRecenzentaForm(id.Value);
            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (id == null)
            {
                MessageBox.Show("Molimo, odaberite recenzenta za brisanje", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Da li ste sigurni da zelite da obrisete ovog recenzenta?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ISession sesija = DataLayer.GetSession();
                    Istrazivac recenzent = sesija.Get<Istrazivac>(id);
                    if (recenzent != null)
                    {
                        recenzent.JeRecenzent = false;
                        sesija.SaveOrUpdate(recenzent);
                        sesija.Flush();
                        sesija.Close();
                    }
                    popuniPodacima();
                    MessageBox.Show("Recenzent je uspesno obrisan", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greska: {ex.Message}", "Greska pri brisanju", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNizOcena_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ova funkcionalnost će biti dostupna u budućoj verziji", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
