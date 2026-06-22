using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class PoglavljaUKnjiziForm : Form
    {

        public PoglavljaUKnjiziForm()
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
            DodajPoglavljeUKnjiziForm form = new DodajPoglavljeUKnjiziForm();
            if (form.ShowDialog() == DialogResult.OK) popuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (id != null)
            {
                IzmeniPoglavljeUKnjiziForm form = new IzmeniPoglavljeUKnjiziForm((int)id);
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
                DTOManager.obrisiPoglavljeUKnjizi((int)id);
                MessageBox.Show("Uspesno obrisano poglavlje u knjizi!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                popuniPodacima();
            }
        }
        private void btnExtra_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new UredniciPoglavljaForm(id.Value);
            form.ShowDialog();
        }

        private void PoglavljaUKnjiziForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            dataGridView.Rows.Clear();

            IList<PoglavljeUKnjiziPregled> podaci = DTOManager.vratiSvePoglavljaUKnjizi();

            if (podaci != null)
            {
                foreach (PoglavljeUKnjiziPregled p in podaci)
                {
                    dataGridView.Rows.Add(p.Id, p.Naslov, p.Izdavac, p.MestoIzdanja);
                }

                dataGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Nisu pronadjena poglavlja u knjizi!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
