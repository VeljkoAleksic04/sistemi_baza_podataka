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
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId(); if (id == null) return; 
            using var form = new IzmeniNaucniRadForm(id: id.Value);
            form.ShowDialog();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (id == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani zapis?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var red = dataGridView.SelectedRows[(int)id];
                NaucniRad nrZaBrisanje = new NaucniRad
                {
                    Id = int.Parse(red.Cells[0].Value.ToString()),
                    Naslov = red.Cells[1].Value.ToString(),
                    DOI = red.Cells[2].Value.ToString(),
                    TipRada = red.Cells[3].Value.ToString(),
                    Stranice = red.Cells[4].Value.ToString(),
                    IdIzvora = int.Parse(red.Cells[5].Value.ToString())
                };
                
                
            }
        }

        private void NaucniRadoviForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            dataGridView.Rows.Clear();
            dataGridView.DataSource = DTOManager.VratiNaucneRadove();
        }

        private void btnIzvor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dodati prikaz podataka o izvoru preko messageboxa");
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int? idIzvora = GetSelectedId();

            if (idIzvora == null)
                MessageBox.Show("Celija nije dobro selektovana", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var izvor = DTOManager.VratiIzvorPoId(idIzvora);

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
    }
}
