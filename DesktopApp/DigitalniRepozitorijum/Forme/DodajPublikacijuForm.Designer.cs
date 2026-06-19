namespace DigitalniRepozitorijum.Forme
{
    partial class DodajPublikacijuForm
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
            lblApstrakt = new Label();
            txtApstrakt = new TextBox();
            lblJezik = new Label();
            txtJezik = new TextBox();
            lblDatumObjavljivanja = new Label();
            txtDatumObjavljivanja = new TextBox();
            lblDatumKreiranja = new Label();
            txtDatumKreiranja = new TextBox();
            lblStatus = new Label();
            txtStatus = new TextBox();
            lblVidljivost = new Label();
            txtVidljivost = new TextBox();
            btnPotvrdi = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Location = new Point(20, 20);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(46, 15);
            lblNaslov.TabIndex = 0;
            lblNaslov.Text = "Naslov:";
            // 
            // txtNaslov
            // 
            txtNaslov.Location = new Point(160, 17);
            txtNaslov.Name = "txtNaslov";
            txtNaslov.Size = new Size(230, 23);
            txtNaslov.TabIndex = 1;
            // 
            // lblApstrakt
            // 
            lblApstrakt.AutoSize = true;
            lblApstrakt.Location = new Point(20, 55);
            lblApstrakt.Name = "lblApstrakt";
            lblApstrakt.Size = new Size(54, 15);
            lblApstrakt.TabIndex = 0;
            lblApstrakt.Text = "Apstrakt:";
            // 
            // txtApstrakt
            // 
            txtApstrakt.Location = new Point(160, 52);
            txtApstrakt.Name = "txtApstrakt";
            txtApstrakt.Size = new Size(230, 23);
            txtApstrakt.TabIndex = 1;
            // 
            // lblJezik
            // 
            lblJezik.AutoSize = true;
            lblJezik.Location = new Point(20, 90);
            lblJezik.Name = "lblJezik";
            lblJezik.Size = new Size(34, 15);
            lblJezik.TabIndex = 0;
            lblJezik.Text = "Jezik:";
            // 
            // txtJezik
            // 
            txtJezik.Location = new Point(160, 87);
            txtJezik.Name = "txtJezik";
            txtJezik.Size = new Size(230, 23);
            txtJezik.TabIndex = 1;
            // 
            // lblDatumObjavljivanja
            // 
            lblDatumObjavljivanja.AutoSize = true;
            lblDatumObjavljivanja.Location = new Point(20, 125);
            lblDatumObjavljivanja.Name = "lblDatumObjavljivanja";
            lblDatumObjavljivanja.Size = new Size(115, 15);
            lblDatumObjavljivanja.TabIndex = 0;
            lblDatumObjavljivanja.Text = "Datum objavljivanja:";
            // 
            // txtDatumObjavljivanja
            // 
            txtDatumObjavljivanja.Location = new Point(160, 122);
            txtDatumObjavljivanja.Name = "txtDatumObjavljivanja";
            txtDatumObjavljivanja.Size = new Size(230, 23);
            txtDatumObjavljivanja.TabIndex = 1;
            // 
            // lblDatumKreiranja
            // 
            lblDatumKreiranja.AutoSize = true;
            lblDatumKreiranja.Location = new Point(20, 160);
            lblDatumKreiranja.Name = "lblDatumKreiranja";
            lblDatumKreiranja.Size = new Size(94, 15);
            lblDatumKreiranja.TabIndex = 0;
            lblDatumKreiranja.Text = "Datum kreiranja:";
            // 
            // txtDatumKreiranja
            // 
            txtDatumKreiranja.Location = new Point(160, 157);
            txtDatumKreiranja.Name = "txtDatumKreiranja";
            txtDatumKreiranja.Size = new Size(230, 23);
            txtDatumKreiranja.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(20, 195);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(160, 192);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(230, 23);
            txtStatus.TabIndex = 1;
            // 
            // lblVidljivost
            // 
            lblVidljivost.AutoSize = true;
            lblVidljivost.Location = new Point(20, 230);
            lblVidljivost.Name = "lblVidljivost";
            lblVidljivost.Size = new Size(58, 15);
            lblVidljivost.TabIndex = 0;
            lblVidljivost.Text = "Vidljivost:";
            // 
            // txtVidljivost
            // 
            txtVidljivost.Location = new Point(160, 227);
            txtVidljivost.Name = "txtVidljivost";
            txtVidljivost.Size = new Size(230, 23);
            txtVidljivost.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Location = new Point(160, 275);
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
            btnOdustani.Location = new Point(280, 275);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(110, 32);
            btnOdustani.TabIndex = 51;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            // 
            // DodajPublikacijuForm
            // 
            AcceptButton = btnPotvrdi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOdustani;
            ClientSize = new Size(420, 320);
            Controls.Add(btnOdustani);
            Controls.Add(btnPotvrdi);
            Controls.Add(lblNaslov);
            Controls.Add(txtNaslov);
            Controls.Add(lblApstrakt);
            Controls.Add(txtApstrakt);
            Controls.Add(lblJezik);
            Controls.Add(txtJezik);
            Controls.Add(lblDatumObjavljivanja);
            Controls.Add(txtDatumObjavljivanja);
            Controls.Add(lblDatumKreiranja);
            Controls.Add(txtDatumKreiranja);
            Controls.Add(lblStatus);
            Controls.Add(txtStatus);
            Controls.Add(lblVidljivost);
            Controls.Add(txtVidljivost);
            Name = "DodajPublikacijuForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj publikaciju";
            Load += DodajPublikacijuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label lblApstrakt;
        private System.Windows.Forms.TextBox txtApstrakt;
        private System.Windows.Forms.Label lblJezik;
        private System.Windows.Forms.TextBox txtJezik;
        private System.Windows.Forms.Label lblDatumObjavljivanja;
        private System.Windows.Forms.TextBox txtDatumObjavljivanja;
        private System.Windows.Forms.Label lblDatumKreiranja;
        private System.Windows.Forms.TextBox txtDatumKreiranja;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblVidljivost;
        private System.Windows.Forms.TextBox txtVidljivost;
    }
}
