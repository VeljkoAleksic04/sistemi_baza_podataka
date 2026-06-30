using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajKontaktTelefonForm : Form
    {
        private readonly int? _idInstitucije;

        public DodajKontaktTelefonForm(int? idInstitucije = null)
        {
            _idInstitucije = idInstitucije;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKontaktTel.Text))
            {
                MessageBox.Show("Unesite kontakt telefon.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new InstitucijaKontaktTelBasic
            {
                Institucija = DTOManager.vratiInstituciju(_idInstitucije.Value),
                KontaktTel = txtKontaktTel.Text
            };

            DTOManager.dodajKontaktTelefon(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
