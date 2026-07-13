using System;
using System.Windows.Forms;
using DigitalniRepozitorijum.Entiteti;
using DigitalniRepozitorijum.Utils;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniCitatForm : Form
    {
        private readonly int? _idPublikacije;
        private readonly int? _idPubCitat;
        private readonly int? _idCitata;

        public IzmeniCitatForm(int? idPublikacije = null, int? idPubCitat = null, int? idCitata = null)
        {
            _idPublikacije = idPublikacije;
            _idPubCitat = idPubCitat;
            _idCitata = idCitata;

            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            try
            {
                PublikacijaBasic pubCitira = DTOManager.vratiPublikaciju(_idPublikacije.Value);
                PublikacijaBasic pubCitirana = DTOManager.vratiPublikaciju(_idPubCitat.Value);

                CitatBasic citat = new CitatBasic
                {
                    Id = (int)_idCitata,
                    PubCitira = pubCitira,
                    PubCitirana = pubCitirana,
                    TipCitata = txtTipCitata.Text,
                    MestoCitiranja = txtMestoCitiranja.Text,
                    TekstualniKontekst = txtKontekst.Text
                };

                DTOManager.IzmeniCitat(citat);
                MessageBox.Show("Uspesno je izmenjen citat.", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Nesto nije u redu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        private void IzmeniCitatForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (_idPubCitat.HasValue)
                {
                    CitatBasic nadjen = DTOManager.VratiCitatPoId(_idPubCitat.Value);
                    txtTipCitata.Text = nadjen.TipCitata;
                    txtMestoCitiranja.Text = nadjen.MestoCitiranja ?? "";
                    txtKontekst.Text = nadjen.TekstualniKontekst ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska pri ucitavanju citata: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
