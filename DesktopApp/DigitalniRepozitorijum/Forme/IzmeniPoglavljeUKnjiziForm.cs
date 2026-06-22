using DigitalniRepozitorijum.Utils;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniPoglavljeUKnjiziForm : Form
    {
        private readonly int _id;
        PoglavljeUKnjiziBasic pkb;

        public IzmeniPoglavljeUKnjiziForm(int id)
        {
            _id = id;
            pkb = DTOManager.vratiPoglavljeUKnjizi(_id);
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedItem = pkb.Status;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            pkb.Naslov = txtNaslov.Text;
            pkb.Apstrakt = txtApstrakt.Text;
            pkb.Jezik = tbJezik.Text;
            pkb.DatumObjavljivanja = dateObjave.Value;
            pkb.DatumKreiranjaZapisa = dateKreiranja.Value;
            pkb.Status = (string)cmbStatus.SelectedValue;
            pkb.Vidljivost = txtVidljivost.Text;
            pkb.Izdavac = txtIzdavac.Text;
            pkb.MestoIzdanja = txtMestoIzdanja.Text;

            DTOManager.azurirajPoglavljeUKnjizi(pkb);

            MessageBox.Show("Uspesna izmena!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void IzmeniPoglavljeUKnjiziForm_Load(object sender, EventArgs e)
        {
            txtNaslov.Text = pkb.Naslov;
            txtApstrakt.Text = pkb.Apstrakt;
            tbJezik.Text = pkb.Jezik;
            dateObjave.Value = pkb.DatumObjavljivanja;
            dateKreiranja.Value = pkb.DatumKreiranjaZapisa;
            // status mora u konstruktoru
            txtVidljivost.Text = pkb.Vidljivost;
            txtIzdavac.Text = pkb.Izdavac;
            txtMestoIzdanja.Text = pkb.MestoIzdanja;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
