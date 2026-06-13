namespace DigitalniRepozitorijum.Forme
{
    partial class DodajNaucniRadForm
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
            this.lblDOI = new System.Windows.Forms.Label();
            this.lblDOI.AutoSize = true;
            this.lblDOI.Location = new System.Drawing.Point(20, 55);
            this.lblDOI.Name = "lblDOI";
            this.lblDOI.Size = new System.Drawing.Size(120, 15);
            this.lblDOI.TabIndex = 0;
            this.lblDOI.Text = "DOI:";
            this.txtDOI = new System.Windows.Forms.TextBox();
            this.txtDOI.Location = new System.Drawing.Point(160, 52);
            this.txtDOI.Name = "txtDOI";
            this.txtDOI.Size = new System.Drawing.Size(230, 23);
            this.txtDOI.TabIndex = 1;
            this.lblTipRada = new System.Windows.Forms.Label();
            this.lblTipRada.AutoSize = true;
            this.lblTipRada.Location = new System.Drawing.Point(20, 90);
            this.lblTipRada.Name = "lblTipRada";
            this.lblTipRada.Size = new System.Drawing.Size(120, 15);
            this.lblTipRada.TabIndex = 0;
            this.lblTipRada.Text = "Tip rada:";
            this.txtTipRada = new System.Windows.Forms.TextBox();
            this.txtTipRada.Location = new System.Drawing.Point(160, 87);
            this.txtTipRada.Name = "txtTipRada";
            this.txtTipRada.Size = new System.Drawing.Size(230, 23);
            this.txtTipRada.TabIndex = 1;
            this.lblStranice = new System.Windows.Forms.Label();
            this.lblStranice.AutoSize = true;
            this.lblStranice.Location = new System.Drawing.Point(20, 125);
            this.lblStranice.Name = "lblStranice";
            this.lblStranice.Size = new System.Drawing.Size(120, 15);
            this.lblStranice.TabIndex = 0;
            this.lblStranice.Text = "Stranice:";
            this.txtStranice = new System.Windows.Forms.TextBox();
            this.txtStranice.Location = new System.Drawing.Point(160, 122);
            this.txtStranice.Name = "txtStranice";
            this.txtStranice.Size = new System.Drawing.Size(230, 23);
            this.txtStranice.TabIndex = 1;
            this.lblIzvor = new System.Windows.Forms.Label();
            this.lblIzvor.AutoSize = true;
            this.lblIzvor.Location = new System.Drawing.Point(20, 160);
            this.lblIzvor.Name = "lblIzvor";
            this.lblIzvor.Size = new System.Drawing.Size(120, 15);
            this.lblIzvor.TabIndex = 0;
            this.lblIzvor.Text = "Izvor:";
            this.txtIzvor = new System.Windows.Forms.TextBox();
            this.txtIzvor.Location = new System.Drawing.Point(160, 157);
            this.txtIzvor.Name = "txtIzvor";
            this.txtIzvor.Size = new System.Drawing.Size(230, 23);
            this.txtIzvor.TabIndex = 1;
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
            this.Controls.Add(this.lblDOI);
            this.Controls.Add(this.txtDOI);
            this.Controls.Add(this.lblTipRada);
            this.Controls.Add(this.txtTipRada);
            this.Controls.Add(this.lblStranice);
            this.Controls.Add(this.txtStranice);
            this.Controls.Add(this.lblIzvor);
            this.Controls.Add(this.txtIzvor);
            this.Name = "DodajNaucniRadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj naučni rad";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label lblDOI;
        private System.Windows.Forms.TextBox txtDOI;
        private System.Windows.Forms.Label lblTipRada;
        private System.Windows.Forms.TextBox txtTipRada;
        private System.Windows.Forms.Label lblStranice;
        private System.Windows.Forms.TextBox txtStranice;
        private System.Windows.Forms.Label lblIzvor;
        private System.Windows.Forms.TextBox txtIzvor;
    }
}
