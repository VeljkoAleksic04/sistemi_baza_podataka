using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajVerzijuForm : Form
    {
        private readonly int _idPublikacije;

        public DodajVerzijuForm(int idPublikacije)
        {
            _idPublikacije = idPublikacije;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            VerzijaBasic vb = new VerzijaBasic();
            vb.BrojVerzije = Convert.ToInt32(txtBrojVerzije.Text);
            vb.DatumPostavljanja = dateTimePicker1.Value;
            vb.OpisIzmene = txtOpisIzmene.Text;
            vb.OdgovornaOsoba = txtOdgovornaOsoba.Text;
            vb.Publikacija = DTOManager.vratiPublikacijuBasic((int)_idPublikacije);

            DTOManager.dodajVerziju(vb);

            MessageBox.Show("Uspesno ste dodali verziju publikacije!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DodajVerzijuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
