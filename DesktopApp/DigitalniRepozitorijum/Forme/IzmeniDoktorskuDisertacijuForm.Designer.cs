namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniDoktorskuDisertacijuForm
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
            SuspendLayout();
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 270);
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
            btnOdustani.Location = new Point(280, 270);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // tbJezik
            // 
            tbJezik.Location = new Point(160, 82);
            tbJezik.Name = "tbJezik";
            tbJezik.Size = new Size(230, 23);
            tbJezik.TabIndex = 83;
            // 
            // dateKreiranja
            // 
            dateKreiranja.Location = new Point(160, 155);
            dateKreiranja.Name = "dateKreiranja";
            dateKreiranja.Size = new Size(230, 23);
            dateKreiranja.TabIndex = 82;
            // 
            // dateObjave
            // 
            dateObjave.Location = new Point(160, 120);
            dateObjave.Name = "dateObjave";
            dateObjave.Size = new Size(230, 23);
            dateObjave.TabIndex = 81;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(160, 187);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(230, 23);
            cmbStatus.TabIndex = 80;
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Location = new Point(20, 15);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(46, 15);
            lblNaslov.TabIndex = 70;
            lblNaslov.Text = "Naslov:";
            // 
            // txtNaslov
            // 
            txtNaslov.Location = new Point(160, 12);
            txtNaslov.Name = "txtNaslov";
            txtNaslov.Size = new Size(230, 23);
            txtNaslov.TabIndex = 77;
            // 
            // lblApstrakt
            // 
            lblApstrakt.AutoSize = true;
            lblApstrakt.Location = new Point(20, 50);
            lblApstrakt.Name = "lblApstrakt";
            lblApstrakt.Size = new Size(54, 15);
            lblApstrakt.TabIndex = 71;
            lblApstrakt.Text = "Apstrakt:";
            // 
            // txtApstrakt
            // 
            txtApstrakt.Location = new Point(160, 47);
            txtApstrakt.Name = "txtApstrakt";
            txtApstrakt.Size = new Size(230, 23);
            txtApstrakt.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 85);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 72;
            label1.Text = "Jezik:";
            // 
            // lblDatumObjavljivanja
            // 
            lblDatumObjavljivanja.AutoSize = true;
            lblDatumObjavljivanja.Location = new Point(20, 120);
            lblDatumObjavljivanja.Name = "lblDatumObjavljivanja";
            lblDatumObjavljivanja.Size = new Size(115, 15);
            lblDatumObjavljivanja.TabIndex = 73;
            lblDatumObjavljivanja.Text = "Datum objavljivanja:";
            // 
            // lblDatumKreiranja
            // 
            lblDatumKreiranja.AutoSize = true;
            lblDatumKreiranja.Location = new Point(20, 155);
            lblDatumKreiranja.Name = "lblDatumKreiranja";
            lblDatumKreiranja.Size = new Size(94, 15);
            lblDatumKreiranja.TabIndex = 74;
            lblDatumKreiranja.Text = "Datum kreiranja:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(20, 190);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 75;
            lblStatus.Text = "Status:";
            // 
            // lblVidljivost
            // 
            lblVidljivost.AutoSize = true;
            lblVidljivost.Location = new Point(20, 225);
            lblVidljivost.Name = "lblVidljivost";
            lblVidljivost.Size = new Size(58, 15);
            lblVidljivost.TabIndex = 76;
            lblVidljivost.Text = "Vidljivost:";
            // 
            // txtVidljivost
            // 
            txtVidljivost.Location = new Point(160, 222);
            txtVidljivost.Name = "txtVidljivost";
            txtVidljivost.Size = new Size(230, 23);
            txtVidljivost.TabIndex = 79;
            // 
            // IzmeniDoktorskuDisertacijuForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 323);
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
            Name = "IzmeniDoktorskuDisertacijuForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni doktorsku";
            Load += IzmeniDoktorskuDisertacijuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
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
    }
}
