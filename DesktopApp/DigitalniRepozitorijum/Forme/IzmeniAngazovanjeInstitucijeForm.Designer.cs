namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniAngazovanjeInstitucijeForm
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
            // lblTipAngazovanja
            // 
            lblTipAngazovanja.AutoSize = true;
            lblTipAngazovanja.Location = new Point(20, 20);
            lblTipAngazovanja.Name = "lblTipAngazovanja";
            lblTipAngazovanja.Size = new Size(27, 15);
            lblTipAngazovanja.TabIndex = 0;
            lblTipAngazovanja.Text = "Tip:";
            // 
            // txtTipAngazovanja
            // 
            txtTipAngazovanja.Location = new Point(160, 17);
            txtTipAngazovanja.Name = "txtTipAngazovanja";
            txtTipAngazovanja.Size = new Size(230, 23);
            txtTipAngazovanja.TabIndex = 1;
            // 
            // lblNazivPozicije
            // 
            lblNazivPozicije.AutoSize = true;
            lblNazivPozicije.Location = new Point(20, 55);
            lblNazivPozicije.Name = "lblNazivPozicije";
            lblNazivPozicije.Size = new Size(50, 15);
            lblNazivPozicije.TabIndex = 0;
            lblNazivPozicije.Text = "Pozicija:";
            // 
            // txtNazivPozicije
            // 
            txtNazivPozicije.Location = new Point(160, 52);
            txtNazivPozicije.Name = "txtNazivPozicije";
            txtNazivPozicije.Size = new Size(230, 23);
            txtNazivPozicije.TabIndex = 1;
            // 
            // lblDatumPocetka
            // 
            lblDatumPocetka.AutoSize = true;
            lblDatumPocetka.Location = new Point(20, 90);
            lblDatumPocetka.Name = "lblDatumPocetka";
            lblDatumPocetka.Size = new Size(91, 15);
            lblDatumPocetka.TabIndex = 0;
            lblDatumPocetka.Text = "Datum pocetka:";
            // 
            // lblDatumZavrsetka
            // 
            lblDatumZavrsetka.AutoSize = true;
            lblDatumZavrsetka.Location = new Point(20, 125);
            lblDatumZavrsetka.Name = "lblDatumZavrsetka";
            lblDatumZavrsetka.Size = new Size(97, 15);
            lblDatumZavrsetka.TabIndex = 0;
            lblDatumZavrsetka.Text = "Datum zavrsetka:";
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 170);
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
            btnOdustani.Location = new Point(280, 170);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            // 
            // dateZavrsetka
            // 
            dateZavrsetka.Location = new Point(160, 125);
            dateZavrsetka.Name = "dateZavrsetka";
            dateZavrsetka.Size = new Size(230, 23);
            dateZavrsetka.TabIndex = 52;
            dateZavrsetka.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // datePocetka
            // 
            datePocetka.Location = new Point(160, 90);
            datePocetka.Name = "datePocetka";
            datePocetka.Size = new Size(230, 23);
            datePocetka.TabIndex = 53;
            // 
            // IzmeniAngazovanjeInstitucijeForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 280);
            Controls.Add(datePocetka);
            Controls.Add(dateZavrsetka);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblTipAngazovanja);
            Controls.Add(txtTipAngazovanja);
            Controls.Add(lblNazivPozicije);
            Controls.Add(txtNazivPozicije);
            Controls.Add(lblDatumPocetka);
            Controls.Add(lblDatumZavrsetka);
            Name = "IzmeniAngazovanjeInstitucijeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni angazovanje";
            Load += IzmeniAngazovanjeInstitucijeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblTipAngazovanja;
        private System.Windows.Forms.TextBox txtTipAngazovanja;
        private System.Windows.Forms.Label lblNazivPozicije;
        private System.Windows.Forms.TextBox txtNazivPozicije;
        private System.Windows.Forms.Label lblDatumPocetka;
        private System.Windows.Forms.TextBox txtDatumPocetka;
        private System.Windows.Forms.Label lblDatumZavrsetka;
        private System.Windows.Forms.TextBox txtDatumZavrsetka;
        private DateTimePicker dateZavrsetka;
        private DateTimePicker datePocetka;
    }
}
