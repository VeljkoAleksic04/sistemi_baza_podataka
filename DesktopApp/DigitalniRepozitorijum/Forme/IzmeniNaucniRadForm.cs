using DigitalniRepozitorijum.Utils;
using System.Windows.Forms;
using DigitalniRepozitorijum.Entiteti;
using NHibernate.Engine.Query.Sql;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniNaucniRadForm : Form
    {
        private readonly int? _id;

        public IzmeniNaucniRadForm(int? id = null)
        {
            _id = id;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
            cmbStatus.DataSource = Konstante.StatusiPublikacije;
            cmbStatus.SelectedIndex = 0;
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            try
            {
                NaucniRadBasic nrdto = new NaucniRadBasic
                {
                    Id = (int)_id,
                    Naslov = txtNaslov.Text,
                    Apstrakt = txtApstrakt.Text,
                    Jezik = tbJezik.Text,
                    DatumKreiranjaZapisa = dateKreiranja.Value,
                    DatumObjavljivanja = dateObjave.Value,
                    Status = cmbStatus.SelectedItem?.ToString() ?? Konstante.StatusiPublikacije[0],
                    Vidljivost = txtVidljivost.Text,
                    DOI = txtDOI.Text,
                    TipRada = txtTipRada.Text,
                    Stranice = txtStranice.Text,
                    IdIzvora = int.Parse(txtIzvor.Text)
                };
                DTOManager.IzmeniNaucniRad(nrdto);
                MessageBox.Show("Uspesno je izmenjen naucni rad.", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Nesto nije u redu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        private void IzmeniNaucniRadForm_Load(object sender, EventArgs e)
        {
            NaucniRad nadjen = new NaucniRad();

            nadjen = DTOManager.VratiNaucniRadPoId(_id.Value);
            txtNaslov.Text = nadjen.Naslov;
            txtApstrakt.Text = nadjen.Apstrakt;
            tbJezik.Text = nadjen.Jezik;
            dateKreiranja.Value = nadjen.DatumKreiranjaZapisa;
            dateObjave.Value = nadjen.DatumObjavljivanja == DateTime.MinValue ? dateObjave.MinDate : nadjen.DatumObjavljivanja;
            cmbStatus.SelectedItem = nadjen.Status;
            txtVidljivost.Text = nadjen.Vidljivost;
            txtDOI.Text = nadjen.DOI;
            txtTipRada.Text = nadjen.TipRada;
            txtStranice.Text = nadjen.Stranice;
            txtIzvor.Text = nadjen.Izvor?.Id.ToString() ?? "";

            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
