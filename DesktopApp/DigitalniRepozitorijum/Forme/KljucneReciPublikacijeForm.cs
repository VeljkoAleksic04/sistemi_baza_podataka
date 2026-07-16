using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class KljucneReciPublikacijeForm : Form
    {
        private readonly int _idPublikacije;

        public KljucneReciPublikacijeForm(int idPublikacije)
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
            DodajKljucnuRecForm form = new DodajKljucnuRecForm(_idPublikacije);
            if (form.ShowDialog() == DialogResult.OK) popuniPodacima();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (id != null)
            {
                IzmeniKljucnuRecForm form = new IzmeniKljucnuRecForm(_idPublikacije, (int)id);
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
                DTOManager.obrisiPublikacijaKljucnaRec((int)id);
                MessageBox.Show("Uspesno obrisana kljucna rec!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                popuniPodacima();
            }
        }

        private void KljucneReciPublikacijeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            dataGridView.Rows.Clear();

            IList<PublikacijaKljucnaRecBasic> podaci = DTOManager.vratiPublikacijuBasic(_idPublikacije).KljucneReci;

            if (podaci != null)
            {
                foreach (PublikacijaKljucnaRecBasic p in podaci)
                {
                    dataGridView.Rows.Add(p.Id, p.KljucnaRec);
                }

                dataGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Nisu pronadjene kljucne reci publikacije!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
