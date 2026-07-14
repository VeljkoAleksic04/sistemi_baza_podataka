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
            datePocetka.Value = dto.DatumPocetka;
            dateZavrsetka.Value = dto.DatumZavrsetka == null ? dateZavrsetka.MinDate : dto.DatumZavrsetka.Value;
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
                DatumPocetka = datePocetka.Value,
                DatumZavrsetka = (dateZavrsetka.Value < datePocetka.Value) ? null : dateZavrsetka.Value,
            };

            DTOManager.azurirajAngazovanje(dto);
            MessageBox.Show("Uspesno je izmenjeno angazovanje!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
