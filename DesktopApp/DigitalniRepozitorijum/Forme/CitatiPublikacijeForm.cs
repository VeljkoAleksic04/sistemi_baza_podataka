using DigitalniRepozitorijum.Entiteti;
using NHibernate;
using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class CitatiPublikacijeForm : Form
    {
        private readonly int? _idPublikacije;
        private int? _idPubCitat;

        public CitatiPublikacijeForm(int? idPublikacije = null)
        {
            _idPublikacije = idPublikacije;
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi);
        }

        private int? GetSelectedId()
        {
            if (dataGridView.SelectedRows.Count != 0)
                return Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);

            return null;
        }

        private int? GetSelectedIdCitata()
        {
            if (dataGridView.SelectedRows.Count != 0)
                return Convert.ToInt32(dataGridView.SelectedRows[0].Cells[1].Value);

            return null;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using var form = new DodajCitatForm(_idPublikacije, _idPubCitat); // Id Publikacije koja citira i Id citiranje publikacije
            form.ShowDialog();
            popuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id == null) return;
            using var form = new IzmeniCitatForm(_idPublikacije, id, GetSelectedIdCitata());
            form.ShowDialog();
            popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (id == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var status = DTOManager.ObrisiCitat(id);
                if (status)
                    MessageBox.Show("Uspesno je obrisan citat!!!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Nije uspelo brisanje...", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                popuniPodacima();
            }
        }


        public void popuniPodacima()
        {
            dataGridView.Rows.Clear();

            List<CitatBasic> podaci = DTOManager.VratiCitatePoPublikaciji((int)_idPublikacije).ToList();

            foreach (CitatBasic p in podaci)
            {
                dataGridView.Rows.Add(p.Id, p.PubCitirana.Id, p.TekstualniKontekst, p.TipCitata, p.MestoCitiranja);
            }

            dataGridView.Refresh();
        }
        private void CitatiPublikacijeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            _idPubCitat = GetSelectedIdCitata();
        }
    }
}
