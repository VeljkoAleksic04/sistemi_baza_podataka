namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniUrednikaKnjigeForm
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
            this.lblUrednik = new System.Windows.Forms.Label();
            this.lblUrednik.AutoSize = true;
            this.lblUrednik.Location = new System.Drawing.Point(20, 20);
            this.lblUrednik.Name = "lblUrednik";
            this.lblUrednik.Size = new System.Drawing.Size(120, 15);
            this.lblUrednik.TabIndex = 0;
            this.lblUrednik.Text = "Urednik:";
            this.txtUrednik = new System.Windows.Forms.TextBox();
            this.txtUrednik.Location = new System.Drawing.Point(160, 17);
            this.txtUrednik.Name = "txtUrednik";
            this.txtUrednik.Size = new System.Drawing.Size(230, 23);
            this.txtUrednik.TabIndex = 1;
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
            this.Controls.Add(this.lblUrednik);
            this.Controls.Add(this.txtUrednik);
            this.Name = "IzmeniUrednikaKnjigeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmeni urednika knjige";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblUrednik;
        private System.Windows.Forms.TextBox txtUrednik;
    }
}
