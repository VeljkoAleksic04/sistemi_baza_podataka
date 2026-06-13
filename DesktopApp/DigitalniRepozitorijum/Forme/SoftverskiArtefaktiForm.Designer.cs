namespace DigitalniRepozitorijum.Forme
{
    partial class SoftverskiArtefaktiForm
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
                        this.colNaslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNaslov.HeaderText = "Naslov";
            this.colNaslov.Name = "colNaslov";
            this.colNaslov.DataPropertyName = "Naslov";
                        this.colProgramskiJezik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProgramskiJezik.HeaderText = "ProgramskiJezik";
            this.colProgramskiJezik.Name = "colProgramskiJezik";
            this.colProgramskiJezik.DataPropertyName = "ProgramskiJezik";
                        this.colNacinLicenciranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNacinLicenciranja.HeaderText = "NacinLicenciranja";
            this.colNacinLicenciranja.Name = "colNacinLicenciranja";
            this.colNacinLicenciranja.DataPropertyName = "NacinLicenciranja";
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
            this.groupBox.Text = "Softverski artefakti";
            // dataGridView
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId, this.colNaslov, this.colProgramskiJezik, this.colNacinLicenciranja
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
            this.btnExtra = new System.Windows.Forms.Button();
            this.btnExtra.Location = new System.Drawing.Point(720, 126);
            this.btnExtra.Name = "btnExtra";
            this.btnExtra.Size = new System.Drawing.Size(240, 32);
            this.btnExtra.TabIndex = 10;
            this.btnExtra.Text = "Podrzane platforme";
            this.btnExtra.UseVisualStyleBackColor = true;
            this.btnExtra.Click += new System.EventHandler(this.btnExtra_Click);
            // SoftverskiArtefaktiForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnExtra);
            this.Name = "SoftverskiArtefaktiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOFTVERSKI ARTEFAKTI";
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramskiJezik;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNacinLicenciranja;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnExtra;
    }
}
