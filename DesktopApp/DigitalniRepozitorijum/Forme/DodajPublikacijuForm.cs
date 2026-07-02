using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajPublikacijuForm : Form
    {


        public DodajPublikacijuForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnOdustani, btnNaucniRad, btnObrazovni, btnKnjiga, btnPrezentacija, btnPoglavlje, btnTehnicki, btnSoftverski, btnDataset, btnDoktorska);
        }

        private void DodajPublikacijuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnNaucniRad_Click(object sender, EventArgs e)
        {
            DodajNaucniRadForm form = new DodajNaucniRadForm();
            if (form.ShowDialog() == DialogResult.OK) { DialogResult = DialogResult.OK; Close(); }
        }

        private void btnObrazovni_Click(object sender, EventArgs e)
        {
            DodajObrazovniMaterijalForm form = new DodajObrazovniMaterijalForm();
            if (form.ShowDialog() == DialogResult.OK) { DialogResult = DialogResult.OK; Close(); }
        }

        private void btnKnjiga_Click(object sender, EventArgs e)
        {
            DodajKnjiguForm form = new DodajKnjiguForm();
            if (form.ShowDialog() == DialogResult.OK) { DialogResult = DialogResult.OK; Close(); }
        }

        private void btnPrezentacija_Click(object sender, EventArgs e)
        {
            DodajPrezentacijuForm form = new DodajPrezentacijuForm();
            if (form.ShowDialog() == DialogResult.OK) { DialogResult = DialogResult.OK; Close(); }
        }

        private void btnPoglavlje_Click(object sender, EventArgs e)
        {
            DodajPoglavljeUKnjiziForm form = new DodajPoglavljeUKnjiziForm();
            if (form.ShowDialog() == DialogResult.OK) { DialogResult = DialogResult.OK; Close(); }
        }

        private void btnTehnicki_Click(object sender, EventArgs e)
        {
            DodajTehnickiIzvestajForm form = new DodajTehnickiIzvestajForm();
            if (form.ShowDialog() == DialogResult.OK) { DialogResult = DialogResult.OK; Close(); }
        }

        private void btnSoftverski_Click(object sender, EventArgs e)
        {
            DodajSoftverskiArtefaktForm form = new DodajSoftverskiArtefaktForm();
            if (form.ShowDialog() == DialogResult.OK) { DialogResult = DialogResult.OK; Close(); }
        }

        private void btnDataset_Click(object sender, EventArgs e)
        {
            DodajDatasetForm form = new DodajDatasetForm();
            if (form.ShowDialog() == DialogResult.OK) { DialogResult = DialogResult.OK; Close(); }
        }

        private void btnDoktorska_Click(object sender, EventArgs e)
        {
            DodajDoktorskuDisertacijuForm form = new DodajDoktorskuDisertacijuForm();
            if (form.ShowDialog() == DialogResult.OK) { DialogResult = DialogResult.OK; Close(); }
        }
    }
}
