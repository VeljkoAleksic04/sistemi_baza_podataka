using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniIstrazivacaForm : Form
    {
        private readonly int? _id;

        public IzmeniIstrazivacaForm(int? id = null)
        {
            _id = id;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void IzmeniIstrazivacaForm_Load(object sender, EventArgs e)
        {
            if (_id == null) return;
            var dto = DTOManager.vratiIstrazivaca(_id.Value);
            txtIme.Text = dto.Ime;
            txtPrezime.Text = dto.Prezime;
            txtDatumRodjenja.Text = dto.DatumRodjenja.ToShortDateString();
            txtDrzava.Text = dto.Drzava;
            txtStatusNaloga.Text = dto.StatusNaloga;
            txtNaucnoZvanje.Text = dto.NaucnoZvanje;
            txtNaucnaOblast.Text = dto.NaucnaOblast;
            txtORCID.Text = dto.ORCID;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text) || string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Popunite obavezna polja.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var postojeci = DTOManager.vratiIstrazivaca(_id.Value);

            var dto = new IstrazivacBasic
            {
                Id = _id.Value,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                DatumRodjenja = DateTime.Parse(txtDatumRodjenja.Text),
                Drzava = txtDrzava.Text,
                StatusNaloga = txtStatusNaloga.Text,
                NaucnoZvanje = txtNaucnoZvanje.Text,
                NaucnaOblast = txtNaucnaOblast.Text,
                JeAutor = postojeci.JeAutor,
                JeRecenzent = postojeci.JeRecenzent,
                JeUrednik = postojeci.JeUrednik,
                JeAdmin = postojeci.JeAdmin,
                JeRukovodilacProjekta = postojeci.JeRukovodilacProjekta,
                ORCID = txtORCID.Text,
                OblastEkspertize = postojeci.OblastEkspertize,
                UredjivackaSekcija = postojeci.UredjivackaSekcija,
                AdministratorskaOvlascenja = postojeci.AdministratorskaOvlascenja
            };

            DTOManager.azurirajIstrazivaca(dto);
            MessageBox.Show("Uspesno ste azurirali istrazivaca!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
