using DigitalniRepozitorijum.Utils;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajObrazovniMaterijalForm : Form
    {


        public DodajObrazovniMaterijalForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedIndex = 0;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            ObrazovniMaterijalBasic omb = new ObrazovniMaterijalBasic();
            omb.Naslov = txtNaslov.Text;
            omb.Apstrakt = txtApstrakt.Text;
            omb.Jezik = tbJezik.Text;
            omb.DatumObjavljivanja = dateObjave.Value;
            omb.DatumKreiranjaZapisa = dateKreiranja.Value;
            omb.Status = (string)cmbStatus.SelectedValue;
            omb.Vidljivost = txtVidljivost.Text;

            DTOManager.dodajObrazovniMaterijal(omb);

            MessageBox.Show("Uspesno ste dodali obrazovni materijal!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
