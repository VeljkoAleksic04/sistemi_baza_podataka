using DigitalniRepozitorijum.Entiteti;
using NHibernate;
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

            DTOManager.DodajPodrzanuPlatformu((int)_idPublikacije, txtPodrzanaPlatforma.Text);

            MessageBox.Show("Uspesno je dodata podrzana platforma!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
