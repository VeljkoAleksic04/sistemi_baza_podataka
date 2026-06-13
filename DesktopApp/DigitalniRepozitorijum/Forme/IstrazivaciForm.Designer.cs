namespace DigitalniRepozitorijum.Forme
{
    partial class IstrazivaciForm
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
                        this.colIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIme.HeaderText = "Ime";
            this.colIme.Name = "colIme";
            this.colIme.DataPropertyName = "Ime";
                        this.colPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrezime.HeaderText = "Prezime";
            this.colPrezime.Name = "colPrezime";
            this.colPrezime.DataPropertyName = "Prezime";
                        this.colDrzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrzava.HeaderText = "Drzava";
            this.colDrzava.Name = "colDrzava";
            this.colDrzava.DataPropertyName = "Drzava";
                        this.colNaucnoZvanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNaucnoZvanje.HeaderText = "NaucnoZvanje";
            this.colNaucnoZvanje.Name = "colNaucnoZvanje";
            this.colNaucnoZvanje.DataPropertyName = "NaucnoZvanje";
                        this.colNaucnaOblast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNaucnaOblast.HeaderText = "NaucnaOblast";
            this.colNaucnaOblast.Name = "colNaucnaOblast";
            this.colNaucnaOblast.DataPropertyName = "NaucnaOblast";
                        this.colStatusNaloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusNaloga.HeaderText = "StatusNaloga";
            this.colStatusNaloga.Name = "colStatusNaloga";
            this.colStatusNaloga.DataPropertyName = "StatusNaloga";
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
            this.groupBox.Text = "Lista istrazivaca";
            // dataGridView
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId, this.colIme, this.colPrezime, this.colDrzava, this.colNaucnoZvanje, this.colNaucnaOblast, this.colStatusNaloga
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
            this.btnDodaj.Text = "Dodaj istrazivaca";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnIzmeni.Location = new System.Drawing.Point(720, 50);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(240, 32);
            this.btnIzmeni.TabIndex = 10;
            this.btnIzmeni.Text = "Izmeni istrazivaca";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnObrisi.Location = new System.Drawing.Point(720, 88);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(240, 32);
            this.btnObrisi.TabIndex = 10;
            this.btnObrisi.Text = "Obrisi istrazivaca";
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
            this.btnTelefoni = new System.Windows.Forms.Button();
            this.btnTelefoni.Location = new System.Drawing.Point(720, 148);
            this.btnTelefoni.Name = "btnTelefoni";
            this.btnTelefoni.Size = new System.Drawing.Size(240, 32);
            this.btnTelefoni.TabIndex = 10;
            this.btnTelefoni.Text = "Telefoni";
            this.btnTelefoni.UseVisualStyleBackColor = true;
            this.btnTelefoni.Click += new System.EventHandler(this.btnTelefoni_Click);
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnEmail.Location = new System.Drawing.Point(720, 186);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(240, 32);
            this.btnEmail.TabIndex = 10;
            this.btnEmail.Text = "Email adrese";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            this.btnAngazovanja = new System.Windows.Forms.Button();
            this.btnAngazovanja.Location = new System.Drawing.Point(720, 224);
            this.btnAngazovanja.Name = "btnAngazovanja";
            this.btnAngazovanja.Size = new System.Drawing.Size(240, 32);
            this.btnAngazovanja.TabIndex = 10;
            this.btnAngazovanja.Text = "Angazovanja";
            this.btnAngazovanja.UseVisualStyleBackColor = true;
            this.btnAngazovanja.Click += new System.EventHandler(this.btnAngazovanja_Click);
            this.btnPublikacije = new System.Windows.Forms.Button();
            this.btnPublikacije.Location = new System.Drawing.Point(720, 262);
            this.btnPublikacije.Name = "btnPublikacije";
            this.btnPublikacije.Size = new System.Drawing.Size(240, 32);
            this.btnPublikacije.TabIndex = 10;
            this.btnPublikacije.Text = "Publikacije autora";
            this.btnPublikacije.UseVisualStyleBackColor = true;
            this.btnPublikacije.Click += new System.EventHandler(this.btnPublikacije_Click);
            // IstrazivaciForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblPovezano);
            this.Controls.Add(this.btnTelefoni);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnAngazovanja);
            this.Controls.Add(this.btnPublikacije);
            this.Name = "IstrazivaciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA ISTRAZIVACA";
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrzava;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaucnoZvanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaucnaOblast;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusNaloga;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblPovezano;
        private System.Windows.Forms.Button btnTelefoni;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnAngazovanja;
        private System.Windows.Forms.Button btnPublikacije;
    }
}
