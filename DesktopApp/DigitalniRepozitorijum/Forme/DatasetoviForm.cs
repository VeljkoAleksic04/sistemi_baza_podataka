using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DatasetoviForm : Form
    {
        public DatasetoviForm()
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
            using var form = new DodajDatasetForm();
            form.ShowDialog();
            popuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id == null) return;
            using var form = new IzmeniDatasetForm(id: id.Value);
            form.ShowDialog();
            popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (id == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var status = DTOManager.ObrisiDataset(id);
                if (status)
                    MessageBox.Show("Uspesno je obrisan dataset!!!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Nije uspelo brisanje...", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                popuniPodacima();
            }
        }


        public void popuniPodacima()
        {
            dataGridView.Rows.Clear();
            List<DatasetPregled> podaci = DTOManager.VratiDataseteZaPrikaz();

            foreach (DatasetPregled p in podaci)
                dataGridView.Rows.Add(p.Id, p.Naslov, p.Format, p.BrojZapisa, p.Velicina);

            dataGridView.Refresh();
        }

        private void DatasetoviForm_Load_1(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
