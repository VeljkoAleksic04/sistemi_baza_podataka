using DigitalniRepozitorijum.Entiteti;
using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniUrednikaPoglavljaForm : Form
    {
        private int _id;

        public IzmeniUrednikaPoglavljaForm(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void IzmeniUrednikaPoglavljaForm_Load(object sender, EventArgs e)
        {
            try
            {
                PoglavljeUrednici urednik = DTOManager.VratiUrednikaPoglavljaPoId(_id);
                txtUrednik.Text = urednik.Urednik ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska: {ex.Message}", "Greska pri ucitavanju", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUrednik.Text))
                {
                    MessageBox.Show("Molimo, popunite sve polje", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PoglavljeUredniciBasic urednik = new PoglavljeUredniciBasic
                {
                    Id = _id,
                    Urednik = txtUrednik.Text
                };

                DTOManager.IzmeniUrednikaPoglavlja(urednik);
                MessageBox.Show("Urednik je uspesno izmenjen", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska: {ex.Message}", "Greska pri izmeni", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
