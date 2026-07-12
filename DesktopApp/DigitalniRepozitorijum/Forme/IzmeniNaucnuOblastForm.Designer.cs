namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniNaucnuOblastForm
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
            lblNaucnaOblast = new Label();
            txtNaucnaOblast = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // lblNaucnaOblast
            // 
            lblNaucnaOblast.AutoSize = true;
            lblNaucnaOblast.Location = new Point(20, 20);
            lblNaucnaOblast.Name = "lblNaucnaOblast";
            lblNaucnaOblast.Size = new Size(86, 15);
            lblNaucnaOblast.TabIndex = 0;
            lblNaucnaOblast.Text = "Naucna oblast:";
            // 
            // txtNaucnaOblast
            // 
            txtNaucnaOblast.Location = new Point(160, 17);
            txtNaucnaOblast.Name = "txtNaucnaOblast";
            txtNaucnaOblast.Size = new Size(230, 23);
            txtNaucnaOblast.TabIndex = 1;
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
            // IzmeniNaucnuOblastForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 175);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblNaucnaOblast);
            Controls.Add(txtNaucnaOblast);
            Name = "IzmeniNaucnuOblastForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni naucnu oblast";
            Load += IzmeniNaucnuOblastForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblNaucnaOblast;
        private System.Windows.Forms.TextBox txtNaucnaOblast;
    }
}
