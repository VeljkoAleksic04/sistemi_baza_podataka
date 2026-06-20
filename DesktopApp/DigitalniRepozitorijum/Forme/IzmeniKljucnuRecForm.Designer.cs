namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniKljucnuRecForm
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
            lblKljucnaRec = new Label();
            txtKljucnaRec = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // lblKljucnaRec
            // 
            lblKljucnaRec.AutoSize = true;
            lblKljucnaRec.Location = new Point(20, 20);
            lblKljucnaRec.Name = "lblKljucnaRec";
            lblKljucnaRec.Size = new Size(68, 15);
            lblKljucnaRec.TabIndex = 0;
            lblKljucnaRec.Text = "Kljucna rec:";
            // 
            // txtKljucnaRec
            // 
            txtKljucnaRec.Location = new Point(160, 17);
            txtKljucnaRec.Name = "txtKljucnaRec";
            txtKljucnaRec.Size = new Size(230, 23);
            txtKljucnaRec.TabIndex = 1;
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
            btnOdustani.Click += btnOdustani_Click;
            // 
            // IzmeniKljucnuRecForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 175);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblKljucnaRec);
            Controls.Add(txtKljucnaRec);
            Name = "IzmeniKljucnuRecForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni kljucnu rec";
            Load += IzmeniKljucnuRecForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblKljucnaRec;
        private System.Windows.Forms.TextBox txtKljucnaRec;
    }
}
