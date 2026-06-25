using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class RecenzentiForm : Form
    {
        public RecenzentiForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi, btnNizOcena);
        }

        private int? GetSelectedId()
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite red iz tabele.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajIstrazivacaForm form = new DodajIstrazivacaForm(true);
            if (form.ShowDialog() == DialogResult.OK) popuniPodacima();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            // pozvati IzmeniIstrazivacaForm sa ID iz GetSelectedID
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }

        private void btnNizOcena_Click(object sender, EventArgs e)
        {

        }

        private void RecenzentiForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            // implementacija
        }
    }
}
