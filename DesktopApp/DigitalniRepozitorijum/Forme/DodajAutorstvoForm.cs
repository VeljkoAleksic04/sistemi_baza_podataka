using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajAutorstvoForm : Form
    {
        private readonly int? _idAutora;

        public DodajAutorstvoForm(int? idAutora = null)
        {
            _idAutora = idAutora;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPublikacija.Text) || string.IsNullOrWhiteSpace(txtRedosled.Text))
            {
                MessageBox.Show("Popunite obavezna polja (ID publikacije i redosled).", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new AutorstvoBasic
            {
                IdPublikacije = int.Parse(txtPublikacija.Text),
                IdAutora = _idAutora.Value,
                RedosledAutora = int.Parse(txtRedosled.Text),
                TipDoprinosa = txtTipDoprinosa.Text,
                Uloga = txtUloga.Text
            };

            DTOManager.dodajAutorstvo(dto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
