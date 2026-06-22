namespace DigitalniRepozitorijum.Forme
{
    partial class DodajPodrzanuPlatformuForm
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
            lblPodrzanaPlatforma = new Label();
            txtPodrzanaPlatforma = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // lblPodrzanaPlatforma
            // 
            lblPodrzanaPlatforma.AutoSize = true;
            lblPodrzanaPlatforma.Location = new Point(20, 20);
            lblPodrzanaPlatforma.Name = "lblPodrzanaPlatforma";
            lblPodrzanaPlatforma.Size = new Size(62, 15);
            lblPodrzanaPlatforma.TabIndex = 0;
            lblPodrzanaPlatforma.Text = "Platforma:";
            // 
            // txtPodrzanaPlatforma
            // 
            txtPodrzanaPlatforma.Location = new Point(160, 17);
            txtPodrzanaPlatforma.Name = "txtPodrzanaPlatforma";
            txtPodrzanaPlatforma.Size = new Size(230, 23);
            txtPodrzanaPlatforma.TabIndex = 1;
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
            // DodajPodrzanuPlatformuForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 175);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblPodrzanaPlatforma);
            Controls.Add(txtPodrzanaPlatforma);
            Name = "DodajPodrzanuPlatformuForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj platformu";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblPodrzanaPlatforma;
        private System.Windows.Forms.TextBox txtPodrzanaPlatforma;
    }
}
