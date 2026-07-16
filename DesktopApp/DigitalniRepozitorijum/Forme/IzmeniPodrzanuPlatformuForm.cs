using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniPodrzanuPlatformuForm : Form
    {
        private readonly int? _idPlatforme;

        public IzmeniPodrzanuPlatformuForm(int? idPlatforme = null)
        {
            _idPlatforme = idPlatforme;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            DTOManager.IzmeniPodrzanuPlatformu(_idPlatforme.Value, txtPodrzanaPlatforma.Text);
            MessageBox.Show("Platforma softverskog artefakta je uspešno izmenjena.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IzmeniPodrzanuPlatformuForm_Load(object sender, EventArgs e)
        {
            txtPodrzanaPlatforma.Text = DTOManager.GetPodrzanaPlatforma(_idPlatforme.Value);
        }
    }
}
