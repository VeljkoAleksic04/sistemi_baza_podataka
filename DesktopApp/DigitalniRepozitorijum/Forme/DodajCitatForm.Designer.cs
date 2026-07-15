namespace DigitalniRepozitorijum.Forme
{
    partial class DodajCitatForm
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
            lblCitat = new Label();
            lblTipCitata = new Label();
            txtTipCitata = new TextBox();
            lblMestoCitiranja = new Label();
            txtMestoCitiranja = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            cmbPublikacije = new ComboBox();
            label1 = new Label();
            txtKontekst = new TextBox();
            SuspendLayout();
            // 
            // lblCitat
            // 
            lblCitat.AutoSize = true;
            lblCitat.Location = new Point(20, 20);
            lblCitat.Name = "lblCitat";
            lblCitat.Size = new Size(93, 15);
            lblCitat.TabIndex = 0;
            lblCitat.Text = "Publikacija citat:";
            // 
            // lblTipCitata
            // 
            lblTipCitata.AutoSize = true;
            lblTipCitata.Location = new Point(20, 55);
            lblTipCitata.Name = "lblTipCitata";
            lblTipCitata.Size = new Size(58, 15);
            lblTipCitata.TabIndex = 0;
            lblTipCitata.Text = "Tip citata:";
            // 
            // txtTipCitata
            // 
            txtTipCitata.Location = new Point(160, 52);
            txtTipCitata.Name = "txtTipCitata";
            txtTipCitata.Size = new Size(230, 23);
            txtTipCitata.TabIndex = 1;
            // 
            // lblMestoCitiranja
            // 
            lblMestoCitiranja.AutoSize = true;
            lblMestoCitiranja.Location = new Point(20, 90);
            lblMestoCitiranja.Name = "lblMestoCitiranja";
            lblMestoCitiranja.Size = new Size(88, 15);
            lblMestoCitiranja.TabIndex = 0;
            lblMestoCitiranja.Text = "Mesto citiranja:";
            // 
            // txtMestoCitiranja
            // 
            txtMestoCitiranja.Location = new Point(160, 87);
            txtMestoCitiranja.Name = "txtMestoCitiranja";
            txtMestoCitiranja.Size = new Size(230, 23);
            txtMestoCitiranja.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 181);
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
            btnOdustani.Location = new Point(280, 181);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 127);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 53;
            label1.Text = "Tekstualni kontekst:";
            // 
            // txtKontekst
            // 
            txtKontekst.Location = new Point(160, 124);
            txtKontekst.Name = "txtKontekst";
            txtKontekst.Size = new Size(230, 23);
            txtKontekst.TabIndex = 54;
            // 
            // DodajCitatForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 245);
            Controls.Add(txtKontekst);
            Controls.Add(label1);
            Controls.Add(cmbPublikacije);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblCitat);
            Controls.Add(lblTipCitata);
            Controls.Add(txtTipCitata);
            Controls.Add(lblMestoCitiranja);
            Controls.Add(txtMestoCitiranja);
            Name = "DodajCitatForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj citat";
            Load += DodajCitatForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblCitat;
        private System.Windows.Forms.Label lblTipCitata;
        private System.Windows.Forms.TextBox txtTipCitata;
        private System.Windows.Forms.Label lblMestoCitiranja;
        private System.Windows.Forms.TextBox txtMestoCitiranja;
        private ComboBox cmbPublikacije;
        private Label label1;
        private TextBox txtKontekst;
    }
}
