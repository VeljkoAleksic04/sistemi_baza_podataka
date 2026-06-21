using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajFajlForm : Form
    {
        private readonly int _idVerzije;

        public DodajFajlForm(int idVer)
        {
            _idVerzije = idVer;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void DodajFajlForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            FajlBasic fb = new FajlBasic();
            fb.Putanja = txtPutanja.Text;
            fb.Verzija = DTOManager.vratiVerziju(_idVerzije);

            DTOManager.dodajFajl(fb);

            MessageBox.Show("Uspesno ste dodali fajl!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
