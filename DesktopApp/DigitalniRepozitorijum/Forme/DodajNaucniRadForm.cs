using DigitalniRepozitorijum.Utils;
using System.Windows.Forms;
using DigitalniRepozitorijum.Entiteti;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajNaucniRadForm : Form
    {


        public DodajNaucniRadForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedIndex = 0;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            try
            {
                NaucniRad novi = new NaucniRad
                {
                    Naslov = txtNaslov.Text,
                    Apstrakt = txtApstrakt.Text,
                    Jezik = tbJezik.Text,
                    DatumObjavljivanja = dateObjave.Value,
                    DatumKreiranjaZapisa = dateKreiranja.Value,
                    Status = cmbStatus.SelectedItem?.ToString() ?? cmbStatus.Text,
                    Vidljivost = txtVidljivost.Text,
                    DOI = txtDOI.Text,
                    TipRada = txtTipRada.Text,
                    Stranice = txtStranice.Text,
                    IdIzvora = int.Parse(txtIzvor.Text)
                };
                var success = DTOManager.DodajNaucniRad(novi);
                if (success)
                    MessageBox.Show("Uspesno je dodat naucni rad!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Greska pri dodavanju Naucnog rada.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                throw new Exception("Greska pri dodavanju naucnog rada: " + ex.Message + ex.InnerException);
            }
            finally
            {
                Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
