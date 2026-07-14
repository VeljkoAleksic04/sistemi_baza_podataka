using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IstrazivaciForm : Form
    {

        public IstrazivaciForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi, btnTelefoni, btnEmail, btnAngazovanja, btnPublikacije);
        }


        public void PopuniPodacima()
        {
            dataGridView.Rows.Clear();

            List<IstrazivacPregled> podaci = DTOManager.vratiSveIstrazivace();

            foreach (IstrazivacPregled p in podaci)
            {
                dataGridView.Rows.Add(p.Id, p.Ime, p.Prezime, p.Drzava, p.NaucnoZvanje, p.NaucnaOblast, p.StatusNaloga);
            }

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
            using var form = new DodajIstrazivacaForm();
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return;
            using var form = new IzmeniIstrazivacaForm(id: id.Value);
            if (form.ShowDialog() == DialogResult.OK)
                PopuniPodacima();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiIstrazivaca(id.Value);
                PopuniPodacima();
            }
        }
        private void btnTelefoni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new TelefoniIstrazivacaForm(id.Value);
            form.ShowDialog();
        }
        private void btnEmail_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new EmailAdreseIstrazivacaForm(id.Value);
            form.ShowDialog();
        }
        private void btnAngazovanja_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new AngazovanjaIstrazivacaForm(id.Value);
            form.ShowDialog();
        }
        private void btnPublikacije_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new PublikacijeAutoraForm(id.Value);
            form.ShowDialog();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void IstrazivaciForm_Load_2(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
    }
}
