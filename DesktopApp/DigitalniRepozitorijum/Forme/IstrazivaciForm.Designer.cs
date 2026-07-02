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
            groupBox = new GroupBox();
            dataGridView = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colIme = new DataGridViewTextBoxColumn();
            colPrezime = new DataGridViewTextBoxColumn();
            colDrzava = new DataGridViewTextBoxColumn();
            colNaucnoZvanje = new DataGridViewTextBoxColumn();
            colNaucnaOblast = new DataGridViewTextBoxColumn();
            colStatusNaloga = new DataGridViewTextBoxColumn();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            lblPovezano = new Label();
            btnTelefoni = new Button();
            btnEmail = new Button();
            btnAngazovanja = new Button();
            btnPublikacije = new Button();
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
            groupBox.Text = "Lista istrazivaca";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colId, colIme, colPrezime, colDrzava, colNaucnoZvanje, colNaucnaOblast, colStatusNaloga });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(684, 534);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colIme
            // 
            colIme.DataPropertyName = "Ime";
            colIme.HeaderText = "Ime";
            colIme.Name = "colIme";
            colIme.ReadOnly = true;
            // 
            // colPrezime
            // 
            colPrezime.DataPropertyName = "Prezime";
            colPrezime.HeaderText = "Prezime";
            colPrezime.Name = "colPrezime";
            colPrezime.ReadOnly = true;
            // 
            // colDrzava
            // 
            colDrzava.DataPropertyName = "Drzava";
            colDrzava.HeaderText = "Drzava";
            colDrzava.Name = "colDrzava";
            colDrzava.ReadOnly = true;
            // 
            // colNaucnoZvanje
            // 
            colNaucnoZvanje.DataPropertyName = "NaucnoZvanje";
            colNaucnoZvanje.HeaderText = "NaucnoZvanje";
            colNaucnoZvanje.Name = "colNaucnoZvanje";
            colNaucnoZvanje.ReadOnly = true;
            // 
            // colNaucnaOblast
            // 
            colNaucnaOblast.DataPropertyName = "NaucnaOblast";
            colNaucnaOblast.HeaderText = "NaucnaOblast";
            colNaucnaOblast.Name = "colNaucnaOblast";
            colNaucnaOblast.ReadOnly = true;
            // 
            // colStatusNaloga
            // 
            colStatusNaloga.DataPropertyName = "StatusNaloga";
            colStatusNaloga.HeaderText = "StatusNaloga";
            colStatusNaloga.Name = "colStatusNaloga";
            colStatusNaloga.ReadOnly = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(720, 12);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(240, 32);
            btnDodaj.TabIndex = 10;
            btnDodaj.Text = "Dodaj istrazivaca";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(720, 50);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(240, 32);
            btnIzmeni.TabIndex = 10;
            btnIzmeni.Text = "Izmeni istrazivaca";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(720, 88);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(240, 32);
            btnObrisi.TabIndex = 10;
            btnObrisi.Text = "Obrisi istrazivaca";
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
            // btnTelefoni
            // 
            btnTelefoni.Location = new Point(720, 148);
            btnTelefoni.Name = "btnTelefoni";
            btnTelefoni.Size = new Size(240, 32);
            btnTelefoni.TabIndex = 10;
            btnTelefoni.Text = "Telefoni";
            btnTelefoni.UseVisualStyleBackColor = true;
            btnTelefoni.Click += btnTelefoni_Click;
            // 
            // btnEmail
            // 
            btnEmail.Location = new Point(720, 186);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(240, 32);
            btnEmail.TabIndex = 10;
            btnEmail.Text = "Email adrese";
            btnEmail.UseVisualStyleBackColor = true;
            btnEmail.Click += btnEmail_Click;
            // 
            // btnAngazovanja
            // 
            btnAngazovanja.Location = new Point(720, 224);
            btnAngazovanja.Name = "btnAngazovanja";
            btnAngazovanja.Size = new Size(240, 32);
            btnAngazovanja.TabIndex = 10;
            btnAngazovanja.Text = "Angazovanja";
            btnAngazovanja.UseVisualStyleBackColor = true;
            btnAngazovanja.Click += btnAngazovanja_Click;
            // 
            // btnPublikacije
            // 
            btnPublikacije.Location = new Point(720, 262);
            btnPublikacije.Name = "btnPublikacije";
            btnPublikacije.Size = new Size(240, 32);
            btnPublikacije.TabIndex = 10;
            btnPublikacije.Text = "Publikacije autora";
            btnPublikacije.UseVisualStyleBackColor = true;
            btnPublikacije.Click += btnPublikacije_Click;
            // 
            // IstrazivaciForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 580);
            Controls.Add(groupBox);
            Controls.Add(btnDodaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi);
            Controls.Add(lblPovezano);
            Controls.Add(btnTelefoni);
            Controls.Add(btnEmail);
            Controls.Add(btnAngazovanja);
            Controls.Add(btnPublikacije);
            Name = "IstrazivaciForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LISTA ISTRAZIVACA";
            Load += IstrazivaciForm_Load_2;
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
