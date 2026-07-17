using System;
using System.Windows.Forms;
using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Utils;

namespace DigitalniRepozitorijum.Forme
{
    public partial class NaucniRadoviForm : Form
    {

        public NaucniRadoviForm()
        {
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
            using var form = new DodajNaucniRadForm();
            form.ShowDialog();
            popuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString()); if (id == null) return;
            using var form = new IzmeniNaucniRadForm(id);
            form.ShowDialog();
            popuniPodacima();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (id == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var status = DTOManager.ObrisiNaucniRad(id);
                if (status)
                    MessageBox.Show("Uspesno je obrisan naucni rad!!!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Nije supelo brisanje...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                popuniPodacima();
            }
        }

        private void NaucniRadoviForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            dataGridView.Rows.Clear();
            List<NaucniRadPregled> podaci = DTOManager.VratiNaucneRadoveZaPrikaz();

            foreach (NaucniRadPregled p in podaci)
                dataGridView.Rows.Add(p.Id, p.Naslov, p.DOI, p.TipRada, p.Stranice, p.Izvor);

            dataGridView.Refresh();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int? idPublikacije = GetSelectedId();

            if (idPublikacije == null)
                MessageBox.Show("Celija nije dobro selektovana", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var izvor = DTOManager.VratiIzvorPoId(idPublikacije);

            string zapis = "";

            if (izvor is Casopis)
            {
                zapis = $"[{izvor.Id}]\n" +
                    $"Naziv: ${(izvor as Casopis).Naziv}\n" +
                    $"Broj izdanja: {(izvor as Casopis).BrojIzdanja}\n" +
                    $"Broj sveske: {(izvor as Casopis).BrojSveske}\n" +
                    $"ISSN: {(izvor as Casopis).ISSN}\n";
            }
            else
            {
                zapis = $"[{izvor.Id}]\n" +
                        $"Naziv: ${(izvor as Konferencija).Naziv}\n" +
                        $"Broj izdanja: {(izvor as Konferencija).ISBN}\n";
            }

            richTextBox1.Text = zapis;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}
