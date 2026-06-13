namespace DigitalniRepozitorijum.Forme
{
    partial class DodajNaucnuOblastForm
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
            this.lblNaucnaOblast = new System.Windows.Forms.Label();
            this.lblNaucnaOblast.AutoSize = true;
            this.lblNaucnaOblast.Location = new System.Drawing.Point(20, 20);
            this.lblNaucnaOblast.Name = "lblNaucnaOblast";
            this.lblNaucnaOblast.Size = new System.Drawing.Size(120, 15);
            this.lblNaucnaOblast.TabIndex = 0;
            this.lblNaucnaOblast.Text = "Naucna oblast:";
            this.txtNaucnaOblast = new System.Windows.Forms.TextBox();
            this.txtNaucnaOblast.Location = new System.Drawing.Point(160, 17);
            this.txtNaucnaOblast.Name = "txtNaucnaOblast";
            this.txtNaucnaOblast.Size = new System.Drawing.Size(230, 23);
            this.txtNaucnaOblast.TabIndex = 1;
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
            this.Controls.Add(this.lblNaucnaOblast);
            this.Controls.Add(this.txtNaucnaOblast);
            this.Name = "DodajNaucnuOblastForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj naucnu oblast";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblNaucnaOblast;
        private System.Windows.Forms.TextBox txtNaucnaOblast;
    }
}
