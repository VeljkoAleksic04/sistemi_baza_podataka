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
            var dto = new AutorstvoBasic
            {
                IdPublikacije = (int)cmbPublikacije.SelectedValue,
                IdAutora = _idAutora.Value,
                RedosledAutora = (int)numericUpDown1.Value,
                TipDoprinosa = txtTipDoprinosa.Text,
                Uloga = txtUloga.Text
            };

            DTOManager.dodajAutorstvo(dto);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DodajAutorstvoForm_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var publikacije = DTOManager.vratiSvePublikacije();

            cmbPublikacije.DataSource = publikacije;
            cmbPublikacije.DisplayMember = "Naslov";
            cmbPublikacije.ValueMember = "Id";

            if (cmbPublikacije.Items.Count > 0)
                cmbPublikacije.SelectedIndex = 0;
        }
    }
}
