using DigitalniRepozitorijum.Utils;
using System;
using System.Windows.Forms;
using DigitalniRepozitorijum.Entiteti;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniDatasetForm : Form
    {
        private readonly int? _id;

        public IzmeniDatasetForm(int? id = null)
        {
            _id = id;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedIndex = 0;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            try
            {
                DatasetDTO dataset = new DatasetDTO
                {
                    Id = (int)_id,
                    Naslov = txtNaslov.Text,
                    Apstrakt = txtApstrakt.Text,
                    Jezik = tbJezik.Text,
                    DatumKreiranja = dateKreiranja.Value,
                    DatumObjavljivanja = dateObjave.Value,
                    Status = cmbStatus.SelectedItem.ToString(),
                    Vidljivost = txtVidljivost.Text,
                    BrojZapisa = int.Parse(txtBrojZapisa.Text),
                    Velicina = int.Parse(txtVelicina.Text),
                    Format = txtFormat.Text,
                    LicencaKoriscenja = txtLicenca.Text
                };

                DTOManager.IzmeniDataset(dataset);
                MessageBox.Show("Uspesno je izmenjen dataset.", "Success", MessageBoxButtons.OK,
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

        private void IzmeniDatasetForm_Load(object sender, EventArgs e)
        {
            try
            {
                Dataset nadjen = DTOManager.VratiDatasetPoId(_id.Value);
                txtNaslov.Text = nadjen.Naslov;
                txtApstrakt.Text = nadjen.Apstrakt;
                tbJezik.Text = nadjen.Jezik;
                dateKreiranja.Value = nadjen.DatumKreiranjaZapisa;
                dateObjave.Value = nadjen.DatumObjavljivanja;
                cmbStatus.SelectedItem = nadjen.Status;
                txtVidljivost.Text = nadjen.Vidljivost;
                txtBrojZapisa.Text = nadjen.BrojZapisa.ToString();
                txtVelicina.Text = nadjen.Velicina.ToString();
                txtFormat.Text = nadjen.Format ?? "";
                txtLicenca.Text = nadjen.LicencaKoriscenja ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska pri ucitavanju dataseta: {ex.Message}", "Error", MessageBoxButtons.OK,
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
