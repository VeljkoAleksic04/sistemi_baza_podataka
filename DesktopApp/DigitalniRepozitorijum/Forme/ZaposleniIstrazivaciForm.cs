using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class ZaposleniIstrazivaciForm : Form
    {
        private readonly int? _idInstitucije;

        public ZaposleniIstrazivaciForm(int? idInstitucije = null)
        {
            _idInstitucije = idInstitucije;
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi);
        }

        public void PopuniPodacima()
        {
            dataGridView.Rows.Clear();

            if (_idInstitucije == null) return;

            List<AngazovanjePregled> podaci = DTOManager.vratiSveAngazovanjaInstitucije(_idInstitucije.Value);

            foreach (var p in podaci)
                dataGridView.Rows.Add(p.Id, p.ImeIstrazivaca.Split(" ")[0], p.ImeIstrazivaca.Split(" ")[1], p.TipAngazovanja, p.NazivPozicije, p.DatumPocetka.ToShortDateString());

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
            using var form = new DodajAngazovanjeInstitucijeForm(_idInstitucije);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var idAngazovanja = GetSelectedId(); if (idAngazovanja == null) return;
            using var form = new IzmeniAngazovanjeInstitucijeForm(idAngazovanja);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            var idAngazovanja = GetSelectedId(); if (idAngazovanja == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiAngazovanje(idAngazovanja.Value);
                PopuniPodacima();
            }
        }

        private void ZaposleniIstrazivaciForm_Load_1(object sender, EventArgs e)
        {
            PopuniPodacima();

        }
    }
}
