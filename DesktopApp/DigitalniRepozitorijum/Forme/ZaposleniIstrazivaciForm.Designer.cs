namespace DigitalniRepozitorijum.Forme
{
    partial class ZaposleniIstrazivaciForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
                        this.colIdIstrazivaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdIstrazivaca.HeaderText = "IdIstrazivaca";
            this.colIdIstrazivaca.Name = "colIdIstrazivaca";
            this.colIdIstrazivaca.DataPropertyName = "IdIstrazivaca";
                        this.colIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIme.HeaderText = "Ime";
            this.colIme.Name = "colIme";
            this.colIme.DataPropertyName = "Ime";
                        this.colPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrezime.HeaderText = "Prezime";
            this.colPrezime.Name = "colPrezime";
            this.colPrezime.DataPropertyName = "Prezime";
                        this.colTipAngazovanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipAngazovanja.HeaderText = "TipAngazovanja";
            this.colTipAngazovanja.Name = "colTipAngazovanja";
            this.colTipAngazovanja.DataPropertyName = "TipAngazovanja";
                        this.colNazivPozicije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNazivPozicije.HeaderText = "NazivPozicije";
            this.colNazivPozicije.Name = "colNazivPozicije";
            this.colNazivPozicije.DataPropertyName = "NazivPozicije";
                        this.colDatumPocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatumPocetka.HeaderText = "DatumPocetka";
            this.colDatumPocetka.Name = "colDatumPocetka";
            this.colDatumPocetka.DataPropertyName = "DatumPocetka";
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // groupBox
            this.groupBox.Controls.Add(this.dataGridView);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(690, 556);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Zaposleni istrazivaci";
            // dataGridView
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colIdIstrazivaca, this.colIme, this.colPrezime, this.colTipAngazovanja, this.colNazivPozicije, this.colDatumPocetka
            });
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 19);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(684, 534);
            this.dataGridView.TabIndex = 0;
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnDodaj.Location = new System.Drawing.Point(720, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(240, 32);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnIzmeni.Location = new System.Drawing.Point(720, 50);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(240, 32);
            this.btnIzmeni.TabIndex = 10;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnObrisi.Location = new System.Drawing.Point(720, 88);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(240, 32);
            this.btnObrisi.TabIndex = 10;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // ZaposleniIstrazivaciForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Name = "ZaposleniIstrazivaciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZAPOSLENI ISTRAZIVACI";
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdIstrazivaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipAngazovanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNazivPozicije;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumPocetka;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
    }
}
