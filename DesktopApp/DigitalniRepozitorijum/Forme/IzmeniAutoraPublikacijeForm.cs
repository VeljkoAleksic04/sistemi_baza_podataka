using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniAutoraPublikacijeForm : Form
    {
        private readonly int? _idPublikacije;
        private readonly int? _idAutora;

        public IzmeniAutoraPublikacijeForm(int? idPublikacije = null, int? idAutora = null)
        {
            _idPublikacije = idPublikacije;
            _idAutora = idAutora;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void IzmeniAutoraPublikacijeForm_Load(object sender, EventArgs e)
        {
            if (_idPublikacije == null || _idAutora == null) return;
            var dto = DTOManager.vratiAutorstvo(_idPublikacije.Value, _idAutora.Value);
            txtRedosled.Text = dto.RedosledAutora.ToString();
            txtTipDoprinosa.Text = dto.TipDoprinosa;
            txtUloga.Text = dto.Uloga;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            var dto = new AutorstvoBasic
            {
                IdPublikacije = _idPublikacije.Value,
                IdAutora = _idAutora.Value,
                RedosledAutora = int.Parse(txtRedosled.Text),
                TipDoprinosa = txtTipDoprinosa.Text,
                Uloga = txtUloga.Text
            };

            DTOManager.azurirajAutorstvo(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
