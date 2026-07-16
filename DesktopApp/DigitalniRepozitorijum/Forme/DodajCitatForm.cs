using System;
using System.Windows.Forms;
using DigitalniRepozitorijum.Entiteti;
using DigitalniRepozitorijum.Utils;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajCitatForm : Form
    {
        private readonly int? _idPublikacije;
        private readonly int? _idPubCitat;

        public DodajCitatForm(int? idPublikacije = null, int? idPubCitat = null)
        {
            _idPublikacije = idPublikacije;
            _idPubCitat = idPubCitat;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            try
            { 
                PublikacijaBasic pubCitira = DTOManager.vratiPublikacijuBasic(_idPublikacije.Value);
                PublikacijaBasic pubCitirana = DTOManager.vratiPublikacijuBasic(_idPubCitat.Value);

                if (pubCitira == null || pubCitirana == null)
                {
                    MessageBox.Show("Greška: Nije pronađena publikacija!", "Nesto nije u redu",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CitatBasic novi = new CitatBasic
                {
                    PubCitira = pubCitira,
                    PubCitirana = pubCitirana,
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
            UcitajPublikacije();
        }

        private void UcitajPublikacije()
        {
            var publikacije = DTOManager.vratiSvePublikacije();

            cmbPublikacije.DisplayMember = "Naslov";
            cmbPublikacije.ValueMember = "Id";
            cmbPublikacije.DataSource = publikacije;
        }
    }
}
