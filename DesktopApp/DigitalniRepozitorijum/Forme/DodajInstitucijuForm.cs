using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajInstitucijuForm : Form
    {


        public DodajInstitucijuForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text) || string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                MessageBox.Show("Popunite sva polja.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new InstitucijaBasic
            {
                Naziv = txtNaziv.Text,
                Adresa = txtAdresa.Text
            };

            DTOManager.dodajInstituciju(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
