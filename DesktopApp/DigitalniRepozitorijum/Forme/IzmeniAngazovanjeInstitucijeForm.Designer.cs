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
            this.SuspendLayout();
            this.lblTipAngazovanja = new System.Windows.Forms.Label();
            this.lblTipAngazovanja.AutoSize = true;
            this.lblTipAngazovanja.Location = new System.Drawing.Point(20, 20);
            this.lblTipAngazovanja.Name = "lblTipAngazovanja";
            this.lblTipAngazovanja.Size = new System.Drawing.Size(120, 15);
            this.lblTipAngazovanja.TabIndex = 0;
            this.lblTipAngazovanja.Text = "Tip:";
            this.txtTipAngazovanja = new System.Windows.Forms.TextBox();
            this.txtTipAngazovanja.Location = new System.Drawing.Point(160, 17);
            this.txtTipAngazovanja.Name = "txtTipAngazovanja";
            this.txtTipAngazovanja.Size = new System.Drawing.Size(230, 23);
            this.txtTipAngazovanja.TabIndex = 1;
            this.lblNazivPozicije = new System.Windows.Forms.Label();
            this.lblNazivPozicije.AutoSize = true;
            this.lblNazivPozicije.Location = new System.Drawing.Point(20, 55);
            this.lblNazivPozicije.Name = "lblNazivPozicije";
            this.lblNazivPozicije.Size = new System.Drawing.Size(120, 15);
            this.lblNazivPozicije.TabIndex = 0;
            this.lblNazivPozicije.Text = "Pozicija:";
            this.txtNazivPozicije = new System.Windows.Forms.TextBox();
            this.txtNazivPozicije.Location = new System.Drawing.Point(160, 52);
            this.txtNazivPozicije.Name = "txtNazivPozicije";
            this.txtNazivPozicije.Size = new System.Drawing.Size(230, 23);
            this.txtNazivPozicije.TabIndex = 1;
            this.lblDatumPocetka = new System.Windows.Forms.Label();
            this.lblDatumPocetka.AutoSize = true;
            this.lblDatumPocetka.Location = new System.Drawing.Point(20, 90);
            this.lblDatumPocetka.Name = "lblDatumPocetka";
            this.lblDatumPocetka.Size = new System.Drawing.Size(120, 15);
            this.lblDatumPocetka.TabIndex = 0;
            this.lblDatumPocetka.Text = "Datum pocetka:";
            this.txtDatumPocetka = new System.Windows.Forms.TextBox();
            this.txtDatumPocetka.Location = new System.Drawing.Point(160, 87);
            this.txtDatumPocetka.Name = "txtDatumPocetka";
            this.txtDatumPocetka.Size = new System.Drawing.Size(230, 23);
            this.txtDatumPocetka.TabIndex = 1;
            this.lblDatumZavrsetka = new System.Windows.Forms.Label();
            this.lblDatumZavrsetka.AutoSize = true;
            this.lblDatumZavrsetka.Location = new System.Drawing.Point(20, 125);
            this.lblDatumZavrsetka.Name = "lblDatumZavrsetka";
            this.lblDatumZavrsetka.Size = new System.Drawing.Size(120, 15);
            this.lblDatumZavrsetka.TabIndex = 0;
            this.lblDatumZavrsetka.Text = "Datum zavrsetka:";
            this.txtDatumZavrsetka = new System.Windows.Forms.TextBox();
            this.txtDatumZavrsetka.Location = new System.Drawing.Point(160, 122);
            this.txtDatumZavrsetka.Name = "txtDatumZavrsetka";
            this.txtDatumZavrsetka.Size = new System.Drawing.Size(230, 23);
            this.txtDatumZavrsetka.TabIndex = 1;
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnPotvrdi.Location = new System.Drawing.Point(160, 170);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(110, 32);
            this.btnPotvrdi.TabIndex = 50;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(280, 170);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(110, 32);
            this.btnOdustani.TabIndex = 51;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.AcceptButton = this.btnPotvrdi;
            this.CancelButton = this.btnOdustani;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 280);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.lblTipAngazovanja);
            this.Controls.Add(this.txtTipAngazovanja);
            this.Controls.Add(this.lblNazivPozicije);
            this.Controls.Add(this.txtNazivPozicije);
            this.Controls.Add(this.lblDatumPocetka);
            this.Controls.Add(this.txtDatumPocetka);
            this.Controls.Add(this.lblDatumZavrsetka);
            this.Controls.Add(this.txtDatumZavrsetka);
            this.Name = "IzmeniAngazovanjeInstitucijeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmeni angazovanje";
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}
