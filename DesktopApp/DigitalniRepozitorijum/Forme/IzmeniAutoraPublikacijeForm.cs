using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniAutoraPublikacijeForm : Form
    {
        private readonly int? _idAutorstva;

        public IzmeniAutoraPublikacijeForm(int? idAutorstva = null)
        {
            _idAutorstva = idAutorstva;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            var postojeci = DTOManager.vratiAutorstvo(_idAutorstva.Value);

            var dto = new AutorstvoBasic
            {
                Id = _idAutorstva.Value,
                IdPublikacije = postojeci.IdPublikacije,
                IdAutora = postojeci.IdAutora,
                RedosledAutora = (int)numRedosled.Value,
                TipDoprinosa = txtTipDoprinosa.Text,
                Uloga = txtUloga.Text
            };

            DTOManager.azurirajAutorstvo(dto);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void IzmeniAutoraPublikacijeForm_Load_1(object sender, System.EventArgs e)
        {
            if (_idAutorstva == null) return;
            var dto = DTOManager.vratiAutorstvo(_idAutorstva.Value);
            numRedosled.Value = dto.RedosledAutora;
            txtTipDoprinosa.Text = dto.TipDoprinosa;
            txtUloga.Text = dto.Uloga;
        }
    }
}
