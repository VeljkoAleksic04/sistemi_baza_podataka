using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajObrazovniMaterijalForm : Form
    {


        public DodajObrazovniMaterijalForm()
        {
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
