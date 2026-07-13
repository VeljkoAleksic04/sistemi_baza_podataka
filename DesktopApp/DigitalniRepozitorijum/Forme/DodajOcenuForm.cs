using DigitalniRepozitorijum.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajOcenuForm : Form
    {
        private int _idRecenzenta;
        private int _idRundaRecenzije;
        public DodajOcenuForm(int idRecenzenta, int idRundeRecenzije)
        {
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            _idRecenzenta = idRecenzenta;
            _idRundaRecenzije = idRundeRecenzije;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            ISession sesija = DataLayer.GetSession();

            if (string.IsNullOrEmpty(txtKriterijum.Text) || string.IsNullOrEmpty(txtOcena.Text))
                MessageBox.Show("Sva polja moraju biti popunjena.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

            NizOcena no = new NizOcena
            {
                Kriterijum = txtKriterijum.Text,
                Ocena = double.Parse(txtOcena.Text),
                Recenzent = DTOManager.VratiIstrazivacaPoId(_idRecenzenta),
                RundaRecenzije = DTOManager.VratiRunduRecenzijePoId(_idRundaRecenzije)
            };

            sesija.SaveOrUpdate(no);
            sesija.Flush();
            sesija.Close();

            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DodajOcenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
