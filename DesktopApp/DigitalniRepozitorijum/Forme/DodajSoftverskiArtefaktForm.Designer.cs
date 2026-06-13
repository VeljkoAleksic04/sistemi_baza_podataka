namespace DigitalniRepozitorijum.Forme
{
    partial class DodajSoftverskiArtefaktForm
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(20, 20);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(120, 15);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Naslov:";
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtNaslov.Location = new System.Drawing.Point(160, 17);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(230, 23);
            this.txtNaslov.TabIndex = 1;
            this.lblProgramskiJezik = new System.Windows.Forms.Label();
            this.lblProgramskiJezik.AutoSize = true;
            this.lblProgramskiJezik.Location = new System.Drawing.Point(20, 55);
            this.lblProgramskiJezik.Name = "lblProgramskiJezik";
            this.lblProgramskiJezik.Size = new System.Drawing.Size(120, 15);
            this.lblProgramskiJezik.TabIndex = 0;
            this.lblProgramskiJezik.Text = "Programski jezik:";
            this.txtProgramskiJezik = new System.Windows.Forms.TextBox();
            this.txtProgramskiJezik.Location = new System.Drawing.Point(160, 52);
            this.txtProgramskiJezik.Name = "txtProgramskiJezik";
            this.txtProgramskiJezik.Size = new System.Drawing.Size(230, 23);
            this.txtProgramskiJezik.TabIndex = 1;
            this.lblLink = new System.Windows.Forms.Label();
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(20, 90);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(120, 15);
            this.lblLink.TabIndex = 0;
            this.lblLink.Text = "Link ka repozitorijumu:";
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtLink.Location = new System.Drawing.Point(160, 87);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(230, 23);
            this.txtLink.TabIndex = 1;
            this.lblLicenca = new System.Windows.Forms.Label();
            this.lblLicenca.AutoSize = true;
            this.lblLicenca.Location = new System.Drawing.Point(20, 125);
            this.lblLicenca.Name = "lblLicenca";
            this.lblLicenca.Size = new System.Drawing.Size(120, 15);
            this.lblLicenca.TabIndex = 0;
            this.lblLicenca.Text = "Nacin licenciranja:";
            this.txtLicenca = new System.Windows.Forms.TextBox();
            this.txtLicenca.Location = new System.Drawing.Point(160, 122);
            this.txtLicenca.Name = "txtLicenca";
            this.txtLicenca.Size = new System.Drawing.Size(230, 23);
            this.txtLicenca.TabIndex = 1;
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
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.lblProgramskiJezik);
            this.Controls.Add(this.txtProgramskiJezik);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblLicenca);
            this.Controls.Add(this.txtLicenca);
            this.Name = "DodajSoftverskiArtefaktForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj softverski artefakt";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label lblProgramskiJezik;
        private System.Windows.Forms.TextBox txtProgramskiJezik;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lblLicenca;
        private System.Windows.Forms.TextBox txtLicenca;
    }
}
