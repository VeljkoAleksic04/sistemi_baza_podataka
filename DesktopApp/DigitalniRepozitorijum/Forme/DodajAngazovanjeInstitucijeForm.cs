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
            var dto = new AngazovanjeBasic
            {
                IdInstitucije = _idInstitucije.Value,
                IdIstrazivaca = (int)cmbIstrazivaci.SelectedValue,
                TipAngazovanja = txtTipAngazovanja.Text,
                NazivPozicije = txtNazivPozicije.Text,
                DatumPocetka = datePocetka.Value,
                DatumZavrsetka = dateZavrsetka.Value < datePocetka.Value ? null : dateZavrsetka.Value,
            };

            DTOManager.dodajAngazovanje(dto);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DodajAngazovanjeInstitucijeForm_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var istrazivaci = DTOManager.vratiSveIstrazivace();

            cmbIstrazivaci.DataSource = istrazivaci;
            cmbIstrazivaci.DisplayMember = "PunoIme";
            cmbIstrazivaci.ValueMember = "Id";
        }
    }
}
