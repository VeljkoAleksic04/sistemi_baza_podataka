using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniKljucnuRecForm : Form
    {
        private readonly int? _idPublikacije;
        private readonly int? _id;

        public IzmeniKljucnuRecForm(int? idPublikacije = null, int? id = null)
        {
            _idPublikacije = idPublikacije;
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
