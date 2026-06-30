using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajNaucnuOblastForm : Form
    {
        private readonly int? _idInstitucije;

        public DodajNaucnuOblastForm(int? idInstitucije = null)
        {
            _idInstitucije = idInstitucije;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
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
                Institucija = DTOManager.vratiInstituciju(_idInstitucije.Value),
                NaucnaOblast = txtNaucnaOblast.Text
            };

            DTOManager.dodajNaucnuOblast(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
