using DigitalniRepozitorijum.Entiteti;
using NHibernate;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class IzmeniPovezanuPublikacijuForm : Form
    {
        private readonly int? _id;

        public IzmeniPovezanuPublikacijuForm(int? id = null)
        {
            _id = id;
            InitializeComponent();
            FormStilovi.PrimeniStilUnosa(this, btnPotvrdi, btnOdustani);
        }

        private void btnPotvrdi_Click(object sender, System.EventArgs e)
        {
            var status = DTOManager.IzmeniPovezanuPublikaciju(_id.Value, txtTipPovezanosti.Text);
            if (status)
            {
                MessageBox.Show("Uspesno izmenjena povezana publikacija.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doslo je do greske prilikom izmene povezane publikacije.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void IzmeniPovezanuPublikacijuForm_Load(object sender, EventArgs e)
        {
            ISession session = DataLayer.GetSession();
            string tipPovezanosti = session.Load<PovezanSa>(_id.Value).TipPovezanosti;
            txtTipPovezanosti.Text = tipPovezanosti;
        }
    }
}
