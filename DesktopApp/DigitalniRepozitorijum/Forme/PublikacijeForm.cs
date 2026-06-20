using DigitalniRepozitorijum.Entiteti;
using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class PublikacijeForm : Form
    {

        public PublikacijeForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi, btnAutori, btnVerzije, btnKljucneReci, btnCitati, btnPovezane, btnNaucniRadovi, btnKnjige, btnPoglavlja, btnDoktorske, btnDatasetovi, btnSoftverski, btnObrazovni, btnPrezentacije, btnTehnicki);
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
            using var form = new DodajPublikacijuForm();
            form.ShowDialog();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new IzmeniPublikacijuForm(id: id.Value);
            form.ShowDialog();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (GetSelectedId() == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Brisanje ce biti implementirano kroz NHibernate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAutori_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new AutoriPublikacijeForm(id.Value);
            form.ShowDialog();
        }
        private void btnVerzije_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new VerzijePublikacijeForm((int)id);
            form.ShowDialog();
        }
        private void btnKljucneReci_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new KljucneReciPublikacijeForm((int)id);
            form.ShowDialog();
        }
        private void btnCitati_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new CitatiPublikacijeForm(id.Value);
            form.ShowDialog();
        }
        private void btnPovezane_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; using var form = new PovezanePublikacijeForm(id.Value);
            form.ShowDialog();
        }
        private void btnNaucniRadovi_Click(object sender, EventArgs e)
        {
            using var form = new NaucniRadoviForm();
            form.ShowDialog();
        }
        private void btnKnjige_Click(object sender, EventArgs e)
        {
            using var form = new KnjigeForm();
            form.ShowDialog();
        }
        private void btnPoglavlja_Click(object sender, EventArgs e)
        {
            using var form = new PoglavljaUKnjiziForm();
            form.ShowDialog();
        }
        private void btnDoktorske_Click(object sender, EventArgs e)
        {
            using var form = new DoktorskeDisertacijeForm();
            form.ShowDialog();
        }
        private void btnDatasetovi_Click(object sender, EventArgs e)
        {
            using var form = new DatasetoviForm();
            form.ShowDialog();
        }
        private void btnSoftverski_Click(object sender, EventArgs e)
        {
            using var form = new SoftverskiArtefaktiForm();
            form.ShowDialog();
        }
        private void btnObrazovni_Click(object sender, EventArgs e)
        {
            using var form = new ObrazovniMaterijaliForm();
            form.ShowDialog();
        }
        private void btnPrezentacije_Click(object sender, EventArgs e)
        {
            using var form = new PrezentacijeForm();
            form.ShowDialog();
        }
        private void btnTehnicki_Click(object sender, EventArgs e)
        {
            using var form = new TehnickiIzvestajiForm();
            form.ShowDialog();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PublikacijeForm_Load(object sender, EventArgs e)
        {
            pupuniPodacima();
        }

        public void pupuniPodacima() 
        {
            dataGridView.Rows.Clear();

            List<PublikacijaPregled> podaci = DTOManager.vratiSvePublikacije();

            foreach(PublikacijaPregled p in podaci)
            {
                dataGridView.Rows.Add(p.Id, p.Naslov, p.Jezik, p.DatumObjavljivanja, p.Status, p.Vidljivost);
            }

            dataGridView.Refresh();
        }
    }
}
