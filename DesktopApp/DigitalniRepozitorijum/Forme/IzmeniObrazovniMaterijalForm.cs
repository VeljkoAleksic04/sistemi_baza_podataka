using DigitalniRepozitorijum.Utils;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniObrazovniMaterijalForm : Form
    {
        private readonly int _id;
        ObrazovniMaterijalBasic omb;

        public IzmeniObrazovniMaterijalForm(int id)
        {
            _id = id;
            omb = DTOManager.vratiObrazovniMaterijal(_id);
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedItem = omb.Status;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            omb.Naslov = txtNaslov.Text;
            omb.Apstrakt = txtApstrakt.Text;
            omb.Jezik = tbJezik.Text;
            omb.DatumObjavljivanja = dateObjave.Value;
            omb.DatumKreiranjaZapisa = dateKreiranja.Value;
            omb.Status = (string)cmbStatus.SelectedValue;
            omb.Vidljivost = txtVidljivost.Text;

            DTOManager.azurirajObrazovniMaterijal(omb);

            MessageBox.Show("Uspesna izmena!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void IzmeniObrazovniMaterijalForm_Load(object sender, EventArgs e)
        {
            txtNaslov.Text = omb.Naslov;
            txtApstrakt.Text = omb.Apstrakt;
            tbJezik.Text = omb.Jezik;
            dateObjave.Value = omb.DatumObjavljivanja;
            dateKreiranja.Value = omb.DatumKreiranjaZapisa;
            // status mora u konstruktoru
            txtVidljivost.Text = omb.Vidljivost;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
