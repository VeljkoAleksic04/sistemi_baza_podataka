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
            if (string.IsNullOrWhiteSpace(txtIme.Text) || string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Popunite obavezna polja.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new IstrazivacBasic
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                DatumRodjenja = dateRodj.Value,
                Drzava = txtDrzava.Text,
                StatusNaloga = txtStatusNaloga.Text,
                NaucnoZvanje = txtNaucnoZvanje.Text,
                NaucnaOblast = txtNaucnaOblast.Text,
                JeAutor = cbAutor.Checked,
                JeRecenzent = cbRecenzent.Checked,
                JeUrednik = cbUrednik.Checked,
                JeAdmin = cbAdmin.Checked,
                JeRukovodilacProjekta = cbRukovodilac.Checked,
                ORCID = txtORCID.Text,
                OblastEkspertize = cbRecenzent.Checked ? txtSekcija.Text : null,
                UredjivackaSekcija = cbUrednik.Checked ? txtSekcija.Text : null,
                AdministratorskaOvlascenja = cbAdmin.Checked ? txtOvlascenja.Text : null
            };

            DTOManager.dodajIstrazivaca(dto);
            MessageBox.Show("Uspesno ste dodali istrazivaca!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
