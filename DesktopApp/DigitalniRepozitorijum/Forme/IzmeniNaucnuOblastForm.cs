using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniNaucnuOblastForm : Form
    {
        private readonly int? _idInstitucije;
        private readonly int? _id;

        public IzmeniNaucnuOblastForm(int? idInstitucije = null, int? id = null)
        {
            _idInstitucije = idInstitucije;
            _id = id;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void IzmeniNaucnuOblastForm_Load(object sender, EventArgs e)
        {
            if (_id == null) return;
            var dto = DTOManager.vratiNaucnuOblast(_id.Value);
            txtNaucnaOblast.Text = dto.NaucnaOblast;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaucnaOblast.Text))
            {
                MessageBox.Show("Unesite naucnu oblast.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new InstitucijaNaucnaOblastBasic
            {
                Id = _id.Value,
                NaucnaOblast = txtNaucnaOblast.Text
            };

            DTOManager.azurirajNaucnuOblast(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
