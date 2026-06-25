using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajIstrazivacaForm : Form
    {
        private readonly bool recenzent;
        private readonly bool autor;

        public DodajIstrazivacaForm(bool recenzent = false, bool autor = false) // mislim da je ovo ok resenje za dodavanje specificnik istrazivaca
        {
            this.recenzent = recenzent;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Cuvanje ce biti implementirano kroz NHibernate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DodajIstrazivacaForm_Load(object sender, EventArgs e)
        {
            if (recenzent)
            {
                cbRecenzent.Checked = true;
                cbRecenzent.Enabled = false;
            }
            if (autor)
            {
                cbAutor.Checked = true;
                cbAutor.Enabled = false;
            }
        }

        private void cbAutor_CheckedChanged(object sender, EventArgs e)
        {
            txtORCID.Enabled = cbAutor.Checked;
        }

        private void cbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            txtOvlascenja.Enabled = cbAdmin.Checked;
        }

        private void cbUrednik_CheckedChanged(object sender, EventArgs e)
        {
            txtSekcija.Enabled = cbUrednik.Checked; 
        }
    }
}
