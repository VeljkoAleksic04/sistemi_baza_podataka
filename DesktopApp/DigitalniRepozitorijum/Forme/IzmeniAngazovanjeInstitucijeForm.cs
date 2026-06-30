using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniAngazovanjeInstitucijeForm : Form
    {
        private readonly int? _idInstitucije;
        private readonly int? _idIstrazivaca;

        public IzmeniAngazovanjeInstitucijeForm(int? idInstitucije = null, int? idIstrazivaca = null)
        {
            _idInstitucije = idInstitucije;
            _idIstrazivaca = idIstrazivaca;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void IzmeniAngazovanjeInstitucijeForm_Load(object sender, EventArgs e)
        {
            if (_idInstitucije == null || _idIstrazivaca == null) return;
            var dto = DTOManager.vratiAngazovanje(_idInstitucije.Value, _idIstrazivaca.Value);
            txtTipAngazovanja.Text = dto.TipAngazovanja;
            txtNazivPozicije.Text = dto.NazivPozicije;
            txtDatumPocetka.Text = dto.DatumPocetka.ToShortDateString();
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            var dto = new AngazovanjeBasic
            {
                IdInstitucije = _idInstitucije.Value,
                IdIstrazivaca = _idIstrazivaca.Value,
                TipAngazovanja = txtTipAngazovanja.Text,
                NazivPozicije = txtNazivPozicije.Text,
                DatumPocetka = DateTime.Parse(txtDatumPocetka.Text)
            };

            DTOManager.azurirajAngazovanje(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
