namespace DigitalniRepozitorijum.Forme
{
    partial class DodajSoftverskiArtefaktForm
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
            lblProgramskiJezik = new Label();
            txtProgramskiJezik = new TextBox();
            lblLink = new Label();
            txtLink = new TextBox();
            lblLicenca = new Label();
            txtLicenca = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            tbJezik = new TextBox();
            dateKreiranja = new DateTimePicker();
            dateObjave = new DateTimePicker();
            cmbStatus = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            lblApstrakt = new Label();
            txtApstrakt = new TextBox();
            label2 = new Label();
            lblDatumObjavljivanja = new Label();
            lblDatumKreiranja = new Label();
            lblStatus = new Label();
            lblVidljivost = new Label();
            txtVidljivost = new TextBox();
            SuspendLayout();
            // 
            // lblProgramskiJezik
            // 
            lblProgramskiJezik.AutoSize = true;
            lblProgramskiJezik.Location = new Point(27, 270);
            lblProgramskiJezik.Name = "lblProgramskiJezik";
            lblProgramskiJezik.Size = new Size(96, 15);
            lblProgramskiJezik.TabIndex = 0;
            lblProgramskiJezik.Text = "Programski jezik:";
            // 
            // txtProgramskiJezik
            // 
            txtProgramskiJezik.Location = new Point(167, 267);
            txtProgramskiJezik.Name = "txtProgramskiJezik";
            txtProgramskiJezik.Size = new Size(230, 23);
            txtProgramskiJezik.TabIndex = 1;
            // 
            // lblLink
            // 
            lblLink.AutoSize = true;
            lblLink.Location = new Point(27, 305);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(128, 15);
            lblLink.TabIndex = 0;
            lblLink.Text = "Link ka repozitorijumu:";
            // 
            // txtLink
            // 
            txtLink.Location = new Point(167, 302);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(230, 23);
            txtLink.TabIndex = 1;
            // 
            // lblLicenca
            // 
            lblLicenca.AutoSize = true;
            lblLicenca.Location = new Point(27, 340);
            lblLicenca.Name = "lblLicenca";
            lblLicenca.Size = new Size(104, 15);
            lblLicenca.TabIndex = 0;
            lblLicenca.Text = "Nacin licenciranja:";
            // 
            // txtLicenca
            // 
            txtLicenca.Location = new Point(167, 337);
            txtLicenca.Name = "txtLicenca";
            txtLicenca.Size = new Size(230, 23);
            txtLicenca.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(167, 385);
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
            btnOdustani.Location = new Point(287, 385);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // tbJezik
            // 
            tbJezik.Location = new Point(167, 89);
            tbJezik.Name = "tbJezik";
            tbJezik.Size = new Size(230, 23);
            tbJezik.TabIndex = 97;
            // 
            // dateKreiranja
            // 
            dateKreiranja.Location = new Point(167, 162);
            dateKreiranja.Name = "dateKreiranja";
            dateKreiranja.Size = new Size(230, 23);
            dateKreiranja.TabIndex = 96;
            // 
            // dateObjave
            // 
            dateObjave.Location = new Point(167, 127);
            dateObjave.Name = "dateObjave";
            dateObjave.Size = new Size(230, 23);
            dateObjave.TabIndex = 95;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(167, 194);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(230, 23);
            cmbStatus.TabIndex = 94;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 84;
            label1.Text = "Naslov:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 91;
            // 
            // lblApstrakt
            // 
            lblApstrakt.AutoSize = true;
            lblApstrakt.Location = new Point(27, 57);
            lblApstrakt.Name = "lblApstrakt";
            lblApstrakt.Size = new Size(54, 15);
            lblApstrakt.TabIndex = 85;
            lblApstrakt.Text = "Apstrakt:";
            // 
            // txtApstrakt
            // 
            txtApstrakt.Location = new Point(167, 54);
            txtApstrakt.Name = "txtApstrakt";
            txtApstrakt.Size = new Size(230, 23);
            txtApstrakt.TabIndex = 92;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 92);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 86;
            label2.Text = "Jezik:";
            // 
            // lblDatumObjavljivanja
            // 
            lblDatumObjavljivanja.AutoSize = true;
            lblDatumObjavljivanja.Location = new Point(27, 127);
            lblDatumObjavljivanja.Name = "lblDatumObjavljivanja";
            lblDatumObjavljivanja.Size = new Size(115, 15);
            lblDatumObjavljivanja.TabIndex = 87;
            lblDatumObjavljivanja.Text = "Datum objavljivanja:";
            // 
            // lblDatumKreiranja
            // 
            lblDatumKreiranja.AutoSize = true;
            lblDatumKreiranja.Location = new Point(27, 162);
            lblDatumKreiranja.Name = "lblDatumKreiranja";
            lblDatumKreiranja.Size = new Size(94, 15);
            lblDatumKreiranja.TabIndex = 88;
            lblDatumKreiranja.Text = "Datum kreiranja:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(27, 197);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 89;
            lblStatus.Text = "Status:";
            // 
            // lblVidljivost
            // 
            lblVidljivost.AutoSize = true;
            lblVidljivost.Location = new Point(27, 232);
            lblVidljivost.Name = "lblVidljivost";
            lblVidljivost.Size = new Size(58, 15);
            lblVidljivost.TabIndex = 90;
            lblVidljivost.Text = "Vidljivost:";
            // 
            // txtVidljivost
            // 
            txtVidljivost.Location = new Point(167, 229);
            txtVidljivost.Name = "txtVidljivost";
            txtVidljivost.Size = new Size(230, 23);
            txtVidljivost.TabIndex = 93;
            // 
            // DodajSoftverskiArtefaktForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 441);
            Controls.Add(tbJezik);
            Controls.Add(dateKreiranja);
            Controls.Add(dateObjave);
            Controls.Add(cmbStatus);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lblApstrakt);
            Controls.Add(txtApstrakt);
            Controls.Add(label2);
            Controls.Add(lblDatumObjavljivanja);
            Controls.Add(lblDatumKreiranja);
            Controls.Add(lblStatus);
            Controls.Add(lblVidljivost);
            Controls.Add(txtVidljivost);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblProgramskiJezik);
            Controls.Add(txtProgramskiJezik);
            Controls.Add(lblLink);
            Controls.Add(txtLink);
            Controls.Add(lblLicenca);
            Controls.Add(txtLicenca);
            Name = "DodajSoftverskiArtefaktForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj softverski artefakt";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblProgramskiJezik;
        private System.Windows.Forms.TextBox txtProgramskiJezik;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lblLicenca;
        private System.Windows.Forms.TextBox txtLicenca;
        private TextBox tbJezik;
        private DateTimePicker dateKreiranja;
        private DateTimePicker dateObjave;
        private ComboBox cmbStatus;
        private Label label1;
        private TextBox textBox1;
        private Label lblApstrakt;
        private TextBox txtApstrakt;
        private Label label2;
        private Label lblDatumObjavljivanja;
        private Label lblDatumKreiranja;
        private Label lblStatus;
        private Label lblVidljivost;
        private TextBox txtVidljivost;
    }
}
