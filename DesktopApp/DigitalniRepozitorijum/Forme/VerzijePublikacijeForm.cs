using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class VerzijePublikacijeForm : Form
    {
        private readonly int _idPublikacije;

        public VerzijePublikacijeForm(int idPublikacije)
        {
            _idPublikacije = idPublikacije;
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi, btnFajlovi);
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
            DodajVerzijuForm form = new DodajVerzijuForm(_idPublikacije);
            if (form.ShowDialog() == DialogResult.OK) popuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id != null)
            {
                IzmeniVerzijuForm form = new IzmeniVerzijuForm(_idPublikacije, (int)id);
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
                DTOManager.obrisiVerziju((int)id);
                MessageBox.Show("Uspesno obrisana verzija!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                popuniPodacima();
            }
        }

        private void VerzijePublikacijeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            dataGridView.Rows.Clear();

            IList<VerzijaBasic> podaci = DTOManager.vratiPublikacijuBasic(_idPublikacije).Verzije;

            if (podaci != null)
            {
                foreach (VerzijaBasic p in podaci)
                {
                    dataGridView.Rows.Add(p.Id, p.BrojVerzije, p.DatumPostavljanja, p.OpisIzmene, p.OdgovornaOsoba);
                }

                dataGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Nisu pronadjene verzije publikacije!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFajlovi_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id != null)
            {
                FajloviVerzijeForm form = new FajloviVerzijeForm((int)id);
                if (form.ShowDialog() == DialogResult.OK) popuniPodacima();
            }
        }
    }
}
