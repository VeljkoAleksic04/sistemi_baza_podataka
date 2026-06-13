using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniKontaktMailForm : Form
    {
        private readonly int? _idInstitucije;
        private readonly int? _id;

        public IzmeniKontaktMailForm(int? idInstitucije = null, int? id = null)
        {
            _idInstitucije = idInstitucije;
            _id = id;
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
