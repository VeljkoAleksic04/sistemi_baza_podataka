using DigitalniRepozitorijum.Utils;
using System;
using System.Windows.Forms;
using DigitalniRepozitorijum.Entiteti;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajSoftverskiArtefaktForm : Form
    {
        public DodajSoftverskiArtefaktForm()
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
                SoftverskiArtefakt novi = new SoftverskiArtefakt
                {
                    Naslov = textBox1.Text,
                    Apstrakt = txtApstrakt.Text,
                    Jezik = tbJezik.Text,
                    DatumObjavljivanja = dateObjave.Value,
                    DatumKreiranjaZapisa = dateKreiranja.Value,
                    Status = cmbStatus.SelectedItem.ToString(),
                    Vidljivost = txtVidljivost.Text,
                    ProgramskiJezik = txtProgramskiJezik.Text,
                    LinkKaRepozitorijumu = txtLink.Text,
                    NacinLicenciranja = txtLicenca.Text
                };

                bool success = DTOManager.DodajSoftverskiArtefakt(novi);
                if (success)
                {
                    MessageBox.Show("Uspesno je dodat softverski artefakt!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Dodavanje softverskog artefakta nije uspelo!!!", "Error", MessageBoxButtons.OK,
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
    }
}
