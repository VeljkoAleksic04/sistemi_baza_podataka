namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniCitatForm
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
            lblTipCitata = new Label();
            txtTipCitata = new TextBox();
            lblMestoCitiranja = new Label();
            txtMestoCitiranja = new TextBox();
            lblKontekst = new Label();
            txtKontekst = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // lblTipCitata
            // 
            lblTipCitata.AutoSize = true;
            lblTipCitata.Location = new Point(20, 20);
            lblTipCitata.Name = "lblTipCitata";
            lblTipCitata.Size = new Size(58, 15);
            lblTipCitata.TabIndex = 0;
            lblTipCitata.Text = "Tip citata:";
            // 
            // txtTipCitata
            // 
            txtTipCitata.Location = new Point(160, 17);
            txtTipCitata.Name = "txtTipCitata";
            txtTipCitata.Size = new Size(230, 23);
            txtTipCitata.TabIndex = 1;
            // 
            // lblMestoCitiranja
            // 
            lblMestoCitiranja.AutoSize = true;
            lblMestoCitiranja.Location = new Point(20, 55);
            lblMestoCitiranja.Name = "lblMestoCitiranja";
            lblMestoCitiranja.Size = new Size(88, 15);
            lblMestoCitiranja.TabIndex = 0;
            lblMestoCitiranja.Text = "Mesto citiranja:";
            // 
            // txtMestoCitiranja
            // 
            txtMestoCitiranja.Location = new Point(160, 52);
            txtMestoCitiranja.Name = "txtMestoCitiranja";
            txtMestoCitiranja.Size = new Size(230, 23);
            txtMestoCitiranja.TabIndex = 1;
            // 
            // lblKontekst
            // 
            lblKontekst.AutoSize = true;
            lblKontekst.Location = new Point(20, 90);
            lblKontekst.Name = "lblKontekst";
            lblKontekst.Size = new Size(110, 15);
            lblKontekst.TabIndex = 0;
            lblKontekst.Text = "Tekstualni kontekst:";
            // 
            // txtKontekst
            // 
            txtKontekst.Location = new Point(160, 87);
            txtKontekst.Name = "txtKontekst";
            txtKontekst.Size = new Size(230, 23);
            txtKontekst.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(164, 135);
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
            // IzmeniCitatForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 245);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblTipCitata);
            Controls.Add(txtTipCitata);
            Controls.Add(lblMestoCitiranja);
            Controls.Add(txtMestoCitiranja);
            Controls.Add(lblKontekst);
            Controls.Add(txtKontekst);
            Name = "IzmeniCitatForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni citat";
            Load += IzmeniCitatForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblTipCitata;
        private System.Windows.Forms.TextBox txtTipCitata;
        private System.Windows.Forms.Label lblMestoCitiranja;
        private System.Windows.Forms.TextBox txtMestoCitiranja;
        private System.Windows.Forms.Label lblKontekst;
        private System.Windows.Forms.TextBox txtKontekst;
    }
}
