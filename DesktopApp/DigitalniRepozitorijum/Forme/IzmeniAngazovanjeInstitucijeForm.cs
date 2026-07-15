using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniAngazovanjeInstitucijeForm : Form
    {
        private readonly int? _idAngazovanja;

        public IzmeniAngazovanjeInstitucijeForm(int? idAngazovanja = null)
        {
            _idAngazovanja = idAngazovanja;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void IzmeniAngazovanjeInstitucijeForm_Load(object sender, EventArgs e)
        {
            if (_idAngazovanja == null) return;
            var dto = DTOManager.vratiAngazovanje(_idAngazovanja.Value);
            txtTipAngazovanja.Text = dto.TipAngazovanja;
            txtNazivPozicije.Text = dto.NazivPozicije;
            txtDatumPocetka.Text = dto.DatumPocetka.ToShortDateString();
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            var postojeci = DTOManager.vratiAngazovanje(_idAngazovanja.Value);

            var dto = new AngazovanjeBasic
            {
                Id = _idAngazovanja.Value,
                IdInstitucije = postojeci.IdInstitucije,
                IdIstrazivaca = postojeci.IdIstrazivaca,
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
