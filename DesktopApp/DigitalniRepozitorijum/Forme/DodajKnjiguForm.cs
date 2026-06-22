using DigitalniRepozitorijum.Utils;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajKnjiguForm : Form
    {
        public DodajKnjiguForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedIndex = 0;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            KnjigaBasic kb = new KnjigaBasic();
            kb.Naslov = txtNaslov.Text;
            kb.Apstrakt = txtApstrakt.Text;
            kb.Jezik = tbJezik.Text;
            kb.DatumObjavljivanja = dateObjave.Value;
            kb.DatumKreiranjaZapisa = dateKreiranja.Value;
            kb.Status = (string)cmbStatus.SelectedValue;
            kb.Vidljivost = txtVidljivost.Text;
            kb.Izdavac = txtIzdavac.Text;
            kb.MestoIzdanja = txtMestoIzdanja.Text;

            DTOManager.dodajKnjigu(kb);

            MessageBox.Show("Uspesno ste dodali knjigu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DodajKnjiguForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
