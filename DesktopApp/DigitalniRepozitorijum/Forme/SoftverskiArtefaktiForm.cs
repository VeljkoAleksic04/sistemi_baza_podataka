using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class SoftverskiArtefaktiForm : Form
    {
        public SoftverskiArtefaktiForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi, btnExtra);
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
            using var form = new DodajSoftverskiArtefaktForm();
            form.ShowDialog();
            popuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id == null) return;
            using var form = new IzmeniSoftverskiArtefaktForm(id: id.Value);
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
                var status = DTOManager.ObrisiSoftverskiArtefakt(id);
                if (status)
                    MessageBox.Show("Uspesno je obrisan softverski artefakt!!!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Nije uspelo brisanje...", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                popuniPodacima();
            }
        }

        private void btnExtra_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id == null) return;
            using var form = new PodrzanePlatformeForm(id.Value);
            form.ShowDialog();
        }

        public void popuniPodacima()
        {
            dataGridView.Rows.Clear();

            List<SoftverskiArtefaktPregled> podaci = DTOManager.VratiSoftverskiArtefakteZaPrikaz();

            foreach (SoftverskiArtefaktPregled p in podaci)
            {
                dataGridView.Rows.Add(p.Id, p.Naslov, p.ProgramskiJezik, p.LinkKaRepozitorijumu);
            }

            dataGridView.Refresh();
        }

        private void SoftverskiArtefaktiForm_Load_1(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
