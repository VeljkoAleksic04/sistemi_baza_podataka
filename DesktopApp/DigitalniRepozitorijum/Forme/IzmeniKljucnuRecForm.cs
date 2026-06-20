using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniKljucnuRecForm : Form
    {
        private readonly int _idPublikacije;
        private readonly int _id;
        PublikacijaKljucnaRecBasic pkrb;

        public IzmeniKljucnuRecForm(int idPublikacije, int id)
        {
            _idPublikacije = idPublikacije;
            _id = id;
            pkrb = DTOManager.vratiPublikacijaKljucnaRec(_id);
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            pkrb.KljucnaRec = txtKljucnaRec.Text;

            DTOManager.azurirajPublikacijaKljucnaRec(pkrb);

            MessageBox.Show("Uspesno ste izmenili kljucnu rec!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void IzmeniKljucnuRecForm_Load(object sender, EventArgs e)
        {
            txtKljucnaRec.Text = pkrb.KljucnaRec;
        }
    }
}
