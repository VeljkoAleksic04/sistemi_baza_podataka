using DigitalniRepozitorijum.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class RecenzentiForm : Form
    {
        private int _idRundeRecenzije;
        public RecenzentiForm(int idRundeRecenzije)
        {
            InitializeComponent();
            _idRundeRecenzije = idRundeRecenzije;
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
                var rundaRecenzije = sesija.Get<RundaRecenzije>(_idRundeRecenzije);

                var recenzije = rundaRecenzije.Recenzije;

                List<dynamic> prikazRecenzenata = new List<dynamic>();
                foreach (var recenzija in recenzije)
                {
                    var runda = sesija.Get<RundaRecenzije>(_idRundeRecenzije);
                    prikazRecenzenata.Add(new
                    {
                        Id = recenzija.Recenzent!.Id,
                        Recenzent = $"{recenzija.Recenzent!.Ime} {recenzija.Recenzent.Prezime}",
                        Preporuka = recenzija.Preporuka ?? "N/A"
                    });
                }

                dataGridView.Rows.Clear();

                foreach(var row in prikazRecenzenata)
                {
                    dataGridView.Rows.Add(row.Id, row.Recenzent, row.Preporuka);
                }

                dataGridView.Refresh();


                sesija.Close();
            }
            catch (Exception ex)
            {
                var poruka = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show($"Greska: {poruka}\n\nStack: {ex.InnerException?.StackTrace}",
                    "Greska pri ucitavanju recenzenata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var forma = new NizOcenaForm(_idRundeRecenzije, (int)GetSelectedId());
            forma.ShowDialog();
        }
    }
}
