namespace DigitalniRepozitorijum.Forme
{
    partial class PublikacijeForm
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
            colNaslov = new DataGridViewTextBoxColumn();
            colJezik = new DataGridViewTextBoxColumn();
            colDatumObjavljivanja = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colVidljivost = new DataGridViewTextBoxColumn();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            lblPovezano = new Label();
            btnAutori = new Button();
            btnVerzije = new Button();
            btnKljucneReci = new Button();
            btnCitati = new Button();
            btnPovezane = new Button();
            lblTipovi = new Label();
            btnNaucniRadovi = new Button();
            btnKnjige = new Button();
            btnPoglavlja = new Button();
            btnDoktorske = new Button();
            btnDatasetovi = new Button();
            btnSoftverski = new Button();
            btnObrazovni = new Button();
            btnPrezentacije = new Button();
            btnTehnicki = new Button();
            btnRecenzije = new Button();
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
            groupBox.Text = "Lista publikacija";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colId, colNaslov, colJezik, colDatumObjavljivanja, colStatus, colVidljivost });
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
            // colNaslov
            // 
            colNaslov.DataPropertyName = "Naslov";
            colNaslov.HeaderText = "Naslov";
            colNaslov.Name = "colNaslov";
            colNaslov.ReadOnly = true;
            // 
            // colJezik
            // 
            colJezik.DataPropertyName = "Jezik";
            colJezik.HeaderText = "Jezik";
            colJezik.Name = "colJezik";
            colJezik.ReadOnly = true;
            // 
            // colDatumObjavljivanja
            // 
            colDatumObjavljivanja.DataPropertyName = "DatumObjavljivanja";
            colDatumObjavljivanja.HeaderText = "DatumObjavljivanja";
            colDatumObjavljivanja.Name = "colDatumObjavljivanja";
            colDatumObjavljivanja.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colVidljivost
            // 
            colVidljivost.DataPropertyName = "Vidljivost";
            colVidljivost.HeaderText = "Vidljivost";
            colVidljivost.Name = "colVidljivost";
            colVidljivost.ReadOnly = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(720, 12);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(240, 32);
            btnDodaj.TabIndex = 10;
            btnDodaj.Text = "Dodaj publikaciju";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(720, 50);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(240, 32);
            btnIzmeni.TabIndex = 10;
            btnIzmeni.Text = "Izmeni publikaciju";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(720, 88);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(240, 32);
            btnObrisi.TabIndex = 10;
            btnObrisi.Text = "Obrisi publikaciju";
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
            // btnAutori
            // 
            btnAutori.Location = new Point(720, 148);
            btnAutori.Name = "btnAutori";
            btnAutori.Size = new Size(240, 32);
            btnAutori.TabIndex = 10;
            btnAutori.Text = "Autori publikacije";
            btnAutori.UseVisualStyleBackColor = true;
            btnAutori.Click += btnAutori_Click;
            // 
            // btnVerzije
            // 
            btnVerzije.Location = new Point(720, 186);
            btnVerzije.Name = "btnVerzije";
            btnVerzije.Size = new Size(240, 32);
            btnVerzije.TabIndex = 10;
            btnVerzije.Text = "Verzije publikacije";
            btnVerzije.UseVisualStyleBackColor = true;
            btnVerzije.Click += btnVerzije_Click;
            // 
            // btnKljucneReci
            // 
            btnKljucneReci.Location = new Point(720, 224);
            btnKljucneReci.Name = "btnKljucneReci";
            btnKljucneReci.Size = new Size(240, 32);
            btnKljucneReci.TabIndex = 10;
            btnKljucneReci.Text = "Ključne reci";
            btnKljucneReci.UseVisualStyleBackColor = true;
            btnKljucneReci.Click += btnKljucneReci_Click;
            // 
            // btnCitati
            // 
            btnCitati.Location = new Point(720, 262);
            btnCitati.Name = "btnCitati";
            btnCitati.Size = new Size(240, 32);
            btnCitati.TabIndex = 10;
            btnCitati.Text = "Citati";
            btnCitati.UseVisualStyleBackColor = true;
            btnCitati.Click += btnCitati_Click;
            // 
            // btnPovezane
            // 
            btnPovezane.Location = new Point(720, 300);
            btnPovezane.Name = "btnPovezane";
            btnPovezane.Size = new Size(240, 32);
            btnPovezane.TabIndex = 10;
            btnPovezane.Text = "Povezane publikacije";
            btnPovezane.UseVisualStyleBackColor = true;
            btnPovezane.Click += btnPovezane_Click;
            // 
            // lblTipovi
            // 
            lblTipovi.AutoSize = true;
            lblTipovi.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblTipovi.Location = new Point(720, 381);
            lblTipovi.Name = "lblTipovi";
            lblTipovi.Size = new Size(107, 13);
            lblTipovi.TabIndex = 100;
            lblTipovi.Text = "Tipovi publikacije";
            // 
            // btnNaucniRadovi
            // 
            btnNaucniRadovi.Location = new Point(720, 403);
            btnNaucniRadovi.Name = "btnNaucniRadovi";
            btnNaucniRadovi.Size = new Size(240, 32);
            btnNaucniRadovi.TabIndex = 10;
            btnNaucniRadovi.Text = "Naučni radovi";
            btnNaucniRadovi.UseVisualStyleBackColor = true;
            btnNaucniRadovi.Click += btnNaucniRadovi_Click;
            // 
            // btnKnjige
            // 
            btnKnjige.Location = new Point(720, 441);
            btnKnjige.Name = "btnKnjige";
            btnKnjige.Size = new Size(240, 32);
            btnKnjige.TabIndex = 10;
            btnKnjige.Text = "Knjige";
            btnKnjige.UseVisualStyleBackColor = true;
            btnKnjige.Click += btnKnjige_Click;
            // 
            // btnPoglavlja
            // 
            btnPoglavlja.Location = new Point(720, 479);
            btnPoglavlja.Name = "btnPoglavlja";
            btnPoglavlja.Size = new Size(240, 32);
            btnPoglavlja.TabIndex = 10;
            btnPoglavlja.Text = "Poglavlja u knjizi";
            btnPoglavlja.UseVisualStyleBackColor = true;
            btnPoglavlja.Click += btnPoglavlja_Click;
            // 
            // btnDoktorske
            // 
            btnDoktorske.Location = new Point(720, 517);
            btnDoktorske.Name = "btnDoktorske";
            btnDoktorske.Size = new Size(240, 32);
            btnDoktorske.TabIndex = 10;
            btnDoktorske.Text = "Doktorske disertacije";
            btnDoktorske.UseVisualStyleBackColor = true;
            btnDoktorske.Click += btnDoktorske_Click;
            // 
            // btnDatasetovi
            // 
            btnDatasetovi.Location = new Point(720, 555);
            btnDatasetovi.Name = "btnDatasetovi";
            btnDatasetovi.Size = new Size(240, 32);
            btnDatasetovi.TabIndex = 10;
            btnDatasetovi.Text = "Datasetovi";
            btnDatasetovi.UseVisualStyleBackColor = true;
            btnDatasetovi.Click += btnDatasetovi_Click;
            // 
            // btnSoftverski
            // 
            btnSoftverski.Location = new Point(720, 593);
            btnSoftverski.Name = "btnSoftverski";
            btnSoftverski.Size = new Size(240, 32);
            btnSoftverski.TabIndex = 10;
            btnSoftverski.Text = "Softverski artefakti";
            btnSoftverski.UseVisualStyleBackColor = true;
            btnSoftverski.Click += btnSoftverski_Click;
            // 
            // btnObrazovni
            // 
            btnObrazovni.Location = new Point(720, 631);
            btnObrazovni.Name = "btnObrazovni";
            btnObrazovni.Size = new Size(240, 32);
            btnObrazovni.TabIndex = 10;
            btnObrazovni.Text = "Obrazovni materijali";
            btnObrazovni.UseVisualStyleBackColor = true;
            btnObrazovni.Click += btnObrazovni_Click;
            // 
            // btnPrezentacije
            // 
            btnPrezentacije.Location = new Point(720, 669);
            btnPrezentacije.Name = "btnPrezentacije";
            btnPrezentacije.Size = new Size(240, 32);
            btnPrezentacije.TabIndex = 10;
            btnPrezentacije.Text = "Prezentacije";
            btnPrezentacije.UseVisualStyleBackColor = true;
            btnPrezentacije.Click += btnPrezentacije_Click;
            // 
            // btnTehnicki
            // 
            btnTehnicki.Location = new Point(720, 707);
            btnTehnicki.Name = "btnTehnicki";
            btnTehnicki.Size = new Size(240, 32);
            btnTehnicki.TabIndex = 10;
            btnTehnicki.Text = "Tehnicki izvestaji";
            btnTehnicki.UseVisualStyleBackColor = true;
            btnTehnicki.Click += btnTehnicki_Click;
            // 
            // btnRecenzije
            // 
            btnRecenzije.Location = new Point(720, 338);
            btnRecenzije.Name = "btnRecenzije";
            btnRecenzije.Size = new Size(240, 32);
            btnRecenzije.TabIndex = 101;
            btnRecenzije.Text = "Recenzije publikacije";
            btnRecenzije.UseVisualStyleBackColor = true;
            btnRecenzije.Click += btnRecenzije_Click;
            // 
            // PublikacijeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 767);
            Controls.Add(btnRecenzije);
            Controls.Add(groupBox);
            Controls.Add(btnDodaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi);
            Controls.Add(lblPovezano);
            Controls.Add(btnAutori);
            Controls.Add(btnVerzije);
            Controls.Add(btnKljucneReci);
            Controls.Add(btnCitati);
            Controls.Add(btnPovezane);
            Controls.Add(lblTipovi);
            Controls.Add(btnNaucniRadovi);
            Controls.Add(btnKnjige);
            Controls.Add(btnPoglavlja);
            Controls.Add(btnDoktorske);
            Controls.Add(btnDatasetovi);
            Controls.Add(btnSoftverski);
            Controls.Add(btnObrazovni);
            Controls.Add(btnPrezentacije);
            Controls.Add(btnTehnicki);
            Name = "PublikacijeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LISTA PUBLIKACIJA";
            Load += PublikacijeForm_Load;
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJezik;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumObjavljivanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVidljivost;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblPovezano;
        private System.Windows.Forms.Button btnAutori;
        private System.Windows.Forms.Button btnVerzije;
        private System.Windows.Forms.Button btnKljucneReci;
        private System.Windows.Forms.Button btnCitati;
        private System.Windows.Forms.Button btnPovezane;
        private System.Windows.Forms.Label lblTipovi;
        private System.Windows.Forms.Button btnNaucniRadovi;
        private System.Windows.Forms.Button btnKnjige;
        private System.Windows.Forms.Button btnPoglavlja;
        private System.Windows.Forms.Button btnDoktorske;
        private System.Windows.Forms.Button btnDatasetovi;
        private System.Windows.Forms.Button btnSoftverski;
        private System.Windows.Forms.Button btnObrazovni;
        private System.Windows.Forms.Button btnPrezentacije;
        private System.Windows.Forms.Button btnTehnicki;
        private Button btnRecenzije;
    }
}
