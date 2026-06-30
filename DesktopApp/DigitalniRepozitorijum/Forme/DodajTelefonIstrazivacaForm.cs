using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajTelefonIstrazivacaForm : Form
    {
        private readonly int? _idIstrazivaca;

        public DodajTelefonIstrazivacaForm(int? idIstrazivaca = null)
        {
            _idIstrazivaca = idIstrazivaca;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
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
                Istrazivac = DTOManager.vratiIstrazivaca(_idIstrazivaca.Value),
                Telefon = txtTelefon.Text
            };

            DTOManager.dodajTelefonIstrazivaca(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
