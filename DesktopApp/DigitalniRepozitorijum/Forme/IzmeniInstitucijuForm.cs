using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniInstitucijuForm : Form
    {
        private readonly int? _id;

        public IzmeniInstitucijuForm(int? id = null)
        {
            _id = id;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void IzmeniInstitucijuForm_Load(object sender, EventArgs e)
        {
            if (_id == null) return;
            var dto = DTOManager.vratiInstituciju(_id.Value);
            txtNaziv.Text = dto.Naziv;
            txtAdresa.Text = dto.Adresa;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text) || string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                MessageBox.Show("Popunite sva polja.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new InstitucijaBasic(_id.Value, txtNaziv.Text, txtAdresa.Text);
            DTOManager.azurirajInstituciju(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
