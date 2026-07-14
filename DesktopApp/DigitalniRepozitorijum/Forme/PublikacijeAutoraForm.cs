using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class PublikacijeAutoraForm : Form
    {
        private readonly int? _idAutora;

        public PublikacijeAutoraForm(int? idAutora = null)
        {
            _idAutora = idAutora;
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi);
        }


        public void PopuniPodacima()
        {
            dataGridView.Rows.Clear();

            if (_idAutora == null) return;

            List<AutorstvoBasic> podaci = DTOManager.vratiSvePublikacijeAutora(_idAutora.Value);

            foreach (var p in podaci)
                dataGridView.Rows.Add(p.Id, p.NaslovPublikacije, p.RedosledAutora, p.TipDoprinosa, p.Uloga);

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
            using var form = new DodajAutorstvoForm(_idAutora);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var idAutorstva = GetSelectedId(); if (idAutorstva == null) return;
            using var form = new IzmeniAutorstvoForm(idAutorstva);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            var idAutorstva = GetSelectedId(); if (idAutorstva == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiAutorstvo(idAutorstva.Value);
                PopuniPodacima();
            }
        }

        private void PublikacijeAutoraForm_Load_1(object sender, EventArgs e)
        {
            PopuniPodacima();

        }
    }
}
