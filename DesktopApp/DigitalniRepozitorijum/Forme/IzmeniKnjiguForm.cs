using DigitalniRepozitorijum.Utils;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniKnjiguForm : Form
    {
        private readonly int _id;
        KnjigaBasic kb;

        public IzmeniKnjiguForm(int id)
        {
            _id = id;
            kb = DTOManager.vratiKnjigu(_id);
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedItem = kb.Status;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            kb.Naslov = txtNaslov.Text;
            kb.Apstrakt = txtApstrakt.Text;
            kb.Jezik = tbJezik.Text;
            kb.DatumObjavljivanja = dateObjave.Value;
            kb.DatumKreiranjaZapisa = dateKreiranja.Value;
            kb.Status = (string)cmbStatus.SelectedValue;
            kb.Vidljivost = txtVidljivost.Text;
            kb.Izdavac = txtIzdavac.Text;
            kb.MestoIzdanja = txtMestoIzdanja.Text;

            DTOManager.azurirajKnjigu(kb);

            MessageBox.Show("Uspesna izmena!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void IzmeniKnjiguForm_Load(object sender, EventArgs e)
        {
            txtNaslov.Text = kb.Naslov;
            txtApstrakt.Text = kb.Apstrakt;
            tbJezik.Text = kb.Jezik;
            dateObjave.Value = kb.DatumObjavljivanja;
            dateKreiranja.Value = kb.DatumKreiranjaZapisa;
            // status mora u konstruktoru
            txtVidljivost.Text = kb.Vidljivost;
            txtIzdavac.Text = kb.Izdavac;
            txtMestoIzdanja.Text = kb.MestoIzdanja;
        }
    }
}
