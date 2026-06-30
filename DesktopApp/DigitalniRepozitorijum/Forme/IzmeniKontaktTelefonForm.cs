using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniKontaktTelefonForm : Form
    {
        private readonly int? _idInstitucije;
        private readonly int? _id;

        public IzmeniKontaktTelefonForm(int? idInstitucije = null, int? id = null)
        {
            _idInstitucije = idInstitucije;
            _id = id;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void IzmeniKontaktTelefonForm_Load(object sender, EventArgs e)
        {
            if (_id == null) return;
            var dto = DTOManager.vratiKontaktTelefon(_id.Value);
            txtKontaktTel.Text = dto.KontaktTel;
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
                Id = _id.Value,
                KontaktTel = txtKontaktTel.Text
            };

            DTOManager.azurirajKontaktTelefon(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
