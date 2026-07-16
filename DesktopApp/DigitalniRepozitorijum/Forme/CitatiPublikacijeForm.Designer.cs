namespace DigitalniRepozitorijum.Forme
{
    partial class CitatiPublikacijeForm
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
            colIdCitata = new DataGridViewTextBoxColumn();
            IdPubCitata = new DataGridViewTextBoxColumn();
            colTekst = new DataGridViewTextBoxColumn();
            colTipCitata = new DataGridViewTextBoxColumn();
            colMestoCitiranja = new DataGridViewTextBoxColumn();
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
            groupBox.Text = "Citati publikacije";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colIdCitata, IdPubCitata, colTekst, colTipCitata, colMestoCitiranja });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(684, 534);
            dataGridView.TabIndex = 0;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // colIdCitata
            // 
            colIdCitata.DataPropertyName = "IdCitata";
            colIdCitata.HeaderText = "IdCitata";
            colIdCitata.Name = "colIdCitata";
            colIdCitata.ReadOnly = true;
            // 
            // IdPubCitata
            // 
            IdPubCitata.HeaderText = "CitiranaPublikacija";
            IdPubCitata.Name = "IdPubCitata";
            IdPubCitata.ReadOnly = true;
            // 
            // colTekst
            // 
            colTekst.DataPropertyName = "Tekst";
            colTekst.HeaderText = "TekstualniKontekst";
            colTekst.Name = "colTekst";
            colTekst.ReadOnly = true;
            // 
            // colTipCitata
            // 
            colTipCitata.DataPropertyName = "TipCitata";
            colTipCitata.HeaderText = "TipCitata";
            colTipCitata.Name = "colTipCitata";
            colTipCitata.ReadOnly = true;
            // 
            // colMestoCitiranja
            // 
            colMestoCitiranja.DataPropertyName = "MestoCitiranja";
            colMestoCitiranja.HeaderText = "MestoCitiranja";
            colMestoCitiranja.Name = "colMestoCitiranja";
            colMestoCitiranja.ReadOnly = true;
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
            // CitatiPublikacijeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 580);
            Controls.Add(groupBox);
            Controls.Add(btnDodaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi);
            Name = "CitatiPublikacijeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CITATI";
            Load += CitatiPublikacijeForm_Load;
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
        private DataGridViewTextBoxColumn colIdCitata;
        private DataGridViewTextBoxColumn IdPubCitata;
        private DataGridViewTextBoxColumn colTekst;
        private DataGridViewTextBoxColumn colTipCitata;
        private DataGridViewTextBoxColumn colMestoCitiranja;
    }
}
