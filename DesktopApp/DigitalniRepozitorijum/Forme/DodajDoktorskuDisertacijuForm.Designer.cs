namespace DigitalniRepozitorijum.Forme
{
    partial class DodajDoktorskuDisertacijuForm
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
            this.lblApstrakt = new System.Windows.Forms.Label();
            this.lblApstrakt.AutoSize = true;
            this.lblApstrakt.Location = new System.Drawing.Point(20, 55);
            this.lblApstrakt.Name = "lblApstrakt";
            this.lblApstrakt.Size = new System.Drawing.Size(120, 15);
            this.lblApstrakt.TabIndex = 0;
            this.lblApstrakt.Text = "Apstrakt:";
            this.txtApstrakt = new System.Windows.Forms.TextBox();
            this.txtApstrakt.Location = new System.Drawing.Point(160, 52);
            this.txtApstrakt.Name = "txtApstrakt";
            this.txtApstrakt.Size = new System.Drawing.Size(230, 23);
            this.txtApstrakt.TabIndex = 1;
            this.lblJezik = new System.Windows.Forms.Label();
            this.lblJezik.AutoSize = true;
            this.lblJezik.Location = new System.Drawing.Point(20, 90);
            this.lblJezik.Name = "lblJezik";
            this.lblJezik.Size = new System.Drawing.Size(120, 15);
            this.lblJezik.TabIndex = 0;
            this.lblJezik.Text = "Jezik:";
            this.txtJezik = new System.Windows.Forms.TextBox();
            this.txtJezik.Location = new System.Drawing.Point(160, 87);
            this.txtJezik.Name = "txtJezik";
            this.txtJezik.Size = new System.Drawing.Size(230, 23);
            this.txtJezik.TabIndex = 1;
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
            this.Controls.Add(this.lblApstrakt);
            this.Controls.Add(this.txtApstrakt);
            this.Controls.Add(this.lblJezik);
            this.Controls.Add(this.txtJezik);
            this.Name = "DodajDoktorskuDisertacijuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj doktorsku";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label lblApstrakt;
        private System.Windows.Forms.TextBox txtApstrakt;
        private System.Windows.Forms.Label lblJezik;
        private System.Windows.Forms.TextBox txtJezik;
    }
}
