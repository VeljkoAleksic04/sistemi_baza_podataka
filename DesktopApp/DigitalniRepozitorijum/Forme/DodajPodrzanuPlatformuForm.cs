using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajPodrzanuPlatformuForm : Form
    {
        private readonly int? _idPublikacije;

        public DodajPodrzanuPlatformuForm(int? idPublikacije = null)
        {
            _idPublikacije = idPublikacije;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Cuvanje ce biti implementirano kroz NHibernate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
