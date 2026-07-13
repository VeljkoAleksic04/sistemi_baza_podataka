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
    public partial class IzmeniOcenuForm : Form
    {

        private NizOcena _ocena;
        public IzmeniOcenuForm(NizOcena ocena)
        {
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            _ocena = ocena;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            ISession sesija = DataLayer.GetSession();

            var obj = sesija.Load<NizOcena>(_ocena.Id);
            if (obj == null) throw new Exception("Ocena koja se menja ne postoji...");

            obj.Ocena = double.Parse(txtOcena.Text);
            obj.Kriterijum = txtKriterijum.Text;
            obj.Recenzent = _ocena.Recenzent;
            obj.RundaRecenzije = _ocena.RundaRecenzije;
            obj.VrsiRecenziju = _ocena.VrsiRecenziju;

            sesija.SaveOrUpdate(obj);
            sesija.Flush();
            sesija.Close();

            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IzmeniOcenuForm_Load(object sender, EventArgs e)
        {
            txtKriterijum.Text = _ocena.Kriterijum;
            txtOcena.Text = _ocena.Ocena.ToString();
        }
    }
}
