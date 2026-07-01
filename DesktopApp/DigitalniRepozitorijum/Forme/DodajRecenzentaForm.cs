using DigitalniRepozitorijum.Entiteti;
using NHibernate;
using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajRecenzentaForm : Form
    {
        public DodajRecenzentaForm()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtImePrezime.Text))
                {
                    MessageBox.Show("Molimo, popunite sva polja", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string[] imena = txtImePrezime.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (imena.Length < 2)
                {
                    MessageBox.Show("Molimo, unesite i ime i prezime", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ISession s = DataLayer.GetSession();

                Istrazivac noviRecenzent = new Istrazivac
                {
                    Ime = imena[0],
                    Prezime = imena[1],
                    JeRecenzent = true
                };

                s.SaveOrUpdate(noviRecenzent);
                s.Flush();
                s.Close();

                MessageBox.Show("Recenzent je uspesno dodan", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
