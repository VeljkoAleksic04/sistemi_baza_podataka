using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class AutoriPublikacijeForm : Form
    {
        private readonly int? _idPublikacije;

        public AutoriPublikacijeForm(int? idPublikacije = null)
        {
            _idPublikacije = idPublikacije;
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi);
        }



        public void PopuniPodacima()
        {
            dataGridView.Rows.Clear();

            if (_idPublikacije == null) return;

            List<AutorstvoBasic> podaci = DTOManager.vratiSveAutorePublikacije(_idPublikacije.Value);

            foreach (var p in podaci)
                dataGridView.Rows.Add(p.Id, p.ImeAutora.Split(" ")[0], p.ImeAutora.Split(" ")[1], p.RedosledAutora, p.TipDoprinosa, p.Uloga);

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
            using var form = new DodajAutoraPublikacijeForm(_idPublikacije);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var idAutorstva = GetSelectedId(); if (idAutorstva == null) return;
            using var form = new IzmeniAutoraPublikacijeForm(idAutorstva);
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

        private void AutoriPublikacijeForm_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
    }
}
