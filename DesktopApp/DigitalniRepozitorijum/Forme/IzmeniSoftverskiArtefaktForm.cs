using DigitalniRepozitorijum.Utils;
using System;
using System.Windows.Forms;
using DigitalniRepozitorijum.Entiteti;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniSoftverskiArtefaktForm : Form
    {
        private readonly int? _id;

        public IzmeniSoftverskiArtefaktForm(int? id = null)
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
                SoftverskiArtefaktBasic artefakt = new SoftverskiArtefaktBasic
                {
                    Id = (int)_id,
                    Naslov = txtNaslov.Text,
                    Apstrakt = txtApstrakt.Text,
                    Jezik = tbJezik.Text,
                    DatumKreiranjaZapisa = dateKreiranja.Value,
                    DatumObjavljivanja = dateObjave.Value,
                    Status = cmbStatus.SelectedItem.ToString(),
                    Vidljivost = txtVidljivost.Text,
                    ProgramskiJezik = txtProgramskiJezik.Text,
                    LinkKaRepozitorijumu = txtLink.Text,
                    NacinLicenciranja = txtLicenca.Text
                };

                DTOManager.IzmeniSoftverskiArtefakt(artefakt);
                MessageBox.Show("Uspesno je izmenjen softverski artefakt.", "Success", MessageBoxButtons.OK,
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

        private void IzmeniSoftverskiArtefaktForm_Load(object sender, EventArgs e)
        {
            try
            {
                SoftverskiArtefakt nadjen = DTOManager.VratiSoftverskiArtefaktPoId(_id.Value);
                txtNaslov.Text = nadjen.Naslov;
                txtApstrakt.Text = nadjen.Apstrakt;
                tbJezik.Text = nadjen.Jezik;
                dateKreiranja.Value = nadjen.DatumKreiranjaZapisa;
                dateObjave.Value = nadjen.DatumObjavljivanja;
                cmbStatus.SelectedItem = nadjen.Status;
                txtVidljivost.Text = nadjen.Vidljivost;
                txtProgramskiJezik.Text = nadjen.ProgramskiJezik ?? "";
                txtLink.Text = nadjen.LinkKaRepozitorijumu ?? "";
                txtLicenca.Text = nadjen.NacinLicenciranja ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska pri ucitavanju softverskog artefakta: {ex.Message}", "Error", MessageBoxButtons.OK,
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
