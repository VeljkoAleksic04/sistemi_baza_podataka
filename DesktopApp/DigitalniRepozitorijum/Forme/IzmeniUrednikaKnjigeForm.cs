using DigitalniRepozitorijum.Entiteti;
using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniUrednikaKnjigeForm : Form
    {
        private int _id;
        KnjigaUrednici u = new KnjigaUrednici();

        public IzmeniUrednikaKnjigeForm(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void IzmeniUrednikaKnjigeForm_Load(object sender, EventArgs e)
        {
            try
            {
                u = DTOManager.VratiUredikaKnijePoId(_id);
                txtUrednik.Text = u.Urednik ?? "";
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

                KnjigaUredniciBasic urednik = new KnjigaUredniciBasic
                {
                    Id = _id,
                    Urednik = txtUrednik.Text
                };

                DTOManager.IzmeniUredikaKnjige(urednik);
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
