namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniDatasetForm
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
            lblNaslov = new Label();
            txtNaslov = new TextBox();
            lblFormat = new Label();
            txtFormat = new TextBox();
            lblBrojZapisa = new Label();
            lblVelicina = new Label();
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
            numVelicina = new NumericUpDown();
            numBrZapisa = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numVelicina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBrZapisa).BeginInit();
            SuspendLayout();
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Location = new Point(23, 261);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(46, 15);
            lblNaslov.TabIndex = 0;
            lblNaslov.Text = "Naslov:";
            // 
            // txtNaslov
            // 
            txtNaslov.Location = new Point(163, 258);
            txtNaslov.Name = "txtNaslov";
            txtNaslov.Size = new Size(230, 23);
            txtNaslov.TabIndex = 1;
            // 
            // lblFormat
            // 
            lblFormat.AutoSize = true;
            lblFormat.Location = new Point(23, 296);
            lblFormat.Name = "lblFormat";
            lblFormat.Size = new Size(48, 15);
            lblFormat.TabIndex = 0;
            lblFormat.Text = "Format:";
            // 
            // txtFormat
            // 
            txtFormat.Location = new Point(163, 293);
            txtFormat.Name = "txtFormat";
            txtFormat.Size = new Size(230, 23);
            txtFormat.TabIndex = 1;
            // 
            // lblBrojZapisa
            // 
            lblBrojZapisa.AutoSize = true;
            lblBrojZapisa.Location = new Point(23, 331);
            lblBrojZapisa.Name = "lblBrojZapisa";
            lblBrojZapisa.Size = new Size(66, 15);
            lblBrojZapisa.TabIndex = 0;
            lblBrojZapisa.Text = "Broj zapisa:";
            // 
            // lblVelicina
            // 
            lblVelicina.AutoSize = true;
            lblVelicina.Location = new Point(23, 366);
            lblVelicina.Name = "lblVelicina";
            lblVelicina.Size = new Size(50, 15);
            lblVelicina.TabIndex = 0;
            lblVelicina.Text = "Velicina:";
            // 
            // lblLicenca
            // 
            lblLicenca.AutoSize = true;
            lblLicenca.Location = new Point(23, 401);
            lblLicenca.Name = "lblLicenca";
            lblLicenca.Size = new Size(50, 15);
            lblLicenca.TabIndex = 0;
            lblLicenca.Text = "Licenca:";
            // 
            // txtLicenca
            // 
            txtLicenca.Location = new Point(163, 398);
            txtLicenca.Name = "txtLicenca";
            txtLicenca.Size = new Size(230, 23);
            txtLicenca.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(163, 446);
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
            btnOdustani.Location = new Point(283, 446);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // tbJezik
            // 
            tbJezik.Location = new Point(163, 82);
            tbJezik.Name = "tbJezik";
            tbJezik.Size = new Size(230, 23);
            tbJezik.TabIndex = 111;
            // 
            // dateKreiranja
            // 
            dateKreiranja.Location = new Point(163, 155);
            dateKreiranja.Name = "dateKreiranja";
            dateKreiranja.Size = new Size(230, 23);
            dateKreiranja.TabIndex = 110;
            // 
            // dateObjave
            // 
            dateObjave.Location = new Point(163, 120);
            dateObjave.Name = "dateObjave";
            dateObjave.Size = new Size(230, 23);
            dateObjave.TabIndex = 109;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(163, 187);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(230, 23);
            cmbStatus.TabIndex = 108;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 98;
            label1.Text = "Naslov:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 105;
            // 
            // lblApstrakt
            // 
            lblApstrakt.AutoSize = true;
            lblApstrakt.Location = new Point(23, 50);
            lblApstrakt.Name = "lblApstrakt";
            lblApstrakt.Size = new Size(54, 15);
            lblApstrakt.TabIndex = 99;
            lblApstrakt.Text = "Apstrakt:";
            // 
            // txtApstrakt
            // 
            txtApstrakt.Location = new Point(163, 47);
            txtApstrakt.Name = "txtApstrakt";
            txtApstrakt.Size = new Size(230, 23);
            txtApstrakt.TabIndex = 106;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 85);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 100;
            label2.Text = "Jezik:";
            // 
            // lblDatumObjavljivanja
            // 
            lblDatumObjavljivanja.AutoSize = true;
            lblDatumObjavljivanja.Location = new Point(23, 120);
            lblDatumObjavljivanja.Name = "lblDatumObjavljivanja";
            lblDatumObjavljivanja.Size = new Size(115, 15);
            lblDatumObjavljivanja.TabIndex = 101;
            lblDatumObjavljivanja.Text = "Datum objavljivanja:";
            // 
            // lblDatumKreiranja
            // 
            lblDatumKreiranja.AutoSize = true;
            lblDatumKreiranja.Location = new Point(23, 155);
            lblDatumKreiranja.Name = "lblDatumKreiranja";
            lblDatumKreiranja.Size = new Size(94, 15);
            lblDatumKreiranja.TabIndex = 102;
            lblDatumKreiranja.Text = "Datum kreiranja:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(23, 190);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 103;
            lblStatus.Text = "Status:";
            // 
            // lblVidljivost
            // 
            lblVidljivost.AutoSize = true;
            lblVidljivost.Location = new Point(23, 225);
            lblVidljivost.Name = "lblVidljivost";
            lblVidljivost.Size = new Size(58, 15);
            lblVidljivost.TabIndex = 104;
            lblVidljivost.Text = "Vidljivost:";
            // 
            // txtVidljivost
            // 
            txtVidljivost.Location = new Point(163, 222);
            txtVidljivost.Name = "txtVidljivost";
            txtVidljivost.Size = new Size(230, 23);
            txtVidljivost.TabIndex = 107;
            // 
            // numVelicina
            // 
            numVelicina.Location = new Point(163, 364);
            numVelicina.Name = "numVelicina";
            numVelicina.Size = new Size(230, 23);
            numVelicina.TabIndex = 113;
            // 
            // numBrZapisa
            // 
            numBrZapisa.Location = new Point(163, 329);
            numBrZapisa.Name = "numBrZapisa";
            numBrZapisa.Size = new Size(230, 23);
            numBrZapisa.TabIndex = 112;
            // 
            // IzmeniDatasetForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 496);
            Controls.Add(numVelicina);
            Controls.Add(numBrZapisa);
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
            Controls.Add(lblNaslov);
            Controls.Add(txtNaslov);
            Controls.Add(lblFormat);
            Controls.Add(txtFormat);
            Controls.Add(lblBrojZapisa);
            Controls.Add(lblVelicina);
            Controls.Add(lblLicenca);
            Controls.Add(txtLicenca);
            Name = "IzmeniDatasetForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni dataset";
            Load += IzmeniDatasetForm_Load;
            ((System.ComponentModel.ISupportInitialize)numVelicina).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBrZapisa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Label lblBrojZapisa;
        private System.Windows.Forms.Label lblVelicina;
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
        private NumericUpDown numVelicina;
        private NumericUpDown numBrZapisa;
    }
}
