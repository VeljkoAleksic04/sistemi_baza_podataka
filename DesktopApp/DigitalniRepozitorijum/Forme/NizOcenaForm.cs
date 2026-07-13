using DigitalniRepozitorijum.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DigitalniRepozitorijum.Entiteti;
using NHibernate;

namespace DigitalniRepozitorijum.Forme
{
    public partial class NizOcenaForm : Form
    {
        private int _idRundaRecenzije;
        private int _idRecenzenta;
        public NizOcenaForm(int idRundaRecenzije, int idRecenzenta)
        {
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi);
            _idRecenzenta = idRecenzenta;
            _idRundaRecenzije = idRundaRecenzije;

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var form = new DodajOcenuForm(_idRecenzenta, _idRundaRecenzije);
            form.ShowDialog();
            dataGridView.Rows.Clear();
            NizOcenaForm_Load(sender, e);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            ISession sesija = DataLayer.GetSession();

            var ocena = sesija.Get<NizOcena>(dataGridView.SelectedRows[0].Cells[0].Value);

            var form = new IzmeniOcenuForm(ocena);
            form.ShowDialog();
            dataGridView.Rows.Clear();
            NizOcenaForm_Load(sender, e);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Da li ste sigurni da zelite da obrisete ocenu", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (yesno == DialogResult.No) return;

            ISession sesija = DataLayer.GetSession();
            int idx = dataGridView.SelectedRows[0].Index;

            NizOcena obj = sesija.Load<NizOcena>(dataGridView.Rows[idx].Cells[0].Value);

            sesija.Delete(obj);
            sesija.Flush();
            sesija.Close();

            dataGridView.Rows.RemoveAt(idx);
        }

        private void NizOcenaForm_Load(object sender, EventArgs e)
        {

            ISession sesija = DataLayer.GetSession();

            var vrsiRecenziju = sesija.Query<VrsiRecenziju>()
                .Where(v => v.RundaRecenzije.Id == _idRundaRecenzije
                         && v.Recenzent.Id == _idRecenzenta)
                .FirstOrDefault();

            if (vrsiRecenziju == null)
            {
                MessageBox.Show("No assignment found for that reviewer/round.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // or handle appropriately
            }

            var ocene = sesija.Query<NizOcena>()
                .Where(o => o.RundaRecenzije.Id == vrsiRecenziju.RundaRecenzije.Id
                         && o.Recenzent.Id == vrsiRecenziju.Recenzent.Id)
                .ToList();

            foreach (var ocena in ocene)
            {
                dataGridView.Rows.Add(ocena.Id, ocena.Ocena, ocena.Kriterijum ?? "N/A");
            }
            dataGridView.Refresh();
        }
    }
}
