namespace DigitalniRepozitorijum.Forme
{
    partial class DodajVerzijuForm
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
            this.lblBrojVerzije = new System.Windows.Forms.Label();
            this.lblBrojVerzije.AutoSize = true;
            this.lblBrojVerzije.Location = new System.Drawing.Point(20, 20);
            this.lblBrojVerzije.Name = "lblBrojVerzije";
            this.lblBrojVerzije.Size = new System.Drawing.Size(120, 15);
            this.lblBrojVerzije.TabIndex = 0;
            this.lblBrojVerzije.Text = "Broj verzije:";
            this.txtBrojVerzije = new System.Windows.Forms.TextBox();
            this.txtBrojVerzije.Location = new System.Drawing.Point(160, 17);
            this.txtBrojVerzije.Name = "txtBrojVerzije";
            this.txtBrojVerzije.Size = new System.Drawing.Size(230, 23);
            this.txtBrojVerzije.TabIndex = 1;
            this.lblDatumPostavljanja = new System.Windows.Forms.Label();
            this.lblDatumPostavljanja.AutoSize = true;
            this.lblDatumPostavljanja.Location = new System.Drawing.Point(20, 55);
            this.lblDatumPostavljanja.Name = "lblDatumPostavljanja";
            this.lblDatumPostavljanja.Size = new System.Drawing.Size(120, 15);
            this.lblDatumPostavljanja.TabIndex = 0;
            this.lblDatumPostavljanja.Text = "Datum:";
            this.txtDatumPostavljanja = new System.Windows.Forms.TextBox();
            this.txtDatumPostavljanja.Location = new System.Drawing.Point(160, 52);
            this.txtDatumPostavljanja.Name = "txtDatumPostavljanja";
            this.txtDatumPostavljanja.Size = new System.Drawing.Size(230, 23);
            this.txtDatumPostavljanja.TabIndex = 1;
            this.lblOpisIzmene = new System.Windows.Forms.Label();
            this.lblOpisIzmene.AutoSize = true;
            this.lblOpisIzmene.Location = new System.Drawing.Point(20, 90);
            this.lblOpisIzmene.Name = "lblOpisIzmene";
            this.lblOpisIzmene.Size = new System.Drawing.Size(120, 15);
            this.lblOpisIzmene.TabIndex = 0;
            this.lblOpisIzmene.Text = "Opis izmene:";
            this.txtOpisIzmene = new System.Windows.Forms.TextBox();
            this.txtOpisIzmene.Location = new System.Drawing.Point(160, 87);
            this.txtOpisIzmene.Name = "txtOpisIzmene";
            this.txtOpisIzmene.Size = new System.Drawing.Size(230, 23);
            this.txtOpisIzmene.TabIndex = 1;
            this.lblOdgovornaOsoba = new System.Windows.Forms.Label();
            this.lblOdgovornaOsoba.AutoSize = true;
            this.lblOdgovornaOsoba.Location = new System.Drawing.Point(20, 125);
            this.lblOdgovornaOsoba.Name = "lblOdgovornaOsoba";
            this.lblOdgovornaOsoba.Size = new System.Drawing.Size(120, 15);
            this.lblOdgovornaOsoba.TabIndex = 0;
            this.lblOdgovornaOsoba.Text = "Odgovorna osoba:";
            this.txtOdgovornaOsoba = new System.Windows.Forms.TextBox();
            this.txtOdgovornaOsoba.Location = new System.Drawing.Point(160, 122);
            this.txtOdgovornaOsoba.Name = "txtOdgovornaOsoba";
            this.txtOdgovornaOsoba.Size = new System.Drawing.Size(230, 23);
            this.txtOdgovornaOsoba.TabIndex = 1;
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
            this.Controls.Add(this.lblBrojVerzije);
            this.Controls.Add(this.txtBrojVerzije);
            this.Controls.Add(this.lblDatumPostavljanja);
            this.Controls.Add(this.txtDatumPostavljanja);
            this.Controls.Add(this.lblOpisIzmene);
            this.Controls.Add(this.txtOpisIzmene);
            this.Controls.Add(this.lblOdgovornaOsoba);
            this.Controls.Add(this.txtOdgovornaOsoba);
            this.Name = "DodajVerzijuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj verziju";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblBrojVerzije;
        private System.Windows.Forms.TextBox txtBrojVerzije;
        private System.Windows.Forms.Label lblDatumPostavljanja;
        private System.Windows.Forms.TextBox txtDatumPostavljanja;
        private System.Windows.Forms.Label lblOpisIzmene;
        private System.Windows.Forms.TextBox txtOpisIzmene;
        private System.Windows.Forms.Label lblOdgovornaOsoba;
        private System.Windows.Forms.TextBox txtOdgovornaOsoba;
    }
}
