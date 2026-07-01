namespace DigitalniRepozitorijum.Forme
{
    partial class DodajRecenzentaForm
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
            lblImePrezime = new Label();
            txtImePrezime = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            SuspendLayout();

            lblImePrezime.AutoSize = true;
            lblImePrezime.Location = new Point(20, 20);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(89, 15);
            lblImePrezime.Text = "Ime i prezime:";

            txtImePrezime.Location = new Point(160, 17);
            txtImePrezime.Name = "txtImePrezime";
            txtImePrezime.Size = new Size(230, 23);

            btnPotvrdi.Location = new Point(160, 65);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Size = new Size(110, 32);
            btnPotvrdi.Text = "Potvrdi";
            btnPotvrdi.UseVisualStyleBackColor = true;
            btnPotvrdi.Click += btnPotvrdi_Click;

            btnOdustani.DialogResult = DialogResult.Cancel;
            btnOdustani.Location = new Point(280, 65);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 130);
            Controls.Add(lblImePrezime);
            Controls.Add(txtImePrezime);
            Controls.Add(btnPotvrdi);
            Controls.Add(btnOdustani);
            Name = "DodajRecenzentaForm";
            Text = "Dodaj recenzenta";
            ResumeLayout(false);
            PerformLayout();
        }


        private Label lblImePrezime;
        private TextBox txtImePrezime;
        private Button btnPotvrdi;
        private Button btnOdustani;
    }
}
