using DigitalniRepozitorijum.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniFajlForm : Form
    {
        private readonly int _idFajla;
        FajlBasic fajl;

        public IzmeniFajlForm(int id)
        {
            _idFajla = id;
            fajl = DTOManager.vratiFajl(_idFajla);
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void IzmeniFajlForm_Load(object sender, EventArgs e)
        {
            txtPutanja.Text = fajl.Putanja;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            fajl.Putanja = txtPutanja.Text;
            DTOManager.azurirajFajl(fajl);
            MessageBox.Show("Uspesna izmena!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
