using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniAutorstvoForm : Form
    {
        private readonly int? _idAutora;
        private readonly int? _idPublikacije;

        public IzmeniAutorstvoForm(int? idAutora = null, int? idPublikacije = null)
        {
            _idAutora = idAutora;
            _idPublikacije = idPublikacije;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void IzmeniAutorstvoForm_Load(object sender, EventArgs e)
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
