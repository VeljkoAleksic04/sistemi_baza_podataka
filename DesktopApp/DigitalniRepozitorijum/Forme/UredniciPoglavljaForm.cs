using DigitalniRepozitorijum.Entiteti;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class UredniciPoglavljaForm : Form
    {
        private int _idPoglavlja;

        public UredniciPoglavljaForm(int idPoglavlja = 0)
        {
            InitializeComponent();
            _idPoglavlja = idPoglavlja;
        }

        private void UredniciPoglavljaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            try
            {
                dataGridViewUrednici.DataSource = null;

                var urednici = DTOManager.VratiUrednikePoglavlja(_idPoglavlja);

                colId.DataPropertyName = "Id";
                colIdPublikacije.DataPropertyName = "IdPublikacije";
                colUrednik.DataPropertyName = "Urednik";

                List<dynamic> prikazUrednika = new List<dynamic>();
                foreach (var urednik in urednici)
                {
                    prikazUrednika.Add(new
                    {
                        Id = urednik.Id,
                        IdPublikacije = urednik.PoglavljeUKnjizi?.Id ?? _idPoglavlja,
                        Urednik = urednik.Urednik
                    });
                }

                dataGridViewUrednici.DataSource = prikazUrednika;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska: {ex.Message}", "Greska pri ucitavanju urednika", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? GetSelectedId()
        {
            if (dataGridViewUrednici.SelectedRows.Count > 0)
            {
                return (int)dataGridViewUrednici.SelectedRows[0].Cells[0].Value;
            }
            return null;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajUrednikaPoglavljaForm forma = new DodajUrednikaPoglavljaForm(_idPoglavlja);
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
                MessageBox.Show("Molimo, odaberite urednika za izmenu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IzmeniUrednikaPoglavljaForm forma = new IzmeniUrednikaPoglavljaForm(id.Value);
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
                MessageBox.Show("Molimo, odaberite urednika za brisanje", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Da li ste sigurni da zelite da obrisete ovog urednika?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DTOManager.ObrisiUrednikaPoglavlja(id);
                    popuniPodacima();
                    MessageBox.Show("Urednik je uspesno obrisan", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greska: {ex.Message}", "Greska pri brisanju", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
