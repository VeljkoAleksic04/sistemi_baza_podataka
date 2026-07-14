namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniAngazovanjeForm
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
            dateZavrsetka = new DateTimePicker();
            datePocetka = new DateTimePicker();
            SuspendLayout();
            // 
            // lblOrganizacionaJedinica
            // 
            lblOrganizacionaJedinica.AutoSize = true;
            lblOrganizacionaJedinica.Location = new Point(20, 20);
            lblOrganizacionaJedinica.Name = "lblOrganizacionaJedinica";
            lblOrganizacionaJedinica.Size = new Size(77, 15);
            lblOrganizacionaJedinica.TabIndex = 0;
            lblOrganizacionaJedinica.Text = "Org. jedinica:";
            // 
            // txtOrganizacionaJedinica
            // 
            txtOrganizacionaJedinica.Location = new Point(160, 17);
            txtOrganizacionaJedinica.Name = "txtOrganizacionaJedinica";
            txtOrganizacionaJedinica.Size = new Size(230, 23);
            txtOrganizacionaJedinica.TabIndex = 1;
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
            // lblDatumZavrsetka
            // 
            lblDatumZavrsetka.AutoSize = true;
            lblDatumZavrsetka.Location = new Point(20, 160);
            lblDatumZavrsetka.Name = "lblDatumZavrsetka";
            lblDatumZavrsetka.Size = new Size(97, 15);
            lblDatumZavrsetka.TabIndex = 0;
            lblDatumZavrsetka.Text = "Datum zavrsetka:";
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 205);
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
            btnOdustani.Location = new Point(280, 205);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            // 
            // dateZavrsetka
            // 
            dateZavrsetka.Location = new Point(160, 158);
            dateZavrsetka.Name = "dateZavrsetka";
            dateZavrsetka.Size = new Size(230, 23);
            dateZavrsetka.TabIndex = 55;
            dateZavrsetka.Value = new DateTime(1953, 1, 1, 0, 0, 0, 0);
            // 
            // datePocetka
            // 
            datePocetka.Location = new Point(160, 125);
            datePocetka.Name = "datePocetka";
            datePocetka.Size = new Size(230, 23);
            datePocetka.TabIndex = 54;
            // 
            // IzmeniAngazovanjeForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 315);
            Controls.Add(dateZavrsetka);
            Controls.Add(datePocetka);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblOrganizacionaJedinica);
            Controls.Add(txtOrganizacionaJedinica);
            Controls.Add(lblTipAngazovanja);
            Controls.Add(txtTipAngazovanja);
            Controls.Add(lblNazivPozicije);
            Controls.Add(txtNazivPozicije);
            Controls.Add(lblDatumPocetka);
            Controls.Add(lblDatumZavrsetka);
            Name = "IzmeniAngazovanjeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni angazovanje";
            Load += IzmeniAngazovanjeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblOrganizacionaJedinica;
        private System.Windows.Forms.TextBox txtOrganizacionaJedinica;
        private System.Windows.Forms.Label lblTipAngazovanja;
        private System.Windows.Forms.TextBox txtTipAngazovanja;
        private System.Windows.Forms.Label lblNazivPozicije;
        private System.Windows.Forms.TextBox txtNazivPozicije;
        private System.Windows.Forms.Label lblDatumPocetka;
        private System.Windows.Forms.Label lblDatumZavrsetka;
        private DateTimePicker dateZavrsetka;
        private DateTimePicker datePocetka;
    }
}
