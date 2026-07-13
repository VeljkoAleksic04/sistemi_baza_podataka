namespace DigitalniRepozitorijum.Forme
{
    partial class DodajAutoraPublikacijeForm
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
            lblAutor = new Label();
            lblRedosled = new Label();
            lblTipDoprinosa = new Label();
            txtTipDoprinosa = new TextBox();
            lblUloga = new Label();
            txtUloga = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            cmbAutor = new ComboBox();
            numRedosled = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numRedosled).BeginInit();
            SuspendLayout();
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(20, 20);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 0;
            lblAutor.Text = "Autor:";
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
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(160, 17);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(230, 23);
            cmbAutor.TabIndex = 52;
            // 
            // numRedosled
            // 
            numRedosled.Location = new Point(160, 53);
            numRedosled.Name = "numRedosled";
            numRedosled.Size = new Size(230, 23);
            numRedosled.TabIndex = 53;
            // 
            // DodajAutoraPublikacijeForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 280);
            Controls.Add(numRedosled);
            Controls.Add(cmbAutor);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblAutor);
            Controls.Add(lblRedosled);
            Controls.Add(lblTipDoprinosa);
            Controls.Add(txtTipDoprinosa);
            Controls.Add(lblUloga);
            Controls.Add(txtUloga);
            Name = "DodajAutoraPublikacijeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj autora";
            Load += DodajAutoraPublikacijeForm_Load;
            ((System.ComponentModel.ISupportInitialize)numRedosled).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblRedosled;
        private System.Windows.Forms.Label lblTipDoprinosa;
        private System.Windows.Forms.TextBox txtTipDoprinosa;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.TextBox txtUloga;
        private ComboBox cmbAutor;
        private NumericUpDown numRedosled;
    }
}
