namespace DigitalniRepozitorijum.Forme
{
    partial class DodajIstrazivacaForm
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
            cbAutor = new CheckBox();
            cbAdmin = new CheckBox();
            label1 = new Label();
            txtOvlascenja = new TextBox();
            label2 = new Label();
            txtSekcija = new TextBox();
            cbUrednik = new CheckBox();
            cbRecenzent = new CheckBox();
            cbRukovodilac = new CheckBox();
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
            lblORCID.Location = new Point(20, 352);
            lblORCID.Name = "lblORCID";
            lblORCID.Size = new Size(45, 15);
            lblORCID.TabIndex = 0;
            lblORCID.Text = "ORCID:";
            // 
            // txtORCID
            // 
            txtORCID.Enabled = false;
            txtORCID.Location = new Point(160, 349);
            txtORCID.Name = "txtORCID";
            txtORCID.Size = new Size(230, 23);
            txtORCID.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 529);
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
            btnOdustani.Location = new Point(280, 529);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            // 
            // cbAutor
            // 
            cbAutor.AutoSize = true;
            cbAutor.Location = new Point(160, 323);
            cbAutor.Name = "cbAutor";
            cbAutor.Size = new Size(56, 19);
            cbAutor.TabIndex = 52;
            cbAutor.Text = "Autor";
            cbAutor.UseVisualStyleBackColor = true;
            cbAutor.CheckedChanged += cbAutor_CheckedChanged;
            // 
            // cbAdmin
            // 
            cbAdmin.AutoSize = true;
            cbAdmin.Location = new Point(160, 388);
            cbAdmin.Name = "cbAdmin";
            cbAdmin.Size = new Size(179, 19);
            cbAdmin.TabIndex = 53;
            cbAdmin.Text = "Administrator repozitorijuma";
            cbAdmin.UseVisualStyleBackColor = true;
            cbAdmin.CheckedChanged += cbAdmin_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 416);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 54;
            label1.Text = "Ovlascenja:";
            // 
            // txtOvlascenja
            // 
            txtOvlascenja.Enabled = false;
            txtOvlascenja.Location = new Point(160, 413);
            txtOvlascenja.Name = "txtOvlascenja";
            txtOvlascenja.Size = new Size(230, 23);
            txtOvlascenja.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 484);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 57;
            label2.Text = "Sekcija:";
            // 
            // txtSekcija
            // 
            txtSekcija.Enabled = false;
            txtSekcija.Location = new Point(160, 481);
            txtSekcija.Name = "txtSekcija";
            txtSekcija.Size = new Size(230, 23);
            txtSekcija.TabIndex = 58;
            // 
            // cbUrednik
            // 
            cbUrednik.AutoSize = true;
            cbUrednik.Location = new Point(160, 456);
            cbUrednik.Name = "cbUrednik";
            cbUrednik.Size = new Size(67, 19);
            cbUrednik.TabIndex = 56;
            cbUrednik.Text = "Urednik";
            cbUrednik.UseVisualStyleBackColor = true;
            cbUrednik.CheckedChanged += cbUrednik_CheckedChanged;
            // 
            // cbRecenzent
            // 
            cbRecenzent.AutoSize = true;
            cbRecenzent.Location = new Point(160, 266);
            cbRecenzent.Name = "cbRecenzent";
            cbRecenzent.Size = new Size(80, 19);
            cbRecenzent.TabIndex = 59;
            cbRecenzent.Text = "Recenzent";
            cbRecenzent.UseVisualStyleBackColor = true;
            // 
            // cbRukovodilac
            // 
            cbRukovodilac.AutoSize = true;
            cbRukovodilac.Location = new Point(160, 294);
            cbRukovodilac.Name = "cbRukovodilac";
            cbRukovodilac.Size = new Size(137, 19);
            cbRukovodilac.TabIndex = 60;
            cbRukovodilac.Text = "Rukovodilac projekta";
            cbRukovodilac.UseVisualStyleBackColor = true;
            // 
            // dateRodj
            // 
            dateRodj.Location = new Point(160, 88);
            dateRodj.Name = "dateRodj";
            dateRodj.Size = new Size(230, 23);
            dateRodj.TabIndex = 61;
            // 
            // DodajIstrazivacaForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 573);
            Controls.Add(dateRodj);
            Controls.Add(cbRukovodilac);
            Controls.Add(cbRecenzent);
            Controls.Add(label2);
            Controls.Add(txtSekcija);
            Controls.Add(cbUrednik);
            Controls.Add(label1);
            Controls.Add(txtOvlascenja);
            Controls.Add(cbAdmin);
            Controls.Add(cbAutor);
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
            Name = "DodajIstrazivacaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj istrazivaca";
            Load += DodajIstrazivacaForm_Load;
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
        private CheckBox cbAutor;
        private CheckBox cbAdmin;
        private Label label1;
        private TextBox txtOvlascenja;
        private Label label2;
        private TextBox txtSekcija;
        private CheckBox cbUrednik;
        private CheckBox cbRecenzent;
        private CheckBox cbRukovodilac;
        private DateTimePicker dateRodj;
    }
}
