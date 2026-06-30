using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniKontaktMailForm : Form
    {
        private readonly int? _idInstitucije;
        private readonly int? _id;

        public IzmeniKontaktMailForm(int? idInstitucije = null, int? id = null)
        {
            _idInstitucije = idInstitucije;
            _id = id;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void IzmeniKontaktMailForm_Load(object sender, EventArgs e)
        {
            if (_id == null) return;
            var dto = DTOManager.vratiKontaktMail(_id.Value);
            txtKontaktMail.Text = dto.KontaktMail;
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
                Id = _id.Value,
                KontaktMail = txtKontaktMail.Text
            };

            DTOManager.azurirajKontaktMail(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
