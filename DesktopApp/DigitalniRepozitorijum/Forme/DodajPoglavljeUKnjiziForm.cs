using DigitalniRepozitorijum.Utils;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajPoglavljeUKnjiziForm : Form
    {
        public DodajPoglavljeUKnjiziForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedIndex = 0;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            PoglavljeUKnjiziBasic pkb = new PoglavljeUKnjiziBasic();
            pkb.Naslov = txtNaslov.Text;
            pkb.Apstrakt = txtApstrakt.Text;
            pkb.Jezik = tbJezik.Text;
            pkb.DatumObjavljivanja = dateObjave.Value;
            pkb.DatumKreiranjaZapisa = dateKreiranja.Value;
            pkb.Status = (string)cmbStatus.SelectedValue;
            pkb.Vidljivost = txtVidljivost.Text;
            pkb.Izdavac = txtIzdavac.Text;
            pkb.MestoIzdanja = txtMestoIzdanja.Text;

            DTOManager.dodajPoglavljeUKnjizi(pkb);

            MessageBox.Show("Uspesno ste dodali poglaclje u knjizi!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
