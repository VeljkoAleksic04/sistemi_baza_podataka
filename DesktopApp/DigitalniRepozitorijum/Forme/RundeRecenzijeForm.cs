using NHibernate;
using System;
using System.Windows.Forms;
using DigitalniRepozitorijum.Entiteti;

namespace DigitalniRepozitorijum.Forme
{
    public partial class RundeRecenzijeForm : Form
    {
        private int _idPublikacije;

        public RundeRecenzijeForm(int idPublikacije)
        {
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi, btnUrednik);
            _idPublikacije = idPublikacije;
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

        private void RundeRecenzijeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            dataGridView.Rows.Clear();

            List<RundaRecenzijePregled> podaci = DTOManager.VratiRundeRecenzijeZaPrikaz(_idPublikacije);

            foreach (RundaRecenzijePregled p in podaci)
            {
                dataGridView.Rows.Add(p.Id, p.BrojRunde, p.Datum, p.KonacnaOdluka);
            }

            dataGridView.Refresh();
        }


        private void btnUrednik_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id == null) return;
            try
            {
                var runda = DTOManager.VratiRunduRecenzijePoId(id.Value);
                var urednikId = runda.Urednik?.Id ?? runda.IdUrednika;
                if (urednikId == 0)
                {
                    MessageBox.Show("Runda nema dodeljenog urednika.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var urednik = DTOManager.VratiIstrazivacaPoId(urednikId);
                string email = "";
                if (urednik.Emailovi != null && urednik.Emailovi.Count > 0)
                    email = urednik.Emailovi[0].Email;
                MessageBox.Show($"Urednik: {urednik.Ime} {urednik.Prezime}\nEmail: {email}",
                    "Urednik recenzije", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecenzenti_Click(object sender, EventArgs e)
        {
            bool recenzentiPostoje = DTOManager.VratiIstrazivacaRundeRecenzije((int)GetSelectedId()).Any();
            if(recenzentiPostoje)
            {
                int id = (int)GetSelectedId();
                if (id == -1) throw new Exception("Nije izabrana runda recenzije.");
                var forma = new RecenzentiForm(id);
                forma.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nema dodeljenih recenzenata za izabranu rundu recenzije.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ISession sesija = DataLayer.GetSession();
            var publikacija = sesija.Get<Publikacija>(_idPublikacije);

            var urednik = sesija.Query<RundaRecenzije>().Where(r => r.Publikacija.Id == publikacija.Id).Select(r => r.Urednik).FirstOrDefault();
            if (urednik == null) MessageBox.Show("Nije uspelo dodavanje runde recenzije...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            using var form = new DodajRunduRecenzijeForm(publikacija.Id, urednik.Id);
            form.ShowDialog();
            popuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id == null) return;
            using var form = new IzmeniRunduRecenzijeForm(id: id.Value);
            form.ShowDialog();
            popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();
            if (id == null) return;
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranu rundu recenzije?", "Brisanje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var status = DTOManager.ObrisiRunduRecenzije(id);
                if (status)
                    MessageBox.Show("Uspesno je obrisana runda recenzije!!!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Nije uspelo brisanje...", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                popuniPodacima();
            }
        }
    }
}
