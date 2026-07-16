namespace DigitalniRepozitorijum.Forme
{
    partial class DodajPovezanuPublikacijuForm
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
            lblPublikacija = new Label();
            lblTipPovezanosti = new Label();
            txtTipPovezanosti = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            cmbPublikacije = new ComboBox();
            SuspendLayout();
            // 
            // lblPublikacija
            // 
            lblPublikacija.AutoSize = true;
            lblPublikacija.Location = new Point(20, 20);
            lblPublikacija.Name = "lblPublikacija";
            lblPublikacija.Size = new Size(67, 15);
            lblPublikacija.TabIndex = 0;
            lblPublikacija.Text = "Publikacija:";
            // 
            // lblTipPovezanosti
            // 
            lblTipPovezanosti.AutoSize = true;
            lblTipPovezanosti.Location = new Point(20, 55);
            lblTipPovezanosti.Name = "lblTipPovezanosti";
            lblTipPovezanosti.Size = new Size(92, 15);
            lblTipPovezanosti.TabIndex = 0;
            lblTipPovezanosti.Text = "Tip povezanosti:";
            // 
            // txtTipPovezanosti
            // 
            txtTipPovezanosti.Location = new Point(160, 52);
            txtTipPovezanosti.Name = "txtTipPovezanosti";
            txtTipPovezanosti.Size = new Size(230, 23);
            txtTipPovezanosti.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 100);
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
            btnOdustani.Location = new Point(280, 100);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            // 
            // cmbPublikacije
            // 
            cmbPublikacije.FormattingEnabled = true;
            cmbPublikacije.Location = new Point(160, 17);
            cmbPublikacije.Name = "cmbPublikacije";
            cmbPublikacije.Size = new Size(230, 23);
            cmbPublikacije.TabIndex = 52;
            // 
            // DodajPovezanuPublikacijuForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 156);
            Controls.Add(cmbPublikacije);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblPublikacija);
            Controls.Add(lblTipPovezanosti);
            Controls.Add(txtTipPovezanosti);
            Name = "DodajPovezanuPublikacijuForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj povezanu publikaciju";
            Load += DodajPovezanuPublikacijuForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblPublikacija;
        private System.Windows.Forms.Label lblTipPovezanosti;
        private System.Windows.Forms.TextBox txtTipPovezanosti;
        private ComboBox cmbPublikacije;
    }
}
