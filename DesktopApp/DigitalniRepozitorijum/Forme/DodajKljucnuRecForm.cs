using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajKljucnuRecForm : Form
    {
        private readonly int _idPublikacije;

        public DodajKljucnuRecForm(int idPublikacije)
        {
            _idPublikacije = idPublikacije;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            PublikacijaKljucnaRecBasic pb = new PublikacijaKljucnaRecBasic();
            pb.KljucnaRec = txtKljucnaRec.Text;
            pb.Publikacija = DTOManager.vratiPublikacijuBasic(_idPublikacije);

            DTOManager.dodajPublikacijaKljucnaRec(pb);

            MessageBox.Show("Uspesno ste dodali kljucnu rec!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DodajKljucnuRecForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
