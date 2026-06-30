using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniTelefonIstrazivacaForm : Form
    {
        private readonly int? _idIstrazivaca;
        private readonly int? _id;

        public IzmeniTelefonIstrazivacaForm(int? idIstrazivaca = null, int? id = null)
        {
            _idIstrazivaca = idIstrazivaca;
            _id = id;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void IzmeniTelefonIstrazivacaForm_Load(object sender, EventArgs e)
        {
            if (_id == null) return;
            var dto = DTOManager.vratiTelefonIstrazivaca(_id.Value);
            txtTelefon.Text = dto.Telefon;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Unesite broj telefona.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new IstrazivacTelefonBasic
            {
                Id = _id.Value,
                Telefon = txtTelefon.Text
            };

            DTOManager.azurirajTelefonIstrazivaca(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
