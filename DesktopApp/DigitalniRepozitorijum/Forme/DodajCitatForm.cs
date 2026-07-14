using System;
using System.Windows.Forms;
using DigitalniRepozitorijum.Entiteti;
using DigitalniRepozitorijum.Utils;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajCitatForm : Form
    {
        private readonly int? _idPublikacije;

        public DodajCitatForm(int? idPublikacije = null)
        {
            _idPublikacije = idPublikacije;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            try
            {
                CitatBasic novi = new CitatBasic
                {
                    IdCitira = (int)_idPublikacije,
                    IdCitirana = (int)cmbPublikacije.SelectedValue,
                    TipCitata = txtTipCitata.Text,
                    MestoCitiranja = txtMestoCitiranja.Text,
                    TekstualniKontekst = txtKontekst.Text
                };

                bool success = DTOManager.DodajCitat(novi);
                if (success)
                {
                    MessageBox.Show("Uspesno je dodat citat!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Dodavanje citata nije uspelo!!!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DodajCitatForm_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var publikacije = DTOManager.vratiSvePublikacije();

            cmbPublikacije.DataSource = publikacije;
            cmbPublikacije.ValueMember = "Id";
            cmbPublikacije.DisplayMember = "Naslov";
        }
    }
}
