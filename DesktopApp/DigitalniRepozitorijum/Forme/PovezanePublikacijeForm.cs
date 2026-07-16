using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class PovezanePublikacijeForm : Form
    {
        private readonly int? _idPublikacije;

        public PovezanePublikacijeForm(int? idPublikacije = null)
        {
            _idPublikacije = idPublikacije;
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi);
        }

        private int? GetSelectedId()
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite red iz tabele.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using var form = new DodajPovezanuPublikacijuForm(_idPublikacije);
            form.ShowDialog();

            PopuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new IzmeniPovezanuPublikacijuForm((int)dataGridView.SelectedRows[0].Cells[0].Value);
            form.ShowDialog();

            PopuniPodacima();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (GetSelectedId() == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DTOManager.ObrisiPovezanuPublikaciju(GetSelectedId().Value);
            }

            PopuniPodacima();
        }

        private void PopuniPodacima()
        {
            dataGridView.Rows.Clear();

            List<PovezanSaPregled> podaci = DTOManager.VratiPovezanePublikacije((int)_idPublikacije);

            foreach (PovezanSaPregled p in podaci)
            {
                dataGridView.Rows.Add(p.Id, p.IdPublikacije2, p.Naslov, p.TipPovezanosti);
            }

            dataGridView.Refresh();
        }

        private void PovezanePublikacijeForm_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
