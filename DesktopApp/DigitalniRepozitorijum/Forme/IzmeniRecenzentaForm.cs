using DigitalniRepozitorijum.Entiteti;
using NHibernate;
using System;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniRecenzentaForm : Form
    {
        private int _id;

        public IzmeniRecenzentaForm(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void IzmeniRecenzentaForm_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Istrazivac recenzent = s.Get<Istrazivac>(_id);
                s.Close();

                if (recenzent != null)
                {
                    txtImePrezime.Text = $"{recenzent.Ime} {recenzent.Prezime}";
                }
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
                Istrazivac recenzent = s.Get<Istrazivac>(_id);

                if (recenzent != null)
                {
                    recenzent.Ime = imena[0];
                    recenzent.Prezime = imena[1];
                    s.SaveOrUpdate(recenzent);
                    s.Flush();
                }
                s.Close();

                MessageBox.Show("Recenzent je uspesno izmenjen", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
