using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class NaucneOblastiInstitucijeForm : Form
    {
        private readonly int? _idInstitucije;

        public NaucneOblastiInstitucijeForm(int? idInstitucije = null)
        {
            _idInstitucije = idInstitucije;
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi);
        }


        public void PopuniPodacima()
        {
            dataGridView.Rows.Clear();

            if (_idInstitucije == null) return;

            List<InstitucijaNaucnaOblastPregled> podaci = DTOManager.vratiSveNaucneOblasti(_idInstitucije.Value);

            foreach (var p in podaci)
                dataGridView.Rows.Add(p.Id, p.NaucnaOblast);

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
            using var form = new DodajNaucnuOblastForm(_idInstitucije);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return;
            using var form = new IzmeniNaucnuOblastForm(_idInstitucije, id);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiNaucnuOblast(id.Value);
                PopuniPodacima();
            }
        }

        private void NaucneOblastiInstitucijeForm_Load_1(object sender, EventArgs e)
        {
            PopuniPodacima();

        }
    }
}
