namespace DigitalniRepozitorijum.Forme
{
    partial class DodajAutorstvoForm
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
            lblRedosled = new Label();
            lblTipDoprinosa = new Label();
            txtTipDoprinosa = new TextBox();
            lblUloga = new Label();
            txtUloga = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            cmbPublikacije = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            // lblRedosled
            // 
            lblRedosled.AutoSize = true;
            lblRedosled.Location = new Point(20, 55);
            lblRedosled.Name = "lblRedosled";
            lblRedosled.Size = new Size(58, 15);
            lblRedosled.TabIndex = 0;
            lblRedosled.Text = "Redosled:";
            // 
            // lblTipDoprinosa
            // 
            lblTipDoprinosa.AutoSize = true;
            lblTipDoprinosa.Location = new Point(20, 90);
            lblTipDoprinosa.Name = "lblTipDoprinosa";
            lblTipDoprinosa.Size = new Size(83, 15);
            lblTipDoprinosa.TabIndex = 0;
            lblTipDoprinosa.Text = "Tip doprinosa:";
            // 
            // txtTipDoprinosa
            // 
            txtTipDoprinosa.Location = new Point(160, 87);
            txtTipDoprinosa.Name = "txtTipDoprinosa";
            txtTipDoprinosa.Size = new Size(230, 23);
            txtTipDoprinosa.TabIndex = 1;
            // 
            // lblUloga
            // 
            lblUloga.AutoSize = true;
            lblUloga.Location = new Point(20, 125);
            lblUloga.Name = "lblUloga";
            lblUloga.Size = new Size(41, 15);
            lblUloga.TabIndex = 0;
            lblUloga.Text = "Uloga:";
            // 
            // txtUloga
            // 
            txtUloga.Location = new Point(160, 122);
            txtUloga.Name = "txtUloga";
            txtUloga.Size = new Size(230, 23);
            txtUloga.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 170);
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
            btnOdustani.Location = new Point(280, 170);
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(160, 53);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(230, 23);
            numericUpDown1.TabIndex = 53;
            // 
            // DodajAutorstvoForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 280);
            Controls.Add(numericUpDown1);
            Controls.Add(cmbPublikacije);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblPublikacija);
            Controls.Add(lblRedosled);
            Controls.Add(lblTipDoprinosa);
            Controls.Add(txtTipDoprinosa);
            Controls.Add(lblUloga);
            Controls.Add(txtUloga);
            Name = "DodajAutorstvoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj publikaciju autoru";
            Load += DodajAutorstvoForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblPublikacija;
        private System.Windows.Forms.Label lblRedosled;
        private System.Windows.Forms.Label lblTipDoprinosa;
        private System.Windows.Forms.TextBox txtTipDoprinosa;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.TextBox txtUloga;
        private ComboBox cmbPublikacije;
        private NumericUpDown numericUpDown1;
    }
}
