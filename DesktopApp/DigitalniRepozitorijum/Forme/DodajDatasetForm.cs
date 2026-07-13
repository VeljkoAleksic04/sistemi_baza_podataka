using DigitalniRepozitorijum.Utils;
using System;
using System.Windows.Forms;
using DigitalniRepozitorijum.Entiteti;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajDatasetForm : Form
    {
        public DodajDatasetForm()
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
                Dataset novi = new Dataset
                {
                    Naslov = txtNaslov.Text,
                    Apstrakt = txtApstrakt.Text,
                    Jezik = tbJezik.Text,
                    DatumObjavljivanja = dateObjave.Value,
                    DatumKreiranjaZapisa = dateKreiranja.Value,
                    Status = cmbStatus.SelectedItem.ToString(),
                    Vidljivost = txtVidljivost.Text,
                    BrojZapisa = (int)numBrZapisa.Value,
                    Velicina = (int)numVelicina.Value,
                    Format = txtFormat.Text,
                    LicencaKoriscenja = txtLicenca.Text
                };

                bool success = DTOManager.DodajDataset(novi);
                if (success)
                {
                    MessageBox.Show("Uspesno je dodat dataset!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Dodavanje dataseta nije uspelo!!!", "Error", MessageBoxButtons.OK,
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

        private void DodajDatasetForm_Load(object sender, EventArgs e)
        {
        }
    }
}
