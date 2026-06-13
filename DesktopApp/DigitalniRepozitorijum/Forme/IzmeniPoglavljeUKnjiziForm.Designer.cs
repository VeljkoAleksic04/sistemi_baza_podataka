namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniPoglavljeUKnjiziForm
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
            this.lblIzdavac = new System.Windows.Forms.Label();
            this.lblIzdavac.AutoSize = true;
            this.lblIzdavac.Location = new System.Drawing.Point(20, 55);
            this.lblIzdavac.Name = "lblIzdavac";
            this.lblIzdavac.Size = new System.Drawing.Size(120, 15);
            this.lblIzdavac.TabIndex = 0;
            this.lblIzdavac.Text = "Izdavac:";
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.txtIzdavac.Location = new System.Drawing.Point(160, 52);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(230, 23);
            this.txtIzdavac.TabIndex = 1;
            this.lblMestoIzdanja = new System.Windows.Forms.Label();
            this.lblMestoIzdanja.AutoSize = true;
            this.lblMestoIzdanja.Location = new System.Drawing.Point(20, 90);
            this.lblMestoIzdanja.Name = "lblMestoIzdanja";
            this.lblMestoIzdanja.Size = new System.Drawing.Size(120, 15);
            this.lblMestoIzdanja.TabIndex = 0;
            this.lblMestoIzdanja.Text = "Mesto izdanja:";
            this.txtMestoIzdanja = new System.Windows.Forms.TextBox();
            this.txtMestoIzdanja.Location = new System.Drawing.Point(160, 87);
            this.txtMestoIzdanja.Name = "txtMestoIzdanja";
            this.txtMestoIzdanja.Size = new System.Drawing.Size(230, 23);
            this.txtMestoIzdanja.TabIndex = 1;
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnPotvrdi.Location = new System.Drawing.Point(160, 135);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(110, 32);
            this.btnPotvrdi.TabIndex = 50;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(280, 135);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(110, 32);
            this.btnOdustani.TabIndex = 51;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.AcceptButton = this.btnPotvrdi;
            this.CancelButton = this.btnOdustani;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 245);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.lblIzdavac);
            this.Controls.Add(this.txtIzdavac);
            this.Controls.Add(this.lblMestoIzdanja);
            this.Controls.Add(this.txtMestoIzdanja);
            this.Name = "IzmeniPoglavljeUKnjiziForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmeni poglavlje";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label lblIzdavac;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.Label lblMestoIzdanja;
        private System.Windows.Forms.TextBox txtMestoIzdanja;
    }
}
