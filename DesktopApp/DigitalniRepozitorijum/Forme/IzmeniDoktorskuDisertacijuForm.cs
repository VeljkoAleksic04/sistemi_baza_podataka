using DigitalniRepozitorijum.Utils;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniDoktorskuDisertacijuForm : Form
    {
        private readonly int _id;
        DoktorskaDisertacijaBasic ddb;

        public IzmeniDoktorskuDisertacijuForm(int id)
        {
            _id = id;
            ddb = DTOManager.vratiDoktorskuDisertaciju(_id);
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedItem = ddb.Status;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            ddb.Naslov = txtNaslov.Text;
            ddb.Apstrakt = txtApstrakt.Text;
            ddb.Jezik = tbJezik.Text;
            ddb.DatumObjavljivanja = dateObjave.Value;
            ddb.DatumKreiranjaZapisa = dateKreiranja.Value;
            ddb.Status = (string)cmbStatus.SelectedValue;
            ddb.Vidljivost = txtVidljivost.Text;

            DTOManager.azurirajDoktorskuDisertaciju(ddb);

            MessageBox.Show("Uspesna izmena!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void IzmeniDoktorskuDisertacijuForm_Load(object sender, EventArgs e)
        {
            txtNaslov.Text = ddb.Naslov;
            txtApstrakt.Text = ddb.Apstrakt;
            tbJezik.Text = ddb.Jezik;
            dateObjave.Value = ddb.DatumObjavljivanja;
            dateKreiranja.Value = ddb.DatumKreiranjaZapisa;
            // status mora u konstruktoru
            txtVidljivost.Text = ddb.Vidljivost;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
