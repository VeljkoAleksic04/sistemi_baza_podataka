using DigitalniRepozitorijum.Utils;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniTehnickiIzvestajForm : Form
    {
        private readonly int _id;
        TehnickiIzvestajBasic tb;

        public IzmeniTehnickiIzvestajForm(int id)
        {
            _id = id;
            tb = DTOManager.vratiTehnickiIzvestaj(_id);
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedItem = tb.Status;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            tb.Naslov = txtNaslov.Text;
            tb.Apstrakt = txtApstrakt.Text;
            tb.Jezik = tbJezik.Text;
            tb.DatumObjavljivanja = dateObjave.Value;
            tb.DatumKreiranjaZapisa = dateKreiranja.Value;
            tb.Status = (string)cmbStatus.SelectedValue;
            tb.Vidljivost = txtVidljivost.Text;

            DTOManager.azurirajTehnickiIzvestaj(tb);

            MessageBox.Show("Uspesna izmena!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void IzmeniTehnickiIzvestajForm_Load(object sender, EventArgs e)
        {
            txtNaslov.Text = tb.Naslov;
            txtApstrakt.Text = tb.Apstrakt;
            tbJezik.Text = tb.Jezik;
            dateObjave.Value = tb.DatumObjavljivanja;
            dateKreiranja.Value = tb.DatumKreiranjaZapisa;
            // status mora u konstruktoru
            txtVidljivost.Text = tb.Vidljivost;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
