namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniPovezanuPublikacijuForm
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
            this.lblTipPovezanosti = new System.Windows.Forms.Label();
            this.lblTipPovezanosti.AutoSize = true;
            this.lblTipPovezanosti.Location = new System.Drawing.Point(20, 20);
            this.lblTipPovezanosti.Name = "lblTipPovezanosti";
            this.lblTipPovezanosti.Size = new System.Drawing.Size(120, 15);
            this.lblTipPovezanosti.TabIndex = 0;
            this.lblTipPovezanosti.Text = "Tip povezanosti:";
            this.txtTipPovezanosti = new System.Windows.Forms.TextBox();
            this.txtTipPovezanosti.Location = new System.Drawing.Point(160, 17);
            this.txtTipPovezanosti.Name = "txtTipPovezanosti";
            this.txtTipPovezanosti.Size = new System.Drawing.Size(230, 23);
            this.txtTipPovezanosti.TabIndex = 1;
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
            this.Controls.Add(this.lblTipPovezanosti);
            this.Controls.Add(this.txtTipPovezanosti);
            this.Name = "IzmeniPovezanuPublikacijuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmeni povezanu publikaciju";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblTipPovezanosti;
        private System.Windows.Forms.TextBox txtTipPovezanosti;
    }
}
