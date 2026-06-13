namespace DigitalniRepozitorijum.Forme
{
    partial class DodajCitatForm
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
            this.lblCitat = new System.Windows.Forms.Label();
            this.lblCitat.AutoSize = true;
            this.lblCitat.Location = new System.Drawing.Point(20, 20);
            this.lblCitat.Name = "lblCitat";
            this.lblCitat.Size = new System.Drawing.Size(120, 15);
            this.lblCitat.TabIndex = 0;
            this.lblCitat.Text = "Publikacija citat:";
            this.txtCitat = new System.Windows.Forms.TextBox();
            this.txtCitat.Location = new System.Drawing.Point(160, 17);
            this.txtCitat.Name = "txtCitat";
            this.txtCitat.Size = new System.Drawing.Size(230, 23);
            this.txtCitat.TabIndex = 1;
            this.lblTipCitata = new System.Windows.Forms.Label();
            this.lblTipCitata.AutoSize = true;
            this.lblTipCitata.Location = new System.Drawing.Point(20, 55);
            this.lblTipCitata.Name = "lblTipCitata";
            this.lblTipCitata.Size = new System.Drawing.Size(120, 15);
            this.lblTipCitata.TabIndex = 0;
            this.lblTipCitata.Text = "Tip citata:";
            this.txtTipCitata = new System.Windows.Forms.TextBox();
            this.txtTipCitata.Location = new System.Drawing.Point(160, 52);
            this.txtTipCitata.Name = "txtTipCitata";
            this.txtTipCitata.Size = new System.Drawing.Size(230, 23);
            this.txtTipCitata.TabIndex = 1;
            this.lblMestoCitiranja = new System.Windows.Forms.Label();
            this.lblMestoCitiranja.AutoSize = true;
            this.lblMestoCitiranja.Location = new System.Drawing.Point(20, 90);
            this.lblMestoCitiranja.Name = "lblMestoCitiranja";
            this.lblMestoCitiranja.Size = new System.Drawing.Size(120, 15);
            this.lblMestoCitiranja.TabIndex = 0;
            this.lblMestoCitiranja.Text = "Mesto citiranja:";
            this.txtMestoCitiranja = new System.Windows.Forms.TextBox();
            this.txtMestoCitiranja.Location = new System.Drawing.Point(160, 87);
            this.txtMestoCitiranja.Name = "txtMestoCitiranja";
            this.txtMestoCitiranja.Size = new System.Drawing.Size(230, 23);
            this.txtMestoCitiranja.TabIndex = 1;
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
            this.Controls.Add(this.lblCitat);
            this.Controls.Add(this.txtCitat);
            this.Controls.Add(this.lblTipCitata);
            this.Controls.Add(this.txtTipCitata);
            this.Controls.Add(this.lblMestoCitiranja);
            this.Controls.Add(this.txtMestoCitiranja);
            this.Name = "DodajCitatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj citat";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblCitat;
        private System.Windows.Forms.TextBox txtCitat;
        private System.Windows.Forms.Label lblTipCitata;
        private System.Windows.Forms.TextBox txtTipCitata;
        private System.Windows.Forms.Label lblMestoCitiranja;
        private System.Windows.Forms.TextBox txtMestoCitiranja;
    }
}
