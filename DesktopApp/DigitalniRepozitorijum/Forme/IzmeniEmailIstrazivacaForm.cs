using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniEmailIstrazivacaForm : Form
    {
        private readonly int? _idIstrazivaca;
        private readonly int? _id;

        public IzmeniEmailIstrazivacaForm(int? idIstrazivaca = null, int? id = null)
        {
            _idIstrazivaca = idIstrazivaca;
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
