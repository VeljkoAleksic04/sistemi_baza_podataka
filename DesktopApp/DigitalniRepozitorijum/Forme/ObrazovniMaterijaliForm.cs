using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class ObrazovniMaterijaliForm : Form
    {

        public ObrazovniMaterijaliForm()
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
            DodajObrazovniMaterijalForm form = new DodajObrazovniMaterijalForm();
            if (form.ShowDialog() == DialogResult.OK) popuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (id != null)
            {
                IzmeniObrazovniMaterijalForm form = new IzmeniObrazovniMaterijalForm((int)id);
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
                DTOManager.obrisiObrazovniMaterijal((int)id);
                MessageBox.Show("Uspesno obrisan obrazovni materijal!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                popuniPodacima();
            }
        }

        private void ObrazovniMaterijaliForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            dataGridView.Rows.Clear();

            IList<ObrazovniMaterijalPregled> podaci = DTOManager.vratiSveObrazovneMaterijale();

            if (podaci != null)
            {
                foreach (ObrazovniMaterijalPregled p in podaci)
                {
                    dataGridView.Rows.Add(p.Id, p.Naslov, p.Jezik, p.Status);
                }

                dataGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Nisu pronadjeni obrazovni materijali!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
