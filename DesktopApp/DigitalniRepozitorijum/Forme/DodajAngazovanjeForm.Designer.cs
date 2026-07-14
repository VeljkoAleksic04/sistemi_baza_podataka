namespace DigitalniRepozitorijum.Forme
{
    partial class DodajAngazovanjeForm
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
            lblInstitucija = new Label();
            lblOrganizacionaJedinica = new Label();
            txtOrganizacionaJedinica = new TextBox();
            lblTipAngazovanja = new Label();
            txtTipAngazovanja = new TextBox();
            lblNazivPozicije = new Label();
            txtNazivPozicije = new TextBox();
            lblDatumPocetka = new Label();
            lblDatumZavrsetka = new Label();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            datePocetka = new DateTimePicker();
            dateZavrsetka = new DateTimePicker();
            cmbInstitucije = new ComboBox();
            SuspendLayout();
            // 
            // lblInstitucija
            // 
            lblInstitucija.AutoSize = true;
            lblInstitucija.Location = new Point(20, 20);
            lblInstitucija.Name = "lblInstitucija";
            lblInstitucija.Size = new Size(61, 15);
            lblInstitucija.TabIndex = 0;
            lblInstitucija.Text = "Institucija:";
            // 
            // lblOrganizacionaJedinica
            // 
            lblOrganizacionaJedinica.AutoSize = true;
            lblOrganizacionaJedinica.Location = new Point(20, 55);
            lblOrganizacionaJedinica.Name = "lblOrganizacionaJedinica";
            lblOrganizacionaJedinica.Size = new Size(77, 15);
            lblOrganizacionaJedinica.TabIndex = 0;
            lblOrganizacionaJedinica.Text = "Org. jedinica:";
            // 
            // txtOrganizacionaJedinica
            // 
            txtOrganizacionaJedinica.Location = new Point(160, 52);
            txtOrganizacionaJedinica.Name = "txtOrganizacionaJedinica";
            txtOrganizacionaJedinica.Size = new Size(230, 23);
            txtOrganizacionaJedinica.TabIndex = 1;
            // 
            // lblTipAngazovanja
            // 
            lblTipAngazovanja.AutoSize = true;
            lblTipAngazovanja.Location = new Point(20, 90);
            lblTipAngazovanja.Name = "lblTipAngazovanja";
            lblTipAngazovanja.Size = new Size(27, 15);
            lblTipAngazovanja.TabIndex = 0;
            lblTipAngazovanja.Text = "Tip:";
            // 
            // txtTipAngazovanja
            // 
            txtTipAngazovanja.Location = new Point(160, 87);
            txtTipAngazovanja.Name = "txtTipAngazovanja";
            txtTipAngazovanja.Size = new Size(230, 23);
            txtTipAngazovanja.TabIndex = 1;
            // 
            // lblNazivPozicije
            // 
            lblNazivPozicije.AutoSize = true;
            lblNazivPozicije.Location = new Point(20, 125);
            lblNazivPozicije.Name = "lblNazivPozicije";
            lblNazivPozicije.Size = new Size(50, 15);
            lblNazivPozicije.TabIndex = 0;
            lblNazivPozicije.Text = "Pozicija:";
            // 
            // txtNazivPozicije
            // 
            txtNazivPozicije.Location = new Point(160, 122);
            txtNazivPozicije.Name = "txtNazivPozicije";
            txtNazivPozicije.Size = new Size(230, 23);
            txtNazivPozicije.TabIndex = 1;
            // 
            // lblDatumPocetka
            // 
            lblDatumPocetka.AutoSize = true;
            lblDatumPocetka.Location = new Point(20, 160);
            lblDatumPocetka.Name = "lblDatumPocetka";
            lblDatumPocetka.Size = new Size(91, 15);
            lblDatumPocetka.TabIndex = 0;
            lblDatumPocetka.Text = "Datum pocetka:";
            // 
            // lblDatumZavrsetka
            // 
            lblDatumZavrsetka.AutoSize = true;
            lblDatumZavrsetka.Location = new Point(20, 195);
            lblDatumZavrsetka.Name = "lblDatumZavrsetka";
            lblDatumZavrsetka.Size = new Size(97, 15);
            lblDatumZavrsetka.TabIndex = 0;
            lblDatumZavrsetka.Text = "Datum zavrsetka:";
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 240);
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
            btnOdustani.Location = new Point(280, 240);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            // 
            // datePocetka
            // 
            datePocetka.Location = new Point(160, 157);
            datePocetka.Name = "datePocetka";
            datePocetka.Size = new Size(230, 23);
            datePocetka.TabIndex = 52;
            // 
            // dateZavrsetka
            // 
            dateZavrsetka.Location = new Point(160, 190);
            dateZavrsetka.Name = "dateZavrsetka";
            dateZavrsetka.Size = new Size(230, 23);
            dateZavrsetka.TabIndex = 53;
            dateZavrsetka.Value = new DateTime(1953, 1, 1, 0, 0, 0, 0);
            // 
            // cmbInstitucije
            // 
            cmbInstitucije.FormattingEnabled = true;
            cmbInstitucije.Location = new Point(160, 17);
            cmbInstitucije.Name = "cmbInstitucije";
            cmbInstitucije.Size = new Size(230, 23);
            cmbInstitucije.TabIndex = 54;
            // 
            // DodajAngazovanjeForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 350);
            Controls.Add(cmbInstitucije);
            Controls.Add(dateZavrsetka);
            Controls.Add(datePocetka);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblInstitucija);
            Controls.Add(lblOrganizacionaJedinica);
            Controls.Add(txtOrganizacionaJedinica);
            Controls.Add(lblTipAngazovanja);
            Controls.Add(txtTipAngazovanja);
            Controls.Add(lblNazivPozicije);
            Controls.Add(txtNazivPozicije);
            Controls.Add(lblDatumPocetka);
            Controls.Add(lblDatumZavrsetka);
            Name = "DodajAngazovanjeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj angazovanje";
            Load += DodajAngazovanjeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblInstitucija;
        private System.Windows.Forms.Label lblOrganizacionaJedinica;
        private System.Windows.Forms.TextBox txtOrganizacionaJedinica;
        private System.Windows.Forms.Label lblTipAngazovanja;
        private System.Windows.Forms.TextBox txtTipAngazovanja;
        private System.Windows.Forms.Label lblNazivPozicije;
        private System.Windows.Forms.TextBox txtNazivPozicije;
        private System.Windows.Forms.Label lblDatumPocetka;
        private System.Windows.Forms.Label lblDatumZavrsetka;
        private DateTimePicker datePocetka;
        private DateTimePicker dateZavrsetka;
        private ComboBox cmbInstitucije;
    }
}
