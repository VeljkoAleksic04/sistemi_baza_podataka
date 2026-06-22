using DigitalniRepozitorijum.Utils;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajDatasetForm : Form
    {


        public DodajDatasetForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedIndex = 0;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Cuvanje ce biti implementirano kroz NHibernate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {

        }

        private void DodajDatasetForm_Load(object sender, EventArgs e)
        {

        }
    }
}
