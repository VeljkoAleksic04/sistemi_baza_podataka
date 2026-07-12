namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniKontaktTelefonForm
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
            lblKontaktTel = new Label();
            txtKontaktTel = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // lblKontaktTel
            // 
            lblKontaktTel.AutoSize = true;
            lblKontaktTel.Location = new Point(20, 20);
            lblKontaktTel.Name = "lblKontaktTel";
            lblKontaktTel.Size = new Size(48, 15);
            lblKontaktTel.TabIndex = 0;
            lblKontaktTel.Text = "Telefon:";
            // 
            // txtKontaktTel
            // 
            txtKontaktTel.Location = new Point(160, 17);
            txtKontaktTel.Name = "txtKontaktTel";
            txtKontaktTel.Size = new Size(230, 23);
            txtKontaktTel.TabIndex = 1;
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
            // IzmeniKontaktTelefonForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 175);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblKontaktTel);
            Controls.Add(txtKontaktTel);
            Name = "IzmeniKontaktTelefonForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni kontakt telefon";
            Load += IzmeniKontaktTelefonForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblKontaktTel;
        private System.Windows.Forms.TextBox txtKontaktTel;
    }
}
