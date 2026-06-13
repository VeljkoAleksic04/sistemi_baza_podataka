namespace DigitalniRepozitorijum.Forme
{
    partial class DodajKontaktTelefonForm
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
            this.lblKontaktTel = new System.Windows.Forms.Label();
            this.lblKontaktTel.AutoSize = true;
            this.lblKontaktTel.Location = new System.Drawing.Point(20, 20);
            this.lblKontaktTel.Name = "lblKontaktTel";
            this.lblKontaktTel.Size = new System.Drawing.Size(120, 15);
            this.lblKontaktTel.TabIndex = 0;
            this.lblKontaktTel.Text = "Telefon:";
            this.txtKontaktTel = new System.Windows.Forms.TextBox();
            this.txtKontaktTel.Location = new System.Drawing.Point(160, 17);
            this.txtKontaktTel.Name = "txtKontaktTel";
            this.txtKontaktTel.Size = new System.Drawing.Size(230, 23);
            this.txtKontaktTel.TabIndex = 1;
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnPotvrdi.Location = new System.Drawing.Point(160, 65);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(110, 32);
            this.btnPotvrdi.TabIndex = 50;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(280, 65);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(110, 32);
            this.btnOdustani.TabIndex = 51;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.AcceptButton = this.btnPotvrdi;
            this.CancelButton = this.btnOdustani;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 175);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.lblKontaktTel);
            this.Controls.Add(this.txtKontaktTel);
            this.Name = "DodajKontaktTelefonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj kontakt telefon";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblKontaktTel;
        private System.Windows.Forms.TextBox txtKontaktTel;
    }
}
