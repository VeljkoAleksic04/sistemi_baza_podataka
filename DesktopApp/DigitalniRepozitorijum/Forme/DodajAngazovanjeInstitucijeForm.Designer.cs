namespace DigitalniRepozitorijum.Forme
{
    partial class DodajAngazovanjeInstitucijeForm
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

        private void InitializeComponent()
        {
            lblIstrazivac = new Label();
            lblTipAngazovanja = new Label();
            txtTipAngazovanja = new TextBox();
            lblNazivPozicije = new Label();
            txtNazivPozicije = new TextBox();
            lblDatumPocetka = new Label();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            cmbIstrazivaci = new ComboBox();
            datePocetka = new DateTimePicker();
            dateZavrsetka = new DateTimePicker();
            lblDatumZavrsetka = new Label();
            SuspendLayout();
            // 
            // lblIstrazivac
            // 
            lblIstrazivac.AutoSize = true;
            lblIstrazivac.Location = new Point(20, 20);
            lblIstrazivac.Name = "lblIstrazivac";
            lblIstrazivac.Size = new Size(58, 15);
            lblIstrazivac.TabIndex = 0;
            lblIstrazivac.Text = "Istrazivac:";
            // 
            // lblTipAngazovanja
            // 
            lblTipAngazovanja.AutoSize = true;
            lblTipAngazovanja.Location = new Point(20, 55);
            lblTipAngazovanja.Name = "lblTipAngazovanja";
            lblTipAngazovanja.Size = new Size(27, 15);
            lblTipAngazovanja.TabIndex = 0;
            lblTipAngazovanja.Text = "Tip:";
            // 
            // txtTipAngazovanja
            // 
            txtTipAngazovanja.Location = new Point(160, 52);
            txtTipAngazovanja.Name = "txtTipAngazovanja";
            txtTipAngazovanja.Size = new Size(230, 23);
            txtTipAngazovanja.TabIndex = 1;
            // 
            // lblNazivPozicije
            // 
            lblNazivPozicije.AutoSize = true;
            lblNazivPozicije.Location = new Point(20, 90);
            lblNazivPozicije.Name = "lblNazivPozicije";
            lblNazivPozicije.Size = new Size(50, 15);
            lblNazivPozicije.TabIndex = 0;
            lblNazivPozicije.Text = "Pozicija:";
            // 
            // txtNazivPozicije
            // 
            txtNazivPozicije.Location = new Point(160, 87);
            txtNazivPozicije.Name = "txtNazivPozicije";
            txtNazivPozicije.Size = new Size(230, 23);
            txtNazivPozicije.TabIndex = 1;
            // 
            // lblDatumPocetka
            // 
            lblDatumPocetka.AutoSize = true;
            lblDatumPocetka.Location = new Point(20, 125);
            lblDatumPocetka.Name = "lblDatumPocetka";
            lblDatumPocetka.Size = new Size(91, 15);
            lblDatumPocetka.TabIndex = 0;
            lblDatumPocetka.Text = "Datum pocetka:";
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 195);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(110, 32);
            btnPotvrdi.TabIndex = 50;
            btnPotvrdi.Text = "Potvrdi";
            btnPotvrdi.UseVisualStyleBackColor = true;
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.DialogResult = DialogResult.Cancel;
            btnOdustani.Location = new Point(280, 195);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            // 
            // cmbIstrazivaci
            // 
            cmbIstrazivaci.FormattingEnabled = true;
            cmbIstrazivaci.Location = new Point(160, 17);
            cmbIstrazivaci.Name = "cmbIstrazivaci";
            cmbIstrazivaci.Size = new Size(230, 23);
            cmbIstrazivaci.TabIndex = 52;
            // 
            // datePocetka
            // 
            datePocetka.Location = new Point(160, 125);
            datePocetka.Name = "datePocetka";
            datePocetka.Size = new Size(230, 23);
            datePocetka.TabIndex = 53;
            // 
            // dateZavrsetka
            // 
            dateZavrsetka.Location = new Point(160, 158);
            dateZavrsetka.Name = "dateZavrsetka";
            dateZavrsetka.Size = new Size(230, 23);
            dateZavrsetka.TabIndex = 55;
            // 
            // lblDatumZavrsetka
            // 
            lblDatumZavrsetka.AutoSize = true;
            lblDatumZavrsetka.Location = new Point(20, 158);
            lblDatumZavrsetka.Name = "lblDatumZavrsetka";
            lblDatumZavrsetka.Size = new Size(97, 15);
            lblDatumZavrsetka.TabIndex = 54;
            lblDatumZavrsetka.Text = "Datum zavrsetka:";
            // 
            // DodajAngazovanjeInstitucijeForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 280);
            Controls.Add(dateZavrsetka);
            Controls.Add(lblDatumZavrsetka);
            Controls.Add(datePocetka);
            Controls.Add(cmbIstrazivaci);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblIstrazivac);
            Controls.Add(lblTipAngazovanja);
            Controls.Add(txtTipAngazovanja);
            Controls.Add(lblNazivPozicije);
            Controls.Add(txtNazivPozicije);
            Controls.Add(lblDatumPocetka);
            Name = "DodajAngazovanjeInstitucijeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj zaposlenog";
            Load += DodajAngazovanjeInstitucijeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblIstrazivac;
        private System.Windows.Forms.Label lblTipAngazovanja;
        private System.Windows.Forms.TextBox txtTipAngazovanja;
        private System.Windows.Forms.Label lblNazivPozicije;
        private System.Windows.Forms.TextBox txtNazivPozicije;
        private System.Windows.Forms.Label lblDatumPocetka;
        private ComboBox cmbIstrazivaci;
        private DateTimePicker datePocetka;
        private DateTimePicker dateZavrsetka;
        private Label lblDatumZavrsetka;
    }
}
