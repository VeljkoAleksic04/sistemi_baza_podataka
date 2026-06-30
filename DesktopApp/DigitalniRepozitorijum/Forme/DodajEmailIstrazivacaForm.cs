using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajEmailIstrazivacaForm : Form
    {
        private readonly int? _idIstrazivaca;

        public DodajEmailIstrazivacaForm(int? idIstrazivaca = null)
        {
            _idIstrazivaca = idIstrazivaca;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
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
                Istrazivac = DTOManager.vratiIstrazivaca(_idIstrazivaca.Value),
                Email = txtEmail.Text
            };

            DTOManager.dodajEmailIstrazivaca(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
