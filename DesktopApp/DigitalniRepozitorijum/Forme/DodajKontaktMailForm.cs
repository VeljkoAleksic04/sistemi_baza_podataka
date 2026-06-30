using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajKontaktMailForm : Form
    {
        private readonly int? _idInstitucije;

        public DodajKontaktMailForm(int? idInstitucije = null)
        {
            _idInstitucije = idInstitucije;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKontaktMail.Text))
            {
                MessageBox.Show("Unesite kontakt mail.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new InstitucijaKontaktMailBasic
            {
                Institucija = DTOManager.vratiInstituciju(_idInstitucije.Value),
                KontaktMail = txtKontaktMail.Text
            };

            DTOManager.dodajKontaktMail(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
