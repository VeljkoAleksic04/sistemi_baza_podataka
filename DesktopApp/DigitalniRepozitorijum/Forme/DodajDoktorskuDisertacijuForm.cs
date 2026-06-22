using DigitalniRepozitorijum.Utils;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajDoktorskuDisertacijuForm : Form
    {


        public DodajDoktorskuDisertacijuForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedIndex = 0;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            DoktorskaDisertacijaBasic ddb = new DoktorskaDisertacijaBasic();
            ddb.Naslov = txtNaslov.Text;
            ddb.Apstrakt = txtApstrakt.Text;
            ddb.Jezik = tbJezik.Text;
            ddb.DatumObjavljivanja = dateObjave.Value;
            ddb.DatumKreiranjaZapisa = dateKreiranja.Value;
            ddb.Status = (string)cmbStatus.SelectedValue;
            ddb.Vidljivost = txtVidljivost.Text;

            DTOManager.dodajDoktorskuDisertaciju(ddb);

            MessageBox.Show("Uspesno ste dodali doktorsku disertaciju!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void DodajDoktorskuDisertacijuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
