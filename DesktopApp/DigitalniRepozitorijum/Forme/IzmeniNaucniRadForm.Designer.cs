namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniNaucniRadForm
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
            lblDOI = new Label();
            txtDOI = new TextBox();
            lblTipRada = new Label();
            txtTipRada = new TextBox();
            lblStranice = new Label();
            txtStranice = new TextBox();
            lblIzvor = new Label();
            txtIzvor = new TextBox();
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
            // lblDOI
            // 
            lblDOI.AutoSize = true;
            lblDOI.Location = new Point(23, 277);
            lblDOI.Name = "lblDOI";
            lblDOI.Size = new Size(30, 15);
            lblDOI.TabIndex = 0;
            lblDOI.Text = "DOI:";
            // 
            // txtDOI
            // 
            txtDOI.Location = new Point(163, 274);
            txtDOI.Name = "txtDOI";
            txtDOI.Size = new Size(230, 23);
            txtDOI.TabIndex = 1;
            // 
            // lblTipRada
            // 
            lblTipRada.AutoSize = true;
            lblTipRada.Location = new Point(23, 312);
            lblTipRada.Name = "lblTipRada";
            lblTipRada.Size = new Size(53, 15);
            lblTipRada.TabIndex = 0;
            lblTipRada.Text = "Tip rada:";
            // 
            // txtTipRada
            // 
            txtTipRada.Location = new Point(163, 309);
            txtTipRada.Name = "txtTipRada";
            txtTipRada.Size = new Size(230, 23);
            txtTipRada.TabIndex = 1;
            // 
            // lblStranice
            // 
            lblStranice.AutoSize = true;
            lblStranice.Location = new Point(23, 347);
            lblStranice.Name = "lblStranice";
            lblStranice.Size = new Size(52, 15);
            lblStranice.TabIndex = 0;
            lblStranice.Text = "Stranice:";
            // 
            // txtStranice
            // 
            txtStranice.Location = new Point(163, 344);
            txtStranice.Name = "txtStranice";
            txtStranice.Size = new Size(230, 23);
            txtStranice.TabIndex = 1;
            // 
            // lblIzvor
            // 
            lblIzvor.AutoSize = true;
            lblIzvor.Location = new Point(23, 382);
            lblIzvor.Name = "lblIzvor";
            lblIzvor.Size = new Size(35, 15);
            lblIzvor.TabIndex = 0;
            lblIzvor.Text = "Izvor:";
            // 
            // txtIzvor
            // 
            txtIzvor.Location = new Point(163, 379);
            txtIzvor.Name = "txtIzvor";
            txtIzvor.Size = new Size(230, 23);
            txtIzvor.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(163, 427);
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
            btnOdustani.Location = new Point(283, 427);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // tbJezik
            // 
            tbJezik.Location = new Point(163, 95);
            tbJezik.Name = "tbJezik";
            tbJezik.Size = new Size(230, 23);
            tbJezik.TabIndex = 97;
            // 
            // dateKreiranja
            // 
            dateKreiranja.Location = new Point(163, 168);
            dateKreiranja.Name = "dateKreiranja";
            dateKreiranja.Size = new Size(230, 23);
            dateKreiranja.TabIndex = 96;
            // 
            // dateObjave
            // 
            dateObjave.Location = new Point(163, 133);
            dateObjave.Name = "dateObjave";
            dateObjave.Size = new Size(230, 23);
            dateObjave.TabIndex = 95;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(163, 200);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(230, 23);
            cmbStatus.TabIndex = 94;
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Location = new Point(23, 28);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(46, 15);
            lblNaslov.TabIndex = 84;
            lblNaslov.Text = "Naslov:";
            // 
            // txtNaslov
            // 
            txtNaslov.Location = new Point(163, 25);
            txtNaslov.Name = "txtNaslov";
            txtNaslov.Size = new Size(230, 23);
            txtNaslov.TabIndex = 91;
            // 
            // lblApstrakt
            // 
            lblApstrakt.AutoSize = true;
            lblApstrakt.Location = new Point(23, 63);
            lblApstrakt.Name = "lblApstrakt";
            lblApstrakt.Size = new Size(54, 15);
            lblApstrakt.TabIndex = 85;
            lblApstrakt.Text = "Apstrakt:";
            // 
            // txtApstrakt
            // 
            txtApstrakt.Location = new Point(163, 60);
            txtApstrakt.Name = "txtApstrakt";
            txtApstrakt.Size = new Size(230, 23);
            txtApstrakt.TabIndex = 92;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 98);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 86;
            label1.Text = "Jezik:";
            // 
            // lblDatumObjavljivanja
            // 
            lblDatumObjavljivanja.AutoSize = true;
            lblDatumObjavljivanja.Location = new Point(23, 133);
            lblDatumObjavljivanja.Name = "lblDatumObjavljivanja";
            lblDatumObjavljivanja.Size = new Size(115, 15);
            lblDatumObjavljivanja.TabIndex = 87;
            lblDatumObjavljivanja.Text = "Datum objavljivanja:";
            // 
            // lblDatumKreiranja
            // 
            lblDatumKreiranja.AutoSize = true;
            lblDatumKreiranja.Location = new Point(23, 168);
            lblDatumKreiranja.Name = "lblDatumKreiranja";
            lblDatumKreiranja.Size = new Size(94, 15);
            lblDatumKreiranja.TabIndex = 88;
            lblDatumKreiranja.Text = "Datum kreiranja:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(23, 203);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 89;
            lblStatus.Text = "Status:";
            // 
            // lblVidljivost
            // 
            lblVidljivost.AutoSize = true;
            lblVidljivost.Location = new Point(23, 238);
            lblVidljivost.Name = "lblVidljivost";
            lblVidljivost.Size = new Size(58, 15);
            lblVidljivost.TabIndex = 90;
            lblVidljivost.Text = "Vidljivost:";
            // 
            // txtVidljivost
            // 
            txtVidljivost.Location = new Point(163, 235);
            txtVidljivost.Name = "txtVidljivost";
            txtVidljivost.Size = new Size(230, 23);
            txtVidljivost.TabIndex = 93;
            // 
            // IzmeniNaucniRadForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 490);
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
            Controls.Add(lblDOI);
            Controls.Add(txtDOI);
            Controls.Add(lblTipRada);
            Controls.Add(txtTipRada);
            Controls.Add(lblStranice);
            Controls.Add(txtStranice);
            Controls.Add(lblIzvor);
            Controls.Add(txtIzvor);
            Name = "IzmeniNaucniRadForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni naučni rad";
            Load += IzmeniNaucniRadForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblDOI;
        private System.Windows.Forms.TextBox txtDOI;
        private System.Windows.Forms.Label lblTipRada;
        private System.Windows.Forms.TextBox txtTipRada;
        private System.Windows.Forms.Label lblStranice;
        private System.Windows.Forms.TextBox txtStranice;
        private System.Windows.Forms.Label lblIzvor;
        private System.Windows.Forms.TextBox txtIzvor;
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
