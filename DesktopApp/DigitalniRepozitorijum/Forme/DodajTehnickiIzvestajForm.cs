using DigitalniRepozitorijum.Utils;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajTehnickiIzvestajForm : Form
    {


        public DodajTehnickiIzvestajForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedIndex = 0;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            TehnickiIzvestajBasic tb = new TehnickiIzvestajBasic();
            tb.Naslov = txtNaslov.Text;
            tb.Apstrakt = txtApstrakt.Text;
            tb.Jezik = tbJezik.Text;
            tb.DatumObjavljivanja = dateObjave.Value;
            tb.DatumKreiranjaZapisa = dateKreiranja.Value;
            tb.Status = (string)cmbStatus.SelectedValue;
            tb.Vidljivost = txtVidljivost.Text;

            DTOManager.dodajTehnickiIzvestaj(tb);

            MessageBox.Show("Uspesno ste dodali tehnicki izvestaj!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
