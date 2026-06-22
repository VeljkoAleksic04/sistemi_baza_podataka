using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class PrezentacijeForm : Form
    {

        public PrezentacijeForm()
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
            DodajPrezentacijuForm form = new DodajPrezentacijuForm();
            if (form.ShowDialog() == DialogResult.OK) popuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (id != null)
            {
                IzmeniPrezentacijuForm form = new IzmeniPrezentacijuForm((int)id);
                if (form.ShowDialog() == DialogResult.OK) popuniPodacima();
            }
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (id == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiPrezentaciju((int)id);
                MessageBox.Show("Uspesno obrisana prezentacija!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                popuniPodacima();
            }
        }

        private void PrezentacijeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            dataGridView.Rows.Clear();

            IList<PrezentacijaPregled> podaci = DTOManager.vratiSvePrezentacije();

            if (podaci != null)
            {
                foreach (PrezentacijaPregled p in podaci)
                {
                    dataGridView.Rows.Add(p.Id, p.Naslov, p.DatumObjavljivanja);
                }

                dataGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Nisu pronadjene prezentacije!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
