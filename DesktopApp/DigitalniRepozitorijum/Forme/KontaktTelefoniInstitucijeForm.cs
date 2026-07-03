using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class KontaktTelefoniInstitucijeForm : Form
    {
        private readonly int? _idInstitucije;

        public KontaktTelefoniInstitucijeForm(int? idInstitucije = null)
        {
            _idInstitucije = idInstitucije;
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi);
        }


        public void PopuniPodacima()
        {
            dataGridView.Rows.Clear();

            if (_idInstitucije == null) return;

            List<InstitucijaKontaktTelPregled> podaci = DTOManager.vratiSveKontaktTelefone(_idInstitucije.Value);

            foreach (var p in podaci)
                dataGridView.Rows.Add(p.Id, p.KontaktTel);

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
            using var form = new DodajKontaktTelefonForm(_idInstitucije);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return;
            using var form = new IzmeniKontaktTelefonForm(_idInstitucije, id);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiKontaktTelefon(id.Value);
                PopuniPodacima();
            }
        }

        private void KontaktTelefoniInstitucijeForm_Load_1(object sender, EventArgs e)
        {
            PopuniPodacima();

        }
    }
}
