using System;
using System.Windows.Forms;
using DigitalniRepozitorijum.Entiteti;
using DigitalniRepozitorijum.Utils;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajRunduRecenzijeForm : Form
    {
        private int _idPublikacije;
        private int _idUrednika;
        public DodajRunduRecenzijeForm(int idPublikacije, int idUrednika)
        {
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);

            _idPublikacije = idPublikacije;
            _idUrednika = idUrednika;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                RundaRecenzije nova = new RundaRecenzije
                {
                    BrojRunde = (int)numBrojRunde.Value,
                    Datum = datumPost.Value,
                    KonacnaOdluka = txtKonacnaOdluka.Text,
                    IdPublikacije = _idPublikacije,
                    IdUrednika = _idUrednika
                };

                bool success = DTOManager.DodajRunduRecenzije(nova);
                if (success)
                {
                    MessageBox.Show("Uspesno je dodata runda recenzije!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Dodavanje runde recenzije nije uspelo!!!", "Error", MessageBoxButtons.OK,
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
