namespace DigitalniRepozitorijum.Forme
{
    partial class InstitucijeForm
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
                        this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.DataPropertyName = "Id";
                        this.colNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNaziv.HeaderText = "Naziv";
            this.colNaziv.Name = "colNaziv";
            this.colNaziv.DataPropertyName = "Naziv";
                        this.colAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdresa.HeaderText = "Adresa";
            this.colAdresa.Name = "colAdresa";
            this.colAdresa.DataPropertyName = "Adresa";
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
            this.groupBox.Text = "Lista institucija";
            // dataGridView
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId, this.colNaziv, this.colAdresa
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
            this.btnDodaj.Text = "Dodaj instituciju";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnIzmeni.Location = new System.Drawing.Point(720, 50);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(240, 32);
            this.btnIzmeni.TabIndex = 10;
            this.btnIzmeni.Text = "Izmeni instituciju";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnObrisi.Location = new System.Drawing.Point(720, 88);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(240, 32);
            this.btnObrisi.TabIndex = 10;
            this.btnObrisi.Text = "Obrisi instituciju";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            this.lblPovezano = new System.Windows.Forms.Label();
            this.lblPovezano.AutoSize = true;
            this.lblPovezano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPovezano.Location = new System.Drawing.Point(720, 126);
            this.lblPovezano.Name = "lblPovezano";
            this.lblPovezano.Size = new System.Drawing.Size(200, 13);
            this.lblPovezano.TabIndex = 100;
            this.lblPovezano.Text = "Povezani podaci";
            this.btnKontaktTelefoni = new System.Windows.Forms.Button();
            this.btnKontaktTelefoni.Location = new System.Drawing.Point(720, 148);
            this.btnKontaktTelefoni.Name = "btnKontaktTelefoni";
            this.btnKontaktTelefoni.Size = new System.Drawing.Size(240, 32);
            this.btnKontaktTelefoni.TabIndex = 10;
            this.btnKontaktTelefoni.Text = "Kontakt telefoni";
            this.btnKontaktTelefoni.UseVisualStyleBackColor = true;
            this.btnKontaktTelefoni.Click += new System.EventHandler(this.btnKontaktTelefoni_Click);
            this.btnKontaktMailovi = new System.Windows.Forms.Button();
            this.btnKontaktMailovi.Location = new System.Drawing.Point(720, 186);
            this.btnKontaktMailovi.Name = "btnKontaktMailovi";
            this.btnKontaktMailovi.Size = new System.Drawing.Size(240, 32);
            this.btnKontaktMailovi.TabIndex = 10;
            this.btnKontaktMailovi.Text = "Kontakt mailovi";
            this.btnKontaktMailovi.UseVisualStyleBackColor = true;
            this.btnKontaktMailovi.Click += new System.EventHandler(this.btnKontaktMailovi_Click);
            this.btnNaucneOblasti = new System.Windows.Forms.Button();
            this.btnNaucneOblasti.Location = new System.Drawing.Point(720, 224);
            this.btnNaucneOblasti.Name = "btnNaucneOblasti";
            this.btnNaucneOblasti.Size = new System.Drawing.Size(240, 32);
            this.btnNaucneOblasti.TabIndex = 10;
            this.btnNaucneOblasti.Text = "Naucne oblasti";
            this.btnNaucneOblasti.UseVisualStyleBackColor = true;
            this.btnNaucneOblasti.Click += new System.EventHandler(this.btnNaucneOblasti_Click);
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.btnZaposleni.Location = new System.Drawing.Point(720, 262);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(240, 32);
            this.btnZaposleni.TabIndex = 10;
            this.btnZaposleni.Text = "Zaposleni istrazivaci";
            this.btnZaposleni.UseVisualStyleBackColor = true;
            this.btnZaposleni.Click += new System.EventHandler(this.btnZaposleni_Click);
            // InstitucijeForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblPovezano);
            this.Controls.Add(this.btnKontaktTelefoni);
            this.Controls.Add(this.btnKontaktMailovi);
            this.Controls.Add(this.btnNaucneOblasti);
            this.Controls.Add(this.btnZaposleni);
            this.Name = "InstitucijeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA INSTITUCIJA";
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdresa;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblPovezano;
        private System.Windows.Forms.Button btnKontaktTelefoni;
        private System.Windows.Forms.Button btnKontaktMailovi;
        private System.Windows.Forms.Button btnNaucneOblasti;
        private System.Windows.Forms.Button btnZaposleni;
    }
}
