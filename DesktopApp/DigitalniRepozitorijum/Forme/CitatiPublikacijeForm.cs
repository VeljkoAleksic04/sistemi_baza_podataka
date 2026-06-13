using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class CitatiPublikacijeForm : Form
    {
        private readonly int? _idPublikacije;

        public CitatiPublikacijeForm(int? idPublikacije = null)
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
            using var form = new DodajCitatForm(_idPublikacije);
            form.ShowDialog();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new IzmeniCitatForm(_idPublikacije);
            form.ShowDialog();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (GetSelectedId() == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Brisanje ce biti implementirano kroz NHibernate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
