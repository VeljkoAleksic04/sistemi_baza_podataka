using DigitalniRepozitorijum.Entiteti;
using NHibernate;
using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class PodrzanePlatformeForm : Form
    {
        private readonly int? _idPublikacije;

        public PodrzanePlatformeForm(int? idPublikacije = null)
        {
            _idPublikacije = idPublikacije;
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi);
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
            using var form = new DodajPodrzanuPlatformuForm(_idPublikacije);
            form.ShowDialog();
            popuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new IzmeniPodrzanuPlatformuForm((int)dataGridView.SelectedRows[0].Cells[0].Value);
            form.ShowDialog();
            popuniPodacima();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (GetSelectedId() == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DTOManager.ObrisiPodrzanuPlatformu((int)GetSelectedId());
                MessageBox.Show("Uspesno je obrisana podrzana platforma!!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                popuniPodacima();
            }
        }

        private void PodrzanePlatformeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            dataGridView.Rows.Clear();

            ISession session = DataLayer.GetSession();
            var sa = session.QueryOver<SoftverskiArtefaktPodrzanePlatforme>().List();
            foreach(var sa1 in sa)
            {
                dataGridView.Rows.Add(sa1.Id, sa1.PodrzanaPlatforma);
            }

            dataGridView.Refresh();
        }



    }
}
