using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class DodajAutoraPublikacijeForm : Form
    {
        private readonly int? _idPublikacije;

        public DodajAutoraPublikacijeForm(int? idPublikacije = null)
        {
            _idPublikacije = idPublikacije;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtRedosled.Text))
            //{
            //    MessageBox.Show("Popunite obavezna polja (ID autora i redosled).", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            var dto = new AutorstvoBasic
            {
                IdPublikacije = _idPublikacije.Value,
                IdAutora = (int)cmbAutor.SelectedValue,
                RedosledAutora = (int)numRedosled.Value,
                TipDoprinosa = txtTipDoprinosa.Text,
                Uloga = txtUloga.Text
            };

            DTOManager.dodajAutorstvo(dto);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DodajAutoraPublikacijeForm_Load(object sender, EventArgs e)
        {
            UcitajAutore();
        }

        private void UcitajAutore()
        {
            var istrazivaci = DTOManager.vratiSveIstrazivace();
            cmbAutor.DataSource = istrazivaci;
            cmbAutor.DisplayMember = "PunoIme";
            cmbAutor.ValueMember = "Id";
        }
    }
}
