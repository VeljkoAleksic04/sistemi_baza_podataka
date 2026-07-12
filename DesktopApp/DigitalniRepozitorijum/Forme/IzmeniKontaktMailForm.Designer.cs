namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniKontaktMailForm
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
            lblKontaktMail = new Label();
            txtKontaktMail = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // lblKontaktMail
            // 
            lblKontaktMail.AutoSize = true;
            lblKontaktMail.Location = new Point(20, 20);
            lblKontaktMail.Name = "lblKontaktMail";
            lblKontaktMail.Size = new Size(39, 15);
            lblKontaktMail.TabIndex = 0;
            lblKontaktMail.Text = "Email:";
            // 
            // txtKontaktMail
            // 
            txtKontaktMail.Location = new Point(160, 17);
            txtKontaktMail.Name = "txtKontaktMail";
            txtKontaktMail.Size = new Size(230, 23);
            txtKontaktMail.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 65);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(110, 32);
            btnPotvrdi.TabIndex = 50;
            btnPotvrdi.Text = "Potvrdi";
            btnPotvrdi.UseVisualStyleBackColor = true;
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.DialogResult = DialogResult.Cancel;
            btnOdustani.Location = new Point(280, 65);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            // 
            // IzmeniKontaktMailForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 175);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblKontaktMail);
            Controls.Add(txtKontaktMail);
            Name = "IzmeniKontaktMailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni kontakt mail";
            Load += IzmeniKontaktMailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblKontaktMail;
        private System.Windows.Forms.TextBox txtKontaktMail;
    }
}
