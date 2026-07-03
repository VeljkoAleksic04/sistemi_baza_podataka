using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class AngazovanjaIstrazivacaForm : Form
    {
        private readonly int? _idIstrazivaca;

        public AngazovanjaIstrazivacaForm(int? idIstrazivaca = null)
        {
            _idIstrazivaca = idIstrazivaca;
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi);
        }

        private void AngazovanjaIstrazivacaForm_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            dataGridView.Rows.Clear();

            if (_idIstrazivaca == null) return;

            List<AngazovanjePregled> podaci = DTOManager.vratiSveAngazovanjaIstrazivaca(_idIstrazivaca.Value);

            foreach (var p in podaci)
                dataGridView.Rows.Add(p.IdInstitucije, p.NazivInstitucije, p.NazivPozicije, p.DatumPocetka.ToShortDateString());

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
            using var form = new DodajAngazovanjeForm(_idIstrazivaca);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var idInstitucije = GetSelectedId(); if (idInstitucije == null) return;
            using var form = new IzmeniAngazovanjeForm(_idIstrazivaca, idInstitucije);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            var idInstitucije = GetSelectedId(); if (idInstitucije == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiAngazovanje(idInstitucije.Value, _idIstrazivaca.Value);
                PopuniPodacima();
            }
        }

        private void AngazovanjaIstrazivacaForm_Load_1(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
    }
}
