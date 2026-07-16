namespace DigitalniRepozitorijum.Forme
{
    partial class IzmeniIstrazivacaForm
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
            lblIme = new Label();
            txtIme = new TextBox();
            lblPrezime = new Label();
            txtPrezime = new TextBox();
            lblDatumRodjenja = new Label();
            lblDrzava = new Label();
            txtDrzava = new TextBox();
            lblStatusNaloga = new Label();
            txtStatusNaloga = new TextBox();
            lblNaucnoZvanje = new Label();
            txtNaucnoZvanje = new TextBox();
            lblNaucnaOblast = new Label();
            txtNaucnaOblast = new TextBox();
            lblORCID = new Label();
            txtORCID = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            dateRodj = new DateTimePicker();
            SuspendLayout();
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(20, 20);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(30, 15);
            lblIme.TabIndex = 0;
            lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(160, 17);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(230, 23);
            txtIme.TabIndex = 1;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new Point(20, 55);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(52, 15);
            lblPrezime.TabIndex = 0;
            lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(160, 52);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(230, 23);
            txtPrezime.TabIndex = 1;
            // 
            // lblDatumRodjenja
            // 
            lblDatumRodjenja.AutoSize = true;
            lblDatumRodjenja.Location = new Point(20, 90);
            lblDatumRodjenja.Name = "lblDatumRodjenja";
            lblDatumRodjenja.Size = new Size(92, 15);
            lblDatumRodjenja.TabIndex = 0;
            lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(20, 125);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(45, 15);
            lblDrzava.TabIndex = 0;
            lblDrzava.Text = "Drzava:";
            // 
            // txtDrzava
            // 
            txtDrzava.Location = new Point(160, 122);
            txtDrzava.Name = "txtDrzava";
            txtDrzava.Size = new Size(230, 23);
            txtDrzava.TabIndex = 1;
            // 
            // lblStatusNaloga
            // 
            lblStatusNaloga.AutoSize = true;
            lblStatusNaloga.Location = new Point(20, 160);
            lblStatusNaloga.Name = "lblStatusNaloga";
            lblStatusNaloga.Size = new Size(81, 15);
            lblStatusNaloga.TabIndex = 0;
            lblStatusNaloga.Text = "Status naloga:";
            // 
            // txtStatusNaloga
            // 
            txtStatusNaloga.Location = new Point(160, 157);
            txtStatusNaloga.Name = "txtStatusNaloga";
            txtStatusNaloga.Size = new Size(230, 23);
            txtStatusNaloga.TabIndex = 1;
            // 
            // lblNaucnoZvanje
            // 
            lblNaucnoZvanje.AutoSize = true;
            lblNaucnoZvanje.Location = new Point(20, 195);
            lblNaucnoZvanje.Name = "lblNaucnoZvanje";
            lblNaucnoZvanje.Size = new Size(88, 15);
            lblNaucnoZvanje.TabIndex = 0;
            lblNaucnoZvanje.Text = "Naucno zvanje:";
            // 
            // txtNaucnoZvanje
            // 
            txtNaucnoZvanje.Location = new Point(160, 192);
            txtNaucnoZvanje.Name = "txtNaucnoZvanje";
            txtNaucnoZvanje.Size = new Size(230, 23);
            txtNaucnoZvanje.TabIndex = 1;
            // 
            // lblNaucnaOblast
            // 
            lblNaucnaOblast.AutoSize = true;
            lblNaucnaOblast.Location = new Point(20, 230);
            lblNaucnaOblast.Name = "lblNaucnaOblast";
            lblNaucnaOblast.Size = new Size(86, 15);
            lblNaucnaOblast.TabIndex = 0;
            lblNaucnaOblast.Text = "Naucna oblast:";
            // 
            // txtNaucnaOblast
            // 
            txtNaucnaOblast.Location = new Point(160, 227);
            txtNaucnaOblast.Name = "txtNaucnaOblast";
            txtNaucnaOblast.Size = new Size(230, 23);
            txtNaucnaOblast.TabIndex = 1;
            // 
            // lblORCID
            // 
            lblORCID.AutoSize = true;
            lblORCID.Location = new Point(20, 265);
            lblORCID.Name = "lblORCID";
            lblORCID.Size = new Size(45, 15);
            lblORCID.TabIndex = 0;
            lblORCID.Text = "ORCID:";
            // 
            // txtORCID
            // 
            txtORCID.Location = new Point(160, 262);
            txtORCID.Name = "txtORCID";
            txtORCID.Size = new Size(230, 23);
            txtORCID.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 310);
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
            btnOdustani.Location = new Point(280, 310);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            // 
            // dateRodj
            // 
            dateRodj.Location = new Point(160, 88);
            dateRodj.Name = "dateRodj";
            dateRodj.Size = new Size(230, 23);
            dateRodj.TabIndex = 62;
            // 
            // IzmeniIstrazivacaForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 350);
            Controls.Add(dateRodj);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblIme);
            Controls.Add(txtIme);
            Controls.Add(lblPrezime);
            Controls.Add(txtPrezime);
            Controls.Add(lblDatumRodjenja);
            Controls.Add(lblDrzava);
            Controls.Add(txtDrzava);
            Controls.Add(lblStatusNaloga);
            Controls.Add(txtStatusNaloga);
            Controls.Add(lblNaucnoZvanje);
            Controls.Add(txtNaucnoZvanje);
            Controls.Add(lblNaucnaOblast);
            Controls.Add(txtNaucnaOblast);
            Controls.Add(lblORCID);
            Controls.Add(txtORCID);
            Name = "IzmeniIstrazivacaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmeni istrazivaca";
            Load += IzmeniIstrazivacaForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblDrzava;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.Label lblStatusNaloga;
        private System.Windows.Forms.TextBox txtStatusNaloga;
        private System.Windows.Forms.Label lblNaucnoZvanje;
        private System.Windows.Forms.TextBox txtNaucnoZvanje;
        private System.Windows.Forms.Label lblNaucnaOblast;
        private System.Windows.Forms.TextBox txtNaucnaOblast;
        private System.Windows.Forms.Label lblORCID;
        private System.Windows.Forms.TextBox txtORCID;
        private DateTimePicker dateRodj;
    }
}
