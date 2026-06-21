using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class FajloviVerzijeForm : Form
    {
        private readonly int _idVerzije;

        public FajloviVerzijeForm(int idVer)
        {
            _idVerzije = idVer;
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FajloviVerzijeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            dataGridView.Rows.Clear();

            IList<FajlBasic> podaci = DTOManager.vratiVerziju(_idVerzije).Fajlovi;

            foreach (FajlBasic p in podaci)
            {
                dataGridView.Rows.Add(p.Id, p.Putanja);
            }

            dataGridView.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajFajlForm form = new DodajFajlForm(_idVerzije);
            if (form.ShowDialog() == DialogResult.OK) popuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id != null)
            {
                IzmeniFajlForm form = new IzmeniFajlForm((int)id);
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
                DTOManager.obrisiFajl((int)id);
                MessageBox.Show("Uspesno obrisan fajl!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                popuniPodacima();
            }
        }
    }
}
