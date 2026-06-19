namespace DigitalniRepozitorijum.Forme
{
    partial class VerzijePublikacijeForm
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
            colIdVerzije = new DataGridViewTextBoxColumn();
            colBrojVerzije = new DataGridViewTextBoxColumn();
            colDatumPostavljanja = new DataGridViewTextBoxColumn();
            colOpisIzmene = new DataGridViewTextBoxColumn();
            colOdgovornaOsoba = new DataGridViewTextBoxColumn();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
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
            groupBox.Text = "Verzije publikacije";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colIdVerzije, colBrojVerzije, colDatumPostavljanja, colOpisIzmene, colOdgovornaOsoba });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(684, 534);
            dataGridView.TabIndex = 0;
            // 
            // colIdVerzije
            // 
            colIdVerzije.DataPropertyName = "IdVerzije";
            colIdVerzije.HeaderText = "IdVerzije";
            colIdVerzije.Name = "colIdVerzije";
            colIdVerzije.ReadOnly = true;
            // 
            // colBrojVerzije
            // 
            colBrojVerzije.DataPropertyName = "BrojVerzije";
            colBrojVerzije.HeaderText = "BrojVerzije";
            colBrojVerzije.Name = "colBrojVerzije";
            colBrojVerzije.ReadOnly = true;
            // 
            // colDatumPostavljanja
            // 
            colDatumPostavljanja.DataPropertyName = "DatumPostavljanja";
            colDatumPostavljanja.HeaderText = "DatumPostavljanja";
            colDatumPostavljanja.Name = "colDatumPostavljanja";
            colDatumPostavljanja.ReadOnly = true;
            // 
            // colOpisIzmene
            // 
            colOpisIzmene.DataPropertyName = "OpisIzmene";
            colOpisIzmene.HeaderText = "OpisIzmene";
            colOpisIzmene.Name = "colOpisIzmene";
            colOpisIzmene.ReadOnly = true;
            // 
            // colOdgovornaOsoba
            // 
            colOdgovornaOsoba.DataPropertyName = "OdgovornaOsoba";
            colOdgovornaOsoba.HeaderText = "OdgovornaOsoba";
            colOdgovornaOsoba.Name = "colOdgovornaOsoba";
            colOdgovornaOsoba.ReadOnly = true;
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
            // VerzijePublikacijeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 580);
            Controls.Add(groupBox);
            Controls.Add(btnDodaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi);
            Name = "VerzijePublikacijeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VERZIJE PUBLIKACIJE";
            Load += VerzijePublikacijeForm_Load;
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdVerzije;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrojVerzije;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumPostavljanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpisIzmene;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOdgovornaOsoba;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
    }
}
