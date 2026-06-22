namespace DigitalniRepozitorijum.Forme
{
    partial class DodajKnjiguForm
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
            lblIzdavac = new Label();
            txtIzdavac = new TextBox();
            lblMestoIzdanja = new Label();
            txtMestoIzdanja = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
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
            cmbStatus = new ComboBox();
            dateObjave = new DateTimePicker();
            dateKreiranja = new DateTimePicker();
            tbJezik = new TextBox();
            SuspendLayout();
            // 
            // lblIzdavac
            // 
            lblIzdavac.AutoSize = true;
            lblIzdavac.Location = new Point(12, 267);
            lblIzdavac.Name = "lblIzdavac";
            lblIzdavac.Size = new Size(49, 15);
            lblIzdavac.TabIndex = 0;
            lblIzdavac.Text = "Izdavac:";
            // 
            // txtIzdavac
            // 
            txtIzdavac.Location = new Point(152, 264);
            txtIzdavac.Name = "txtIzdavac";
            txtIzdavac.Size = new Size(230, 23);
            txtIzdavac.TabIndex = 1;
            // 
            // lblMestoIzdanja
            // 
            lblMestoIzdanja.AutoSize = true;
            lblMestoIzdanja.Location = new Point(12, 302);
            lblMestoIzdanja.Name = "lblMestoIzdanja";
            lblMestoIzdanja.Size = new Size(83, 15);
            lblMestoIzdanja.TabIndex = 0;
            lblMestoIzdanja.Text = "Mesto izdanja:";
            // 
            // txtMestoIzdanja
            // 
            txtMestoIzdanja.Location = new Point(152, 299);
            txtMestoIzdanja.Name = "txtMestoIzdanja";
            txtMestoIzdanja.Size = new Size(230, 23);
            txtMestoIzdanja.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(152, 350);
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
            btnOdustani.Location = new Point(272, 350);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Location = new Point(12, 19);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(46, 15);
            lblNaslov.TabIndex = 52;
            lblNaslov.Text = "Naslov:";
            // 
            // txtNaslov
            // 
            txtNaslov.Location = new Point(152, 16);
            txtNaslov.Name = "txtNaslov";
            txtNaslov.Size = new Size(230, 23);
            txtNaslov.TabIndex = 59;
            // 
            // lblApstrakt
            // 
            lblApstrakt.AutoSize = true;
            lblApstrakt.Location = new Point(12, 54);
            lblApstrakt.Name = "lblApstrakt";
            lblApstrakt.Size = new Size(54, 15);
            lblApstrakt.TabIndex = 53;
            lblApstrakt.Text = "Apstrakt:";
            // 
            // txtApstrakt
            // 
            txtApstrakt.Location = new Point(152, 51);
            txtApstrakt.Name = "txtApstrakt";
            txtApstrakt.Size = new Size(230, 23);
            txtApstrakt.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 54;
            label1.Text = "Jezik:";
            // 
            // lblDatumObjavljivanja
            // 
            lblDatumObjavljivanja.AutoSize = true;
            lblDatumObjavljivanja.Location = new Point(12, 124);
            lblDatumObjavljivanja.Name = "lblDatumObjavljivanja";
            lblDatumObjavljivanja.Size = new Size(115, 15);
            lblDatumObjavljivanja.TabIndex = 55;
            lblDatumObjavljivanja.Text = "Datum objavljivanja:";
            // 
            // lblDatumKreiranja
            // 
            lblDatumKreiranja.AutoSize = true;
            lblDatumKreiranja.Location = new Point(12, 159);
            lblDatumKreiranja.Name = "lblDatumKreiranja";
            lblDatumKreiranja.Size = new Size(94, 15);
            lblDatumKreiranja.TabIndex = 56;
            lblDatumKreiranja.Text = "Datum kreiranja:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 194);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 57;
            lblStatus.Text = "Status:";
            // 
            // lblVidljivost
            // 
            lblVidljivost.AutoSize = true;
            lblVidljivost.Location = new Point(12, 229);
            lblVidljivost.Name = "lblVidljivost";
            lblVidljivost.Size = new Size(58, 15);
            lblVidljivost.TabIndex = 58;
            lblVidljivost.Text = "Vidljivost:";
            // 
            // txtVidljivost
            // 
            txtVidljivost.Location = new Point(152, 226);
            txtVidljivost.Name = "txtVidljivost";
            txtVidljivost.Size = new Size(230, 23);
            txtVidljivost.TabIndex = 65;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(152, 191);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(230, 23);
            cmbStatus.TabIndex = 66;
            // 
            // dateObjave
            // 
            dateObjave.Location = new Point(152, 124);
            dateObjave.Name = "dateObjave";
            dateObjave.Size = new Size(230, 23);
            dateObjave.TabIndex = 67;
            // 
            // dateKreiranja
            // 
            dateKreiranja.Location = new Point(152, 159);
            dateKreiranja.Name = "dateKreiranja";
            dateKreiranja.Size = new Size(230, 23);
            dateKreiranja.TabIndex = 68;
            // 
            // tbJezik
            // 
            tbJezik.Location = new Point(152, 86);
            tbJezik.Name = "tbJezik";
            tbJezik.Size = new Size(230, 23);
            tbJezik.TabIndex = 69;
            // 
            // DodajKnjiguForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 406);
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
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblIzdavac);
            Controls.Add(txtIzdavac);
            Controls.Add(lblMestoIzdanja);
            Controls.Add(txtMestoIzdanja);
            Name = "DodajKnjiguForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj knjigu";
            Load += DodajKnjiguForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblIzdavac;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.Label lblMestoIzdanja;
        private System.Windows.Forms.TextBox txtMestoIzdanja;
        private System.Windows.Forms.Label lblJezik;
        private System.Windows.Forms.TextBox txtBoxJezik;
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
        private ComboBox cmbStatus;
        private DateTimePicker dateObjave;
        private DateTimePicker dateKreiranja;
        private TextBox tbJezik;
    }
}
