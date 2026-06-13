namespace DigitalniRepozitorijum.Forme
{
    partial class DodajDatasetForm
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
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(20, 55);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(120, 15);
            this.lblFormat.TabIndex = 0;
            this.lblFormat.Text = "Format:";
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.txtFormat.Location = new System.Drawing.Point(160, 52);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(230, 23);
            this.txtFormat.TabIndex = 1;
            this.lblBrojZapisa = new System.Windows.Forms.Label();
            this.lblBrojZapisa.AutoSize = true;
            this.lblBrojZapisa.Location = new System.Drawing.Point(20, 90);
            this.lblBrojZapisa.Name = "lblBrojZapisa";
            this.lblBrojZapisa.Size = new System.Drawing.Size(120, 15);
            this.lblBrojZapisa.TabIndex = 0;
            this.lblBrojZapisa.Text = "Broj zapisa:";
            this.txtBrojZapisa = new System.Windows.Forms.TextBox();
            this.txtBrojZapisa.Location = new System.Drawing.Point(160, 87);
            this.txtBrojZapisa.Name = "txtBrojZapisa";
            this.txtBrojZapisa.Size = new System.Drawing.Size(230, 23);
            this.txtBrojZapisa.TabIndex = 1;
            this.lblVelicina = new System.Windows.Forms.Label();
            this.lblVelicina.AutoSize = true;
            this.lblVelicina.Location = new System.Drawing.Point(20, 125);
            this.lblVelicina.Name = "lblVelicina";
            this.lblVelicina.Size = new System.Drawing.Size(120, 15);
            this.lblVelicina.TabIndex = 0;
            this.lblVelicina.Text = "Velicina:";
            this.txtVelicina = new System.Windows.Forms.TextBox();
            this.txtVelicina.Location = new System.Drawing.Point(160, 122);
            this.txtVelicina.Name = "txtVelicina";
            this.txtVelicina.Size = new System.Drawing.Size(230, 23);
            this.txtVelicina.TabIndex = 1;
            this.lblLicenca = new System.Windows.Forms.Label();
            this.lblLicenca.AutoSize = true;
            this.lblLicenca.Location = new System.Drawing.Point(20, 160);
            this.lblLicenca.Name = "lblLicenca";
            this.lblLicenca.Size = new System.Drawing.Size(120, 15);
            this.lblLicenca.TabIndex = 0;
            this.lblLicenca.Text = "Licenca:";
            this.txtLicenca = new System.Windows.Forms.TextBox();
            this.txtLicenca.Location = new System.Drawing.Point(160, 157);
            this.txtLicenca.Name = "txtLicenca";
            this.txtLicenca.Size = new System.Drawing.Size(230, 23);
            this.txtLicenca.TabIndex = 1;
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnPotvrdi.Location = new System.Drawing.Point(160, 205);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(110, 32);
            this.btnPotvrdi.TabIndex = 50;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(280, 205);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(110, 32);
            this.btnOdustani.TabIndex = 51;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.AcceptButton = this.btnPotvrdi;
            this.CancelButton = this.btnOdustani;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 315);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.lblBrojZapisa);
            this.Controls.Add(this.txtBrojZapisa);
            this.Controls.Add(this.lblVelicina);
            this.Controls.Add(this.txtVelicina);
            this.Controls.Add(this.lblLicenca);
            this.Controls.Add(this.txtLicenca);
            this.Name = "DodajDatasetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj dataset";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Label lblBrojZapisa;
        private System.Windows.Forms.TextBox txtBrojZapisa;
        private System.Windows.Forms.Label lblVelicina;
        private System.Windows.Forms.TextBox txtVelicina;
        private System.Windows.Forms.Label lblLicenca;
        private System.Windows.Forms.TextBox txtLicenca;
    }
}
