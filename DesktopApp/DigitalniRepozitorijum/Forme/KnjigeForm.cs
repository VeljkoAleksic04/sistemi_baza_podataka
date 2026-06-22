using Oracle.ManagedDataAccess.OpenTelemetry;
using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class KnjigeForm : Form
    {

        public KnjigeForm()
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
            DodajKnjiguForm form = new DodajKnjiguForm();
            if (form.ShowDialog() == DialogResult.OK) popuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (id != null)
            {
                IzmeniKnjiguForm form = new IzmeniKnjiguForm((int)id);
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
                DTOManager.obrisiKnjigu((int)id);
                MessageBox.Show("Uspesno obrisana knjiga!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                popuniPodacima();
            }
        }
        private void btnExtra_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new UredniciKnjigeForm(id.Value);
            form.ShowDialog();
        }

        private void KnjigeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            dataGridView.Rows.Clear();

            IList<KnjigaPregled> podaci = DTOManager.vratiSveKnjige();

            if (podaci != null)
            {
                foreach (KnjigaPregled p in podaci)
                {
                    dataGridView.Rows.Add(p.Id, p.Naslov, p.Izdavac, p.MestoIzdanja);
                }

                dataGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Nisu pronadjene knjige!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
