using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajAngazovanjeInstitucijeForm : Form
    {
        private readonly int? _idInstitucije;

        public DodajAngazovanjeInstitucijeForm(int? idInstitucije = null)
        {
            _idInstitucije = idInstitucije;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIstrazivac.Text))
            {
                MessageBox.Show("Unesite ID istrazivaca.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new AngazovanjeBasic
            {
                IdInstitucije = _idInstitucije.Value,
                IdIstrazivaca = int.Parse(txtIstrazivac.Text),
                TipAngazovanja = txtTipAngazovanja.Text,
                NazivPozicije = txtNazivPozicije.Text,
                DatumPocetka = DateTime.Parse(txtDatumPocetka.Text)
            };

            DTOManager.dodajAngazovanje(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
