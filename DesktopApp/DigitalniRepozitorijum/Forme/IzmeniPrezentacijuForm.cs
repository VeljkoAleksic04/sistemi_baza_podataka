using DigitalniRepozitorijum.Utils;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniPrezentacijuForm : Form
    {
        private readonly int _id;
        PrezentacijaBasic pb;

        public IzmeniPrezentacijuForm(int id)
        {
            _id = id;
            pb = DTOManager.vratiPrezentaciju(_id);
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedItem = pb.Status;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            pb.Naslov = txtNaslov.Text;
            pb.Apstrakt = txtApstrakt.Text;
            pb.Jezik = tbJezik.Text;
            pb.DatumObjavljivanja = dateObjave.Value;
            pb.DatumKreiranjaZapisa = dateKreiranja.Value;
            pb.Status = (string)cmbStatus.SelectedValue;
            pb.Vidljivost = txtVidljivost.Text;

            DTOManager.azurirajPrezentaciju(pb);

            MessageBox.Show("Uspesna izmena!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void IzmeniPrezentacijuForm_Load(object sender, EventArgs e)
        {
            txtNaslov.Text = pb.Naslov;
            txtApstrakt.Text = pb.Apstrakt;
            tbJezik.Text = pb.Jezik;
            dateObjave.Value = pb.DatumObjavljivanja;
            dateKreiranja.Value = pb.DatumKreiranjaZapisa;
            // status mora u konstruktoru
            txtVidljivost.Text = pb.Vidljivost;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
