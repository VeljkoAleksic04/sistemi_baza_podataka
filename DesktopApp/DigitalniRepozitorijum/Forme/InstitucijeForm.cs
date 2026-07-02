using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class InstitucijeForm : Form
    {

        public InstitucijeForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi, btnKontaktTelefoni, btnKontaktMailovi, btnNaucneOblasti, btnZaposleni);
        }

        public void PopuniPodacima()
        {
            dataGridView.Rows.Clear();
            List<InstitucijaPregled> podaci = DTOManager.vratiSveInstitucije();

            foreach (InstitucijaPregled p in podaci)
                dataGridView.Rows.Add(p.Id, p.Naziv, p.Adresa);

            dataGridView.Refresh();
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
            using var form = new DodajInstitucijuForm();
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return;
            using var form = new IzmeniInstitucijuForm(id: id.Value);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiInstituciju(id.Value);
                PopuniPodacima();
            }
        }
        private void btnKontaktTelefoni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new KontaktTelefoniInstitucijeForm(id.Value);
            form.ShowDialog();
        }
        private void btnKontaktMailovi_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new KontaktMailoviInstitucijeForm(id.Value);
            form.ShowDialog();
        }
        private void btnNaucneOblasti_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new NaucneOblastiInstitucijeForm(id.Value);
            form.ShowDialog();
        }
        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new ZaposleniIstrazivaciForm(id.Value);
            form.ShowDialog();
        }

        private void InstitucijeForm_Load_1(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
    }
}
