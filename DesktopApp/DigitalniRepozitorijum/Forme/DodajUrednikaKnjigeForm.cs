using DigitalniRepozitorijum.Entiteti;
using NHibernate;
using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajUrednikaKnjigeForm : Form
    {
        private int _idKnjige;

        public DodajUrednikaKnjigeForm(int idKnjige)
        {
            InitializeComponent();
            _idKnjige = idKnjige;
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

                KnjigaUrednici noviUrednik = new KnjigaUrednici
                {
                    Knjiga = session.Load<Knjiga>(_idKnjige),
                    Urednik = txtUrednik.Text
                };

                DTOManager.DodajUredikaKnjige(noviUrednik);
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

        private void DodajUrednikaKnjigeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
