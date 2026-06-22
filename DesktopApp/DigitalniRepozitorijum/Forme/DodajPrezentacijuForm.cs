using DigitalniRepozitorijum.Utils;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajPrezentacijuForm : Form
    {


        public DodajPrezentacijuForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedIndex = 0;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            PrezentacijaBasic pb = new PrezentacijaBasic();
            pb.Naslov = txtNaslov.Text;
            pb.Apstrakt = txtApstrakt.Text;
            pb.Jezik = tbJezik.Text;
            pb.DatumObjavljivanja = dateObjave.Value;
            pb.DatumKreiranjaZapisa = dateKreiranja.Value;
            pb.Status = (string)cmbStatus.SelectedValue;
            pb.Vidljivost = txtVidljivost.Text;

            DTOManager.dodajPrezentaciju(pb);

            MessageBox.Show("Uspesno ste dodali prezentaciju", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
