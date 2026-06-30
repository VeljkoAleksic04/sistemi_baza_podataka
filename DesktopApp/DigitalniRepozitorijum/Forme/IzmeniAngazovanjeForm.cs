using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniAngazovanjeForm : Form
    {
        private readonly int? _idIstrazivaca;
        private readonly int? _idInstitucije;

        public IzmeniAngazovanjeForm(int? idIstrazivaca = null, int? idInstitucije = null)
        {
            _idIstrazivaca = idIstrazivaca;
            _idInstitucije = idInstitucije;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void IzmeniAngazovanjeForm_Load(object sender, EventArgs e)
        {
            if (_idInstitucije == null || _idIstrazivaca == null) return;
            var dto = DTOManager.vratiAngazovanje(_idInstitucije.Value, _idIstrazivaca.Value);
            txtOrganizacionaJedinica.Text = dto.OrganizacionaJedinica;
            txtTipAngazovanja.Text = dto.TipAngazovanja;
            txtNazivPozicije.Text = dto.NazivPozicije;
            txtDatumPocetka.Text = dto.DatumPocetka.ToShortDateString();
            txtDatumZavrsetka.Text = dto.DatumZavrsetka?.ToShortDateString();
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            var postojeci = DTOManager.vratiAngazovanje(_idInstitucije.Value, _idIstrazivaca.Value);

            var dto = new AngazovanjeBasic
            {
                IdInstitucije = _idInstitucije.Value,
                IdIstrazivaca = _idIstrazivaca.Value,
                OrganizacionaJedinica = txtOrganizacionaJedinica.Text,
                TipAngazovanja = txtTipAngazovanja.Text,
                NazivPozicije = txtNazivPozicije.Text,
                DatumPocetka = DateTime.Parse(txtDatumPocetka.Text),
                DatumZavrsetka = string.IsNullOrWhiteSpace(txtDatumZavrsetka.Text) ? (DateTime?)null : DateTime.Parse(txtDatumZavrsetka.Text)
            };

            DTOManager.azurirajAngazovanje(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
