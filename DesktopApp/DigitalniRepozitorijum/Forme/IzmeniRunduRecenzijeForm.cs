using System;
using System.Windows.Forms;
using DigitalniRepozitorijum.Entiteti;
using DigitalniRepozitorijum.Utils;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniRunduRecenzijeForm : Form
    {
        private readonly int? _id;

        public IzmeniRunduRecenzijeForm(int? id = null)
        {
            _id = id;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                RundaRecenzijeBasic runda = new RundaRecenzijeBasic
                {
                    Id = (int)_id,
                    BrojRunde = (int)numBrojRunde.Value,
                    Datum = datumPost.Value,
                    KonacnaOdluka = txtKonacnaOdluka.Text
                };

                DTOManager.IzmeniRunduRecenzije(runda);
                MessageBox.Show("Uspesno je izmenjena runda recenzije.", "Success", MessageBoxButtons.OK,
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

        private void IzmeniRunduRecenzijeForm_Load(object sender, EventArgs e)
        {
            try
            {
                RundaRecenzije nadjena = DTOManager.VratiRunduRecenzijePoId(_id.Value);
                numBrojRunde.Value = nadjena.BrojRunde;
                datumPost.Value = nadjena.Datum;
                txtKonacnaOdluka.Text = nadjena.KonacnaOdluka ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska pri ucitavanju runde recenzije: {ex.Message}", "Error", MessageBoxButtons.OK,
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
