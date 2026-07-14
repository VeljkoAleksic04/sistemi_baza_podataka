namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniAutorstvoForm
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
            lblRedosled = new Label();
            lblTipDoprinosa = new Label();
            txtTipDoprinosa = new TextBox();
            lblUloga = new Label();
            txtUloga = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            numRedosled = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numRedosled).BeginInit();
            SuspendLayout();
            // 
            // lblRedosled
            // 
            lblRedosled.AutoSize = true;
            lblRedosled.Location = new Point(20, 20);
            lblRedosled.Name = "lblRedosled";
            lblRedosled.Size = new Size(58, 15);
            lblRedosled.TabIndex = 0;
            lblRedosled.Text = "Redosled:";
            // 
            // lblTipDoprinosa
            // 
            lblTipDoprinosa.AutoSize = true;
            lblTipDoprinosa.Location = new Point(20, 55);
            lblTipDoprinosa.Name = "lblTipDoprinosa";
            lblTipDoprinosa.Size = new Size(83, 15);
            lblTipDoprinosa.TabIndex = 0;
            lblTipDoprinosa.Text = "Tip doprinosa:";
            // 
            // txtTipDoprinosa
            // 
            txtTipDoprinosa.Location = new Point(160, 52);
            txtTipDoprinosa.Name = "txtTipDoprinosa";
            txtTipDoprinosa.Size = new Size(230, 23);
            txtTipDoprinosa.TabIndex = 1;
            // 
            // lblUloga
            // 
            lblUloga.AutoSize = true;
            lblUloga.Location = new Point(20, 90);
            lblUloga.Name = "lblUloga";
            lblUloga.Size = new Size(41, 15);
            lblUloga.TabIndex = 0;
            lblUloga.Text = "Uloga:";
            // 
            // txtUloga
            // 
            txtUloga.Location = new Point(160, 87);
            txtUloga.Name = "txtUloga";
            txtUloga.Size = new Size(230, 23);
            txtUloga.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 135);
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
            btnOdustani.Location = new Point(280, 135);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            // 
            // numRedosled
            // 
            numRedosled.Location = new Point(160, 18);
            numRedosled.Name = "numRedosled";
            numRedosled.Size = new Size(230, 23);
            numRedosled.TabIndex = 55;
            // 
            // IzmeniAutorstvoForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 245);
            Controls.Add(numRedosled);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblRedosled);
            Controls.Add(lblTipDoprinosa);
            Controls.Add(txtTipDoprinosa);
            Controls.Add(lblUloga);
            Controls.Add(txtUloga);
            Name = "IzmeniAutorstvoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni autorstvo";
            Load += IzmeniAutorstvoForm_Load;
            ((System.ComponentModel.ISupportInitialize)numRedosled).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblRedosled;
        private System.Windows.Forms.Label lblTipDoprinosa;
        private System.Windows.Forms.TextBox txtTipDoprinosa;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.TextBox txtUloga;
        private NumericUpDown numRedosled;
    }
}
