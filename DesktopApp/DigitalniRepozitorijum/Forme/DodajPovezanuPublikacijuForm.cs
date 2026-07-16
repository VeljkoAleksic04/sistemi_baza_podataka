using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajPovezanuPublikacijuForm : Form
    {
        private readonly int? _idPublikacije;

        public DodajPovezanuPublikacijuForm(int? idPublikacije = null)
        {
            _idPublikacije = idPublikacije;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            try
            {
                bool state = DTOManager.DodajPovezanuPublikaciju(_idPublikacije.Value, (int)cmbPublikacije.SelectedValue, txtTipPovezanosti.Text);
                if(state) MessageBox.Show("Uspesno je dodata povezana publikacija!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Vec postoji takva povezana publikacija, ili dodavanje nije uspelo!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        private void DodajPovezanuPublikacijuForm_Load_1(object sender, EventArgs e)
        {
            cmbPublikacije.DataSource = DTOManager.VratiSveOsim(_idPublikacije.Value);
            cmbPublikacije.DisplayMember = "Naslov";
            cmbPublikacije.ValueMember = "Id";
        }
    }
}
