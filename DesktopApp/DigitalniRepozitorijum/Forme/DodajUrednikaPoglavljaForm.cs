using DigitalniRepozitorijum.Entiteti;
using NHibernate;
using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajUrednikaPoglavljaForm : Form
    {
        private int _idPoglavlja;

        public DodajUrednikaPoglavljaForm(int idPoglavlja)
        {
            InitializeComponent();
            _idPoglavlja = idPoglavlja;
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

                ISession session = DataLayer.GetSession();

                PoglavljeUrednici noviUrednik = new PoglavljeUrednici
                {
                    PoglavljeUKnjizi = session.Load<PoglavljeUKnjizi>(_idPoglavlja),
                    Urednik = txtUrednik.Text
                };

                DTOManager.DodajUrednikaPoglavlja(noviUrednik);
                MessageBox.Show("Urednik je uspesno dodan", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska: {ex.Message}", "Greska pri dodavanju", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
