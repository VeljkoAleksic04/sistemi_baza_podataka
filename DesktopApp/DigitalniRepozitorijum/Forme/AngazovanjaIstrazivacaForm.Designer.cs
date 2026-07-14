namespace DigitalniRepozitorijum.Forme
{
    partial class AngazovanjaIstrazivacaForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBox = new GroupBox();
            dataGridView = new DataGridView();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            IdAngazovanja = new DataGridViewTextBoxColumn();
            colIdInstitucije = new DataGridViewTextBoxColumn();
            colNazivInstitucije = new DataGridViewTextBoxColumn();
            colOrganizacionaJedinica = new DataGridViewTextBoxColumn();
            colTipAngazovanja = new DataGridViewTextBoxColumn();
            colNazivPozicije = new DataGridViewTextBoxColumn();
            colDatumPocetka = new DataGridViewTextBoxColumn();
            colDatumZavrsetka = new DataGridViewTextBoxColumn();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(dataGridView);
            groupBox.Location = new Point(12, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(690, 556);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Angazovanja istrazivaca";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { IdAngazovanja, colIdInstitucije, colNazivInstitucije, colOrganizacionaJedinica, colTipAngazovanja, colNazivPozicije, colDatumPocetka, colDatumZavrsetka });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(684, 534);
            dataGridView.TabIndex = 0;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(720, 12);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(240, 32);
            btnDodaj.TabIndex = 10;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(720, 50);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(240, 32);
            btnIzmeni.TabIndex = 10;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(720, 88);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(240, 32);
            btnObrisi.TabIndex = 10;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // IdAngazovanja
            // 
            IdAngazovanja.HeaderText = "IdAngazovanja";
            IdAngazovanja.Name = "IdAngazovanja";
            IdAngazovanja.ReadOnly = true;
            // 
            // colIdInstitucije
            // 
            colIdInstitucije.DataPropertyName = "IdInstitucije";
            colIdInstitucije.HeaderText = "IdInstitucije";
            colIdInstitucije.Name = "colIdInstitucije";
            colIdInstitucije.ReadOnly = true;
            // 
            // colNazivInstitucije
            // 
            colNazivInstitucije.DataPropertyName = "NazivInstitucije";
            colNazivInstitucije.HeaderText = "NazivInstitucije";
            colNazivInstitucije.Name = "colNazivInstitucije";
            colNazivInstitucije.ReadOnly = true;
            // 
            // colOrganizacionaJedinica
            // 
            colOrganizacionaJedinica.DataPropertyName = "OrganizacionaJedinica";
            colOrganizacionaJedinica.HeaderText = "OrganizacionaJedinica";
            colOrganizacionaJedinica.Name = "colOrganizacionaJedinica";
            colOrganizacionaJedinica.ReadOnly = true;
            // 
            // colTipAngazovanja
            // 
            colTipAngazovanja.DataPropertyName = "TipAngazovanja";
            colTipAngazovanja.HeaderText = "TipAngazovanja";
            colTipAngazovanja.Name = "colTipAngazovanja";
            colTipAngazovanja.ReadOnly = true;
            // 
            // colNazivPozicije
            // 
            colNazivPozicije.DataPropertyName = "NazivPozicije";
            colNazivPozicije.HeaderText = "NazivPozicije";
            colNazivPozicije.Name = "colNazivPozicije";
            colNazivPozicije.ReadOnly = true;
            // 
            // colDatumPocetka
            // 
            colDatumPocetka.DataPropertyName = "DatumPocetka";
            colDatumPocetka.HeaderText = "DatumPocetka";
            colDatumPocetka.Name = "colDatumPocetka";
            colDatumPocetka.ReadOnly = true;
            // 
            // colDatumZavrsetka
            // 
            colDatumZavrsetka.DataPropertyName = "DatumZavrsetka";
            colDatumZavrsetka.HeaderText = "DatumZavrsetka";
            colDatumZavrsetka.Name = "colDatumZavrsetka";
            colDatumZavrsetka.ReadOnly = true;
            // 
            // AngazovanjaIstrazivacaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 580);
            Controls.Add(groupBox);
            Controls.Add(btnDodaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi);
            Name = "AngazovanjaIstrazivacaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ANGAZOVANJA";
            Load += AngazovanjaIstrazivacaForm_Load;
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private DataGridViewTextBoxColumn IdAngazovanja;
        private DataGridViewTextBoxColumn colIdInstitucije;
        private DataGridViewTextBoxColumn colNazivInstitucije;
        private DataGridViewTextBoxColumn colOrganizacionaJedinica;
        private DataGridViewTextBoxColumn colTipAngazovanja;
        private DataGridViewTextBoxColumn colNazivPozicije;
        private DataGridViewTextBoxColumn colDatumPocetka;
        private DataGridViewTextBoxColumn colDatumZavrsetka;
    }
}
