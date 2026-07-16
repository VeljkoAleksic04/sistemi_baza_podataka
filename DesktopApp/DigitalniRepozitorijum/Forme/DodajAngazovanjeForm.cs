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
            var dto = new AngazovanjeBasic
            {
                IdInstitucije = (int)cmbInstitucije.SelectedValue,
                IdIstrazivaca = _idIstrazivaca.Value,
                OrganizacionaJedinica = txtOrganizacionaJedinica.Text,
                TipAngazovanja = txtTipAngazovanja.Text,
                NazivPozicije = txtNazivPozicije.Text,
                DatumPocetka = datePocetka.Value,
                DatumZavrsetka = (dateZavrsetka.Value < datePocetka.Value) ? null : dateZavrsetka.Value,
            };

            DTOManager.dodajAngazovanje(dto);
            MessageBox.Show("Uspesno je dodato angazovanje!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DodajAngazovanjeForm_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var institucije = DTOManager.vratiSveInstitucije();
            cmbInstitucije.DataSource = institucije;
            cmbInstitucije.DisplayMember = "Naziv";
            cmbInstitucije.ValueMember = "Id";
        }
    }
}
