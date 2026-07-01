namespace DigitalniRepozitorijum.Forme
{
    partial class UredniciPoglavljaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBox = new GroupBox();
            dataGridViewUrednici = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colIdPublikacije = new DataGridViewTextBoxColumn();
            colUrednik = new DataGridViewTextBoxColumn();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrednici).BeginInit();
            groupBox.SuspendLayout();
            SuspendLayout();

            groupBox.Controls.Add(dataGridViewUrednici);
            groupBox.Location = new Point(12, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(449, 283);

            dataGridViewUrednici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUrednici.Columns.AddRange(new DataGridViewColumn[] { colId, colIdPublikacije, colUrednik });
            dataGridViewUrednici.Location = new Point(3, 19);
            dataGridViewUrednici.Name = "dataGridViewUrednici";
            dataGridViewUrednici.Size = new Size(443, 261);

            colId.Name = "colId";
            colId.HeaderText = "Id";
            colIdPublikacije.Name = "colIdPublikacije";
            colIdPublikacije.HeaderText = "IdPublikacije";
            colUrednik.Name = "colUrednik";
            colUrednik.HeaderText = "Urednik";

            btnDodaj.Location = new Point(481, 12);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(240, 32);
            btnDodaj.Text = "Dodaj urednika";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;

            btnIzmeni.Location = new Point(481, 50);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(240, 32);
            btnIzmeni.Text = "Izmeni urednika";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;

            btnObrisi.Location = new Point(481, 88);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(240, 32);
            btnObrisi.Text = "Obrisi urednika";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 307);
            Controls.Add(btnDodaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi);
            Controls.Add(groupBox);
            Name = "UredniciPoglavljaForm";
            Text = "Urednici poglavlja";
            Load += UredniciPoglavljaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrednici).EndInit();
            groupBox.ResumeLayout(false);
            ResumeLayout(false);
        }


        private GroupBox groupBox;
        private DataGridView dataGridViewUrednici;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colIdPublikacije;
        private DataGridViewTextBoxColumn colUrednik;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
    }
}
