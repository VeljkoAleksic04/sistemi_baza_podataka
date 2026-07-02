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
            groupBox = new GroupBox();
            dataGridView = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNaziv = new DataGridViewTextBoxColumn();
            colAdresa = new DataGridViewTextBoxColumn();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            lblPovezano = new Label();
            btnKontaktTelefoni = new Button();
            btnKontaktMailovi = new Button();
            btnNaucneOblasti = new Button();
            btnZaposleni = new Button();
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
            groupBox.Text = "Lista institucija";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colId, colNaziv, colAdresa });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(684, 534);
            dataGridView.TabIndex = 0;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNaziv
            // 
            colNaziv.DataPropertyName = "Naziv";
            colNaziv.HeaderText = "Naziv";
            colNaziv.Name = "colNaziv";
            colNaziv.ReadOnly = true;
            // 
            // colAdresa
            // 
            colAdresa.DataPropertyName = "Adresa";
            colAdresa.HeaderText = "Adresa";
            colAdresa.Name = "colAdresa";
            colAdresa.ReadOnly = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(720, 12);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(240, 32);
            btnDodaj.TabIndex = 10;
            btnDodaj.Text = "Dodaj instituciju";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(720, 50);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(240, 32);
            btnIzmeni.TabIndex = 10;
            btnIzmeni.Text = "Izmeni instituciju";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(720, 88);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(240, 32);
            btnObrisi.TabIndex = 10;
            btnObrisi.Text = "Obrisi instituciju";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // lblPovezano
            // 
            lblPovezano.AutoSize = true;
            lblPovezano.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblPovezano.Location = new Point(720, 126);
            lblPovezano.Name = "lblPovezano";
            lblPovezano.Size = new Size(101, 13);
            lblPovezano.TabIndex = 100;
            lblPovezano.Text = "Povezani podaci";
            // 
            // btnKontaktTelefoni
            // 
            btnKontaktTelefoni.Location = new Point(720, 148);
            btnKontaktTelefoni.Name = "btnKontaktTelefoni";
            btnKontaktTelefoni.Size = new Size(240, 32);
            btnKontaktTelefoni.TabIndex = 10;
            btnKontaktTelefoni.Text = "Kontakt telefoni";
            btnKontaktTelefoni.UseVisualStyleBackColor = true;
            btnKontaktTelefoni.Click += btnKontaktTelefoni_Click;
            // 
            // btnKontaktMailovi
            // 
            btnKontaktMailovi.Location = new Point(720, 186);
            btnKontaktMailovi.Name = "btnKontaktMailovi";
            btnKontaktMailovi.Size = new Size(240, 32);
            btnKontaktMailovi.TabIndex = 10;
            btnKontaktMailovi.Text = "Kontakt mailovi";
            btnKontaktMailovi.UseVisualStyleBackColor = true;
            btnKontaktMailovi.Click += btnKontaktMailovi_Click;
            // 
            // btnNaucneOblasti
            // 
            btnNaucneOblasti.Location = new Point(720, 224);
            btnNaucneOblasti.Name = "btnNaucneOblasti";
            btnNaucneOblasti.Size = new Size(240, 32);
            btnNaucneOblasti.TabIndex = 10;
            btnNaucneOblasti.Text = "Naucne oblasti";
            btnNaucneOblasti.UseVisualStyleBackColor = true;
            btnNaucneOblasti.Click += btnNaucneOblasti_Click;
            // 
            // btnZaposleni
            // 
            btnZaposleni.Location = new Point(720, 262);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Size = new Size(240, 32);
            btnZaposleni.TabIndex = 10;
            btnZaposleni.Text = "Zaposleni istrazivaci";
            btnZaposleni.UseVisualStyleBackColor = true;
            btnZaposleni.Click += btnZaposleni_Click;
            // 
            // InstitucijeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 580);
            Controls.Add(groupBox);
            Controls.Add(btnDodaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi);
            Controls.Add(lblPovezano);
            Controls.Add(btnKontaktTelefoni);
            Controls.Add(btnKontaktMailovi);
            Controls.Add(btnNaucneOblasti);
            Controls.Add(btnZaposleni);
            Name = "InstitucijeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LISTA INSTITUCIJA";
            Load += InstitucijeForm_Load_1;
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
