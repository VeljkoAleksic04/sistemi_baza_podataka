using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniAngazovanjeForm : Form
    {
        private readonly int? _idAngazovanja;

        public IzmeniAngazovanjeForm(int? idAngazovanja = null)
        {
            _idAngazovanja = idAngazovanja;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void IzmeniAngazovanjeForm_Load(object sender, EventArgs e)
        {
            if (_idAngazovanja == null) return;
            var dto = DTOManager.vratiAngazovanje(_idAngazovanja.Value);
            txtOrganizacionaJedinica.Text = dto.OrganizacionaJedinica;
            txtTipAngazovanja.Text = dto.TipAngazovanja;
            txtNazivPozicije.Text = dto.NazivPozicije;
            txtDatumPocetka.Text = dto.DatumPocetka.ToShortDateString();
            txtDatumZavrsetka.Text = dto.DatumZavrsetka?.ToShortDateString();
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            var postojeci = DTOManager.vratiAngazovanje(_idAngazovanja.Value);

            var dto = new AngazovanjeBasic
            {
                Id = _idAngazovanja.Value,
                IdInstitucije = postojeci.IdInstitucije,
                IdIstrazivaca = postojeci.IdIstrazivaca,
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
