using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class ObrazovniMaterijaliForm : Form
    {

        public ObrazovniMaterijaliForm()
        {
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
            using var form = new DodajObrazovniMaterijalForm();
            form.ShowDialog();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new IzmeniObrazovniMaterijalForm(id: id.Value);
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
