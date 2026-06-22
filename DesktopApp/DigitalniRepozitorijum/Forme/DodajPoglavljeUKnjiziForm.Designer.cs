namespace DigitalniRepozitorijum.Forme
{
    partial class DodajPoglavljeUKnjiziForm
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
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            tbJezik = new TextBox();
            dateKreiranja = new DateTimePicker();
            dateObjave = new DateTimePicker();
            cmbStatus = new ComboBox();
            lblNaslov = new Label();
            txtNaslov = new TextBox();
            lblApstrakt = new Label();
            txtApstrakt = new TextBox();
            label1 = new Label();
            lblDatumObjavljivanja = new Label();
            lblDatumKreiranja = new Label();
            lblStatus = new Label();
            lblVidljivost = new Label();
            txtVidljivost = new TextBox();
            lblIzdavac = new Label();
            txtIzdavac = new TextBox();
            lblMestoIzdanja = new Label();
            txtMestoIzdanja = new TextBox();
            SuspendLayout();
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 365);
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
            btnOdustani.Location = new Point(280, 365);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // tbJezik
            // 
            tbJezik.Location = new Point(160, 94);
            tbJezik.Name = "tbJezik";
            tbJezik.Size = new Size(230, 23);
            tbJezik.TabIndex = 87;
            // 
            // dateKreiranja
            // 
            dateKreiranja.Location = new Point(160, 167);
            dateKreiranja.Name = "dateKreiranja";
            dateKreiranja.Size = new Size(230, 23);
            dateKreiranja.TabIndex = 86;
            // 
            // dateObjave
            // 
            dateObjave.Location = new Point(160, 132);
            dateObjave.Name = "dateObjave";
            dateObjave.Size = new Size(230, 23);
            dateObjave.TabIndex = 85;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(160, 199);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(230, 23);
            cmbStatus.TabIndex = 84;
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Location = new Point(20, 27);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(46, 15);
            lblNaslov.TabIndex = 74;
            lblNaslov.Text = "Naslov:";
            // 
            // txtNaslov
            // 
            txtNaslov.Location = new Point(160, 24);
            txtNaslov.Name = "txtNaslov";
            txtNaslov.Size = new Size(230, 23);
            txtNaslov.TabIndex = 81;
            // 
            // lblApstrakt
            // 
            lblApstrakt.AutoSize = true;
            lblApstrakt.Location = new Point(20, 62);
            lblApstrakt.Name = "lblApstrakt";
            lblApstrakt.Size = new Size(54, 15);
            lblApstrakt.TabIndex = 75;
            lblApstrakt.Text = "Apstrakt:";
            // 
            // txtApstrakt
            // 
            txtApstrakt.Location = new Point(160, 59);
            txtApstrakt.Name = "txtApstrakt";
            txtApstrakt.Size = new Size(230, 23);
            txtApstrakt.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 97);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 76;
            label1.Text = "Jezik:";
            // 
            // lblDatumObjavljivanja
            // 
            lblDatumObjavljivanja.AutoSize = true;
            lblDatumObjavljivanja.Location = new Point(20, 132);
            lblDatumObjavljivanja.Name = "lblDatumObjavljivanja";
            lblDatumObjavljivanja.Size = new Size(115, 15);
            lblDatumObjavljivanja.TabIndex = 77;
            lblDatumObjavljivanja.Text = "Datum objavljivanja:";
            // 
            // lblDatumKreiranja
            // 
            lblDatumKreiranja.AutoSize = true;
            lblDatumKreiranja.Location = new Point(20, 167);
            lblDatumKreiranja.Name = "lblDatumKreiranja";
            lblDatumKreiranja.Size = new Size(94, 15);
            lblDatumKreiranja.TabIndex = 78;
            lblDatumKreiranja.Text = "Datum kreiranja:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(20, 202);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 79;
            lblStatus.Text = "Status:";
            // 
            // lblVidljivost
            // 
            lblVidljivost.AutoSize = true;
            lblVidljivost.Location = new Point(20, 237);
            lblVidljivost.Name = "lblVidljivost";
            lblVidljivost.Size = new Size(58, 15);
            lblVidljivost.TabIndex = 80;
            lblVidljivost.Text = "Vidljivost:";
            // 
            // txtVidljivost
            // 
            txtVidljivost.Location = new Point(160, 234);
            txtVidljivost.Name = "txtVidljivost";
            txtVidljivost.Size = new Size(230, 23);
            txtVidljivost.TabIndex = 83;
            // 
            // lblIzdavac
            // 
            lblIzdavac.AutoSize = true;
            lblIzdavac.Location = new Point(20, 275);
            lblIzdavac.Name = "lblIzdavac";
            lblIzdavac.Size = new Size(49, 15);
            lblIzdavac.TabIndex = 70;
            lblIzdavac.Text = "Izdavac:";
            // 
            // txtIzdavac
            // 
            txtIzdavac.Location = new Point(160, 272);
            txtIzdavac.Name = "txtIzdavac";
            txtIzdavac.Size = new Size(230, 23);
            txtIzdavac.TabIndex = 73;
            // 
            // lblMestoIzdanja
            // 
            lblMestoIzdanja.AutoSize = true;
            lblMestoIzdanja.Location = new Point(20, 310);
            lblMestoIzdanja.Name = "lblMestoIzdanja";
            lblMestoIzdanja.Size = new Size(83, 15);
            lblMestoIzdanja.TabIndex = 71;
            lblMestoIzdanja.Text = "Mesto izdanja:";
            // 
            // txtMestoIzdanja
            // 
            txtMestoIzdanja.Location = new Point(160, 307);
            txtMestoIzdanja.Name = "txtMestoIzdanja";
            txtMestoIzdanja.Size = new Size(230, 23);
            txtMestoIzdanja.TabIndex = 72;
            // 
            // DodajPoglavljeUKnjiziForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 418);
            Controls.Add(tbJezik);
            Controls.Add(dateKreiranja);
            Controls.Add(dateObjave);
            Controls.Add(cmbStatus);
            Controls.Add(lblNaslov);
            Controls.Add(txtNaslov);
            Controls.Add(lblApstrakt);
            Controls.Add(txtApstrakt);
            Controls.Add(label1);
            Controls.Add(lblDatumObjavljivanja);
            Controls.Add(lblDatumKreiranja);
            Controls.Add(lblStatus);
            Controls.Add(lblVidljivost);
            Controls.Add(txtVidljivost);
            Controls.Add(lblIzdavac);
            Controls.Add(txtIzdavac);
            Controls.Add(lblMestoIzdanja);
            Controls.Add(txtMestoIzdanja);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Name = "DodajPoglavljeUKnjiziForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj poglavlje";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnPotvrdi;
        private Button btnOdustani;
        private TextBox tbJezik;
        private DateTimePicker dateKreiranja;
        private DateTimePicker dateObjave;
        private ComboBox cmbStatus;
        private Label lblNaslov;
        private TextBox txtNaslov;
        private Label lblApstrakt;
        private TextBox txtApstrakt;
        private Label label1;
        private Label lblDatumObjavljivanja;
        private Label lblDatumKreiranja;
        private Label lblStatus;
        private Label lblVidljivost;
        private TextBox txtVidljivost;
        private Label lblIzdavac;
        private TextBox txtIzdavac;
        private Label lblMestoIzdanja;
        private TextBox txtMestoIzdanja;
    }
}
