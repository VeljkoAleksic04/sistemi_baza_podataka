using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniVerzijuForm : Form
    {
        private readonly int _idPublikacije;
        private readonly int _id;

        VerzijaBasic vb;

        public IzmeniVerzijuForm(int idPublikacije, int id)
        {
            _idPublikacije = idPublikacije;
            _id = id;
            vb = DTOManager.vratiVerziju(_id);
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            vb.BrojVerzije = Convert.ToInt32(txtBrojVerzije.Text);
            vb.DatumPostavljanja = dateTimePicker1.Value;
            vb.OpisIzmene = txtOpisIzmene.Text;
            vb.OdgovornaOsoba = txtOdgovornaOsoba.Text;
            DTOManager.azurirajVerziju(vb);

            MessageBox.Show("Uspesna izmena!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void IzmeniVerzijuForm_Load(object sender, EventArgs e)
        {
            ucitajPodatke();
        }

        public void ucitajPodatke()
        {
            txtBrojVerzije.Text = vb.BrojVerzije.ToString();
            dateTimePicker1.Value = vb.DatumPostavljanja;
            txtOpisIzmene.Text = vb.OpisIzmene;
            txtOdgovornaOsoba.Text = vb.OdgovornaOsoba;

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
