using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigitalniRepozitorijum.Forme
{
    public partial class RundeRecenzijeForm : Form
    {
        public RundeRecenzijeForm()
        {
            InitializeComponent();
            FormStilovi.PrimeniStilListe(this, groupBox, btnDodaj, btnIzmeni, btnObrisi, btnUrednik);
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

        private void RundeRecenzijeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUrednik_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dodati funkciju koja prikazuje ko je urednik recenzije u messageboxu");

        }

        private void btnRecenzenti_Click(object sender, EventArgs e)
        {

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }
    }
}
