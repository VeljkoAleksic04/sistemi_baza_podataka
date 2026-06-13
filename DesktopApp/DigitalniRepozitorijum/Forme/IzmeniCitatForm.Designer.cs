namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniCitatForm
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
            this.lblTipCitata = new System.Windows.Forms.Label();
            this.lblTipCitata.AutoSize = true;
            this.lblTipCitata.Location = new System.Drawing.Point(20, 20);
            this.lblTipCitata.Name = "lblTipCitata";
            this.lblTipCitata.Size = new System.Drawing.Size(120, 15);
            this.lblTipCitata.TabIndex = 0;
            this.lblTipCitata.Text = "Tip citata:";
            this.txtTipCitata = new System.Windows.Forms.TextBox();
            this.txtTipCitata.Location = new System.Drawing.Point(160, 17);
            this.txtTipCitata.Name = "txtTipCitata";
            this.txtTipCitata.Size = new System.Drawing.Size(230, 23);
            this.txtTipCitata.TabIndex = 1;
            this.lblMestoCitiranja = new System.Windows.Forms.Label();
            this.lblMestoCitiranja.AutoSize = true;
            this.lblMestoCitiranja.Location = new System.Drawing.Point(20, 55);
            this.lblMestoCitiranja.Name = "lblMestoCitiranja";
            this.lblMestoCitiranja.Size = new System.Drawing.Size(120, 15);
            this.lblMestoCitiranja.TabIndex = 0;
            this.lblMestoCitiranja.Text = "Mesto citiranja:";
            this.txtMestoCitiranja = new System.Windows.Forms.TextBox();
            this.txtMestoCitiranja.Location = new System.Drawing.Point(160, 52);
            this.txtMestoCitiranja.Name = "txtMestoCitiranja";
            this.txtMestoCitiranja.Size = new System.Drawing.Size(230, 23);
            this.txtMestoCitiranja.TabIndex = 1;
            this.lblKontekst = new System.Windows.Forms.Label();
            this.lblKontekst.AutoSize = true;
            this.lblKontekst.Location = new System.Drawing.Point(20, 90);
            this.lblKontekst.Name = "lblKontekst";
            this.lblKontekst.Size = new System.Drawing.Size(120, 15);
            this.lblKontekst.TabIndex = 0;
            this.lblKontekst.Text = "Tekstualni kontekst:";
            this.txtKontekst = new System.Windows.Forms.TextBox();
            this.txtKontekst.Location = new System.Drawing.Point(160, 87);
            this.txtKontekst.Name = "txtKontekst";
            this.txtKontekst.Size = new System.Drawing.Size(230, 23);
            this.txtKontekst.TabIndex = 1;
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
            this.Controls.Add(this.lblTipCitata);
            this.Controls.Add(this.txtTipCitata);
            this.Controls.Add(this.lblMestoCitiranja);
            this.Controls.Add(this.txtMestoCitiranja);
            this.Controls.Add(this.lblKontekst);
            this.Controls.Add(this.txtKontekst);
            this.Name = "IzmeniCitatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmeni citat";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblTipCitata;
        private System.Windows.Forms.TextBox txtTipCitata;
        private System.Windows.Forms.Label lblMestoCitiranja;
        private System.Windows.Forms.TextBox txtMestoCitiranja;
        private System.Windows.Forms.Label lblKontekst;
        private System.Windows.Forms.TextBox txtKontekst;
    }
}
