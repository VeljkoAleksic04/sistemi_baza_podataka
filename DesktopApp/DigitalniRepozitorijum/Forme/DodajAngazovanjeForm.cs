using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajAngazovanjeForm : Form
    {
        private readonly int? _idIstrazivaca;

        public DodajAngazovanjeForm(int? idIstrazivaca = null)
        {
            _idIstrazivaca = idIstrazivaca;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInstitucija.Text))
            {
                MessageBox.Show("Unesite ID institucije.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new AngazovanjeBasic
            {
                IdInstitucije = int.Parse(txtInstitucija.Text),
                IdIstrazivaca = _idIstrazivaca.Value,
                OrganizacionaJedinica = txtOrganizacionaJedinica.Text,
                TipAngazovanja = txtTipAngazovanja.Text,
                NazivPozicije = txtNazivPozicije.Text,
                DatumPocetka = DateTime.Parse(txtDatumPocetka.Text),
                DatumZavrsetka = string.IsNullOrWhiteSpace(txtDatumZavrsetka.Text) ? (DateTime?)null : DateTime.Parse(txtDatumZavrsetka.Text)
            };

            DTOManager.dodajAngazovanje(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
