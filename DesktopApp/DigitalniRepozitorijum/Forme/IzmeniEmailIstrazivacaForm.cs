using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniEmailIstrazivacaForm : Form
    {
        private readonly int? _idIstrazivaca;
        private readonly int? _id;

        public IzmeniEmailIstrazivacaForm(int? idIstrazivaca = null, int? id = null)
        {
            _idIstrazivaca = idIstrazivaca;
            _id = id;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void IzmeniEmailIstrazivacaForm_Load(object sender, EventArgs e)
        {
            if (_id == null) return;
            var dto = DTOManager.vratiEmailIstrazivaca(_id.Value);
            txtEmail.Text = dto.Email;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Unesite email adresu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new IstrazivacEmailBasic
            {
                Id = _id.Value,
                Email = txtEmail.Text
            };

            DTOManager.azurirajEmailIstrazivaca(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
